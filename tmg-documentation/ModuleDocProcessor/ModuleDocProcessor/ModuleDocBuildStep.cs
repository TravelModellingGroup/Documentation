using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Composition;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Threading.Tasks.Schedulers;
using System.Web.UI.WebControls;
using Fluid;
using Fluid.Accessors;
using Fluid.Values;
using Microsoft.DocAsCode.Common;
using Microsoft.DocAsCode.Plugins;
using ModuleDocMetaGenerator;
using Newtonsoft.Json.Linq;

namespace ModuleDocProcessor
{
    [Export(nameof(ModuleDocProcessor), typeof(IDocumentBuildStep))]
    public class ModuleDocBuildStep : IDocumentBuildStep
    {
        private readonly TaskFactory _taskFactory = new TaskFactory(new StaTaskScheduler(1));

        private static string _template;

        private static string _moduleListTemplate;

        static ModuleDocBuildStep()
        {

            var assembly = Assembly.GetAssembly(typeof(ModuleDocBuildStep));
            var resourceName = "ModuleDocProcessor.Module.liquid";
            // Console.WriteLine(assembly);

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                     _template = reader.ReadToEnd();
                    
                }
            }
            resourceName = "ModuleDocProcessor.ModuleList.liquid";
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    _moduleListTemplate = reader.ReadToEnd();
                }
            }
        }

        public IEnumerable<FileModel> Prebuild(ImmutableList<FileModel> models, IHostService host)
        {
            TemplateContext.GlobalMemberAccessStrategy.Register<JObject, object>((source, name) => source[name]);

            // Convert JToken to FluidValue
            FluidValue.TypeMappings.Add(typeof(JObject), o => new ObjectValue(o));
            FluidValue.TypeMappings.Add(typeof(JValue), o => FluidValue.Create(((JValue)o).Value));


            return models;
        }

        public static FluidValue Hyphenate(FluidValue input, FilterArguments arguments, TemplateContext context)
        {
            return new StringValue(Regex.Replace(input.ToStringValue(), @"([a-z])([A-Z])", "$1-$2").ToLower());
        }

        public void Build(FileModel model, IHostService host)
        {
            // model.Content = "transform test";
            // ((Dictionary<string, object>)model.Content)["conceptual"] = model.C;
            Console.WriteLine(model.File + " - " + model.Key);
            if (!model.File.Contains("assembly"))
            {
                if (FluidTemplate.TryParse(_template, out var template))
                {
                    var context = new TemplateContext();
                    var module = ((((Dictionary<string, object>)model.Content)["json"]) as JObject);
                    var moduleName = module.GetValue("TypeName").Value<string>();

                    moduleName = moduleName.Substring(moduleName.LastIndexOf('.') + 1);
                    context.Filters.AddFilter("hyphenate", Hyphenate);
                    context.SetValue("Module", ((Dictionary<string, object>) model.Content)["json"]);
                    context.SetValue("Json", ((Dictionary<string, object>) model.Content)["conceptual"]);
                    context.SetValue("ModuleName", moduleName);
                    var rendered = template.Render(context);
                    ((Dictionary<string, object>) model.Content)["conceptual"] = rendered;
                }
            }
           
            else if(model.File.Contains("assembly"))
            {
                if (FluidTemplate.TryParse(_moduleListTemplate, out var assemblyTemplate,out var errors))
                {
                    var assembly = ((Dictionary<string, object>) model.Content)["json"] as JObject;

                    var moduleMetaInfos = (assembly?.GetValue("ModulesInfo") as JArray).ToList()
                        .OrderBy(x => x.Value<string>("Name"));

                    if (assembly != null)
                    {
                        //     assembly.ModulesInfo = moduleMetaInfos.ToList();
                        assembly?.Remove("ModulesInfo");

                       assembly?.Add("ModulesInfo",  JArray.FromObject(moduleMetaInfos));
                    }
                    else
                    {
                        
                    }

                    var context = new TemplateContext();
                    context.Filters.AddFilter("hyphenate", Hyphenate);
                    context.SetValue("Assembly", assembly);
                    context.SetValue("AssemblyName", model.File);
                    context.SetValue("Json", ((Dictionary<string, object>)model.Content)["conceptual"]);

                    var rendered = assemblyTemplate.Render(context);
                    ((Dictionary<string, object>)model.Content)["conceptual"] = rendered;
                }
                else
                {
                    Console.WriteLine("Error parsing");
                    foreach (var e in errors)
                    {
                        Console.WriteLine(e);
                    }
                }
            }


        }

        public void Postbuild(ImmutableList<FileModel> models, IHostService host)
        {
            return;
        }

        public string Name => nameof(ModuleDocBuildStep);




        public int BuildOrder => 0;
    }
}

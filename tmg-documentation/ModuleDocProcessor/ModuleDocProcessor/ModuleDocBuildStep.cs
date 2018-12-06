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
using Newtonsoft.Json.Linq;

namespace ModuleDocProcessor
{
    [Export(nameof(ModuleDocProcessor), typeof(IDocumentBuildStep))]
    public class ModuleDocBuildStep : IDocumentBuildStep
    {
        private readonly TaskFactory _taskFactory = new TaskFactory(new StaTaskScheduler(1));

        private static string _template;

        static ModuleDocBuildStep()
        {

            var assembly = Assembly.GetAssembly(typeof(ModuleDocBuildStep));
            var resourceName = "ModuleDocProcessor.module.liquid";
            Console.WriteLine(assembly);

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                     _template = reader.ReadToEnd();
                    Console.WriteLine(_template);
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

            if (FluidTemplate.TryParse(_template, out var template))
            {
                var context = new TemplateContext();
                context.Filters.AddFilter("hyphenate", Hyphenate);
                context.SetValue("Module", ((Dictionary<string, object>)model.Content)["json"]);
                context.SetValue("Json", ((Dictionary<string, object>)model.Content)["conceptual"]);

                var rendered = template.Render(context);
                ((Dictionary<string, object>)model.Content)["conceptual"] = rendered;
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

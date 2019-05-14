using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.CommandLineUtils;
using Newtonsoft.Json;
using Formatting = System.Xml.Formatting;
using YamlDotNet.Serialization;

namespace ModuleDocMetaGenerator
{
    public class ModuleDocMetaGeneratorUtil
    {

        private static Dictionary<string, string> _moduleAssemblyMap;

        private static Dictionary<string, AssemblyInfo> _assemblyModulesMap;

        private static List<TocElement> _tocElements;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            _assemblyModulesMap = new Dictionary<string, AssemblyInfo>();
            _moduleAssemblyMap = new Dictionary<string, string>();
            _tocElements = new List<TocElement>();

            CommandLineApplication commandLineApplication =
                new CommandLineApplication(throwOnUnexpectedArg: false);
            CommandOption outputOption = commandLineApplication.Option(
                "-$|-o |--output <output>",
                "The output directory path.",
                CommandOptionType.SingleValue);


            CommandOption inputOption = commandLineApplication.Option(
                "-$|-i |--input <input>",
                "The input directory path.",
                CommandOptionType.SingleValue);

            CommandOption uidOption = commandLineApplication.Option(
                "-$|-u | --uid-prefix",
                "The UID prefix",
                CommandOptionType.SingleValue);

            commandLineApplication.HelpOption("-? | -h | --help");
            commandLineApplication.OnExecute(() =>
            {
                var inputDir = inputOption.HasValue() ? inputOption.Value() : Directory.GetCurrentDirectory();
                if (!outputOption.HasValue())
                {
                    Directory.CreateDirectory("output");
                }
                var outputDir = outputOption.HasValue() ? outputOption.Value() : Path.Combine(Directory.GetCurrentDirectory(), "output");
                var totalModuleCount = 0;
                foreach (string file in Directory.EnumerateFiles(
                    inputDir, "*.dll", SearchOption.AllDirectories))
                {
                    totalModuleCount += ProcessAssembly(file, outputDir, uidOption);
                }

                foreach (var k in _assemblyModulesMap.Keys.ToList())
                {
                    if (_assemblyModulesMap[k].ModulesInfo.Count > 0)
                    {
                        var info = _assemblyModulesMap[k];
                        var tocElement = new TocElement()
                        {
                            href = (uidOption.HasValue() ?  uidOption.Value() + "_" : "") + info.Assembly.GetName().Name.Replace("`", "_") + "-assembly.json",
                            items = new List<TocElement>(),
                            name = info.Assembly.GetName().Name.Replace("`", "_")
                        };
                        _tocElements.Add(tocElement);

                        info.ModulesInfo = info.ModulesInfo.OrderBy(x => x.Name).ToList();
                        foreach (var module in info.ModulesInfo)
                        {
                            tocElement.items.Add(new TocElement()
                            {
                                href = (uidOption.HasValue() ? uidOption.Value() + "_" : "") + module.TypeName.Replace("+", "+").Replace("`","_") + ".json",
                                items = new List<TocElement>(),
                                name =  module.TypeName.Substring(module.TypeName.LastIndexOf('.')+1).Replace("`", "_")
                            });
                        }

                        _assemblyModulesMap[k].ModulesInfo = _assemblyModulesMap[k].ModulesInfo.OrderBy(x => x.Name).ToList();
                        string jsonData = JsonConvert.SerializeObject(_assemblyModulesMap[k]);
                        System.IO.File.WriteAllText(Path.Combine(outputDir, (uidOption.HasValue() ? uidOption.Value() +"_" : "") + $"{_assemblyModulesMap[k].Assembly.GetName().Name}-assembly.json".Replace("`","_")), jsonData);
                        Console.WriteLine();

                    }
                }
                _tocElements = _tocElements.OrderBy(x => x.name).ToList();
                var serializer = new SerializerBuilder().Build();
                var yaml = serializer.Serialize(_tocElements);



                Console.WriteLine(_tocElements.Count);
                File.WriteAllText(Path.Combine(outputDir, "toc.yml"), yaml);

                Console.WriteLine("Total modules: " + totalModuleCount);
                return 0;
            });
            commandLineApplication.Execute(args);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="assemblyPath"></param>
        /// <param name="outputDir"></param>
        /// <returns></returns>
        public static int ProcessAssembly(string assemblyPath, string outputDir, CommandOption uidOption)
        {
            
            Assembly assembly = Assembly.LoadFrom(assemblyPath);
            _assemblyModulesMap[assembly.FullName] = new AssemblyInfo()
            {
                Assembly = assembly,
                AssemblyName = assembly.GetName().Name
            };


            var descriptionAttribute = assembly
                .GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false)
                .OfType<AssemblyDescriptionAttribute>()
                .FirstOrDefault();

            _assemblyModulesMap[assembly.FullName].AssemblyDescription = descriptionAttribute?.Description;
            int moduleCount = 0;
            foreach (var type in assembly.GetExportedTypes())
            {
                foreach (var interfaceType in type.GetInterfaces())
                {
                    if (interfaceType.Name == ("IModule") || interfaceType.Name == ("ISelfContainedModule"))
                    {
                        Console.WriteLine(type + " - " + assembly);
                        ProcessModule(type, outputDir,assembly,uidOption);
                        moduleCount++;
                        break;
                    }
                }
            }

            // write out module json and build TOC 






            return moduleCount;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="moduleType"></param>
        /// <param name="outputDir"></param>
        /// <param name="assembly"></param>
        public static void ProcessModule(Type moduleType, string outputDir, Assembly assembly, CommandOption uidOption)
        {
            var info = new ModuleMetaInfo()
            {
                Name = moduleType.Name,
                TypeInfo = moduleType,
                AssemblyInfo = moduleType.Assembly,
                TypeName = moduleType.FullName,
                DisplayName = moduleType.FullName.Substring(moduleType.FullName.LastIndexOf('.')+1)

            };

            _moduleAssemblyMap[moduleType.Name] = assembly.FullName;
            _assemblyModulesMap[assembly.FullName].ModulesInfo.Add(info);

            foreach (var attribute in moduleType.GetCustomAttributes())
            {
                if (attribute.GetType().Name == "ModuleInformationAttribute")
                {
                    info.ModuleInfo = attribute;
                }
            }

            foreach (var property in moduleType.GetProperties())
            {
                var propertyInfo = new PropertyMetaInfo()
                {
                    PropertyInfo = property
                };

                foreach (var pAttribute in property.GetCustomAttributes())
                {
                    if (pAttribute.GetType().Name.Contains("Parameter"))
                    {
                        info.ParameterPropertyMetaInfo.Add(propertyInfo);
                    }
                    if (pAttribute.GetType().Name.Contains("SubModelInfo"))
                    {
                        info.SubModulePropertyMetaInfo.Add(propertyInfo);
                    }

                    propertyInfo.Attributes.Add(pAttribute);
                }
            }

            string jsonData = JsonConvert.SerializeObject(info);
            System.IO.File.WriteAllText(Path.Combine(outputDir, (uidOption.HasValue() ? uidOption.Value() + "_" : "") + $"{moduleType.FullName.Replace("+","+").Replace("`", "_")}.json"), jsonData);
        }
    }

    public class AssemblyInfo
    {
        public List<ModuleMetaInfo> ModulesInfo { get; set; }
        public string AssemblyDescription { get; set; }
        public Assembly Assembly { get; set; }
        public string AssemblyName { get; set; }

        public AssemblyInfo()
        {
            ModulesInfo = new List<ModuleMetaInfo>();
        }
    }

    public class ModuleMetaInfo
    {

        public Type TypeInfo { get; set; }
        public string TypeName { get; set; }
        public Assembly AssemblyInfo { get; set; }
        public List<PropertyMetaInfo> ParameterPropertyMetaInfo { get; set; }
        public List<PropertyMetaInfo> SubModulePropertyMetaInfo { get; set; }
        public Attribute ModuleInfo { get; set; }

        public string DisplayName { get; set; }

        public string Name;


        public ModuleMetaInfo()
        {
            ParameterPropertyMetaInfo = new List<PropertyMetaInfo>();
            SubModulePropertyMetaInfo = new List<PropertyMetaInfo>();
        }
    }

    public class PropertyMetaInfo
    {
        public List<Attribute> Attributes { get; set; }

        public PropertyInfo PropertyInfo { get; set; }

        public PropertyMetaInfo()
        {
            Attributes = new List<Attribute>();

        }
    }
    /*### YamlMime:TableOfContent
- uid: Tasha.Common
  name: Tasha.Common
  items:
  - uid: Tasha.Common.ForwardLookup
    name: ForwardLookup
- uid: Tasha.Validation
  name: Tasha.Validation
  items:
  - uid: Tasha.Validation.AutoSanityCheck
    name: AutoSanityCheck
  - uid: Tasha.Validation.ComparisonOfFiles
    name: ComparisonOfFiles */
    public class TocElement
    {
        public string href { get; set; }

        public string name { get; set; }

        public List<TocElement> items { get; set; }
    }

}

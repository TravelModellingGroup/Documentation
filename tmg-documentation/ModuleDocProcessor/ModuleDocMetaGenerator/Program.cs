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

namespace ModuleDocMetaGenerator
{
    public class ModuleDocMetaGeneratorUtil
    {

        private static Dictionary<string, string> _moduleAssemblyMap;

        private static Dictionary<string, List<ModuleMetaInfo>> _assemblyModulesMap;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            _assemblyModulesMap = new Dictionary<string, List<ModuleMetaInfo>>();
            _moduleAssemblyMap = new Dictionary<string, string>();

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
                    totalModuleCount += ProcessAssembly(file, outputDir);
                }
                Console.WriteLine("Total modules: " + totalModuleCount);
                return 0;
            });
            commandLineApplication.Execute(args);

            Console.ReadKey();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="assemblyPath"></param>
        /// <param name="outputDir"></param>
        /// <returns></returns>
        public static int ProcessAssembly(string assemblyPath, string outputDir)
        {
            
            Assembly assembly = Assembly.LoadFrom(assemblyPath);
            _assemblyModulesMap[assembly.FullName] = new List<ModuleMetaInfo>();
            int moduleCount = 0;
            foreach (var type in assembly.GetExportedTypes())
            {
                foreach (var interfaceType in type.GetInterfaces())
                {
                    if (interfaceType.Name == ("IModule") || interfaceType.Name == ("ISelfContainedModule"))
                    {
                        Console.WriteLine(type + " - " + assembly);
                        ProcessModule(type, outputDir,assembly);
                        moduleCount++;
                        break;
                    }
                }
            }

            foreach (var k in _assemblyModulesMap.Keys.ToList())
            {
                if (_assemblyModulesMap[k].Count > 0)
                {
                    string jsonData = JsonConvert.SerializeObject(_assemblyModulesMap[k]);
                    System.IO.File.WriteAllText(Path.Combine(outputDir, $"{k}-assembly.json"), jsonData);
                    Console.WriteLine();
                    
                }
            }
            return moduleCount;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="moduleType"></param>
        /// <param name="outputDir"></param>
        /// <param name="assembly"></param>
        public static void ProcessModule(Type moduleType, string outputDir, Assembly assembly)
        {
            var info = new ModuleMetaInfo()
            {
                Name = moduleType.Name,
                TypeInfo = moduleType,
                AssemblyInfo = moduleType.Assembly

            };

            _moduleAssemblyMap[moduleType.Name] = assembly.FullName;
            _assemblyModulesMap[assembly.FullName].Add(info);

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
            System.IO.File.WriteAllText(Path.Combine(outputDir, $"{moduleType.FullName}.json"), jsonData);
        }
    }

    public class ModuleMetaInfo
    {

        public Type TypeInfo { get; set; }
        public Assembly AssemblyInfo { get; set; }
        public List<PropertyMetaInfo> ParameterPropertyMetaInfo { get; set; }
        public List<PropertyMetaInfo> SubModulePropertyMetaInfo { get; set; }
        public Attribute ModuleInfo { get; set; }
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

}

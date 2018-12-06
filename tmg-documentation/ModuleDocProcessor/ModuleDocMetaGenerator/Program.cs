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


        public static void Main(string[] args)
        {
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

        public static int ProcessAssembly(string assemblyPath, string outputDir)
        {
            Assembly assembly = Assembly.LoadFrom(assemblyPath);
            int moduleCount = 0;
            foreach (var type in assembly.GetExportedTypes())
            {
                foreach (var interfaceType in type.GetInterfaces())
                {
                    if (interfaceType.Name == ("IModule") || interfaceType.Name == ("ISelfContainedModule"))
                    {
                        Console.WriteLine(type + " - " + assembly);
                        ProcessModule(type, outputDir);
                        moduleCount++;
                        break;
                    }
                }
            }

            return moduleCount;
        }

        public static void ProcessModule(Type moduleType, string outputDir)
        {
            var info = new ModuleMetaInfo()
            {
                Name = moduleType.Name,
                TypeInfo = moduleType,
                AssemblyInfo = moduleType.Assembly

            };

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

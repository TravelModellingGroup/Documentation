using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Composition;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.DocAsCode.Common;
using Microsoft.DocAsCode.Plugins;

namespace ModuleDocProcessor
{
    [Export(typeof(IDocumentProcessor))]
    public class ModuleDocProcessor : IDocumentProcessor
    {
        /// <summary>
        /// Notify that that this document processor will process .NET assemblies (.dll)
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public ProcessingPriority GetProcessingPriority(FileAndType file)
        {

            if (file.Type == DocumentType.Article &&
                ".json".Equals(Path.GetExtension(file.File), StringComparison.OrdinalIgnoreCase))
            {
                
                return ProcessingPriority.Normal;
            }
            return ProcessingPriority.NotSupported;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="file"></param>
        /// <param name="metadata"></param>
        /// <returns></returns>
        public FileModel Load(FileAndType file, ImmutableDictionary<string, object> metadata)
        {
            // Assembly assembly = Assembly.LoadFrom(Path.Combine(file.BaseDir, file.File));

            var content = new Dictionary<string, object>
            {
                ["conceptual"] = File.ReadAllText(Path.Combine(file.BaseDir, file.File)),
                ["type"] = "Conceptual",
                ["path"] = file.File
            };

            var localPathFromRoot = PathUtility.MakeRelativePath(EnvironmentContext.BaseDirectory, EnvironmentContext.FileAbstractLayer.GetPhysicalPath(file.File));
            return new FileModel(file, content)
            {
                LocalPathFromRoot = localPathFromRoot,
                BaseDir = Path.Combine(EnvironmentContext.BaseDirectory,"_modules")
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public SaveResult Save(FileModel model)
        {
            return new SaveResult
            {
                DocumentType = "Conceptual",
                FileWithoutExtension = Path.ChangeExtension(model.File, null),
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <param name="context"></param>
        public void UpdateHref(FileModel model, IDocumentBuildContext context)
        {
            // throw new NotImplementedException();
        }

        public string Name  => nameof(ModuleDocProcessor);

        [ImportMany(nameof(ModuleDocProcessor))]
        public IEnumerable<IDocumentBuildStep> BuildSteps { get; set; }
    }
}

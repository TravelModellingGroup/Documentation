using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.DocAsCode.Plugins;

namespace ModuleDocProcessor
{
    [Export(typeof(IDocumentProcessor))]
    public class ModuleDocProcessor : IDocumentProcessor
    {
        public ProcessingPriority GetProcessingPriority(FileAndType file)
        {
            throw new NotImplementedException();
        }

        public FileModel Load(FileAndType file, ImmutableDictionary<string, object> metadata)
        {
            throw new NotImplementedException();
        }

        public SaveResult Save(FileModel model)
        {
            throw new NotImplementedException();
        }

        public void UpdateHref(FileModel model, IDocumentBuildContext context)
        {
            throw new NotImplementedException();
        }

        public string Name { get; }

        public IEnumerable<IDocumentBuildStep> BuildSteps { get; }
    }
}

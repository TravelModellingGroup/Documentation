using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Schedulers;
using Microsoft.DocAsCode.Plugins;

namespace ModuleDocProcessor
{
    [Export(nameof(ModuleDocProcessor), typeof(IDocumentBuildStep))]
    public class ModuleDocBuildStep : IDocumentBuildStep
    {
        private readonly TaskFactory _taskFactory = new TaskFactory(new StaTaskScheduler(1));

        public IEnumerable<FileModel> Prebuild(ImmutableList<FileModel> models, IHostService host)
        {
            return models;
        }

        public void Build(FileModel model, IHostService host)
        {
            model.Content = "transform test";
        }

        public void Postbuild(ImmutableList<FileModel> models, IHostService host)
        {
            return;
        }

        public string Name => nameof(ModuleDocBuildStep);


        public int BuildOrder => 0;
    }
}

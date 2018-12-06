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
            Console.WriteLine("in build step 1");
            // model.Content = "transform test";
            ((Dictionary<string, object>)model.Content)["conceptual"] = "hello!";
        }

        public void Postbuild(ImmutableList<FileModel> models, IHostService host)
        {
            return;
        }

        public string Name => nameof(ModuleDocBuildStep);


        public int BuildOrder => 0;
    }
}

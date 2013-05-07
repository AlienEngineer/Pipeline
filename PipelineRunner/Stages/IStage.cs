using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PipelineRunner.Stages
{
    interface IStage
    {
        IPipelineJob Job { get; }
        IStage Next { get; set; }
        IStage First { get; set; }
    }
}

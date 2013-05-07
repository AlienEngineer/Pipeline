
namespace PipelineRunner.Stages
{
    interface IStage
    {
        IPipelineJob Job { get; }
        IStage Next { get; set; }
        IStage First { get; set; }
    }
}

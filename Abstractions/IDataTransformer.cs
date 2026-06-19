namespace StrategyPipeline.Abstractions;

public interface IDataTransformer
{
    IEnumerable<string> Apply(IEnumerable<string> data);
}

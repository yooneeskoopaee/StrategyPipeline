namespace StrategyPipeline.Abstractions;

public interface IDataFilter
{
    IEnumerable<string> Apply(IEnumerable<string> data);
}

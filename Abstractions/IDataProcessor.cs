namespace StrategyPipeline.Abstractions;

public interface IDataProcessor
{
    IEnumerable<string> Process(IEnumerable<string> data);
}

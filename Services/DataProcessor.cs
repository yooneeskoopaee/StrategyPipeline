using StrategyPipeline.Abstractions;

namespace StrategyPipeline.Services;

public sealed class DataProcessor : IDataProcessor
{
    private readonly IEnumerable<IDataFilter> _filters;
    private readonly IEnumerable<IDataTransformer> _transformers;

    public DataProcessor(
        IEnumerable<IDataFilter> filters,
        IEnumerable<IDataTransformer> transformers)
    {
        _filters = filters;
        _transformers = transformers;
    }

    public IEnumerable<string> Process(IEnumerable<string> data)
    {
        IEnumerable<string> current = data;

        foreach (var filter in _filters)
        {
            current = filter.Apply(current);
        }

        foreach (var transformer in _transformers)
        {
            current = transformer.Apply(current);
        }

        return current;
    }
}

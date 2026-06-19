using StrategyPipeline.Abstractions;

namespace StrategyPipeline.Transformers;

public sealed class UpperCaseTransformer : IDataTransformer
{
    public IEnumerable<string> Apply(IEnumerable<string> data)
    {
        foreach (var item in data)
        {
            yield return item.ToUpperInvariant();
        }
    }
}

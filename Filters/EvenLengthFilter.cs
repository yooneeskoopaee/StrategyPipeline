using StrategyPipeline.Abstractions;

namespace StrategyPipeline.Filters;

public sealed class EvenLengthFilter : IDataFilter
{
    public IEnumerable<string> Apply(IEnumerable<string> data)
    {
        foreach (var item in data)
        {
            if (!string.IsNullOrWhiteSpace(item) && item.Length % 2 == 0)
            {
                yield return item.Trim();
            }
        }
    }
}

using Microsoft.Extensions.DependencyInjection;
using StrategyPipeline.Abstractions;
using StrategyPipeline.Filters;
using StrategyPipeline.Services;
using StrategyPipeline.Transformers;

var services = new ServiceCollection();

services.AddSingleton<IDataFilter, EvenLengthFilter>();
services.AddSingleton<IDataTransformer, UpperCaseTransformer>();
services.AddSingleton<IDataProcessor, DataProcessor>();

using var serviceProvider = services.BuildServiceProvider();

var processor = serviceProvider.GetRequiredService<IDataProcessor>();

Console.WriteLine("Enter data (comma separated):");
var input = Console.ReadLine();

if (string.IsNullOrWhiteSpace(input))
{
    Console.WriteLine("No input provided.");
    return;
}

var data = input
    .Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

var result = processor.Process(data);

Console.WriteLine("Processed Data:");
foreach (var item in result)
{
    Console.WriteLine(item);
}

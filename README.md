# StrategyPipeline

ModularDataProcessor
A modular .NET 9 console application demonstrating clean architecture principles using Dependency Injection, Strategy Pattern, and SOLID design principles.

The application processes a collection of input strings through a configurable pipeline of filters and transformers, making it easy to extend functionality without modifying existing code.

Features
Clean and modular architecture
Dependency Injection using Microsoft.Extensions.DependencyInjection
Strategy Pattern for pluggable behaviors
Extensible processing pipeline
SOLID design principles
Easy to add new filters or transformations
Architecture Overview
The application is designed around a processing pipeline:

Input Data → Filters → Transformers → Output

Core Components
IDataFilter

Defines filtering strategies.
IDataTransformer

Defines transformation strategies.
DataProcessor

Orchestrates the processing pipeline.
Program

Application entry point and DI configuration.
Project Structure
ModularDataProcessor/

Abstractions/

IDataFilter.cs

IDataTransformer.cs

Filters/

EvenLengthFilter.cs

Transformers/

UpperCaseTransformer.cs

Services/

DataProcessor.cs

Program.cs

Example Workflow
User input:

ab,abc,abcd,hello,tool,xyz

Processing steps:

Filter strings with even length
Convert remaining strings to uppercase
Output:

AB

ABCD

TOOL

var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.BlazorLearn>("blazorlearn");

builder.Build().Run();

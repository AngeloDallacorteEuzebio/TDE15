var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.Formas_ApiService>("apiservice");

builder.AddProject<Projects.Formas_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();

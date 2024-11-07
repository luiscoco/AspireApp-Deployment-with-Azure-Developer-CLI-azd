var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.AspireAppStepByStepDeployment_ApiService>("apiservice");

builder.AddProject<Projects.AspireAppStepByStepDeployment_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();

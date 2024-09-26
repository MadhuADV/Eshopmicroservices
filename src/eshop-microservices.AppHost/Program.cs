var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.CatelogAPI>("catelogapi");

builder.Build().Run();

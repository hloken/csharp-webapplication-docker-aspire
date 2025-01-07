var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.WebApplication1>("webapplication1");
builder.AddContainer("SqlServer", "mcr.microsoft.com/mssql/server:2022-latest");

builder.Build().Run();

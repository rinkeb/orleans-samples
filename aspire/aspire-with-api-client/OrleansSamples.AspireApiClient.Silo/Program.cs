using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

builder.AddKeyedAzureBlobClient("grain-storage");
builder.AddKeyedAzureTableClient("clustering");

builder.AddServiceDefaults();

// Configure Orleans
builder.UseOrleans();

var app = builder.Build();

app.MapDefaultEndpoints();

app.UseHttpsRedirection();

app.Run();
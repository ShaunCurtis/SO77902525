using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Shared;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddScoped<IDataBroker, APIDataBroker>();

await builder.Build().RunAsync();

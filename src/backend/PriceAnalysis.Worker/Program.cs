using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        // Register background services, schedulers, and ingestion workers here
    })
    .ConfigureLogging(logging => logging.AddConsole())
    .Build();

await host.RunAsync();

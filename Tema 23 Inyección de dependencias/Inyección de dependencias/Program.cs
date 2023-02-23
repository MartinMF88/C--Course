// Inyeccion de dependencias

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) =>
    services.AddTransient<ITransientOperation, DefaultOperation>()
    .AddScoped<IScopedOperation, DefaultOperation>()
    .AddSingleton<IScopedOperation, DefaultOperation>()
    .AddTransient<OperationLogger>())
    .Build();
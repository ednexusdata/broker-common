// using EdNexusData.Broker.Common.Connector;

// namespace Microsoft.Extensions.DependencyInjection;

// public static class MyConfigServiceCollectionExtensions
// {
//     /*
//     public static IServiceCollection AddConfig(this IServiceCollection services, IConfiguration config)
//     {
//         return services;
//     }
//     */

//     public static IServiceCollection AddConnectorLoader(this IServiceCollection services)
//     {
//         services.AddSingleton<ConnectorLoader>();
        
//         return services;
//     }
    
//     public static IServiceCollection AddConnectorDependencies(this IServiceCollection services)
//     {
//         Activator.CreateInstance<ConnectorLoader>();
        
//         //services.AddSingleton<AuthenticationProvidersLocator>();
//         //services.AddScoped<ConnectorCredentialRetriever>();

//         var types = AppDomain.CurrentDomain.GetAssemblies()
//                         .SelectMany(s => s.GetExportedTypes())
//                         .Where(p => p.GetInterface(nameof(IConnectorServiceCollection)) is not null);
        
//         foreach(var type in types)
//         {   
//             var myMethod = type.GetMethod("AddDependencies");
//             myMethod!.Invoke(null, new object[] { services });
//         }

//         return services;
//     }
// }
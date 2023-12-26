using System.Reflection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using OregonNexus.Broker.Connector.Payload;
using OregonNexus.Broker.Connector.PayloadContentTypes;

namespace OregonNexus.Broker.Connector;

public class ConnectorLoader
{
    public List<Type> Connectors { get; private set; } = new List<Type>();
    public List<Type> Payloads { get; private set; } = new List<Type>();
    public List<Type> ContentTypes { get; private set; } = new List<Type>();

    public Dictionary<string, Assembly> Assemblies { get; private set; } = new Dictionary<string, Assembly>();

    public Dictionary<string, string> ConnectorIndex { get; private set; } = new Dictionary<string, string>();
    public Dictionary<string, string> ConfigurationIndex { get; private set; } = new Dictionary<string, string>();
    

    public bool IsLoaded { get; set; } = false;

    private ILogger<ConnectorLoader> _logger;

    public ConnectorLoader()
    {
        _logger = LoggerFactory.Create(config =>
        {
            config.AddConsole();
        }).CreateLogger<ConnectorLoader>();
        
        if (IsLoaded == false)
        {
            LoadConnectorAssemblies();
            LoadConfigurations();
            LoadPayloads();
            LoadContentTypes();
        }
    }

    public Type? GetConnector(string connectorType)
    {
        return Connectors.Where(x => x.GetInterface(nameof(IConnector)) is not null && x.FullName == connectorType).FirstOrDefault();
    }

    public List<Type>? GetConfigurations(Assembly assembly)
    {
        return assembly.GetTypes().Where(x => x.GetInterface(nameof(Configuration.IConfiguration)) is not null).ToList();
    }

    public List<Type>? GetPayloads(Assembly assembly)
    {
        return assembly.GetTypes().Where(x => x.GetInterface(nameof(IPayload)) is not null && x.IsAbstract == false).ToList();
    }

    public List<Type>? GetContentTypes()
    {
        return ContentTypes;
    }

    private void LoadPayloads()
    {
        var types = AppDomain.CurrentDomain.GetAssemblies()
                        .SelectMany(s => s.GetTypes())
                        .Where(p => p.GetInterface(nameof(IPayload)) is not null);

        foreach(var type in types)
        {
            if (type.GetInterface(nameof(IPayload)) is not null && type.IsAbstract == false && type.Assembly.GetName().Name == "OregonNexus.Broker.Connector")
            {
                Payloads.Add(type);
                
                _logger.LogInformation($"Payload loaded: {type.FullName} from {type.AssemblyQualifiedName}");
            }
        }
    }

    private void LoadConnectorAssemblies()
    {
        IsLoaded = true;

        var connectorAssemblyPaths = Directory.GetDirectories($"{System.AppDomain.CurrentDomain.BaseDirectory}connectors");
        if (connectorAssemblyPaths.Length == 0)
        {
            _logger.LogInformation($"No connectors loaded from paths: {connectorAssemblyPaths}");
            return;
        }

        foreach(var assemblyPath in connectorAssemblyPaths)
        {
            if (String.IsNullOrEmpty(assemblyPath)) return;

            var connectorAssemblyFiles = Directory.GetFiles(assemblyPath);

            foreach(var assemblyFilePath in connectorAssemblyFiles)
            {
                if (String.IsNullOrEmpty(assemblyFilePath)) return;

                var fileInfo = new FileInfo(assemblyFilePath);
                if (fileInfo.Extension == ".dll")
                {
                    Assembly.LoadFrom(assemblyFilePath);
                }
            }
        }

        var types = AppDomain.CurrentDomain.GetAssemblies()
                        .SelectMany(s => s.GetTypes())
                        .Where(p => p.GetInterface(nameof(IConnector)) is not null);

        if (types is not null) {
            foreach(var type in types)
            {
                if (type.GetInterface(nameof(IConnector)) != null)
                {
                    Connectors.Add(type);
                    Assemblies.Add(type.Assembly.GetName().Name!, type.Assembly);
                    ConnectorIndex.Add(type.FullName!, type.AssemblyQualifiedName!);
                    
                    _logger.LogInformation($"Connector loaded: {type.FullName} from {type.AssemblyQualifiedName}");
                }
            }
        }
        
    }

    private void LoadConfigurations()
    {
        foreach(var connector in Connectors)
        {
            var configurations = connector.Assembly.GetTypes().Where(p => p.GetInterface(nameof(Configuration.IConfiguration)) is not null);
            if (configurations.Count() > 0)
            {
                foreach(var config in configurations)
                {
                    ConfigurationIndex.Add(config.FullName!, connector.AssemblyQualifiedName!);
                }
            }
        }
    }

    private void LoadContentTypes()
    {
        foreach(var connector in Connectors)
        {
            var contentTypes = connector.Assembly.GetTypes().Where(p => p.IsAssignableTo(typeof(PayloadContentType)) && p.IsAbstract == false);
            if (contentTypes.Count() > 0)
            {
                foreach(var contentType in contentTypes)
                {
                    ContentTypes.Add(contentType);
                
                    _logger.LogInformation($"ContentType loaded: {contentType.FullName} from {contentType.AssemblyQualifiedName}");
                }
            }
        }
    }
}
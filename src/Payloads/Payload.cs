namespace EdNexusData.Broker.Common.Payloads;

/// <summary>
/// A class that all Payload types inherit from. The brokers need to know what they are requesting 
/// of each other, and it's the payloads that define it. Therefore, only the broker's core assembly 
/// (not the connectors themselves) can define the payload types.
/// </summary>
public abstract class Payload
{
}

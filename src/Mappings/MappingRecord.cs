namespace EdNexusData.Broker.Common.Mappings;

public class MappingRecord
{
    private string? _brokerId;
    public string? BrokerId { 
        get {
            if (_brokerId is null)
            {
                _brokerId = Guid.NewGuid().ToString();
            }
            return _brokerId;
        }
        set {
            _brokerId = value;
        }
    }
    public string? BrokerOriginalId { get; set; }
    public bool IsValid { get; set; } = true;
    public MappingRecordAction BrokerMappingRecordAction { get; set; } = MappingRecordAction.None;
}
namespace Domain.DTOs;

public class ConnectCommercialMatchResponse
{
    public List<ConnectCommercialMatch>? ConnectCommercialMatch { get; set; }
}
public class ConnectCommercialMatch
{
    public string? MatchingEngineID { get; set; }
    public string? SubscriberEnquiryID { get; set; }
    public string? CommercialID { get; set; }
    public string? BusinessName { get; set; }
    public object? TradingName { get; set; }
    public string? RegistrationNo { get; set; }
    public string? TaxIDNo { get; set; }
    public object? CommencementDate { get; set; }
    public string? IncorporationDate { get; set; }
    public string? AccountNo { get; set; }
    public object? TelePhoneNumber { get; set; }
}

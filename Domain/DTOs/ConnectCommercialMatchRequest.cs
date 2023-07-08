namespace Domain.DTOs;
public class ConnectCommercialMatchRequest
{
    public string RequestId { get; set; }
    public string DataTicket { get; set; }
    public string EnquiryReason { get; set; }
    public string BusinessName { get; set; }
    public string BusinessRegistrationNumber { get; set; }
    public string AccountNumber { get; set; }
    public string ProductID { get; set; }
}
namespace Domain.DTOs;

public class ConnectConsumerMatchRequest
{
    public string RequestId { get; set; }
    public string DataTicket { get; set; }
    public string EnquiryReason { get; set; }
    public string ConsumerName { get; set; }
    public string DateOfBirth { get; set; }
    public string Identification { get; set; }
    public string AccountNo { get; set; }
    public int ProductID { get; set; }
}
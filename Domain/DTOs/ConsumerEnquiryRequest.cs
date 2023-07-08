namespace Domain.DTOs;

public class ConsumerEnquiryRequest
{
    public string RequestId { get; set; }
    public string DataTicket { get; set; }
    public string ConsumerID { get; set; }
    public string ProductID { get; set; }
}
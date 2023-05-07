namespace Domain.DTOs;

public class ConsumerReportRequest
{
    public string? DataTicket { get; set; }
    public string? consumerID { get; set; }
    public string? EnquiryID { get; set; }
    public string? consumerMergeList { get; set; }
    public string? SubscriberEnquiryEngineID { get; set; }
}
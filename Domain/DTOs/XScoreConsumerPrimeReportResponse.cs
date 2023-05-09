namespace Domain.DTOs;

public class XScoreConsumerPrimeReportResponse
{
    public List<SubjectList> SubjectList { get; set; }
    public List<PersonalDetailsSummary> PersonalDetailsSummary { get; set; }
    public List<Scoring> Scoring { get; set; }
    public List<CreditSummary> CreditSummary { get; set; }
    public List<PerformanceClassification> PerformanceClassification { get; set; }
    public List<EnquiryDetail> EnquiryDetails { get; set; }
}
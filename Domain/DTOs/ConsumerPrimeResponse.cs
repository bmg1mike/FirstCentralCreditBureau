namespace Domain.DTOs;

public class ConsumerPrimeResponse
{
    public List<SubjectList> SubjectList { get; set; }
    public List<PersonalDetailsSummary> PersonalDetailsSummary { get; set; }
    public List<CreditSummary> CreditSummary { get; set; }
    public List<PerformanceClassification> PerformanceClassification { get; set; }
    public List<EnquiryDetail> EnquiryDetails { get; set; }

}
public class CreditSummary
{
    public string TotalNumberOfAccountsReported { get; set; }
    public string NumberOfAccountsInGoodStanding { get; set; }
    public string NumberofAccountsInBadStanding { get; set; }
}


public class PerformanceClassification
{
    public string NoOfLoansPerforming { get; set; }
    public string NoOfLoansSubstandard { get; set; }
    public string NoOfLoansDoubtful { get; set; }
    public string NoOfLoansLost { get; set; }
}


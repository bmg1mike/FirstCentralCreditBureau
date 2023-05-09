namespace Domain.DTOs;

public class XScoreConsumerFullCreditResponse
{
    public List<SubjectList> SubjectList { get; set; }
    public List<Scoring> Scoring { get; set; }
    public List<PersonalDetailsSummary> PersonalDetailsSummary { get; set; }
    public List<DeliquencyInformation> DeliquencyInformation { get; set; }
    public List<CreditAccountSummary> CreditAccountSummary { get; set; }
    public List<CreditAccountRating> CreditAccountRating { get; set; }
    public List<CreditAgreementSummary> CreditAgreementSummary { get; set; }
    public List<AccountMonthlyPaymentHistoryHeader> AccountMonthlyPaymentHistoryHeader { get; set; }
    public List<AccountMonthlyPaymentHistory> AccountMonthlyPaymentHistory { get; set; }
    public List<GuarantorCount> GuarantorCount { get; set; }
    public List<GuarantorDetail> GuarantorDetails { get; set; }
    public object CompanyDirectorSummary { get; set; }
    public List<EnquiryHistoryTop> EnquiryHistoryTop { get; set; }
    public List<IdentificationHistory> IdentificationHistory { get; set; }
    public List<AddressHistory> AddressHistory { get; set; }
    public List<EmploymentHistory> EmploymentHistory { get; set; }
    public List<TelephoneHistory> TelephoneHistory { get; set; }
    public List<EnquiryInput> EnquiryInput { get; set; }
    public List<EnquiryDetail> EnquiryDetails { get; set; }

}


public class EnquiryInput
{
    public string EnquiryDate { get; set; }
    public string EnquiryType { get; set; }
    public string EnquiryReason { get; set; }
    public string Input { get; set; }
    public string SubscriberName { get; set; }
    public string SubscriberUsername { get; set; }
    public string MatchRate { get; set; }
    public string Disclaimer { get; set; }
}

public class Scoring
{
    public string ConsumerID { get; set; }
    public string RepaymentHistoryScore { get; set; }
    public string TotalAmountOwedScore { get; set; }
    public string TypesOfCreditScore { get; set; }
    public string LengthOfCreditHistoryScore { get; set; }
    public string NoOfAcctScore { get; set; }
    public string TotalConsumerScore { get; set; }
    public string Description { get; set; }
    public string ScoreDate { get; set; }
}

public class TelephoneHistory
{
    public object HomeNoUpdatedonDate { get; set; }
    public object HomeTelephoneNumber { get; set; }
    public object WorkNoUpdatedonDate { get; set; }
    public object WorkTelephoneNumber { get; set; }
    public object MobileNoUpdatedonDate { get; set; }
    public object MobileTelephoneNumber { get; set; }
}

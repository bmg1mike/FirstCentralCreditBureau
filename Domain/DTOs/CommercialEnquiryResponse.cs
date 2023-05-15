using System.Text.Json.Serialization;

namespace Domain.DTOs;

public class CommercialEnquiryResponse
{
    public List<SubjectList> SubjectList { get; set; }
    public List<BusinessDatum> BusinessData { get; set; }
    public List<HighestDelinquencyRating> HighestDelinquencyRating { get; set; }
    public List<FacilityPerformanceSummary> FacilityPerformanceSummary { get; set; }
    public object DirectorInformation { get; set; }
    public List<CreditAgreementSummary> CreditAgreementSummary { get; set; }
    public List<AccountMonthlyPaymentHistoryHeader> AccountMonthlyPaymentHistoryHeader { get; set; }
    public List<AccountMonthlyPaymentHistory> AccountMonthlyPaymentHistory { get; set; }
    public List<AddressHistory> AddressHistory { get; set; }

}



public class BusinessDatum
{
    public object CommercialID { get; set; }
    public object ReferenceNo { get; set; }
    public object BusinessName { get; set; }
    public object TradingName { get; set; }
    public object IndustrySector { get; set; }
    public object PreviousBusinessName { get; set; }
    public object BusinessRegistrationNumber { get; set; }
    public object PreviousRegistrationNumber { get; set; }
    public object NoOfDirectors { get; set; }
    public object BusinessType { get; set; }
    public object DateOfIncorporation { get; set; }
    public object DateOfCommencement { get; set; }
    public object TaxIdentificationNumber { get; set; }
    public object VatNumber { get; set; }
    public object Webaddress { get; set; }
    public object CommercialEmail1 { get; set; }
    public object CommercialEmail2 { get; set; }
    public object CommercialEmail3 { get; set; }
    public object CommercialEmail4 { get; set; }
    public object CommercialAddress1 { get; set; }
    public object CommercialAddress2 { get; set; }
    public object CommercialAddress3 { get; set; }
    public object CommercialAddress4 { get; set; }
    public object postalAddress1 { get; set; }
    public object postalAddress2 { get; set; }
    public object postalAddress3 { get; set; }
    public object postalAddress4 { get; set; }
    public object Telephone1 { get; set; }
    public object Telephone2 { get; set; }
    public object Telephone3 { get; set; }
    public object Telephone4 { get; set; }
    public object Fax1 { get; set; }
    public object Fax2 { get; set; }
    public object Fax3 { get; set; }
    public object Fax4 { get; set; }
    public object UpdatedOn { get; set; }
}


public class FacilityPerformanceSummary
{
    public string TotalMonthlyInstalment { get; set; }
    public string TotalOutstandingdebt { get; set; }
    public string TotalAccountarrear { get; set; }
    public string TotalAccounts { get; set; }
    public string TotalAccounts1 { get; set; }
    public string Amountarrear { get; set; }
    public string TotalaccountinGoodcondition { get; set; }
    public string TotalaccountinBadcondition { get; set; }
    public string TotalNumberofJudgement { get; set; }
    public string TotalJudgementAmount { get; set; }
    public string LastJudgementDate { get; set; }
    public string TotalNumberofDishonoured { get; set; }
    public string TotalDishonouredAmount { get; set; }
    public object LastBouncedChequesDate { get; set; }
    public string TotalMonthlyInstalment1 { get; set; }
    public string TotalOutstandingdebt1 { get; set; }
    public string TotalAccountarrear1 { get; set; }
    public string Amountarrear1 { get; set; }
    public string TotalaccountinGoodcondition1 { get; set; }
    public string TotalaccountinBadcondition1 { get; set; }
    public string TotalNumberofJudgement1 { get; set; }
    public string TotalJudgementAmount1 { get; set; }
    public string LastJudgementDate1 { get; set; }
    public string TotalNumberofDishonoured1 { get; set; }
    public string TotalDishonouredAmount1 { get; set; }
    public object LastBouncedChequesDate1 { get; set; }
    public string TotalNumberofAccounts { get; set; }
    public string LastDishonouredChequeDate { get; set; }
    public object Rating { get; set; }
}

public class HighestDelinquencyRating
{
    [JsonPropertyName("HighestDelinquencyRating")]
    public string highestDelinquencyRating { get; set; }
}
namespace Domain.DTOs
{
    public class CommercialFullCreditResponse
    {
        public List<SubjectList> SubjectList { get; set; }
        public required List<BusinessDatum> BusinessData { get; set; }
        public List<HighestDelinquencyRating> HighestDelinquencyRating { get; set; }
        public List<FacilityPerformanceSummary> FacilityPerformanceSummary { get; set; }
        public List<DirectorInformation> DirectorInformation { get; set; }
        public List<CreditAgreementSummary> CreditAgreementSummary { get; set; }
        public List<AccountMonthlyPaymentHistoryHeader> AccountMonthlyPaymentHistoryHeader { get; set; }
        public List<AccountMonthlyPaymentHistory> AccountMonthlyPaymentHistory { get; set; }
        public List<AddressHistory> AddressHistory { get; set; }
        public List<AdditionalContactHistory> AdditionalContactHistory { get; set; }
        public List<EnquiryHistoryTop> EnquiryHistoryTop { get; set; }
        public List<EnquiryDetail> EnquiryDetails { get; set; }
    }

    public class DirectorInformation
    {
        public object Directorid { get; set; }
        public object DateofBirth { get; set; }
        public object firstName { get; set; }
        public object othernames { get; set; }
        public object surname { get; set; }
        public object Identificationnumber { get; set; }
        public object DirectorAppointmentdate { get; set; }
    }

     public class AdditionalContactHistory
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

}
namespace Domain.DTOs;

public class ConsumerBasicCreditResponse
{
    public List<SubjectList>? SubjectList { get; set; }
    public List<PersonalDetailsSummary> PersonalDetailsSummary { get; set; }
    public List<CreditAccountSummary> CreditAccountSummary { get; set; }
    public List<AccountRating> AccountRating { get; set; }
    public List<EnquiryDetail> EnquiryDetails { get; set; }

}

public class AccountRating
{
    public string NoOfHomeLoanAccountsGood { get; set; }
    public string NoOfHomeLoanAccountsBad { get; set; }
    public string NoOfAutoLoanccountsGood { get; set; }
    public string NoOfAutoLoanAccountsBad { get; set; }
    public string NoOfStudyLoanAccountsGood { get; set; }
    public string NoOfStudyLoanAccountsBad { get; set; }
    public string NoOfPersonalLoanAccountsGood { get; set; }
    public string NoOfPersonalLoanAccountsBad { get; set; }
    public string NoOfCreditCardAccountsGood { get; set; }
    public string NoOfCreditCardAccountsBad { get; set; }
    public string NoOfRetailAccountsGood { get; set; }
    public string NoOfRetailAccountsBad { get; set; }
    public string NoOfJointLoanAccountsGood { get; set; }
    public string NoOfJointLoanAccountsBad { get; set; }
    public string NoOfTelecomAccountsGood { get; set; }
    public string NoOfTelecomAccountsBad { get; set; }
    public string NoOfOtherAccountsGood { get; set; }
    public string NoOfOtherAccountsBad { get; set; }
}

public class CreditAccountSummary
{
    public string TotalMonthlyInstalment { get; set; }
    public string TotalOutstandingdebt { get; set; }
    public string TotalAccountarrear { get; set; }
    public string Amountarrear { get; set; }
    public string TotalAccounts { get; set; }
    public string TotalAccounts1 { get; set; }
    public string TotalaccountinGodcondition { get; set; }
    public string TotalaccountinGoodcondition { get; set; }
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
    public string TotalaccountinGodcondition1 { get; set; }
    public string TotalaccountinBadcondition { get; set; }
    public string TotalNumberofJudgement1 { get; set; }
    public string TotalJudgementAmount1 { get; set; }
    public string LastJudgementDate1 { get; set; }
    public string TotalNumberofDishonoured1 { get; set; }
    public string TotalDishonouredAmount1 { get; set; }
    public object LastBouncedChequesDate1 { get; set; }
    public string Rating { get; set; }
}

public class EnquiryDetail
{
    public string SubscriberEnquiryResultID { get; set; }
    public string ProductID { get; set; }
    public string MatchingRate { get; set; }
    public string SubscriberEnquiryEngineID { get; set; }
}

public class PersonalDetailsSummary
{
    public string ConsumerID { get; set; }
    public string Header { get; set; }
    public object ReferenceNo { get; set; }
    public string Nationality { get; set; }
    public string NationalIDNo { get; set; }
    public object PassportNo { get; set; }
    public object DriversLicenseNo { get; set; }
    public string BankVerificationNo { get; set; }
    public string PencomIDNo { get; set; }
    public string OtheridNo { get; set; }
    public string BirthDate { get; set; }
    public string Dependants { get; set; }
    public string Gender { get; set; }
    public object MaritalStatus { get; set; }
    public string ResidentialAddress1 { get; set; }
    public string ResidentialAddress2 { get; set; }
    public string ResidentialAddress3 { get; set; }
    public string ResidentialAddress4 { get; set; }
    public string PostalAddress1 { get; set; }
    public string PostalAddress2 { get; set; }
    public string PostalAddress3 { get; set; }
    public string PostalAddress4 { get; set; }
    public object HomeTelephoneNo { get; set; }
    public object WorkTelephoneNo { get; set; }
    public string CellularNo { get; set; }
    public string EmailAddress { get; set; }
    public object EmployerDetail { get; set; }
    public string PropertyOwnedType { get; set; }
    public string Surname { get; set; }
    public string FirstName { get; set; }
    public string OtherNames { get; set; }
}
public class SubjectList
{
    public string ConsumerID { get; set; }
    public string SearchOutput { get; set; }
    public string Reference { get; set; }
}
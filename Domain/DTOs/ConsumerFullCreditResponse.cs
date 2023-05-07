namespace Domain.DTOs;

public class ConsumerFullCreditResponse
{
    public List<SubjectList> SubjectList { get; set; }
    public List<PersonalDetailsSummary> PersonalDetailsSummary { get; set; }
    public List<DeliquencyInformation> DeliquencyInformation { get; set; }
    public List<CreditAccountSummary> CreditAccountSummary { get; set; }
    public List<CreditAccountRating> CreditAccountRating { get; set; }
    public List<CreditAgreementSummary> CreditAgreementSummary { get; set; }
    public List<AccountMonthlyPaymentHistoryHeader> AccountMonthlyPaymentHistoryHeader { get; set; }
    public List<AccountMonthlyPaymentHistory> AccountMonthlyPaymentHistory { get; set; }
    public List<GuarantorCount> GuarantorCount { get; set; }
    public List<GuarantorDetail> GuarantorDetails { get; set; }
    public List<EnquiryHistoryTop> EnquiryHistoryTop { get; set; }
    public List<IdentificationHistory> IdentificationHistory { get; set; }
    public List<AddressHistory> AddressHistory { get; set; }
    public List<EmploymentHistory> EmploymentHistory { get; set; }
    public List<object> TelephoneHistory { get; set; }
    public List<EnquiryDetail> EnquiryDetails { get; set; }

}

public class AccountMonthlyPaymentHistory
{
    public string Header { get; set; }
    public string TableName { get; set; }
    public string DisplayText { get; set; }
    public string DateAccountOpened { get; set; }
    public string SubscriberName { get; set; }
    public string AccountNo { get; set; }
    public string SubAccountNo { get; set; }
    public string Currency { get; set; }
    public string CurrentBalanceDebitInd { get; set; }
    public object IndicatorDescription { get; set; }
    public string MonthlyInstalmentAmt { get; set; }
    public string LastPaymentDate { get; set; }
    public string SubscriberTypeInd { get; set; }
    public string AccountNote { get; set; }
    public string RepaymentFrequencyCode { get; set; }
    public string OpeningBalanceAmt { get; set; }
    public string CurrentBalanceAmt { get; set; }
    public string AmountOverdue { get; set; }
    public object ClosedDate { get; set; }
    public string LastUpdatedDate { get; set; }
    public string PerformanceStatus { get; set; }
    public string LoanDuration { get; set; }
    public string AccountStatus { get; set; }
    public string M01 { get; set; }
    public string M02 { get; set; }
    public string M03 { get; set; }
    public string M04 { get; set; }
    public string M05 { get; set; }
    public string M06 { get; set; }
    public string M07 { get; set; }
    public string M08 { get; set; }
    public string M09 { get; set; }
    public string M10 { get; set; }
    public string M11 { get; set; }
    public string M12 { get; set; }
    public string M13 { get; set; }
    public string M14 { get; set; }
    public string M15 { get; set; }
    public string M16 { get; set; }
    public string M17 { get; set; }
    public string M18 { get; set; }
    public string M19 { get; set; }
    public string M20 { get; set; }
    public string M21 { get; set; }
    public string M22 { get; set; }
    public string M23 { get; set; }
    public string M24 { get; set; }
}

public class AccountMonthlyPaymentHistoryHeader
{
    public string TableName { get; set; }
    public string DisplayText { get; set; }
    public string Company { get; set; }
    public string MH24 { get; set; }
    public string MH23 { get; set; }
    public string MH22 { get; set; }
    public string MH21 { get; set; }
    public string MH20 { get; set; }
    public string MH19 { get; set; }
    public string MH18 { get; set; }
    public string MH17 { get; set; }
    public string MH16 { get; set; }
    public string MH15 { get; set; }
    public string MH14 { get; set; }
    public string MH13 { get; set; }
    public string MH12 { get; set; }
    public string MH11 { get; set; }
    public string MH10 { get; set; }
    public string MH09 { get; set; }
    public string MH08 { get; set; }
    public string MH07 { get; set; }
    public string MH06 { get; set; }
    public string MH05 { get; set; }
    public string MH04 { get; set; }
    public string MH03 { get; set; }
    public string MH02 { get; set; }
    public string MH01 { get; set; }
}


public class CreditAccountRating
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


public class CreditAgreementSummary
{
    public string DateAccountOpened { get; set; }
    public string SubscriberName { get; set; }
    public string AccountNo { get; set; }
    public string SubAccountNo { get; set; }
    public object IndicatorDescription { get; set; }
    public string OpeningBalanceAmt { get; set; }
    public string Currency { get; set; }
    public string CurrentBalanceDebitInd { get; set; }
    public string CurrentBalanceAmt { get; set; }
    public string InstalmentAmount { get; set; }
    public string AmountOverdue { get; set; }
    public object ClosedDate { get; set; }
    public object LoanDuration { get; set; }
    public string RepaymentFrequency { get; set; }
    public string LastUpdatedDate { get; set; }
    public string PerformanceStatus { get; set; }
    public string AccountStatus { get; set; }
}

public class DeliquencyInformation
{
    public string SubscriberName { get; set; }
    public string AccountNo { get; set; }
    public string PeriodNum { get; set; }
    public string MonthsinArrears { get; set; }
}


public class EnquiryHistoryTop
{
    public object SubscriberEnquiryResultID { get; set; }
    public object DateRequested { get; set; }
    public object SubscriberName { get; set; }
    public object EnquiryReason { get; set; }
    public object CompanyTelephoneNo { get; set; }
}

public class GuarantorCount
{
    public string GuarantorsSecured { get; set; }
    public string Accounts { get; set; }
}
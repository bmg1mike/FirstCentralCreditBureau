namespace Domain.DTOs;

public class ConsumerBasicTraceResponse
{
    public List<SubjectList> SubjectList { get; set; }
    public List<PersonalDetailsSummary> PersonalDetailsSummary { get; set; }
    public List<CreditAccountSummary> CreditAccountSummary { get; set; }
    public List<GuarantorDetail> GuarantorDetails { get; set; }
    public List<IdentificationHistory> IdentificationHistory { get; set; }
    public List<AddressHistory> AddressHistory { get; set; }
    public List<EmploymentHistory> EmploymentHistory { get; set; }
    public List<object> TelephoneHistory { get; set; }
}

public class AddressHistory
{
    public string UpDateDate { get; set; }
    public string UpDateOnDate { get; set; }
    public string Address1 { get; set; }
    public object Address2 { get; set; }
    public object Address3 { get; set; }
    public string Address4 { get; set; }
    public string AddressTypeInd { get; set; }
}


public class EmploymentHistory
{
    public object UpDateDate { get; set; }
    public object UpDateOnDate { get; set; }
    public object EmployerDetail { get; set; }
    public object Occupation { get; set; }
}

public class GuarantorDetail
{
    public string GuarantorsSecured { get; set; }
    public string Accounts { get; set; }
    public string GuarantorFirstName { get; set; }
    public string GuarantorOtherName { get; set; }
    public string GuarantorNationalIDNo { get; set; }
    public string GuarantorPassport { get; set; }
    public string GuarantorDriverLicenceNo { get; set; }
    public string GuarantorPENCOMIDNo { get; set; }
    public string GuarantorOtherID { get; set; }
    public string GuarantorGender { get; set; }
    public string GuarantorDateOfBirth { get; set; }
    public string GuarantorAddress1 { get; set; }
    public string GuarantorAddress2 { get; set; }
    public string GuarantorAddress3 { get; set; }
    public string GuarantorHomeTelephone { get; set; }
    public string GuarantorworkTelephone { get; set; }
    public string GuarantorMobileTelephone { get; set; }
}

public class IdentificationHistory
{
    public object UpDateDate { get; set; }
    public object UpDateOnDate { get; set; }
    public object IdentificationNumber { get; set; }
    public object IdentificationType { get; set; }
}


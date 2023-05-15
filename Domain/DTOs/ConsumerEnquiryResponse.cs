namespace Domain.DTOs;

public class ConsumerEnquiryResponse
{
    public List<SubjectList> SubjectList { get; set; }
    public List<PersonalDetailsSummary> PersonalDetailsSummary { get; set; }
    public List<object> IdentificationHistory { get; set; }
    public List<AddressHistory> AddressHistory { get; set; }
    public List<EmploymentHistory> EmploymentHistory { get; set; }
    public List<TelephoneHistory> TelephoneHistory { get; set; }
}

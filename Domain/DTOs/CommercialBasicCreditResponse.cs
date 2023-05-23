namespace Domain.DTOs;

public class CommercialBasicCreditResponse
{
    public List<SubjectList> SubjectList { get; set; }
    public List<BusinessDatum> BusinessData { get; set; }
    public List<DirectorInformation> DirectorInformation { get; set; }
    public List<FacilityPerformanceSummary> FacilityPerformanceSummary { get; set; }
    public List<HighestDelinquencyRating> HighestDelinquencyRating { get; set; }
    public List<EnquiryDetail> EnquiryDetails { get; set; }

}
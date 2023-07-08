namespace Domain.DTOs
{
    public class ConnectConsumerMatchRespose
    {
        public List<MatchedConsumer> MatchedConsumer { get; set; }
    }
    public class MatchedConsumer
    {
        public string MatchingEngineID { get; set; }
        public string EnquiryID { get; set; }
        public string ConsumerID { get; set; }
        public string Reference { get; set; }
        public object IDNo { get; set; }
        public object PassportNo { get; set; }
        public object PencomIDno { get; set; }
        public object VoterID { get; set; }
        public object DriversLicenseNo { get; set; }
        public string FirstName { get; set; }
        public object Surname { get; set; }
        public string SecondName { get; set; }
        public string OtherNames { get; set; }
        public string Address { get; set; }
        public string BirthDate { get; set; }
        public object GenderInd { get; set; }
        public object AccountNo { get; set; }
        public string TelePhoneNumber { get; set; }
        public string MatchingRate { get; set; }
    }
}
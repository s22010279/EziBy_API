namespace EziBy_Core_ClassLibrary.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public bool IsGuestMode { get; set; }
        public string EmailAddress { get; set; }
        public string GuestId { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneVerified { get; set; } = false;
        public bool EmailVerified { get; set; } = false;
        public bool SubscribedForNewsLetters { get; set; }
        public bool Suspended { get; set; } = false;
        public string SuspendedReason { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateLastLogged { get; set; }
    }
}

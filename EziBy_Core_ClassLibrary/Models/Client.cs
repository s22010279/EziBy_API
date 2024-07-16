namespace EziBy_Core_ClassLibrary.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public bool IsGuestMode { get; set; }
        public string EmailAddress { get; set; } = string.Empty;
        public string GuestId { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public bool PhoneVerified { get; set; } = false;
        public bool EmailVerified { get; set; } = false;
        public bool SubscribedForNewsLetters { get; set; }
        public bool Suspended { get; set; } = false;
        public string SuspendedReason { get; set; } = string.Empty;
        public DateTime DateCreated { get; set; }
        public DateTime DateLastLogged { get; set; }
    }
}

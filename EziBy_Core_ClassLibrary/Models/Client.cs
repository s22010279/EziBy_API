namespace EziBy_Core_ClassLibrary.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public int BranchId { get; set; }
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

        //reference
        public virtual ICollection<Rating> Ratings { get; set; } = new List<Rating>();
        public virtual ICollection<MobileOrderMain> MobileOrderMains { get; set; } = new List<MobileOrderMain>();
        public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; } = new List<ShoppingCart>();
        public virtual ICollection<ViewedItem> ViewedItems { get; set; } = new List<ViewedItem>();
        public virtual ICollection<WishList> WishLists { get; set; } = new List<WishList>();
        public virtual Branch? Branch { get; set; }
    }
}

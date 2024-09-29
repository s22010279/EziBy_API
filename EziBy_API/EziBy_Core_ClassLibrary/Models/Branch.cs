namespace EziBy_Core_ClassLibrary.Models;

public class Branch
{
    public int BranchId { get; set; }
    public string BranchName { get; set; } = string.Empty;
    public string BranchDescription { get; set; } = string.Empty;
    public string BranchAddress { get; set; } = string.Empty;
    public string BranchLandPhone { get; set; } = string.Empty;
    public string BranchMobile { get; set; } = string.Empty;
    public bool Active { get; set; }

    //references
    public virtual ICollection<Advertisement> Advertisements { get; set; } = new List<Advertisement>();
    public virtual ICollection<Brand> Brands { get; set; } = new List<Brand>();
    public virtual ICollection<CarouselImage> CarouselImages { get; set; } = new List<CarouselImage>();
    public virtual ICollection<Category> Categories { get; set; } = new List<Category>();
    public virtual ICollection<Client> Clients { get; set; } = new List<Client>();
    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
    public virtual ICollection<CustomerPaymentMain> CustomerPaymentMains { get; set; } = new List<CustomerPaymentMain>();
    public virtual ICollection<CustomerPaymentSub> CustomerPaymentSubs { get; set; } = new List<CustomerPaymentSub>();
    public virtual ICollection<CustomerPointRedeem> CustomerPointRedeems { get; set; } = new List<CustomerPointRedeem>();
    public virtual ICollection<DeliveryCity> DeliveryCities { get; set; } = new List<DeliveryCity>();
    public virtual ICollection<DeliveryTime> DeliveryTimes { get; set; } = new List<DeliveryTime>();
    public virtual ICollection<GrnMain> GrnMains { get; set; } = new List<GrnMain>();
    public virtual ICollection<GrnReturnMain> GrnReturnMains { get; set; } = new List<GrnReturnMain>();
    public virtual ICollection<GrnReturnSub> GrnReturnSubs { get; set; } = new List<GrnReturnSub>();
    public virtual ICollection<GrnSub> GrnSubs { get; set; } = new List<GrnSub>();
    public virtual ICollection<Item> Items { get; set; } = new List<Item>();
    public virtual ICollection<ItemPriceVariant> ItemPriceVariants { get; set; } = new List<ItemPriceVariant>();
    public virtual ICollection<MailSetting> MailSettings { get; set; } = new List<MailSetting>();
    public virtual ICollection<MobileOrderMain> MobileOrderMains { get; set; } = new List<MobileOrderMain>();
    public virtual ICollection<MobileOrderSub> MobileOrderSubs { get; set; } = new List<MobileOrderSub>();
    public virtual ICollection<PosMain> PosMains { get; set; } = new List<PosMain>();
    public virtual ICollection<PosReturnMain> PosReturnMains { get; set; } = new List<PosReturnMain>();
    public virtual ICollection<PosReturnSub> PosReturnSubs { get; set; } = new List<PosReturnSub>();
    public virtual ICollection<PosSub> PosSubs { get; set; } = new List<PosSub>();
    public virtual ICollection<Rating> Ratings { get; set; } = new List<Rating>();
    public virtual ICollection<Serial> Serials { get; set; } = new List<Serial>();
    public virtual ICollection<Setup> Setups { get; set; } = new List<Setup>();
    public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; } = new List<ShoppingCart>();
    public virtual ICollection<SubCategory> SubCategories { get; set; } = new List<SubCategory>();
    public virtual ICollection<Supplier> Suppliers { get; set; } = new List<Supplier>();
    public virtual ICollection<SupplierPaymentMain> SupplierPaymentMains { get; set; } = new List<SupplierPaymentMain>();
    public virtual ICollection<SupplierPaymentSub> SupplierPaymentSubs { get; set; } = new List<SupplierPaymentSub>();
    public virtual ICollection<UOM> UOMs { get; set; } = new List<UOM>();
    public virtual ICollection<User> Users { get; set; } = new List<User>();
    public virtual ICollection<ViewedItem> ViewedItems { get; set; } = new List<ViewedItem>();
    public virtual ICollection<WishList> WishLists { get; set; } = new List<WishList>();
}

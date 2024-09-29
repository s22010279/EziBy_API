using EziBy_Core_ClassLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace EziBy_Core_WebAPI.Data;

public partial class EziByDbContext : DbContext
{
    public EziByDbContext(DbContextOptions<EziByDbContext> options)
         : base(options)
    {
        this.ChangeTracker.LazyLoadingEnabled = false;
    }

    #region //DBSets
    public virtual DbSet<Advertisement> Advertisements { get; set; }
    public virtual DbSet<Branch> Branches { get; set; }
    public virtual DbSet<Brand> Brands { get; set; }
    public virtual DbSet<CarouselImage> CarouselImages { get; set; }
    public virtual DbSet<Category> Categories { get; set; }
    public virtual DbSet<Client> Clients { get; set; }
    public virtual DbSet<CustomerPaymentMain> CustomerPaymentMains { get; set; }
    public virtual DbSet<CustomerPaymentSub> CustomerPaymentSubs { get; set; }
    public virtual DbSet<CustomerPointRedeem> CustomerPointRedeems { get; set; }
    public virtual DbSet<Customer> Customers { get; set; }
    public virtual DbSet<DeliveryCity> DeliveryCities { get; set; }
    public virtual DbSet<DeliveryTime> DeliveryTimes { get; set; }
    public virtual DbSet<GrnMain> GrnMains { get; set; }
    public virtual DbSet<GrnReturnMain> GrnReturnMains { get; set; }
    public virtual DbSet<GrnReturnSub> GrnReturnSubs { get; set; }
    public virtual DbSet<GrnSub> GrnSubs { get; set; }
    public virtual DbSet<ItemPriceVariant> ItemPriceVariants { get; set; }
    public virtual DbSet<Item> Items { get; set; }
    public virtual DbSet<MailSetting> MailSettings { get; set; }
    public virtual DbSet<MobileOrderMain> MobileOrderMains { get; set; }
    public virtual DbSet<MobileOrderSub> MobileOrderSubs { get; set; }
    public virtual DbSet<PosMain> PosMains { get; set; }
    public virtual DbSet<PosReturnMain> PosReturnMains { get; set; }
    public virtual DbSet<PosReturnSub> PosReturnSubs { get; set; }
    public virtual DbSet<PosSub> PosSubs { get; set; }
    public virtual DbSet<Rating> Ratings { get; set; }
    public virtual DbSet<Serial> Serials { get; set; }
    public virtual DbSet<Setup> Setups { get; set; }
    public virtual DbSet<ShoppingCart> ShoppingCarts { get; set; }
    public virtual DbSet<SubCategory> SubCategories { get; set; }
    public virtual DbSet<SupplierPaymentMain> SupplierPaymentMains { get; set; }
    public virtual DbSet<SupplierPaymentSub> SupplierPaymentSubs { get; set; }
    public virtual DbSet<Supplier> Suppliers { get; set; }
    public virtual DbSet<UOM> UOMs { get; set; }
    public virtual DbSet<User> Users { get; set; }
    public virtual DbSet<ViewedItem> ViewedItems { get; set; }
    public virtual DbSet<WishList> WishLists { get; set; }
    #endregion // DBSet

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        #region //Serial
        modelBuilder.Entity<Serial>().Property(e => e.SerialType).UseIdentityColumn(1, 1).IsRequired();
        modelBuilder.Entity<Serial>().Property(e => e.SerialDescription).HasColumnType("varchar").HasMaxLength(200).IsRequired();
        modelBuilder.Entity<Serial>().Property(e => e.CharacterPrefix).HasColumnType("varchar").HasMaxLength(10).IsRequired();
        modelBuilder.Entity<Serial>().Property(e => e.CurrentYear).IsRequired();
        modelBuilder.Entity<Serial>().Property(e => e.NumberOfDigitsInSerial).IsRequired();
        modelBuilder.Entity<Serial>().Property(e => e.NextSerialNo).IsRequired();

        //Keys
        modelBuilder.Entity<Serial>().HasKey(e => e.SerialType);

        //Foreign keys
        modelBuilder.Entity<Serial>()
        .HasOne(e => e.Branch)
        .WithMany(e => e.Serials)
        .HasForeignKey(e => e.BranchId)
        .OnDelete(DeleteBehavior.NoAction);
        #endregion

        #region //MobileOrderMain
        modelBuilder.Entity<MobileOrderMain>().Property(e => e.MobileOrderMainId).HasColumnType("varchar").HasMaxLength(50).IsRequired();
        modelBuilder.Entity<MobileOrderMain>().Property(e => e.OrderGUID).HasColumnType("varchar").HasMaxLength(50).IsRequired();
        modelBuilder.Entity<MobileOrderMain>().Property(e => e.DeliveryFullName).HasColumnType("varchar").HasMaxLength(300).IsRequired();
        modelBuilder.Entity<MobileOrderMain>().Property(e => e.DeliveryEmail).HasColumnType("varchar").HasMaxLength(300).IsRequired();
        modelBuilder.Entity<MobileOrderMain>().Property(e => e.DeliveryPhone).HasColumnType("varchar").HasMaxLength(50).IsRequired();
        modelBuilder.Entity<MobileOrderMain>().Property(e => e.DeliveryAddress).HasColumnType("varchar").HasMaxLength(1000).IsRequired();
        modelBuilder.Entity<MobileOrderMain>().Property(e => e.DeliveryNote).HasColumnType("varchar").HasMaxLength(1000).IsRequired();
        modelBuilder.Entity<MobileOrderMain>().Property(e => e.DeliveryGoogleGeoLocation).HasColumnType("varchar").HasMaxLength(300).IsRequired();
        modelBuilder.Entity<MobileOrderMain>().Property(e => e.Environment).HasColumnType("varchar").HasMaxLength(50).IsRequired();
        modelBuilder.Entity<MobileOrderMain>().Property(e => e.PaymentMethod).HasColumnType("varchar").HasMaxLength(50).IsRequired();

        //Keys
        modelBuilder.Entity<MobileOrderMain>().HasKey(e => e.MobileOrderMainId);
        modelBuilder.Entity<MobileOrderMain>().HasIndex(e => e.ClientId);
        modelBuilder.Entity<MobileOrderMain>().HasIndex(e => e.DeliveryCityId);
        modelBuilder.Entity<MobileOrderMain>().HasIndex(e => e.OrderStatusId);
        modelBuilder.Entity<MobileOrderMain>().HasIndex(e => e.PaidStatusId);
        modelBuilder.Entity<MobileOrderMain>().HasIndex(e => e.OrderGUID).IsUnique(true);

        //Foreign keys
        modelBuilder.Entity<MobileOrderMain>()
        .HasOne(e => e.Branch)
        .WithMany(e => e.MobileOrderMains)
        .HasForeignKey(e => e.BranchId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<MobileOrderMain>()
        .HasOne(e => e.Client)
        .WithMany(e => e.MobileOrderMains)
        .HasForeignKey(e => e.ClientId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<MobileOrderMain>()
        .HasOne(e => e.DeliveryCity)
        .WithMany(e => e.MobileOrderMains)
        .HasForeignKey(e => e.DeliveryCityId)
        .OnDelete(DeleteBehavior.NoAction);
        #endregion

        #region //MobileOrderSub
        modelBuilder.Entity<MobileOrderSub>().Property(e => e.MobileOrderSubId).UseIdentityColumn(1, 1).IsRequired();
        modelBuilder.Entity<MobileOrderSub>().Property(e => e.MobileOrderMainId).HasColumnType("varchar").HasMaxLength(50).IsRequired();

        //Keys
        modelBuilder.Entity<MobileOrderSub>().HasKey(e => e.MobileOrderSubId);
        modelBuilder.Entity<MobileOrderSub>().HasIndex(e => e.MobileOrderMainId);
        modelBuilder.Entity<MobileOrderSub>().HasIndex(e => new { e.MobileOrderMainId, e.MobileOrderSubId });
        modelBuilder.Entity<MobileOrderSub>().HasIndex(e => new { e.ItemId, e.ItemPriceVariantId, e.OrderStatusId });

        //Foreign keys
        modelBuilder.Entity<MobileOrderSub>()
        .HasOne(e => e.Branch)
        .WithMany(e => e.MobileOrderSubs)
        .HasForeignKey(e => e.BranchId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<MobileOrderSub>()
        .HasOne(e => e.Item)
        .WithMany(e => e.MobileOrderSubs)
        .HasForeignKey(e => e.ItemId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<MobileOrderSub>()
        .HasOne(e => e.MobileOrderMain)
        .WithMany(e => e.MobileOrderSubs)
        .HasForeignKey(e => e.MobileOrderMainId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<MobileOrderSub>()
        .HasOne(e => e.ItemPriceVariant)
        .WithMany(e => e.MobileOrderSubs)
        .HasForeignKey(e => new { e.ItemId, e.ItemPriceVariantId })
        .OnDelete(DeleteBehavior.NoAction);
        #endregion

        #region //ShoppingCart
        modelBuilder.Entity<ShoppingCart>().Property(e => e.ShoppingCartId).UseIdentityColumn(1, 1).IsRequired();

        //Keys
        modelBuilder.Entity<ShoppingCart>().HasKey(e => e.ShoppingCartId);
        modelBuilder.Entity<ShoppingCart>().HasIndex(e => e.ClientId);
        modelBuilder.Entity<ShoppingCart>().HasIndex(e => new { e.ClientId, e.ItemId, e.ItemPriceVariantId }).IsUnique(true);

        //Foreign keys
        modelBuilder.Entity<ShoppingCart>()
        .HasOne(e => e.Branch)
        .WithMany(e => e.ShoppingCarts)
        .HasForeignKey(e => e.BranchId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<ShoppingCart>()
        .HasOne(e => e.Client)
        .WithMany(e => e.ShoppingCarts)
        .HasForeignKey(e => e.ClientId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<ShoppingCart>()
        .HasOne(e => e.Item)
        .WithMany(e => e.ShoppingCarts)
        .HasForeignKey(e => e.ItemId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<ShoppingCart>()
        .HasOne(e => e.ItemPriceVariant)
        .WithMany(e => e.ShoppingCarts)
        .HasForeignKey(e => new { e.ItemId, e.ItemPriceVariantId })
        .OnDelete(DeleteBehavior.NoAction);
        #endregion

        #region //ViewedItem
        modelBuilder.Entity<ViewedItem>().Property(e => e.ViewId).UseIdentityColumn(1, 1).IsRequired();

        //Keys
        modelBuilder.Entity<ViewedItem>().HasKey(e => e.ViewId);
        modelBuilder.Entity<ViewedItem>().HasIndex(e => e.ClientId);
        modelBuilder.Entity<ViewedItem>().HasIndex(e => new { e.ItemId, e.ItemPriceVariantId });
        modelBuilder.Entity<ViewedItem>().HasIndex(e => new { e.ClientId, e.ItemId, e.ItemPriceVariantId }).IsUnique(true);

        //Foreign keys
        modelBuilder.Entity<ViewedItem>()
        .HasOne(e => e.Branch)
        .WithMany(e => e.ViewedItems)
        .HasForeignKey(e => e.BranchId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<ViewedItem>()
        .HasOne(e => e.Client)
        .WithMany(e => e.ViewedItems)
        .HasForeignKey(e => e.ClientId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<ViewedItem>()
        .HasOne(e => e.Item)
        .WithMany(e => e.ViewedItems)
        .HasForeignKey(e => e.ItemId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<ViewedItem>()
        .HasOne(e => e.ItemPriceVariant)
        .WithMany(e => e.ViewedItems)
        .HasForeignKey(e => new { e.ItemId, e.ItemPriceVariantId })
        .OnDelete(DeleteBehavior.NoAction);
        #endregion

        #region //WishList
        modelBuilder.Entity<WishList>().Property(e => e.WishListId).UseIdentityColumn(1, 1).IsRequired();

        //Keys
        modelBuilder.Entity<WishList>().HasKey(e => e.WishListId);
        modelBuilder.Entity<WishList>().HasIndex(e => e.ClientId);
        modelBuilder.Entity<WishList>().HasIndex(e => new { e.ClientId, e.ItemId, e.ItemPriceVariantId }).IsUnique(false);

        //Foreign keys
        modelBuilder.Entity<WishList>()
        .HasOne(e => e.Branch)
        .WithMany(e => e.WishLists)
        .HasForeignKey(e => e.BranchId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<WishList>()
        .HasOne(e => e.Client)
        .WithMany(e => e.WishLists)
        .HasForeignKey(e => e.ClientId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<WishList>()
        .HasOne(e => e.Item)
        .WithMany(e => e.WishLists)
        .HasForeignKey(e => e.ItemId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<WishList>()
        .HasOne(e => e.ItemPriceVariant)
        .WithMany(e => e.WishLists)
        .HasForeignKey(e => new { e.ItemId, e.ItemPriceVariantId })
        .OnDelete(DeleteBehavior.NoAction);
        #endregion

        #region //Client
        modelBuilder.Entity<Client>().Property(e => e.ClientId).IsRequired();
        modelBuilder.Entity<Client>().Property(e => e.GuestId).HasColumnType("varchar").HasMaxLength(50).IsRequired();
        modelBuilder.Entity<Client>().Property(e => e.EmailAddress).HasColumnType("varchar").HasMaxLength(200).IsRequired();
        modelBuilder.Entity<Client>().Property(e => e.FullName).HasColumnType("varchar").HasMaxLength(200).IsRequired();
        modelBuilder.Entity<Client>().Property(e => e.PhoneNumber).HasColumnType("varchar").HasMaxLength(20).IsRequired();
        modelBuilder.Entity<Client>().Property(e => e.SuspendedReason).HasColumnType("varchar").HasMaxLength(500).IsRequired();

        //Keys
        modelBuilder.Entity<Client>().HasKey(e => e.ClientId);

        //Foreign keys
        modelBuilder.Entity<Client>()
            .HasOne(e => e.Branch)
            .WithMany(e => e.Clients)
            .HasForeignKey(e => e.BranchId)
            .OnDelete(DeleteBehavior.NoAction);
        #endregion

        #region //Rating
        modelBuilder.Entity<Rating>().Property(e => e.RatingId).IsRequired();
        modelBuilder.Entity<Rating>().Property(e => e.RatingReview).HasColumnType("varchar").HasMaxLength(500).IsRequired();

        //Keys
        modelBuilder.Entity<Rating>().HasKey(e => e.RatingId);
        modelBuilder.Entity<Rating>().HasIndex(e => e.ClientId);
        modelBuilder.Entity<Rating>().HasIndex(e => new { e.ItemId, e.ItemPriceVariantId });

        //Foreign keys
        modelBuilder.Entity<Rating>()
            .HasOne(e => e.Branch)
            .WithMany(e => e.Ratings)
            .HasForeignKey(e => e.BranchId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Rating>()
        .HasOne(e => e.Client)
        .WithMany(e => e.Ratings)
        .HasForeignKey(e => e.ClientId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Rating>()
        .HasOne(e => e.Item)
        .WithMany(e => e.Ratings)
        .HasForeignKey(e => e.ItemId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Rating>()
        .HasOne(e => e.ItemPriceVariant)
        .WithMany(e => e.Ratings)
        .HasForeignKey(e => new { e.ItemId, e.ItemPriceVariantId })
        .OnDelete(DeleteBehavior.NoAction);
        #endregion

        #region //branch is the main table for all of this app
        modelBuilder.Entity<Branch>().Property(e => e.BranchId).IsRequired();
        modelBuilder.Entity<Branch>().Property(e => e.BranchName).HasColumnType("varchar").HasMaxLength(200).IsRequired();
        modelBuilder.Entity<Branch>().Property(e => e.BranchDescription).HasColumnType("varchar").HasMaxLength(500).IsRequired();
        modelBuilder.Entity<Branch>().Property(e => e.BranchAddress).HasColumnType("varchar").HasMaxLength(500).IsRequired();
        modelBuilder.Entity<Branch>().Property(e => e.BranchMobile).HasColumnType("varchar").HasMaxLength(100).IsRequired();
        modelBuilder.Entity<Branch>().Property(e => e.BranchLandPhone).HasColumnType("varchar").HasMaxLength(100).IsRequired();

        //Keys
        modelBuilder.Entity<Branch>().HasKey(e => e.BranchId);
        modelBuilder.Entity<Branch>().HasIndex(e => e.BranchId).IsUnique(true);
        modelBuilder.Entity<Branch>().HasIndex(e => e.BranchName).IsUnique(true);
        #endregion

        #region //Setup
        modelBuilder.Entity<Setup>().Property(e => e.SetupId).IsRequired();
        modelBuilder.Entity<Setup>().Property(e => e.CurrencyMark).HasColumnType("varchar").HasMaxLength(10).IsRequired();
        modelBuilder.Entity<Setup>().Property(e => e.MainSlideShowImagesUri).HasColumnType("varchar").HasMaxLength(500).IsRequired();
        modelBuilder.Entity<Setup>().Property(e => e.CategoryImagesUri).HasColumnType("varchar").HasMaxLength(500).IsRequired();
        modelBuilder.Entity<Setup>().Property(e => e.CategoryHeaderUri).HasColumnType("varchar").HasMaxLength(500).IsRequired();
        modelBuilder.Entity<Setup>().Property(e => e.SubCategoryImagesUri).HasColumnType("varchar").HasMaxLength(500).IsRequired();
        modelBuilder.Entity<Setup>().Property(e => e.ItemsImageUri).HasColumnType("varchar").HasMaxLength(500).IsRequired();
        modelBuilder.Entity<Setup>().Property(e => e.AdvertisementImageUri).HasColumnType("varchar").HasMaxLength(500).IsRequired();
        modelBuilder.Entity<Setup>().Property(e => e.BrandImageUri).HasColumnType("varchar").HasMaxLength(500).IsRequired();
        modelBuilder.Entity<Setup>().Property(e => e.SocialMediaUri).HasColumnType("varchar").HasMaxLength(500).IsRequired();
        modelBuilder.Entity<Setup>().Property(e => e.OtherImageUri).HasColumnType("varchar").HasMaxLength(500).IsRequired();
        modelBuilder.Entity<Setup>().Property(e => e.TermsAndConditionsUri).HasColumnType("varchar").HasMaxLength(500).IsRequired();
        modelBuilder.Entity<Setup>().Property(e => e.PrivacyPolicyUri).HasColumnType("varchar").HasMaxLength(500).IsRequired();
        modelBuilder.Entity<Setup>().Property(e => e.OurServicesUri).HasColumnType("varchar").HasMaxLength(500).IsRequired();
        modelBuilder.Entity<Setup>().Property(e => e.ContactUsUri).HasColumnType("varchar").HasMaxLength(500).IsRequired();
        modelBuilder.Entity<Setup>().Property(e => e.AboutUsUri).HasColumnType("varchar").HasMaxLength(500).IsRequired();
        modelBuilder.Entity<Setup>().Property(e => e.ServerMappedImagePath).HasColumnType("varchar").HasMaxLength(500).IsRequired();
        modelBuilder.Entity<Setup>().Property(e => e.CrystalReportPath).HasColumnType("varchar").HasMaxLength(500).IsRequired();

        //Key
        modelBuilder.Entity<Setup>().HasKey(e => e.SetupId);
        modelBuilder.Entity<Setup>().HasIndex(e => new { e.BranchId, e.Active }).IsUnique(true);

        //Foreign keys
        modelBuilder.Entity<Setup>()
        .HasOne(e => e.Branch)
        .WithMany(e => e.Setups)
        .HasForeignKey(e => e.BranchId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Setup>()
        .HasOne(e => e.Branch)
        .WithMany(e => e.Setups)
        .HasForeignKey(e => e.BranchId)
        .OnDelete(DeleteBehavior.NoAction);
        #endregion

        #region//Mail Setting
        modelBuilder.Entity<MailSetting>().Property(e => e.MailSettingId).UseIdentityColumn(1, 1).IsRequired();
        modelBuilder.Entity<MailSetting>().Property(e => e.OrderEmailAddress).HasColumnType("varchar").HasMaxLength(500).IsRequired();
        modelBuilder.Entity<MailSetting>().Property(e => e.OrderEmailBCCAddress).HasColumnType("varchar").HasMaxLength(500).IsRequired();
        modelBuilder.Entity<MailSetting>().Property(e => e.OrderEmailCCAddress).HasColumnType("varchar").HasMaxLength(500).IsRequired();
        modelBuilder.Entity<MailSetting>().Property(e => e.OrderEmailDisplayName).HasColumnType("varchar").HasMaxLength(500).IsRequired();
        modelBuilder.Entity<MailSetting>().Property(e => e.OrderEmailHost).HasColumnType("varchar").HasMaxLength(500).IsRequired();
        modelBuilder.Entity<MailSetting>().Property(e => e.OrderEmailPassword).HasColumnType("varchar").HasMaxLength(500).IsRequired();
        modelBuilder.Entity<MailSetting>().Property(e => e.UnsubscribeLink).HasColumnType("varchar").HasMaxLength(500).IsRequired();

        //key
        modelBuilder.Entity<MailSetting>().HasKey(e => e.MailSettingId);
        modelBuilder.Entity<MailSetting>().HasIndex(e => new { e.BranchId, e.Active }).IsUnique(true);

        //Foreign keys
        modelBuilder.Entity<MailSetting>()
        .HasOne(e => e.Branch)
        .WithMany(e => e.MailSettings)
        .HasForeignKey(e => e.BranchId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<MailSetting>()
        .HasOne(e => e.Branch)
        .WithMany(e => e.MailSettings)
        .HasForeignKey(e => e.BranchId)
        .OnDelete(DeleteBehavior.NoAction);
        #endregion

        #region//delivery city
        //table
        modelBuilder.Entity<DeliveryCity>().Property(e => e.DeliveryCityId).IsRequired();
        modelBuilder.Entity<DeliveryCity>().Property(e => e.DeliveryCityName).HasColumnType("varchar").HasMaxLength(500).IsRequired();
        modelBuilder.Entity<DeliveryCity>().Property(e => e.DeliveryCharge).HasColumnType("money").IsRequired();

        //Keys
        modelBuilder.Entity<DeliveryCity>().HasKey(e => e.DeliveryCityId);

        //Foreign keys
        modelBuilder.Entity<DeliveryCity>()
        .HasOne(e => e.Branch)
        .WithMany(e => e.DeliveryCities)
        .HasForeignKey(e => e.BranchId)
        .OnDelete(DeleteBehavior.NoAction);
        #endregion

        #region //Advertisements
        //table
        modelBuilder.Entity<Advertisement>().Property(e => e.AdvertisementId).IsRequired();
        modelBuilder.Entity<Advertisement>().Property(e => e.AdvertisementImage).HasColumnType("varchar").HasMaxLength(500).IsRequired();
        modelBuilder.Entity<Advertisement>().Property(e => e.AdvertisementLink).HasColumnType("varchar").HasMaxLength(500).IsRequired();
        modelBuilder.Entity<Advertisement>().Property(e => e.CompanyName).HasColumnType("nvarchar").HasMaxLength(500).IsRequired();
        modelBuilder.Entity<Advertisement>().Property(e => e.PhoneNumber1).HasColumnType("varchar").HasMaxLength(50).IsRequired();
        modelBuilder.Entity<Advertisement>().Property(e => e.PhoneNumber2).HasColumnType("varchar").HasMaxLength(50).IsRequired();
        modelBuilder.Entity<Advertisement>().Property(e => e.Slogan).HasColumnType("nvarchar").HasMaxLength(1000).IsRequired();

        //Keys
        modelBuilder.Entity<Advertisement>().HasKey(e => e.AdvertisementId);

        //Foreign keys
        modelBuilder.Entity<Advertisement>()
        .HasOne(e => e.Branch)
        .WithMany(e => e.Advertisements)
        .HasForeignKey(e => e.BranchId)
        .OnDelete(DeleteBehavior.NoAction);
        #endregion

        #region //Brand
        modelBuilder.Entity<Brand>().Property(e => e.BrandId).IsRequired();
        modelBuilder.Entity<Brand>().Property(e => e.BrandName).HasColumnType("varchar").HasMaxLength(200).IsRequired();
        modelBuilder.Entity<Brand>().Property(e => e.BrandImage).HasColumnType("varchar").HasMaxLength(200).IsRequired();
        
        //Keys
        modelBuilder.Entity<Brand>().HasKey(e => e.BrandId);

        //Foreign keys
        modelBuilder.Entity<Brand>()
        .HasOne(e => e.Branch)
        .WithMany(e => e.Brands)
        .HasForeignKey(e => e.BranchId)
        .OnDelete(DeleteBehavior.NoAction);
        #endregion

        #region //CarouselImage
        modelBuilder.Entity<CarouselImage>().Property(e => e.CarouselId).IsRequired();
        modelBuilder.Entity<CarouselImage>().Property(e => e.CarouselDetails).HasColumnType("varchar").HasMaxLength(200).IsRequired();
        modelBuilder.Entity<CarouselImage>().Property(e => e.CarouselImageName).HasColumnType("varchar").HasMaxLength(200).IsRequired();
        modelBuilder.Entity<CarouselImage>().Property(e => e.CarouselLink).HasColumnType("varchar").HasMaxLength(200).IsRequired();
        modelBuilder.Entity<CarouselImage>().Property(e => e.CarouselType).HasColumnType("varchar").HasMaxLength(200).IsRequired();

        //Keys
        modelBuilder.Entity<CarouselImage>().HasKey(e => e.CarouselId);

        //Foreign keys
        modelBuilder.Entity<CarouselImage>()
        .HasOne(e => e.Branch)
        .WithMany(e => e.CarouselImages)
        .HasForeignKey(e => e.BranchId)
        .OnDelete(DeleteBehavior.NoAction);
        #endregion

        #region //Category
        modelBuilder.Entity<Category>().Property(e => e.CategoryId).IsRequired();
        modelBuilder.Entity<Category>().Property(e => e.CategoryName).HasColumnType("varchar").HasMaxLength(200).IsRequired();
        modelBuilder.Entity<Category>().Property(e => e.CategoryImage).HasColumnType("varchar").HasMaxLength(200).IsRequired();
        modelBuilder.Entity<Category>().Property(e => e.CategoryHeaderImage).HasColumnType("varchar").HasMaxLength(200).IsRequired();

        //Keys
        modelBuilder.Entity<Category>().HasKey(e => e.CategoryId);

        //Foreign keys
        modelBuilder.Entity<Category>()
        .HasOne(e => e.Branch)
        .WithMany(e => e.Categories)
        .HasForeignKey(e => e.BranchId)
        .OnDelete(DeleteBehavior.NoAction);
        #endregion

        #region //SubCategory
        modelBuilder.Entity<SubCategory>().Property(e => e.SubCategoryId).IsRequired();
        modelBuilder.Entity<SubCategory>().Property(e => e.CategoryId).IsRequired();
        modelBuilder.Entity<SubCategory>().Property(e => e.SubCategoryName).HasColumnType("varchar").HasMaxLength(200).IsRequired();
        modelBuilder.Entity<SubCategory>().Property(e => e.SubCategoryImage).HasColumnType("varchar").HasMaxLength(200).IsRequired();
        modelBuilder.Entity<SubCategory>().Property(e => e.DisplayOrder).IsRequired();
        modelBuilder.Entity<SubCategory>().Property(e => e.Active).IsRequired();

        //Keys
        modelBuilder.Entity<SubCategory>().HasKey(e => new { e.CategoryId, e.SubCategoryId });
        modelBuilder.Entity<SubCategory>().HasIndex(e => new { e.CategoryId, e.SubCategoryId }).IsUnique(true);
        modelBuilder.Entity<SubCategory>().HasIndex(e => new { e.CategoryId, e.SubCategoryName }).IsUnique(true);

        //Foreign keys
        modelBuilder.Entity<SubCategory>()
        .HasOne(e => e.Branch)
        .WithMany(e => e.SubCategories)
        .HasForeignKey(e => e.BranchId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<SubCategory>()
        .HasOne(e => e.Category)
        .WithMany(e => e.SubCategories)
        .HasForeignKey(e => e.CategoryId)
        .OnDelete(DeleteBehavior.NoAction);
        #endregion

        #region //DeliveryTime
        modelBuilder.Entity<DeliveryTime>().Property(e => e.DeliveryTimeId).IsRequired();
        modelBuilder.Entity<DeliveryTime>().Property(e => e.DeliveryTimeName).HasColumnType("varchar").HasMaxLength(200).IsRequired();

        //Keys
        modelBuilder.Entity<DeliveryTime>().HasKey(e => e.DeliveryTimeId);

        //Foreign keys
        modelBuilder.Entity<DeliveryTime>()
        .HasOne(e => e.Branch)
        .WithMany(e => e.DeliveryTimes)
        .HasForeignKey(e => e.BranchId)
        .OnDelete(DeleteBehavior.NoAction);
        #endregion

        #region //Supplier
        modelBuilder.Entity<Supplier>().Property(e => e.SupplierId).IsRequired();
        modelBuilder.Entity<Supplier>().Property(e => e.SupplierName).HasColumnType("varchar").HasMaxLength(200).IsRequired();
        modelBuilder.Entity<Supplier>().Property(e => e.Address).HasColumnType("varchar").HasMaxLength(500).IsRequired();
        modelBuilder.Entity<Supplier>().Property(e => e.Mobile).HasColumnType("varchar").HasMaxLength(50).IsRequired();

        //Keys
        modelBuilder.Entity<Supplier>().HasKey(e => e.SupplierId);

        //Foreign keys
        modelBuilder.Entity<Supplier>()
        .HasOne(e => e.Branch)
        .WithMany(e => e.Suppliers)
        .HasForeignKey(e => e.BranchId)
        .OnDelete(DeleteBehavior.NoAction);
        #endregion

        #region //UOM
        modelBuilder.Entity<UOM>().Property(e => e.UOMId).IsRequired();
        modelBuilder.Entity<UOM>().Property(e => e.UOMName).HasColumnType("varchar").HasMaxLength(200).IsRequired();
        modelBuilder.Entity<UOM>().Property(e => e.UOMFullName).HasColumnType("varchar").HasMaxLength(200).IsRequired();

        //Keys
        modelBuilder.Entity<UOM>().HasKey(e => e.UOMId);

        //Foreign keys
        modelBuilder.Entity<UOM>()
        .HasOne(e => e.Branch)
        .WithMany(e => e.UOMs)
        .HasForeignKey(e => e.BranchId)
        .OnDelete(DeleteBehavior.NoAction);
        #endregion

        #region //Customer
        modelBuilder.Entity<Customer>().Property(e => e.CustomerId).IsRequired();
        modelBuilder.Entity<Customer>().Property(e => e.CustomerName).HasColumnType("varchar").HasMaxLength(200).IsRequired();
        modelBuilder.Entity<Customer>().Property(e => e.Address).HasColumnType("varchar").HasMaxLength(500).IsRequired();
        modelBuilder.Entity<Customer>().Property(e => e.Mobile).HasColumnType("varchar").HasMaxLength(50).IsRequired();
        modelBuilder.Entity<Customer>().Property(e => e.Email).HasColumnType("varchar").HasMaxLength(200).IsRequired();

        //Keys
        modelBuilder.Entity<Customer>().HasKey(e => e.CustomerId);

        //Foreign keys
        modelBuilder.Entity<Customer>()
        .HasOne(e => e.Branch)
        .WithMany(e => e.Customers)
        .HasForeignKey(e => e.BranchId)
        .OnDelete(DeleteBehavior.NoAction);
        #endregion

        #region //User
        modelBuilder.Entity<User>().Property(e => e.UserId).IsRequired();
        modelBuilder.Entity<User>().Property(e => e.UserGUID).HasColumnType("varchar").HasMaxLength(50).IsRequired();
        modelBuilder.Entity<User>().Property(e => e.UserName).HasColumnType("varchar").HasMaxLength(100).IsRequired();
        modelBuilder.Entity<User>().Property(e => e.UserFullName).HasColumnType("varchar").HasMaxLength(300).IsRequired();
        modelBuilder.Entity<User>().Property(e => e.Password).HasColumnType("nvarchar").HasMaxLength(200).IsRequired();
        modelBuilder.Entity<User>().Property(e => e.Remarks).HasColumnType("varchar").HasMaxLength(500).IsRequired();

        //Keys
        modelBuilder.Entity<User>().HasKey(e => e.UserId);
        modelBuilder.Entity<User>().HasIndex(e => e.UserName).IsUnique(true);
        modelBuilder.Entity<User>().HasIndex(e => new { e.UserName, e.Password });

        //Foreign keys
        modelBuilder.Entity<User>()
        .HasOne(e => e.Branch)
        .WithMany(e => e.Users)
        .HasForeignKey(e => e.BranchId)
        .OnDelete(DeleteBehavior.NoAction);
        #endregion

        #region //Item
        modelBuilder.Entity<Item>().Property(e => e.ItemId).IsRequired();
        modelBuilder.Entity<Item>().Property(e => e.ItemName).HasColumnType("varchar").HasMaxLength(200).IsRequired();
        modelBuilder.Entity<Item>().Property(e => e.Specification).HasColumnType("varchar").HasMaxLength(1000).IsRequired();
        modelBuilder.Entity<Item>().Property(e => e.SKUBarcode).HasColumnType("varchar").HasMaxLength(100).IsRequired();
        modelBuilder.Entity<Item>().Property(e => e.Dimension).HasColumnType("varchar").HasMaxLength(100).IsRequired();
        modelBuilder.Entity<Item>().Property(e => e.ItemImage1).HasColumnType("varchar").HasMaxLength(100).IsRequired();
        modelBuilder.Entity<Item>().Property(e => e.ItemImage2).HasColumnType("varchar").HasMaxLength(100).IsRequired();
        modelBuilder.Entity<Item>().Property(e => e.ItemImage3).HasColumnType("varchar").HasMaxLength(100).IsRequired();

        //Keys
        modelBuilder.Entity<Item>().HasKey(e => e.ItemId);
        modelBuilder.Entity<Item>().HasIndex(e => e.SKUBarcode);
        modelBuilder.Entity<Item>().HasIndex(e => e.ItemName);
        modelBuilder.Entity<Item>().HasIndex(e => new { e.ItemName, e.SKUBarcode });

        //Foreign keys
        modelBuilder.Entity<Item>()
        .HasOne(e => e.Branch)
        .WithMany(e => e.Items)
        .HasForeignKey(e => e.BranchId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Item>()
        .HasOne(e => e.Brand)
        .WithMany(e => e.Items)
        .HasForeignKey(e => e.BrandId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Item>()
        .HasOne(e => e.Category)
        .WithMany(e => e.Items)
        .HasForeignKey(e => e.CategoryId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Item>()
        .HasOne(e => e.SubCategory)
        .WithMany(e => e.Items)
        .HasForeignKey(e => new { e.CategoryId, e.SubCategoryId })
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Item>()
        .HasOne(e => e.DeliveryTime)
        .WithMany(e => e.Items)
        .HasForeignKey(e => e.DeliveryTimeId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Item>()
        .HasOne(e => e.UOM)
        .WithMany(e => e.Items)
        .HasForeignKey(e => e.UOMId)
        .OnDelete(DeleteBehavior.NoAction);
        #endregion

        #region //ItemPriceVariant
        modelBuilder.Entity<ItemPriceVariant>().Property(e => e.ItemPriceVariantId).UseIdentityColumn(1, 1).IsRequired();

        //Keys
        modelBuilder.Entity<ItemPriceVariant>().HasKey(e => new { e.ItemId, e.ItemPriceVariantId });
        modelBuilder.Entity<ItemPriceVariant>().HasIndex(e => new { e.ItemPriceVariantId, e.ItemId }).IsUnique(true);

        //Foreign keys
        modelBuilder.Entity<ItemPriceVariant>()
        .HasOne(e => e.Branch)
        .WithMany(e => e.ItemPriceVariants)
        .HasForeignKey(e => e.BranchId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<ItemPriceVariant>()
        .HasOne(e => e.Item)
        .WithMany(e => e.ItemPriceVariants)
        .HasForeignKey(e => e.ItemId)
        .OnDelete(DeleteBehavior.NoAction);
        #endregion

        #region //GrnMain
        modelBuilder.Entity<GrnMain>().Property(e => e.GrnMainId).IsRequired();
        modelBuilder.Entity<GrnMain>().Property(e => e.SupplierInvoiceNo).HasColumnType("varchar").HasMaxLength(100).IsRequired();
        modelBuilder.Entity<GrnMain>().Property(e => e.Remarks).HasColumnType("varchar").HasMaxLength(500).IsRequired();

        //Keys
        modelBuilder.Entity<GrnMain>().HasKey(e => e.GrnMainId);

        //Foreign keys
        modelBuilder.Entity<GrnMain>()
        .HasOne(e => e.Branch)
        .WithMany(e => e.GrnMains)
        .HasForeignKey(e => e.BranchId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<GrnMain>()
        .HasOne(e => e.Supplier)
        .WithMany(e => e.GrnMains)
        .HasForeignKey(e => e.SupplierId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<GrnMain>()
        .HasOne(e => e.User)
        .WithMany(e => e.GrnMains)
        .HasForeignKey(e => e.Prepared_UserId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<GrnMain>()
        .HasOne(e => e.User1)
        .WithMany(e => e.GrnMains1)
        .HasForeignKey(e => e.Modified_UserId)
        .OnDelete(DeleteBehavior.NoAction);
        #endregion

        #region //GrnSub
        modelBuilder.Entity<GrnSub>().Property(e => e.GrnSubId).UseIdentityColumn(1, 1).IsRequired();
        modelBuilder.Entity<GrnSub>().Property(e => e.GrnQty).HasPrecision(18, 4);

        //Keys
        modelBuilder.Entity<GrnSub>().HasKey(e => new { e.GrnMainId, e.GrnSubId });
        modelBuilder.Entity<GrnSub>().HasIndex(e => new { e.GrnMainId, e.GrnSubId, e.ItemId, e.ItemPriceVariantId });

        //Foreign keys
        modelBuilder.Entity<GrnSub>()
        .HasOne(e => e.Branch)
        .WithMany(e => e.GrnSubs)
        .HasForeignKey(e => e.BranchId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<GrnSub>()
        .HasOne(e => e.GrnMain)
        .WithMany(e => e.GrnSubs)
        .HasForeignKey(e => e.GrnMainId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<GrnSub>()
        .HasOne(e => e.Item)
        .WithMany(e => e.GrnSubs)
        .HasForeignKey(e => e.ItemId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<GrnSub>()
        .HasOne(e => e.ItemPriceVariant)
        .WithMany(e => e.GrnSubs)
        .HasForeignKey(e => new { e.ItemId, e.ItemPriceVariantId })
        .OnDelete(DeleteBehavior.NoAction);

        #endregion

        #region //GrnReturnMain
        modelBuilder.Entity<GrnReturnMain>().Property(e => e.GrnReturnMainId).IsRequired();
        modelBuilder.Entity<GrnReturnMain>().Property(e => e.Remarks).HasColumnType("varchar").HasMaxLength(500).IsRequired();

        //Keys
        modelBuilder.Entity<GrnReturnMain>().HasKey(e => e.GrnReturnMainId);

        //Foreign keys
        modelBuilder.Entity<GrnReturnMain>()
        .HasOne(e => e.Branch)
        .WithMany(e => e.GrnReturnMains)
        .HasForeignKey(e => e.BranchId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<GrnReturnMain>()
        .HasOne(e => e.GrnMain)
        .WithMany(e => e.GrnReturnMains)
        .HasForeignKey(e => e.GrnMainId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<GrnReturnMain>()
        .HasOne(e => e.User)
        .WithMany(e => e.GrnReturnMains)
        .HasForeignKey(e => e.Prepared_UserId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<GrnReturnMain>()
        .HasOne(e => e.User1)
        .WithMany(e => e.GrnReturnMains1)
        .HasForeignKey(e => e.Modified_UserId)
        .OnDelete(DeleteBehavior.NoAction);
        #endregion

        #region //GrnReturnSub
        modelBuilder.Entity<GrnReturnSub>().Property(e => e.GrnReturnSubId).UseIdentityColumn(1, 1).IsRequired();
        modelBuilder.Entity<GrnReturnSub>().Property(e => e.ReturnedQty).HasPrecision(18, 4);

        //Keys
        modelBuilder.Entity<GrnReturnSub>().HasKey(e => e.GrnReturnSubId);
        modelBuilder.Entity<GrnReturnSub>().HasIndex(e => new { e.GrnReturnMainId, e.GrnReturnSubId, e.GrnSubId });

        //Foreign keys
        modelBuilder.Entity<GrnReturnSub>()
        .HasOne(e => e.Branch)
        .WithMany(e => e.GrnReturnSubs)
        .HasForeignKey(e => e.BranchId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<GrnReturnSub>()
        .HasOne(e => e.GrnReturnMain)
        .WithMany(e => e.GrnReturnSubs)
        .HasForeignKey(e => e.GrnReturnMainId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<GrnReturnSub>()
        .HasOne(e => e.GrnMain)
        .WithMany(e => e.GrnReturnSubs)
        .HasForeignKey(e => e.GrnMainId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<GrnReturnSub>()
        .HasOne(e => e.GrnSub)
        .WithMany(e => e.GrnReturnSubs)
        .HasForeignKey(e => new { e.GrnMainId, e.GrnSubId })
        .OnDelete(DeleteBehavior.NoAction);
        #endregion

        #region //POSMain
        modelBuilder.Entity<PosMain>().Property(e => e.PosMainId).IsRequired();
        modelBuilder.Entity<PosMain>().Property(e => e.PosGUID).HasColumnType("varchar").HasMaxLength(100).IsRequired();
        modelBuilder.Entity<PosMain>().Property(e => e.BankTransferReference).HasColumnType("varchar").HasMaxLength(100).IsRequired();
        modelBuilder.Entity<PosMain>().Property(e => e.ChequeNumber).HasColumnType("varchar").HasMaxLength(100).IsRequired();
        modelBuilder.Entity<PosMain>().Property(e => e.ChequeValueDate).HasColumnType("date");

        //Keys
        modelBuilder.Entity<PosMain>().HasKey(e => e.PosMainId);
        modelBuilder.Entity<PosMain>().HasIndex(e => e.PosGUID).IsUnique(true);

        //Foreign keys
        modelBuilder.Entity<PosMain>()
        .HasOne(e => e.Branch)
        .WithMany(e => e.PosMains)
        .HasForeignKey(e => e.BranchId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<PosMain>()
        .HasOne(e => e.Customer)
        .WithMany(e => e.PosMains)
        .HasForeignKey(e => e.CustomerId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<PosMain>()
        .HasOne(e => e.User)
        .WithMany(e => e.PosMains)
        .HasForeignKey(e => e.Prepared_UserId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<PosMain>()
        .HasOne(e => e.User1)
        .WithMany(e => e.PosMains1)
        .HasForeignKey(e => e.Modified_UserId)
        .OnDelete(DeleteBehavior.NoAction);
        #endregion

        #region //POSSub
        modelBuilder.Entity<PosSub>().Property(e => e.PosSubId).UseIdentityColumn(1, 1).IsRequired();
        modelBuilder.Entity<PosSub>().Property(e => e.PosQty).HasPrecision(18, 4);

        //Keys
        modelBuilder.Entity<PosSub>().HasKey(e => new { e.PosMainId, e.PosSubId });
        modelBuilder.Entity<PosSub>().HasIndex(e => new { e.PosMainId, e.PosSubId, e.ItemId, e.ItemPriceVariantId });

        //Foreign keys
        modelBuilder.Entity<PosSub>()
        .HasOne(e => e.Branch)
        .WithMany(e => e.PosSubs)
        .HasForeignKey(e => e.BranchId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<PosSub>()
        .HasOne(e => e.Item)
        .WithMany(e => e.PosSubs)
        .HasForeignKey(e => e.ItemId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<PosSub>()
        .HasOne(e => e.PosMain)
        .WithMany(e => e.PosSubs)
        .HasForeignKey(e => e.PosMainId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<PosSub>()
        .HasOne(e => e.ItemPriceVariant)
        .WithMany(e => e.PosSubs)
        .HasForeignKey(e => new { e.ItemId, e.ItemPriceVariantId })
        .OnDelete(DeleteBehavior.NoAction);
        #endregion

        #region //PosReturnMain
        modelBuilder.Entity<PosReturnMain>().Property(e => e.PosReturnMainId).IsRequired();
        modelBuilder.Entity<PosReturnMain>().Property(e => e.Reason).HasColumnType("varchar").HasMaxLength(500).IsRequired();
        modelBuilder.Entity<PosReturnMain>().Property(e => e.PosReturnGUID).HasColumnType("varchar").HasMaxLength(50).IsRequired();

        //Keys
        modelBuilder.Entity<PosReturnMain>().HasKey(e => e.PosReturnMainId);
        modelBuilder.Entity<PosReturnMain>().HasIndex(e => e.PosReturnGUID).IsUnique(true);

        //Foreign keys
        modelBuilder.Entity<PosReturnMain>()
        .HasOne(e => e.Branch)
        .WithMany(e => e.PosReturnMains)
        .HasForeignKey(e => e.BranchId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<PosReturnMain>()
        .HasOne(e => e.PosMain)
        .WithMany(e => e.PosReturnMains)
        .HasForeignKey(e => e.PosMainId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<PosReturnMain>()
        .HasOne(e => e.User)
        .WithMany(e => e.PosReturnMains)
        .HasForeignKey(e => e.Prepared_UserId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<PosReturnMain>()
        .HasOne(e => e.User1)
        .WithMany(e => e.PosReturnMains1)
        .HasForeignKey(e => e.Modified_UserId)
        .OnDelete(DeleteBehavior.NoAction);
        #endregion

        #region //PosReturnSub
        modelBuilder.Entity<PosReturnSub>().Property(e => e.PosReturnSubId).UseIdentityColumn(1, 1).IsRequired();
        modelBuilder.Entity<PosReturnSub>().Property(e => e.ReturnedQty).HasPrecision(18, 4);

        //Keys
        modelBuilder.Entity<PosReturnSub>().HasKey(e => e.PosReturnSubId);
        modelBuilder.Entity<PosReturnSub>().HasIndex(e => new { e.PosReturnMainId, e.PosReturnSubId, e.PosSubId });

        //Foreign keys
        modelBuilder.Entity<PosReturnSub>()
        .HasOne(e => e.Branch)
        .WithMany(e => e.PosReturnSubs)
        .HasForeignKey(e => e.BranchId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<PosReturnSub>()
        .HasOne(e => e.PosReturnMain)
        .WithMany(e => e.PosReturnSubs)
        .HasForeignKey(e => e.PosReturnMainId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<PosReturnSub>()
        .HasOne(e => e.PosMain)
        .WithMany(e => e.PosReturnSubs)
        .HasForeignKey(e => e.PosMainId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<PosReturnSub>()
        .HasOne(e => e.PosSub)
        .WithMany(e => e.PosReturnSubs)
        .HasForeignKey(e => new { e.PosMainId, e.PosSubId })
        .OnDelete(DeleteBehavior.NoAction);
        #endregion

        #region //CustomerPaymentMain
        modelBuilder.Entity<CustomerPaymentMain>().Property(e => e.CustomerPaymentMainId).IsRequired();
        modelBuilder.Entity<CustomerPaymentMain>().Property(e => e.Remarks).HasColumnType("varchar").HasMaxLength(500).IsRequired();
        modelBuilder.Entity<CustomerPaymentMain>().Property(e => e.BankTransferReference).HasColumnType("varchar").HasMaxLength(100).IsRequired();
        modelBuilder.Entity<CustomerPaymentMain>().Property(e => e.ChequeNumber).HasColumnType("varchar").HasMaxLength(100).IsRequired();
        modelBuilder.Entity<CustomerPaymentMain>().Property(e => e.ChequeValueDate).HasColumnType("date");

        //Keys
        modelBuilder.Entity<CustomerPaymentMain>().HasKey(e => e.CustomerPaymentMainId);

        //Foreign keys
        modelBuilder.Entity<CustomerPaymentMain>()
        .HasOne(e => e.Branch)
        .WithMany(e => e.CustomerPaymentMains)
        .HasForeignKey(e => e.BranchId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<CustomerPaymentMain>()
        .HasOne(e => e.Customer)
        .WithMany(e => e.CustomerPaymentMains)
        .HasForeignKey(e => e.CustomerId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<CustomerPaymentMain>()
        .HasOne(e => e.User)
        .WithMany(e => e.CustomerPaymentMains)
        .HasForeignKey(e => e.Prepared_UserId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<CustomerPaymentMain>()
        .HasOne(e => e.User1)
        .WithMany(e => e.CustomerPaymentMains1)
        .HasForeignKey(e => e.Modified_UserId)
        .OnDelete(DeleteBehavior.NoAction);
        #endregion

        #region //CustomerPaymentSub
        modelBuilder.Entity<CustomerPaymentSub>().Property(e => e.CustomerPaymentSubId).UseIdentityColumn(1, 1).IsRequired();

        //Keys
        modelBuilder.Entity<CustomerPaymentSub>().HasKey(e => e.CustomerPaymentSubId);
        modelBuilder.Entity<CustomerPaymentSub>().HasIndex(e => e.CustomerPaymentMainId).IsUnique(false);
        modelBuilder.Entity<CustomerPaymentSub>().HasIndex(e => e.PosMainId).IsUnique(false);

        //Foreign keys
        modelBuilder.Entity<CustomerPaymentSub>()
        .HasOne(e => e.Branch)
        .WithMany(e => e.CustomerPaymentSubs)
        .HasForeignKey(e => e.BranchId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<CustomerPaymentSub>()
        .HasOne(e => e.CustomerPaymentMain)
        .WithMany(e => e.CustomerPaymentSubs)
        .HasForeignKey(e => e.CustomerPaymentMainId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<CustomerPaymentSub>()
        .HasOne(e => e.PosMain)
        .WithMany(e => e.CustomerPaymentSubs)
        .HasForeignKey(e => e.PosMainId)
        .OnDelete(DeleteBehavior.NoAction);
        #endregion

        #region //CustomerPointRedeem
        modelBuilder.Entity<CustomerPointRedeem>().Property(e => e.RedeepmedId).IsRequired();
        modelBuilder.Entity<CustomerPointRedeem>().Property(e => e.RedeepedDate).HasColumnType("datetime");

        //Keys
        modelBuilder.Entity<CustomerPointRedeem>().HasKey(e => e.RedeepmedId);

        //Foreign keys
        modelBuilder.Entity<CustomerPointRedeem>()
        .HasOne(e => e.Branch)
        .WithMany(e => e.CustomerPointRedeems)
        .HasForeignKey(e => e.BranchId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<CustomerPointRedeem>()
        .HasOne(e => e.Customer)
        .WithMany(e => e.CustomerPointRedeems)
        .HasForeignKey(e => e.CustomerId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<CustomerPointRedeem>()
        .HasOne(e => e.Branch)
        .WithMany(e => e.CustomerPointRedeems)
        .HasForeignKey(e => e.BranchId)
        .OnDelete(DeleteBehavior.NoAction);
        #endregion

        #region //SupplierPaymentMain
        modelBuilder.Entity<SupplierPaymentMain>().Property(e => e.SupplierPaymentMainId).IsRequired();
        modelBuilder.Entity<SupplierPaymentMain>().Property(e => e.Remarks).HasColumnType("varchar").HasMaxLength(500).IsRequired();
        modelBuilder.Entity<SupplierPaymentMain>().Property(e => e.BankTransferReference).HasColumnType("varchar").HasMaxLength(100).IsRequired();
        modelBuilder.Entity<SupplierPaymentMain>().Property(e => e.ChequeNumber).HasColumnType("varchar").HasMaxLength(100).IsRequired();
        modelBuilder.Entity<SupplierPaymentMain>().Property(e => e.ChequeValueDate).HasColumnType("date");

        //Keys
        modelBuilder.Entity<SupplierPaymentMain>().HasKey(e => e.SupplierPaymentMainId);

        //Foreign keys
        modelBuilder.Entity<SupplierPaymentMain>()
        .HasOne(e => e.Branch)
        .WithMany(e => e.SupplierPaymentMains)
        .HasForeignKey(e => e.BranchId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<SupplierPaymentMain>()
        .HasOne(e => e.Supplier)
        .WithMany(e => e.SupplierPaymentMains)
        .HasForeignKey(e => e.SupplierId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<SupplierPaymentMain>()
        .HasOne(e => e.User)
        .WithMany(e => e.SupplierPaymentMains)
        .HasForeignKey(e => e.Prepared_UserId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<SupplierPaymentMain>()
        .HasOne(e => e.User1)
        .WithMany(e => e.SupplierPaymentMains1)
        .HasForeignKey(e => e.Modified_UserId)
        .OnDelete(DeleteBehavior.NoAction);
        #endregion

        #region //SupplierPaymentSub
        modelBuilder.Entity<SupplierPaymentSub>().Property(e => e.SupplierPaymentSubId).UseIdentityColumn(1, 1).IsRequired();

        //Keys
        modelBuilder.Entity<SupplierPaymentSub>().HasKey(e => e.SupplierPaymentSubId);
        modelBuilder.Entity<SupplierPaymentSub>().HasIndex(e => e.SupplierPaymentMainId).IsUnique(false);
        modelBuilder.Entity<SupplierPaymentSub>().HasIndex(e => e.GrnMainId).IsUnique(false);

        //Foreign keys
        modelBuilder.Entity<SupplierPaymentSub>()
        .HasOne(e => e.Branch)
        .WithMany(e => e.SupplierPaymentSubs)
        .HasForeignKey(e => e.BranchId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<SupplierPaymentSub>()
        .HasOne(e => e.SupplierPaymentMain)
        .WithMany(e => e.SupplierPaymentSubs)
        .HasForeignKey(e => e.SupplierPaymentMainId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<SupplierPaymentSub>()
        .HasOne(e => e.GrnMain)
        .WithMany(e => e.SupplierPaymentSubs)
        .HasForeignKey(e => e.GrnMainId)
        .OnDelete(DeleteBehavior.NoAction);
        #endregion
    }
}
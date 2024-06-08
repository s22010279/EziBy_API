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
    public virtual DbSet<Branch> Branches { get; set; }
    public virtual DbSet<Setup> Setups { get; set; }

    #endregion // DBSet

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);


        #region //branch is the main table for all of this app
        modelBuilder.Entity<Branch>().Property(e => e.BranchId).IsRequired();
        modelBuilder.Entity<Branch>().Property(e => e.BranchName).HasColumnType("varchar").HasMaxLength(200).IsRequired();
        modelBuilder.Entity<Branch>().Property(e => e.BranchDescription).HasColumnType("varchar").HasMaxLength(500).IsRequired();
        modelBuilder.Entity<Branch>().Property(e => e.BranchAddress).HasColumnType("varchar").HasMaxLength(500).IsRequired();
        modelBuilder.Entity<Branch>().Property(e => e.BranchMobile).HasColumnType("varchar").HasMaxLength(100).IsRequired();
        modelBuilder.Entity<Branch>().Property(e => e.BranchLandPhone).HasColumnType("varchar").HasMaxLength(100).IsRequired();

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
        modelBuilder.Entity<Setup>().Property(e => e.BrandImageUri).HasColumnType("varchar").HasMaxLength(500).IsRequired();
        modelBuilder.Entity<Setup>().Property(e => e.SocialMediaUri).HasColumnType("varchar").HasMaxLength(500).IsRequired();
        modelBuilder.Entity<Setup>().Property(e => e.OtherImageUri).HasColumnType("varchar").HasMaxLength(500).IsRequired();
        modelBuilder.Entity<Setup>().Property(e => e.TermsAndConditionsUri).HasColumnType("varchar").HasMaxLength(500).IsRequired();
        modelBuilder.Entity<Setup>().Property(e => e.PrivacyPolicyUri).HasColumnType("varchar").HasMaxLength(500).IsRequired();
        modelBuilder.Entity<Setup>().Property(e => e.OurServicesUri).HasColumnType("varchar").HasMaxLength(500).IsRequired();
        modelBuilder.Entity<Setup>().Property(e => e.ContactUsUri).HasColumnType("varchar").HasMaxLength(500).IsRequired();
        modelBuilder.Entity<Setup>().Property(e => e.AboutUsUri).HasColumnType("varchar").HasMaxLength(500).IsRequired();
        modelBuilder.Entity<Setup>().Property(e => e.ServerMappedImagePath).HasColumnType("varchar").HasMaxLength(500).IsRequired();
        modelBuilder.Entity<Setup>().Property(e => e.CyrstalReportPath).HasColumnType("varchar").HasMaxLength(500).IsRequired();
        modelBuilder.Entity<Setup>().Property(e => e.ItemsImageUri).HasColumnType("varchar").HasMaxLength(500).IsRequired();
        modelBuilder.Entity<Setup>().Property(e => e.MainAPIUri).HasColumnType("varchar").HasMaxLength(500).IsRequired();

        modelBuilder.Entity<Setup>().HasKey(e => e.SetupId);
        modelBuilder.Entity<Setup>().HasIndex(e => new { e.BranchId, e.Active }).IsUnique(true);

        modelBuilder.Entity<Setup>()
            .HasOne(e => e.Branch)
            .WithMany(e => e.Setups)
            .HasForeignKey(e => e.BranchId)
            .OnDelete(DeleteBehavior.NoAction);
        #endregion


    }
}

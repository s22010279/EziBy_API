namespace EziBy_Core_ClassLibrary.Models;

public partial class Setup
{
    public int SetupId { get; set; }
    public int BranchId { get; set; }

    public string CurrencyMark { get; set; } = string.Empty;
    public int CurrencyDecimals { get; set; }
    public int InitialDeliveryDays { get; set; }
    public int MaximumDeliveryDays { get; set; }

    public bool Android_OnGoingMaintenance { get; set; }
    public bool Android_ForceUpdate { get; set; }
    public int Android_BuildNumber { get; set; }

    public string MainAPIUri { get; set; } = string.Empty;
    public string MainSlideShowImagesUri { get; set; } = string.Empty;
    public string CategoryImagesUri { get; set; } = string.Empty;
    public string CategoryHeaderUri { get; set; } = string.Empty;
    public string SubCategoryImagesUri { get; set; } = string.Empty;
    public string ItemsImageUri { get; set; } = string.Empty;
    public string BrandImageUri { get; set; } = string.Empty;
    public string SocialMediaUri { get; set; } = string.Empty;
    public string AdvertisementImageUri { get; set; } = string.Empty;
    public string OtherImageUri { get; set; } = string.Empty;
    public string TermsAndConditionsUri { get; set; } = string.Empty;
    public string PrivacyPolicyUri { get; set; } = string.Empty;
    public string OurServicesUri { get; set; } = string.Empty;
    public string ContactUsUri { get; set; } = string.Empty;
    public string AboutUsUri { get; set; } = string.Empty;
    public string ServerMappedImagePath { get; set; } = string.Empty;
    public int NewOrderRefreshInterval { get; set; }
    public bool AllowDiscountInPOS { get; set; }
    public bool Active { get; set; }

    public string CrystalReportPath { get; set; } = string.Empty;

    //reference
    public virtual Branch? Branch { get; set; }
}

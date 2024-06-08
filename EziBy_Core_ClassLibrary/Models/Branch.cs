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
    public virtual ICollection<Setup> Setups { get; set; } = new List<Setup>();
}

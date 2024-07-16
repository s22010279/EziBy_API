namespace EziBy_Core_ClassLibrary.Models
{
    public class UOM
    {
        public int UOMId { get; set; }
        public string UOMName { get; set; } = string.Empty;
        public string UOMFullName { get; set; } = string.Empty;
        public string UOMNameWithFullName => UOMName + "-" + UOMFullName;
        public bool Active { get; set; }
    }
}

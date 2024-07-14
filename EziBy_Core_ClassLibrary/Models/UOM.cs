namespace EziBy_Core_ClassLibrary.Models
{
    public class UOM
    {
        public int UOMId { get; set; }
        public string UOMName { get; set; }
        public string UOMFullName { get; set; }
        public string UOMNameWithFullName => UOMName + " " + UOMFullName;
        public bool Active { get; set; }
    }
}

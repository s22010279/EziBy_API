namespace EziBy_Core_ClassLibrary.Models
{
    public class Serial
    {
        public int SerialType { get; set; }
        public string SerialDescription { get; set; } = string.Empty;
        public bool AddYearPrefix { get; set; }
        public string CharacterPrefix { get; set; } = string.Empty;
        public int CurrentYear { get; set; }
        public int NumberOfDigitsInSerial { get; set; }
        public int NextSerialNo { get; set; }
    }
}

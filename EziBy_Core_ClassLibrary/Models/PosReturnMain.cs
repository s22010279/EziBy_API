namespace EziBy_Core_ClassLibrary.Models
{
    public class PosReturnMain
    {
        public int PosReturnMainId { get; set; }
        public string PosReturnGUID { get; set; }
        public int PosMainId { get; set; }
        public DateTime PosReturnDate { get; set; }
        public string Reason { get; set; }
        public decimal GrossAmount { get; set; }
        public decimal AdditionAmount { get; set; }
        public decimal DeductionAmount { get; set; }
        public decimal NetAmount { get; set; }
        public decimal RedeemableAmount { get; set; }
        public decimal CreditSettledAmount { get; set; }
        public bool Used { get; set; }
        public int Prepared_UserId { get; set; }
        public DateTime Prepared_Date { get; set; }
        public int Modified_UserId { get; set; }
        public DateTime Modified_Date { get; set; }
    }
}
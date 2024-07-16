namespace EziBy_Core_ClassLibrary.Models
{
    public partial class PosMain
    {
        public int PosMainId { get; set; }
        public string PosGUID { get; set; } = string.Empty;
        public DateTime PosDate { get; set; }
        public int CustomerId { get; set; }
        public bool Cancelled { get; set; }
        public decimal GrossAmount { get; set; }
        public decimal PermissableFraction { get; set; }
        public decimal NetAmount { get; set; }
        public decimal CashAmount { get; set; }
        public decimal CardVisa { get; set; }
        public decimal CardMaster { get; set; }
        public decimal CardAmex { get; set; }
        public decimal BankTransferAmount { get; set; }
        public string BankTransferReference { get; set; } = string.Empty;
        public decimal ChequeAmount { get; set; }
        public string ChequeNumber { get; set; } = string.Empty;
        public DateTime? ChequeValueDate { get; set; }
        public decimal CreditAmount { get; set; }
        public decimal BalanceAmount { get; set; }
        public int Prepared_UserId { get; set; }
        public DateTime Prepared_Date { get; set; }
        public int Modified_UserId { get; set; }
        public DateTime Modified_Date { get; set; }
    }
}
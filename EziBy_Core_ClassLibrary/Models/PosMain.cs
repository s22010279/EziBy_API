﻿namespace EziBy_Core_ClassLibrary.Models
{
    public partial class PosMain
    {
        public int PosMainId { get; set; }
        public string PosGUID { get; set; }
        public DateTime PosDate { get; set; }
        public int CustomerId { get; set; }//ref
        public bool Cancelled { get; set; }
        public decimal GrossAmount { get; set; }
        //public decimal DiscountPercent { get; set; }
        //public decimal DiscountAmount { get; set; }
        //public decimal DeductionAmount { get; set; }
        public decimal PermissableFraction { get; set; }
        public decimal NetAmount { get; set; }
        public decimal CashAmount { get; set; }
        public decimal CardVisa { get; set; }
        public decimal CardMaster { get; set; }
        public decimal CardAmex { get; set; }
        public decimal BankTransferAmount { get; set; }
        public string BankTransferReference { get; set; }
        public decimal ChequeAmount { get; set; }
        public string ChequeNumber { get; set; }
        public DateTime? ChequeValueDate { get; set; }
        public decimal CreditAmount { get; set; }
        public decimal BalanceAmount { get; set; }
        //public byte[] QRCode { get; set; }

        public int Prepared_UserId { get; set; }//ref
        public DateTime Prepared_Date { get; set; }
        public int Modified_UserId { get; set; }//ref
        public DateTime Modified_Date { get; set; }

        //references
        public virtual Customer Customer { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; } //for 2nd foreign key ref
        public virtual ICollection<PosSub> PosSubs { get; set; }
        public virtual ICollection<PosReturnMain> PosReturnMains { get; set; }
        public virtual ICollection<PosReturnSub> PosReturnSubs { get; set; }
        public virtual ICollection<CustomerPaymentSub> CustomerPaymentSubs { get; set; }
    }
}
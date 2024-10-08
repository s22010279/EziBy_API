﻿namespace EziBy_Core_ClassLibrary.Models
{
    internal class CustomerPaymentMain
    {
        public int CustomerPaymentMainId { get; set; }//auto number
        public DateTime PaymentDate { get; set; }
        public int CustomerId { get; set; }//ref
        public bool Cancelled { get; set; }
        public string Remarks { get; set; }

        public decimal CashAmount { get; set; }
        public decimal CardVisa { get; set; }
        public decimal CardMaster { get; set; }
        public decimal CardAmex { get; set; }
        public decimal BankTransferAmount { get; set; }
        public string BankTransferReference { get; set; }
        public decimal ChequeAmount { get; set; }
        public string ChequeNumber { get; set; }
        public DateTime? ChequeValueDate { get; set; }


        public int Prepared_UserId { get; set; }//ref
        public DateTime Prepared_Date { get; set; }
        public int Modified_UserId { get; set; }//ref
        public DateTime Modified_Date { get; set; }
    }
}

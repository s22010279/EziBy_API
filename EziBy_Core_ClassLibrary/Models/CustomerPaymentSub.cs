namespace EziBy_Core_ClassLibrary.Models
{
    public class CustomerPaymentSub
    {
        public int CustomerPaymentSubId { get; set; }//auto number
        public int BranchId { get; set; }
        public int CustomerPaymentMainId { get; set; }//ref
        public int PosMainId { get; set; }//ref
        public decimal SettledAmount { get; set; }

        //ref
        public virtual CustomerPaymentMain? CustomerPaymentMain { get; set; }
        public virtual PosMain? PosMain { get; set; }
        public virtual Branch? Branch { get; set; }
    }
}

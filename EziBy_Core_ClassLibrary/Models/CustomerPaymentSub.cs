namespace EziBy_Core_ClassLibrary.Models
{
    public class CustomerPaymentSub
    {
        public int CustomerPaymentSubId { get; set; }//auto number
        public int CustomerPaymentMainId { get; set; }//ref
        public int PosMainId { get; set; }//ref
        public decimal SettledAmount { get; set11; }
    }
}

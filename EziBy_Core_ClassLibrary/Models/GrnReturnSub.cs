namespace EziBy_Core_ClassLibrary.Models
{
    public class GrnReturnSub
    {
        public int GrnReturnSubId { get; set; }
        public int GrnReturnMainId { get; set; }//ref
        public int GrnMainId { get; set; }//ref
        public int GrnSubId { get; set; }//ref
        public decimal ReturnedQty { get; set; }
    }
}

namespace EziBy_Core_ClassLibrary.Models
{
    public class GrnReturnMain
    {
        public int GrnReturnMainId { get; set; }
        public int GrnMainId { get; set; }//ref
        public DateTime GrnReturnDate { get; set; }

        public string Remarks { get; set; }

        public decimal AdditionAmount { get; set; }
        public decimal DeductionAmount { get; set; }

        public bool Posted { get; set; }

        public int Prepared_UserId { get; set; }//ref
        public DateTime Prepared_Date { get; set; }
        public int Modified_UserId { get; set; }//ref
        public DateTime Modified_Date { get; set; }
    }
}

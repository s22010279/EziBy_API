using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EziBy_Core_ClassLibrary.Models
{
    internal class CustomerPaymentSub
    {
        public int CustomerPaymentSubId { get; set; }//auto number
        public int CustomerPaymentMainId { get; set; }//ref
        public int PosMainId { get; set; }//ref
        public decimal SettledAmount { get; set; }
    }
}

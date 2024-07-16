using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EziBy_Core_ClassLibrary.Models
{
    public class CustomerPointRedeem
    {
        public int RedeepmedId { get; set; }
        public int CustomerId { get; set; }
        public int PointsRedeemped { get; set; }
        public DateTime RedeepedDate { get; set; }

    }
}

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
        public int BranchId { get; set; }
        public int CustomerId { get; set; }
        public int PointsRedeemped { get; set; }
        public DateTime RedeepedDate { get; set; }

        //references
        public virtual Customer? Customer { get; set; }
        public virtual Branch? Branch { get; set; }

    }
}

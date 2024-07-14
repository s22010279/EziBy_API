using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EziBy_Core_ClassLibrary.Models
{
    internal class DeliveryTime
    {
        public int DeliveryTimeId { get; set; }
        public string DeliveryTimeName { get; set; }
        public int DisplayOrder { get; set; }
        public bool Active { get; set; }
    }
}

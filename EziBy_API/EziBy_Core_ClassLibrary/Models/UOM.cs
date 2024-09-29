﻿namespace EziBy_Core_ClassLibrary.Models
{
    public class UOM
    {
        public int UOMId { get; set; }
        public int BranchId { get; set; }
        public string UOMName { get; set; } = string.Empty;
        public string UOMFullName { get; set; } = string.Empty;
        public string UOMNameWithFullName => UOMName + "-" + UOMFullName;
        public bool Active { get; set; }

        //references
        public virtual Branch? Branch { get; set; }
        public virtual ICollection<Item> Items { get; set; } = new List<Item>();

    }
}
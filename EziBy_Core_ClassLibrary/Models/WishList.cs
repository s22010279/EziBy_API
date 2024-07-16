﻿namespace EziBy_Core_ClassLibrary.Models
{
    public class WishList
    {
        public int WishListId { get; set; }
        public int ClientId { get; set; }
        public int ItemId { get; set; }
        public int ItemPriceVariantId { get; set; }
        public int Quantity { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}
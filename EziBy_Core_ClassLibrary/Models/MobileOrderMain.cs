namespace EziBy_Core_ClassLibrary.Models
{
    public partial class MobileOrderMain
    {
        public string MobileOrderMainId { get; set; }
        public string OrderGUID { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderStatusId { get; set; }
        public DateTime OrderStatusUpdatedDate { get; set; }
        public int ClientId { get; set; }//ref
        public int PaidStatusId { get; set; }
        public DateTime DeliveredDateTime { get; set; }
        public string DeliveryFullName { get; set; }
        public string DeliveryEmail { get; set; }
        public string DeliveryPhone { get; set; }
        public string DeliveryAddress { get; set; }
        public int DeliveryCityId { get; set; }//ref
        public string DeliveryNote { get; set; }
        public decimal TotalAmount { get; set; }
        //public decimal Discount { get; set; }
        public decimal DeliveryCharge { get; set; }
        public decimal GrandTotal { get; set; }
        public string DeliveryGoogleGeoLocation { get; set; }
        public String PaymentMethod { get; set; }
        public string Environment { get; set; } // A for android and I for IOS
        //public Byte[] QRCode { get; set; }

    }
}

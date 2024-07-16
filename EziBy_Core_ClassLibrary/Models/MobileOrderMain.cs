namespace EziBy_Core_ClassLibrary.Models
{
    public partial class MobileOrderMain
    {
        public string MobileOrderMainId { get; set; } = string.Empty;
        public string OrderGUID { get; set; } = string.Empty;
        public DateTime OrderDate { get; set; }
        public int OrderStatusId { get; set; }
        public DateTime OrderStatusUpdatedDate { get; set; }
        public int ClientId { get; set; }//ref
        public int PaidStatusId { get; set; }
        public DateTime DeliveredDateTime { get; set; }
        public string DeliveryFullName { get; set; } = string.Empty;
        public string DeliveryEmail { get; set; } = string.Empty;
        public string DeliveryPhone { get; set; } = string.Empty;
        public string DeliveryAddress { get; set; } = string.Empty;
        public int DeliveryCityId { get; set; }//ref
        public string DeliveryNote { get; set; } = string.Empty;
        public decimal TotalAmount { get; set; }
        //public decimal Discount { get; set; }
        public decimal DeliveryCharge { get; set; }
        public decimal GrandTotal { get; set; }
        public string DeliveryGoogleGeoLocation { get; set; } = string.Empty;
        public String PaymentMethod { get; set; } = string.Empty;
        public string Environment { get; set; } = string.Empty;// A for android and I for IOS
        //public Byte[] QRCode { get; set; }

    }
}

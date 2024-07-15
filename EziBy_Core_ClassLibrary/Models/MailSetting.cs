namespace EziBy_Core_ClassLibrary.Models
{
    public class MailSetting
    {
        public int MailSettingId { get; set; }
        public int BranchId { get; set; }
        public string OrderEmailAddress { get; set; }
        public string OrderEmailDisplayName { get; set; }
        public string OrderEmailPassword { get; set; }
        public int OrderEmailPortNo { get; set; }
        public string OrderEmailHost { get; set; }
        public string OrderEmailCCAddress { get; set; }
        public string OrderEmailBCCAddress { get; set; }
        public string UnsubscribeLink { get; set; }
        public bool Active { get; set; }

    }
}

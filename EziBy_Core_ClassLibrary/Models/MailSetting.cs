namespace EziBy_Core_ClassLibrary.Models
{
    public class MailSetting
    {
        public int MailSettingId { get; set; }
        public int BranchId { get; set; }
        public string OrderEmailAddress { get; set; } = string.Empty;
        public string OrderEmailDisplayName { get; set; } = string.Empty;
        public string OrderEmailPassword { get; set; } = string.Empty;
        public int OrderEmailPortNo { get; set; }
        public string OrderEmailHost { get; set; } = string.Empty;
        public string OrderEmailCCAddress { get; set; } = string.Empty;
        public string OrderEmailBCCAddress { get; set; } = string.Empty;
        public string UnsubscribeLink { get; set; } = string.Empty;
        public bool Active { get; set; }

        //references
        public virtual Branch? Branch { get; set; }

    }
}

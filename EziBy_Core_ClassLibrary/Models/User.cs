namespace EziBy_Core_ClassLibrary.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserGUID { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string UserFullName { get; set; } = string.Empty;
        public bool Active { get; set; }
        public string Remarks { get; set; } = string.Empty;
    }
}

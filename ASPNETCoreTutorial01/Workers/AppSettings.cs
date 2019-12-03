namespace ASPNETCoreTutorial01.Workers
{
    public class AppSettings
    {
        public string ClientId { get; set; }
        public string TenantId { get; set; }
        public string AppSecret { get; set; }
        public string Ngrok { get; set; }

        public const string ScopeUserRead = "User.Read";
        public const string ScopeCalReadWrite = "Calendar.ReadWrite";
    }
}

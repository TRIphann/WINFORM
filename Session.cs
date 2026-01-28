namespace JumpArena
{
    public static class Session
    {
        public static int UserId { get; set; }
        public static string FullName { get; set; } = "";
        public static string RoleName { get; set; } = "";
        public static string Username { get; set; } = "";

        public static void Clear()
        {
            UserId = 0;
            FullName = "";
            RoleName = "";
            Username = "";
        }
    }
}
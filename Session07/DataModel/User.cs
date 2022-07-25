namespace Session07.DataModel
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public bool IsActive { get; set; }

        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}

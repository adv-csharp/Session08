namespace Session07.DataModel
{
    public class Permission
    {
        public int Id { get; set; }
        public string FormName { get; set; }
        public string ButtonName { get; set; }
        public ICollection<PermissionRole> PermissionRoles { get; set; }
    }
}

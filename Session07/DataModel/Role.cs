﻿namespace Session07.DataModel
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<PermissionRole> PermissionRoles { get; set; }
    }
}

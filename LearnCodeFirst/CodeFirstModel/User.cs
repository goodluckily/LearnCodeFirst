using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstModel
{
    public class User
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }

        public ICollection<Role> roles { get; set; }

        public ICollection<UserAndRoleMap> userAndRoles { get; set; }

    }

    public class Role
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public ICollection<User> users { get; set; }

        public ICollection<UserAndRoleMap> userAndRoles { get; set; }
    }

    public class UserAndRoleMap
    {
        public Guid UserId { get; set; }
        public User User { get; set; }

        public Guid RoleId { get; set; }
        public Role Role { get; set; }
    }
}

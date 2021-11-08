using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Training.GraphQL.API.IService;
using Training.GraphQL.API.Model;

namespace Training.GraphQL.API.Service
{
    public class RoleService: IRoleService
    {
        List<Role> roles = new List<Role>();
        public RoleService()
        {
            roles.Add(new Role { Id = 1, Name = "IT" });
            roles.Add(new Role { Id = 2, Name = "DEV" });
            roles.Add(new Role { Id = 3, Name = "ADMIN" });
        }

        public Role GetById(long id)
        {
            return roles.SingleOrDefault(x => x.Id.Equals(id));
        }
    }
}

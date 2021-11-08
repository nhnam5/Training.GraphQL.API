using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Training.GraphQL.API.IService;
using Training.GraphQL.API.Model;

namespace Training.GraphQL.API.Service
{
    public class UserService: IUserService
    {
        List<User> users = new List<User>();
        public UserService() 
        {
            users.Add(new User { Id = 1, Name = "Jon", RoleId = 1, DepartmentId = 1 });
            users.Add(new User { Id = 2, Name = "Lemon", RoleId = 2, DepartmentId = 2 });
            users.Add(new User { Id = 3, Name = "Sun", RoleId = 3, DepartmentId = 3 });
        }
        public User GetById(long id)
        {
            return users.SingleOrDefault(x => x.Id.Equals(id));
        }
    }
}

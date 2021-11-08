using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Training.GraphQL.API.Model
{
    public class User
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long RoleId { get; set; }
        public Role Role { get; set; }
        public long DepartmentId { get; set; }
        public Department Department { get; set; }
        public List<UserAsset> UserAssets { get; set; }
    }
}

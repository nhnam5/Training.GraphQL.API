using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Training.GraphQL.API.IService;
using Training.GraphQL.API.Model;

namespace Training.GraphQL.API.Service
{
    public class DepartmentService : IDepartmentService
    {
        List<Department> departments = new List<Department>();
        public DepartmentService()
        {
            departments.Add(new Department { Id = 1, Name = "IT" });
            departments.Add(new Department { Id = 2, Name = "DEV" });
            departments.Add(new Department { Id = 3, Name = "ADMIN" });
        }
        public Department GetById(long id)
        {
            return departments.SingleOrDefault(x => x.Id.Equals(id));
        }
    }
}

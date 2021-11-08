using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Training.GraphQL.API.Model;

namespace Training.GraphQL.API.IService
{
    public interface IDepartmentService
    {
        public Department GetById(long id);
    }
}

using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Training.GraphQL.API.Model;

namespace Training.GraphQL.API.GraphQL.Type
{
    public class DepartmentType: ObjectGraphType<Department>
    {
        public DepartmentType()
        {
            Field(x => x.Id, nullable: false).Description("Id of department");
            Field(x => x.Name).Description("Name of department");
        }
    }
}

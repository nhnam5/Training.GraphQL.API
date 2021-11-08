using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Training.GraphQL.API.Model;

namespace Training.GraphQL.API.GraphQL.Type
{
    public class RoleType: ObjectGraphType<Role>
    {
        public RoleType()
        {
            Field(x => x.Id, nullable: false).Description("Id of role");
            Field(x => x.Name).Description("Name of role");
        }
    }
}

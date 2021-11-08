using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Training.GraphQL.API.GraphQL.Type;
using Training.GraphQL.API.IService;
using Training.GraphQL.API.Model;

namespace Training.GraphQL.API.GraphQL
{
    public class UserType : ObjectGraphType<User>
    {
        public UserType(
            IUserAssetService userAssetService,
            IDepartmentService departmentService,
            IRoleService roleService)
        {
            Field(x => x.Id, nullable: false).Description("Id of user");
            Field(x => x.Name).Description("Name of user");
            Field(x => x.DepartmentId).Description("Id of department");
            Field<DepartmentType>(
                "department",
                resolve: context =>
                {
                    return departmentService.GetById(context.Source.DepartmentId);
                });
            Field(x => x.RoleId).Description("Id of role");
            Field<RoleType>(
                "role",
                resolve: context =>
                {
                    return roleService.GetById(context.Source.RoleId);
                });
            Field<ListGraphType<UserAssetType>>(
                "userAssets",
                resolve: context =>
                {
                    return userAssetService.GetByUserId(context.Source.Id);
                });
        }
    }
}

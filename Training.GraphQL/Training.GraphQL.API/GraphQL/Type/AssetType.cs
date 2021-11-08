using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Training.GraphQL.API.IService;
using Training.GraphQL.API.Model;

namespace Training.GraphQL.API.GraphQL
{
    public class AssetType: ObjectGraphType<Asset>
    {
        public AssetType(IUserAssetService userAssetService)
        {
            Field(x => x.Id, nullable: false).Description("Id of asset");
            Field(x => x.Name).Description("Name of asset");
            Field(x => x.Source).Description("Source of Asset");
            Field<ListGraphType<UserAssetType>>(
                "userAssets",
                resolve: context =>
                {
                    return userAssetService.GetByAssetId(context.Source.Id);
                });
        }
    }
}

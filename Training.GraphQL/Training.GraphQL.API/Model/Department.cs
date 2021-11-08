using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Training.GraphQL.API.Model
{
    public class Department
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Source { get; set; }
        public List<UserAsset> UserAssets { get; set; }
    }
}

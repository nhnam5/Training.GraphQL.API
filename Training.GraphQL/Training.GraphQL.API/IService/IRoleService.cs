﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Training.GraphQL.API.Model;

namespace Training.GraphQL.API.IService
{
    public interface IRoleService
    {
        public Role GetById(long id);
    }
}

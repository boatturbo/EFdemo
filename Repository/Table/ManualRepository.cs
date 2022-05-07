using Entity;
using Entity.Table;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Table
{
    public class ManualRepository : RepositoryBase<Manual>
    {
        public ManualRepository(AeDbContext context) : base(context)
        {
        }
    }
}

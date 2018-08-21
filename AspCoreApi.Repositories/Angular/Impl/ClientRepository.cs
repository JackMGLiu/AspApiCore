using System;
using System.Collections.Generic;
using System.Text;
using AspCoreApi.DataContext;
using AspCoreApi.DataContext.Data;
using AspCoreApi.Models.Angular;

namespace AspCoreApi.Repositories.Angular.Impl
{
    public class ClientRepository : EfRepository<Client>, IClientRepository
    {
        public ClientRepository(CoreContext context) : base(context)
        {
        }
    }
}

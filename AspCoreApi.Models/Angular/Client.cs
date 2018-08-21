using AspCoreApi.Infrastructure.Core.Base;
using AspCoreApi.Infrastructure.Core.EntityConfigurations;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AspCoreApi.Models.Angular
{
    public class Client : EntityBase
    {
        public decimal Balance { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
    }
}
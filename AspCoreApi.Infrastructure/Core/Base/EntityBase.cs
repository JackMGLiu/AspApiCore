using AspCoreApi.Infrastructure.Core.Interface;

namespace AspCoreApi.Infrastructure.Core.Base
{
    public abstract class EntityBase : IEntityBase
    {
        public int Id { get; set; }
        public int Order { get; set; }
        public bool Deleted { get; set; }
    }
}
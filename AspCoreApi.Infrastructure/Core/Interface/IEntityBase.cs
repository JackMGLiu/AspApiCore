namespace AspCoreApi.Infrastructure.Core.Interface
{
    public interface IEntityBase : IOrder, IDeleted
    {
        int Id { get; set; }
    }
}
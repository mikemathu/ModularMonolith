using Modules.OrderManagement.Entities;

namespace Module.OrderManagement.Services
{
    public interface IOrders
    {
        Task<Order?> WithId(int id);
    }
}

using Module.OrderManagement.Services;
using Modules.OrderManagement.Entities;

namespace Module.OrderManagement.Repositories
{
    public class IOrdersRepository : IOrders
    {
        public Task<Order?> WithId(int id)
        {
            if (id != 1)
            {
                return Task.FromResult<Order?>(null);
            }

            return Task.FromResult<Order?>(Order.Create(id, DateTime.Now));
        }
    }
}

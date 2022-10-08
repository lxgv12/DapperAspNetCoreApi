using DapperAspNetCoreApi.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DapperAspNetCoreApi.Contracts.IRepositories
{
    public interface IOrderStatusRepositories
    {
        public Task<IEnumerable<OrderStatus>> GetOrderStatus();
    }
}

using Dapper;
using DapperAspNetCoreApi.Context;
using DapperAspNetCoreApi.Contracts.IRepositories;
using DapperAspNetCoreApi.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperAspNetCoreApi.Contracts.Repositories
{
    public class OrderStatusRepositories : IOrderStatusRepositories
    {
        private readonly DapperContext _context;
        public OrderStatusRepositories(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<OrderStatus>> GetOrderStatus()
        {
            var query = "SELECT * FROM OrderStatus";
            using (var connection = _context.CreateConnection())
            {
                return (await connection.QueryAsync<OrderStatus>(query)).ToList();
            }
        }
    }
}

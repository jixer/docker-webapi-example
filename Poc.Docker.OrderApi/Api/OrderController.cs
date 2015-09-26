using System.Threading.Tasks;
using System.Web.Http;
using Poc.Docker.OrderApi.Data;
using Poc.Docker.OrderApi.Model;

namespace Poc.Docker.OrderApi.Api
{
    public class OrderController : ApiController
    {
        private MongoOrderDb _repo;

        public OrderController()
        {
            _repo = new MongoOrderDb();
        }
        public async Task<Order> Get(string id)
        {
            return await _repo.GetOrder(id);
        }

        public async Task<string> Post(Order order)
        {
            return await _repo.InsertOrder(order);
        }
    }
}

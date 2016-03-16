using APMWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace APMWebAPI.Controllers
{
    public class ProductsController : ApiController
    {
        // GET: api/Products
		public IEnumerable<Product> Get()
		{
			var productRepository = new ProductRepository();

			return productRepository.Retrieve();
		}

		// GET: api/Products/5
		public string Get(int id)
		{
			return "value";
		}
    }
}

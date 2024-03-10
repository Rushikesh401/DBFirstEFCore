using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DBFirstEFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace DBFirstEFCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly postgresContext _postgresContext;


        public ProductController(postgresContext postgresContext)
        {
            _postgresContext = postgresContext;

        }
        [HttpGet]
        public async Task<List<Product>> GetProducts()
        {
            return await _postgresContext.Products.ToListAsync();
        }
    }
}

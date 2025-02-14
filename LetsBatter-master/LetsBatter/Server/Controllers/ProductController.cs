using LetsBatter.Shared.Data;
using LetsBatter.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Contracts;
using Microsoft.EntityFrameworkCore;

namespace LetsBatter.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private LetsBatterDbContext dbContext;
        public ProductController(LetsBatterDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            return dbContext.Products;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Product> PostProduct(Product product)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            dbContext.Products.Add(product);
            dbContext.SaveChanges();
            return Ok(product);

        }
    }
}

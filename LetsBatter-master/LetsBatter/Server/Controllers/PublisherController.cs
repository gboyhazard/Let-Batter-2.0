using LetsBatter.Shared.Data;
using LetsBatter.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LetsBatter.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublisherController : Controller
    {
        private LetsBatterDbContext dbContext;
        public PublisherController(LetsBatterDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet(nameof(GetPublishers))]
        public ActionResult<IEnumerable<Publisher>> GetPublishers()
        {
            return dbContext.Publishers.ToList();
        }

        [HttpGet(Name = nameof(GetPublisher))]
        public ActionResult<Publisher> GetPublisher(int id)
        {
            var publisher = dbContext.Publishers.FirstOrDefault(pub => pub.Id == id);
            if (publisher == null)
                return NotFound();

            return Ok(publisher);
        }

        [HttpPost]
        public ActionResult<Publisher> PostPublisher(Publisher publisher)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            dbContext.Publishers.Add(publisher);

            dbContext.SaveChanges();

            return Ok(publisher);
        }
    }
}

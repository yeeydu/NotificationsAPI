using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using NotificationsAPI.Models;

namespace NotificationsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationsController : ControllerBase
    {

        //Constructor
        private readonly NotificationsDbContext context;

        public NotificationsController(NotificationsDbContext context)
        {
            this.context = context;
        }
        //----

        // GET
        [HttpGet]
        public async Task<ActionResult<List<Notifications>>> Get()
        {
            return Ok(await context.Notifications.ToListAsync());
        }

        // get single 
        [HttpGet("{id}")]
        public async Task<ActionResult<Notifications>> Get(int id)
        {
            var notification = await context.Notifications.FindAsync(id);
            if (notification == null)
                return BadRequest("Error, Nothing found");
            return Ok(notification);
        }

        // POST
        [HttpPost]
        public async Task<ActionResult<List<Notifications>>> AddNotification(Notifications notification)
        {
            context.Notifications.Add(notification);
            await context.SaveChangesAsync();

            return Ok(await context.Notifications.ToListAsync());
        }

        // PUT
        [HttpPut("{Id}")]

        public async Task<ActionResult<List<Notifications>>> UpdateNotification(Notifications request, int Id)
        {
            var notification = await context.Notifications.FindAsync(Id);
            if (notification == null)
                return BadRequest("Error, Nothing found");

            notification.Type = request.Type;
            notification.Content = request.Content;
            notification.Contact = request.Contact;
           // notification.ContactPhone = request.ContactPhone;
            notification.Status = request.Status;

            await context.SaveChangesAsync();

            return Ok(await context.Notifications.ToListAsync());
        }

        // DELETE
        [HttpDelete("{id}")]
        public async Task<ActionResult<Notifications>> Delete(int id)
        {
            var notification = await context.Notifications.FindAsync(id);
            if (notification == null)
                return BadRequest("Error, Nothing found");

            context.Notifications.Remove(notification);
            await context.SaveChangesAsync();

            return Ok(await context.Notifications.ToListAsync());
        }
    }
}

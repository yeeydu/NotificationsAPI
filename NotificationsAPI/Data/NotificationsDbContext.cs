using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using NotificationsAPI.Models;

namespace NotificationsAPI.Data
{
    public class NotificationsDbContext : DbContext
    {
        //Constructor
        public NotificationsDbContext(DbContextOptions<NotificationsDbContext> options) : base(options)
        {
        }
        // DBset Property
        public DbSet<Notifications> Notifications { get; set; }
    }
}

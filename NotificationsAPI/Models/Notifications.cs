namespace NotificationsAPI.Models
{
    public class Notifications
    {
        public int Id { get; set; }
        public string Type { get; set; } 
        public string Content { get; set; } 
        public string Contact { get; set; }
        //public string ContactPhone { get; set; }
        public bool Status { get; set; }

    }
}

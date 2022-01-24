namespace eProtokoll.Application.Entity
{
    public class ePNotification
    {
        public int id { get; set; }
        public string name { get; set; }
        public string message { get; set; }
        public bool isRead { get; set; }
        public int idOfAction { get; set; }
        public bool isNew { get; set; }
        public int userId { get; set; }
    }

}

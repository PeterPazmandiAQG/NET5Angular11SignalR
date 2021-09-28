using System.ComponentModel.DataAnnotations.Schema;

namespace NET5SignalR.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public string TranType { get; set; }
    }
}

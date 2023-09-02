using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlightReservation_Project.Models
{
    public class Login
    {
        public int LoginId { get; set; }
        public string username { get; set; } = null!;
        public string password { get; set; } = null!;
    }
}
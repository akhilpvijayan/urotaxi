using System.ComponentModel.DataAnnotations;
using UroTaxi.Business.Entities;

namespace UroTaxi.Entities
{
    public class User : IUser
    {
        [Key]
        public int userId { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string userEmail { get; set; }
        public long userPhone { get; set; }
        public bool isActive { get; set; }
        public bool isDriver { get; set; }
        public bool isAdmin { get; set; }
    }
}

using SharedLibrary.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.Models
{
    public class Users_TBL
    {
        [Key]
        public int User_ID { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public string Role { get; set; }



    }
}

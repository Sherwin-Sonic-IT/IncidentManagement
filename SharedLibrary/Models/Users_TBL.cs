using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.Models
{
    public class Users_TBL
    {
        [Key]
        public int User_ID { get; set; }
        [Required]
        public string Username { get; set; }
        public string Location { get; set; }
        public string Department_Head {  get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}

using SharedLibrary.Models.ValidationsJM;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Models
{
    public class ApplicationM
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please fill out this field.")]
        public string Abbreviation { get; set; }

        [Required(ErrorMessage = "Please fill out this field.")]
        public string Name { get; set; }

        public string Status { get; set; } = "Active";

        [Required(ErrorMessage = "Please fill out this field.")]
        [RegularExpression(@"^(\d{1,3}\.){3}\d{1,3}$", ErrorMessage = "Invalid IP address.")]
        public string IP { get; set; }

        [IsZeroValidation("Please fill out this field.")]
        public int Port { get; set; }
    }
}

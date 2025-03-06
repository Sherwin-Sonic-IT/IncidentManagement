using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Models
{
    public class RoleGroupHeaderM
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please fill out this field.")]
        public string RoleCode { get; set; }

        [Required(ErrorMessage = "Please fill out this field.")]
        public string RoleName { get; set; }

        public List<RoleGroupDetailM> RoleGrpDetails { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}

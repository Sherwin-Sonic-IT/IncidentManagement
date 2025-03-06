using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedLibrary.Models.ValidationsJM;

namespace SharedLibrary.Models
{
    public class RoleGroupDetailM
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        public int RoleGroupHeaderMId { get; set; }

        public ApplicationM Application { get; set; }
        [IsZeroValidation]
        public int ApplicationId { get; set; }

        public SystemRoleM SystemRole { get; set; }
        [IsZeroValidation]
        public int SystemRoleId { get; set; }


        //public List<int> SiteIds { get; set; } = new List<int>();

        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}

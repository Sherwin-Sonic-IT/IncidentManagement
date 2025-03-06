using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Models
{
    public class UserM
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        public string UserId { get; set; } = string.Empty;


        public string FullName { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = "p@ssw0rd";

        public StatusM? Status { get; set; } 
        public int StatusId { get; set; } = 1;
        public string LoginStatus { get; set; } = "Inactive";

        public RoleGroupHeaderM? RoleGroup { get; set; }
        public int RoleGroupId { get; set; }

        public string Location { get; set; } = string.Empty;
        public string Department_Head { get; set; } = string.Empty;

        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime DateUpdated { get; set; } = DateTime.MinValue;
        public DateTime DateStatus { get; set; } = DateTime.Now;
        public DateTime ExpiryDate { get; set; } = DateTime.Now;

        public List<string> SiteCodes { get; set; } = [];
        public List<int> SiteIds { get; set; } = [];

        public bool IsChangePassOnLogin { get; set; } // if true dli maka lusot dapat change pass
        public bool IsCantChangePass { get; set; }
        public bool IsPasswordNeverExpires { get; set; }
    }

    //public int EmployeeId { get; set; }
    //public string Emp_VerifyId { get; set; }
}

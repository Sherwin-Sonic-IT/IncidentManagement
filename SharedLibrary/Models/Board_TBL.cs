using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Models
{
    public class Board_TBL
    {
        [Key]
        public int Comment_ID { get; set; }
        public int User_ID { get; set; }
        public int Resolver_ID { get; set; }
        [ForeignKey("Incident_ID")]
        public int Incident_ID { get; set; }
        public int Resolver_DeptHead_ID { get; set; }

        public string Username { get; set; }
        public string Department_Head { get; set; }
        public string Comment { get; set; }
        public string Status { get; set; } = "unread";
        public DateTime CreatedAt { get; set; }
        public byte[]? ImageVideoData { get; set; }
        public int? ParentCommentID { get; set; } // For replies, this will refer to the parent comment's ID


        // Navigation property to Incidents_TBL
        public virtual Incidents_TBL Incident { get; set; }

    }
}

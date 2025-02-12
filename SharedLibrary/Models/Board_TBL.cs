using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Models
{
    public class Board_TBL
    {
        [Key]
        public int Comment_ID { get; set; }
        public int Incident_ID { get; set; }
        public string Username { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }
        public byte[]? ImageVideoData { get; set; }
        public int? ParentCommentID { get; set; } // For replies, this will refer to the parent comment's ID

    }
}

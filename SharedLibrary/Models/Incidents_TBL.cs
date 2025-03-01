
//using System.ComponentModel;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

//namespace SharedLibrary.Models
//{
//   public class Incidents_TBL
//    {
//        [Key]
//        public int Incident_ID { get; set; }
//        [Required]
//        public int User_ID { get; set; }
//        public int Resolver_ID { get; set; }
//        public string Incident_Name { get; set; }
//        [Required]
//        public string Category { get; set; }
//        [Required]
//        public DateTime Incident_Date { get; set; }
//        [Required]
//        public string Location { get; set; }
//        [Required]
//        public string Department_Head { get; set; }
//        [Required]
//        public DateTime Date_Reported { get; set; }
//        [Required]
//        public string Reported_By { get; set; }
//        [Required]
//        public string Resolver_Name { get; set; }
//        public string Priority { get; set; }

//        [DefaultValue("Pending")]
//        public string Status { get; set; }


//    }
//}



using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharedLibrary.Models
{
    public class Incidents_TBL
    {
        [Key]
        public int Incident_ID { get; set; }
        [Required]
        public int User_ID { get; set; }
        public int Resolver_ID { get; set; }
        public string Incident_Name { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public DateTime Incident_Date { get; set; }
        public string Location { get; set; }
        public string Department_Head { get; set; }
        [Required]
        public DateTime Date_Reported { get; set; }
        public string Reported_By { get; set; }
        public string Resolver_Name { get; set; }
        //[Required]
        //public string Resolver_Name { get; set; }
        public string Priority { get; set; }

        [DefaultValue("Pending")]
        public string Status { get; set; }

    }
}





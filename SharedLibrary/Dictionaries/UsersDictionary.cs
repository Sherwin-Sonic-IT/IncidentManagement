using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Dictionaries
{
    public class UsersDictionary
    {
        public static readonly Dictionary<string, (string Location, string DepartmentHead)> UserLocationAndDepartmentHead = new()
        {
            //IT
            { "Emman Imbod", ("IT", "Junix Chan") },
            { "Glenne Panilagao", ("IT", "Junix Chan") },
            //MAIN OPD
            { "Caroline Genavia", ("MAIN (OPD)", "Caroline Genavia") },
            { "Christine Charles", ("MAIN (OPD)", "Caroline Genavia") },
            { "Cindy Esabel Spandoms", ("MAIN (OPD)", "Caroline Genavia") },
            { "Debra Maureen Cuizon", ("MAIN (OPD)", "Caroline Genavia") },
            { "Emhe Jane Palicte", ("MAIN (OPD)", "Caroline Genavia") },
            { "Aubrey Blanca Castañales", ("MAIN (OPD)", "Caroline Genavia") },
            { "Roy Pulmones", ("MAIN (OPD)", "Caroline Genavia") },
            { "Jane Villapañe", ("MAIN (OPD)", "Caroline Genavia") },
            { "Rishelle Caligdong", ("MAIN (OPD)", "Caroline Genavia") },
            { "Naz Raphael Hilay", ("MAIN (OPD)", "Caroline Genavia") },
            { "Faith Bautista", ("MAIN (OPD)", "Caroline Genavia") },
            { "Michelle Ingreso", ("MAIN (OPD)", "Caroline Genavia") },
            { "Nerridyl Añover", ("MAIN (OPD)", "Caroline Genavia") },
            { "Leve Parbaqui", ("MAIN (OPD)", "Caroline Genavia") },
            //LOGISTICS
            { "Christina Selgas", ("LOGISTICS", "Christina Selgas") },
            { "Melanie Barazon", ("LOGISTICS", "Christina Selgas") },
            { "Kristine Bunga-os", ("LOGISTICS", "Christina Selgas") },
            { "Julito C. Albores Jr.", ("LOGISTICS", "Christina Selgas") },
            { "Shiela Mae Isidro", ("LOGISTICS", "Christina Selgas") },
            { "Justine Bandayanon", ("LOGISTICS", "Christina Selgas") },
            { "Julie Solera", ("LOGISTICS", "Christina Selgas") },
            { "Carlito Poliño", ("LOGISTICS", "Christina Selgas") },
            { "Geraldine Carisosa", ("LOGISTICS", "Christina Selgas") },
            //DANA
            { "Bernadeth Palang", ("DANA", "Bernadeth Palang") },
            { "Patricia Gutierez", ("DANA", "Bernadeth Palang") },
            { "Sheila Lyn Candelario", ("DANA", "Bernadeth Palang") },
            { "Rubelyn Fiel", ("DANA", "Bernadeth Palang") },
            { "Rochelle Macailing", ("DANA", "Bernadeth Palang") },
        };

    }
}

namespace SharedLibrary.Dictionaries
{
    public class IncidentFormDictionary
    {
        public Dictionary<string, List<string>> CategoryIncidentNames { get; } = new()
    {
        // IT
        { "Hardware Issues", new List<string> { "Device Malfunction (printers, scanners, etc)", "Workstation /PC/Laptop Issues" } },
        { "Network & Connectivity Issues", new List<string> { "Internet connectivity problems", "Slow network performance" } },
        { "User Account & Access Issues", new List<string> { "Password reset request", "Permissions/access control issues" } },
        { "End-User Requests & Assistance", new List<string> { "Software Installation" } },
        // Logistics
         { "Transportation/Equipment Management", new List<string> { "Flat Tires" } },
    };

        public Dictionary<string, List<string>> IncidentNamePriority { get; } = new()
    {
        // Hardware Issues
        { "Device Malfunction (printers, scanners, etc)", new List<string> { "Important" } },
        { "Workstation /PC/Laptop Issues", new List<string> { "Urgent" } },
        // Network & Connectivity Issues
        { "Internet connectivity problems", new List<string> { "Urgent" } },
        { "Slow network performance", new List<string> { "Important" } },
        // User Account & Access Issues
         { "Password reset request", new List<string> { "Important" } },
         { "Permissions/access control issues", new List<string> { "Important" } },
         // End-User Requests & Assistance
         { "Software Installation", new List<string> { "Routine" } },
         // Transportation/Equipment Management
         { "Flat Tires", new List<string> { "Routine" } },
    };

        public Dictionary<string, List<string>> ResolverIncidentName { get; } = new()
    {
        // Hardware Issues
        { "Device Malfunction (printers, scanners, etc)", new List<string> { "Glenne" } },
        { "Workstation /PC/Laptop Issues", new List<string> { "Glenne" } },
        // Network Issues
        { "Internet connectivity problems", new List<string> { "Glenne" } },
        { "Slow network performance", new List<string> { "Glenne" } },
        // User Account & Access Issues
        { "Password reset request", new List<string> { "Glenne" } },
        { "Permissions/access control issues", new List<string> { "Glenne" } },
        // End-User Requests & Assistance
        { "Software Installation", new List<string> { "Glenne" } },
        // Transportation/Equipment Management
        { "Flat Tires", new List<string> { "Aying" } },
    };

        public Dictionary<string, List<string>> DepartmentHeadLocationDepartment { get; } = new()
    {
        { "MAIN (SALES)", new List<string> { "Ruel" } },
        { "MAIN (OPD)", new List<string> { "Charol" } },
        { "MAIN (CASHIER)", new List<string> { "Mimie" } },
        { "HR", new List<string> { "Joan" } },
        { "IT", new List<string> { "Junix Chan" } },
        { "LOGISTICS", new List<string> { "Christina" } },
        { "DANA", new List<string> { "Bernz" } },
        { "DIGOS (SALES)", new List<string> { "Ethan" } },
        { "DIGOS (OPD)", new List<string> { "Liam" } },
        { "DIGOS (CASHIER)", new List<string> { "Lucas" } },
        { "KIDAPAWAN (SALES)", new List<string> { "James" } },
        { "KIDAPAWAN (OPD)", new List<string> { "Olivia" } },
        { "KIDAPAWAN (CASHIER)", new List<string> { "Sophia" } },
        { "COTABATO (SALES)", new List<string> { "Mia" } },
        { "COTABATO (OPD)", new List<string> { "Chloe" } },
        { "COTABATO (CASHIER)", new List<string> { "Ava" } },
    };

        public static readonly Dictionary<string, List<string>> LocationDepartments = new()
    {
        { "MAIN OFFICE", new List<string> { "MAIN (SALES)", "MAIN (OPD)", "MAIN (CASHIER)", "HR", "IT", "LOGISTICS" } },
        { "DANA OFFICE", new List<string> { "DANA" } },
        { "DIGOS OFFICE", new List<string> { "DIGOS (SALES)", "DIGOS (OPD)", "DIGOS (CASHIER)" } },
        { "KIDAPAWAN OFFICE", new List<string> { "KIDAPAWAN (SALES)", "KIDAPAWAN (OPD)", "KIDAPAWAN (CASHIER)" } },
        { "COTABATO OFFICE", new List<string> { "COTABATO (SALES)", "COTABATO (OPD)", "COTABATO (CASHIER)" } }
    };


        public static readonly Dictionary<string, Dictionary<string, int>> departmentUserMap = new()
    {
        { "MAIN OFFICE", new Dictionary<string, int> {
            { "MAIN (SALES)", 2 },
            { "MAIN (OPD)", 3 },
            { "MAIN (CASHIER)", 4 },
            { "HR", 5 },
            { "IT", 6 },
            { "LOGISTICS", 7 }
        }},

        { "DANA OFFICE", new Dictionary<string, int> {
            { "DANA", 8 }
        }},

        { "DIGOS OFFICE", new Dictionary<string, int> {
            { "DIGOS (SALES)", 9 },
            { "DIGOS (OPD)", 10 },
            { "DIGOS (CASHIER)", 11 }
        }},

        { "KIDAPAWAN OFFICE", new Dictionary<string, int> {
            { "KIDAPAWAN (SALES)", 12 },
            { "KIDAPAWAN (OPD)", 13 },
            { "KIDAPAWAN (CASHIER)", 14 }
        }},

        { "COTABATO OFFICE", new Dictionary<string, int> {
            { "COTABATO (SALES)", 15 },
            { "COTABATO (OPD)", 16 },
            { "COTABATO (CASHIER)", 17 }
        }}
    };

        public static readonly Dictionary<string, int> IncidentNameUserMap = new()
    {
        // IT
        { "Device Malfunction (printers, scanners, etc)", 1 },
        { "Workstation /PC/Laptop Issues", 1 },
        { "Internet connectivity problems", 1},
        { "Slow network performance", 1 },
        { "Password reset request", 1 },
        { "Permissions/access control issues", 1 },
        { "Software Installation", 1 },
        //Logistics
        { "Flat Tires", 7 },
    };



    }
}

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
        { "WMS Issue", new List<string> { "WMS Account Login Failure" } },
        { "ISR Issue", new List<string> { "ISR Password reset request" } },
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
         //WMS Issue
         { "WMS Account Login Failure", new List<string> { "Urgent" } },
         //ISR Issue
         { "ISR Password reset request", new List<string> { "Routine" } },
         // Transportation/Equipment Management
         { "Flat Tires", new List<string> { "Routine" } },
    };

        public Dictionary<string, List<string>> ResolverIncidentName { get; } = new()
    {
        // Hardware Issues
        { "Device Malfunction (printers, scanners, etc)", new List<string> { "Glenne Panilagao" } },
        { "Workstation /PC/Laptop Issues", new List<string> { "Glenne Panilagao" } },
        // Network Issues
        { "Internet connectivity problems", new List<string> { "Glenne Panilagao" } },
        { "Slow network performance", new List<string> { "Glenne Panilagao" } },
        // User Account & Access Issues
        { "Password reset request", new List<string> { "Glenne Panilagao" } },
        { "Permissions/access control issues", new List<string> { "Glenne Panilagao" } },
        // End-User Requests & Assistance
        { "Software Installation", new List<string> { "Glenne Panilagao" } },
         //WMS Issue
         { "WMS Account Login Failure", new List<string> { "Froilan Estalilla" } },
        //ISR Issue
        { "ISR Password reset request", new List<string> { "Emman Imbod" } },
        // Transportation/Equipment Management
        { "Flat Tires", new List<string> { "Carlito Poliño" } },
    };

        public static readonly Dictionary<string, List<string>> LocationDepartments = new()
    {
        { "MAIN OFFICE", new List<string> { "MAIN (SALES)", "MAIN (OPD)", "MAIN (CASHIER)", "HR", "IT", "LOGISTICS" } },
        { "DANA OFFICE", new List<string> { "DANA" } },
        //{ "DIGOS OFFICE", new List<string> { "DIGOS (SALES)", "DIGOS (OPD)", "DIGOS (CASHIER)" } },
        //{ "KIDAPAWAN OFFICE", new List<string> { "KIDAPAWAN (SALES)", "KIDAPAWAN (OPD)", "KIDAPAWAN (CASHIER)" } },
        //{ "COTABATO OFFICE", new List<string> { "COTABATO (SALES)", "COTABATO (OPD)", "COTABATO (CASHIER)" } }
    };

        public Dictionary<string, List<string>> DepartmentHeadLocationDepartment { get; } = new()
    {
        { "MAIN (SALES)", new List<string> { "Ruel" } },
        { "MAIN (OPD)", new List<string> { "Caroline Genavia" } },
        { "MAIN (CASHIER)", new List<string> { "Mimie" } },
        { "HR", new List<string> { "Joanne Sumangil" } },
        { "IT", new List<string> { "Junix Chan" } },
        { "LOGISTICS", new List<string> { "Christina Selgas" } },
        { "DANA", new List<string> { "Bernadeth Palang" } },
        //{ "DIGOS (SALES)", new List<string> { "Ethan" } },
        //{ "DIGOS (OPD)", new List<string> { "Liam" } },
        //{ "DIGOS (CASHIER)", new List<string> { "Lucas" } },
        //{ "KIDAPAWAN (SALES)", new List<string> { "James" } },
        //{ "KIDAPAWAN (OPD)", new List<string> { "Olivia" } },
        //{ "KIDAPAWAN (CASHIER)", new List<string> { "Sophia" } },
        //{ "COTABATO (SALES)", new List<string> { "Mia" } },
        //{ "COTABATO (OPD)", new List<string> { "Chloe" } },
        //{ "COTABATO (CASHIER)", new List<string> { "Ava" } },
    };



        public static readonly Dictionary<string, (int UserId, string Department, string DepartmentHead)> IncidentNameUserMap = new()
    {
        // IT
        { "Device Malfunction (printers, scanners, etc)", (1, "IT", "Junix Chan") },
        { "Workstation /PC/Laptop Issues", (1, "IT", "Junix Chan") },
        { "Internet connectivity problems", (1, "IT", "Junix Chan") },
        { "Slow network performance", (1, "IT", "Junix Chan") },
        { "Password reset request", (1, "IT", "Junix Chan") },
        { "Permissions/access control issues", (1, "IT", "Junix Chan") },
        { "Software Installation", (1, "IT", "Junix Chan") },
        { "WMS Account Login Failure", (1, "IT", "Junix Chan") },
        { "ISR Password reset request", (1, "IT", "Junix Chan") },

        // Logistics
        { "Flat Tires", (50, "LOGISTICS", "Christina Selgas") },
    };



        //    public static readonly Dictionary<string, (int UserId, string Department)> IncidentNameUserMap = new()
        //{
        //    // IT
        //    { "Device Malfunction (printers, scanners, etc)", (1, "IT") },
        //    { "Workstation /PC/Laptop Issues", (1, "IT") },
        //    { "Internet connectivity problems", (1, "IT") },
        //    { "Slow network performance", (1, "IT") },
        //    { "Password reset request", (1, "IT") },
        //    { "Permissions/access control issues", (1, "IT") },
        //    { "Software Installation", (1, "IT") },
        //    { "WMS Account Login Failure", (1, "IT") },
        //    { "ISR Password reset request", (1, "IT") },

        //    // Logistics
        //    { "Flat Tires", (50, "LOGISTICS") },
        //};


        public Dictionary<string, string> ResolverToDepartment { get; } = new()
    {
        { "Glenne Panilagao", "IT" },
        { "Junix Chan", "IT" },
        { "Froilan Estalilla", "IT" },
        { "Emman Imbod", "IT" },
        { "Mae Mabasa", "IT" },
        { "Carlito Poliño", "LOGISTICS" },
    };


        //    public static readonly Dictionary<string, int> IncidentNameUserMap = new()
        //{
        //    // IT
        //    { "Device Malfunction (printers, scanners, etc)", 1 },
        //    { "Workstation /PC/Laptop Issues", 1 },
        //    { "Internet connectivity problems", 1},
        //    { "Slow network performance", 1 },
        //    { "Password reset request", 1 },
        //    { "Permissions/access control issues", 1 },
        //    { "Software Installation", 1 },
        //    { "WMS Account Login Failure", 1 },
        //    { "ISR Password reset request", 1 },
        //    //Logistics
        //    { "Flat Tires", 50 },
        //};


    }
}

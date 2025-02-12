namespace SharedLibrary.Dictionaries
{
    public class IncidentFormDictionary
    {
        public Dictionary<string, List<string>> CategoryIncidentNames { get; } = new()
    {
        { "Service Disruption", new List<string> { "Network Outage", "System Downtime", "Slow Service" } },
        { "Category 2", new List<string> { "Hardware Failure", "Software Issue", "System Crash" } },
    };

        public Dictionary<string, List<string>> IncidentNamePriority { get; } = new()
    {
        { "Network Outage", new List<string> { "Urgent" } },
        { "System Downtime", new List<string> { "Urgent" } },
        { "Slow Service", new List<string> { "Important" } },
        { "Hardware Failure", new List<string> { "Urgent" } },
        { "Software Issue", new List<string> { "Routine" } },
        { "System Crash", new List<string> { "Important" } },
        { "Power Loss", new List<string> { "Urgent" } },
        { "Security Breach", new List<string> { "Routine" } },
        { "Maintenance", new List<string> { "Important" } },
    };

        public Dictionary<string, List<string>> DepartmentHeadLocationDepartment { get; } = new()
    {
        { "MAIN (SALES)", new List<string> { "ROWEL" } },
        { "MAIN (OPD)", new List<string> { "KA" } },
        { "MAIN (CASHIER)", new List<string> { "MIMIE" } },
        { "HR", new List<string> { "Joan" } },
        { "IT", new List<string> { "Junix Chan" } },
        { "DANA", new List<string> { "BERNZ" } },
        { "DIGOS (SALES)", new List<string> { "Juan Dela Cruz" } },
        { "DIGOS (OPD)", new List<string> { "Mang Juan" } },
        { "DIGOS (CASHIER)", new List<string> { "Magdalena" } },
        { "KIDAPAWAN (SALES)", new List<string> { "Maria Ozawa" } },
        { "KIDAPAWAN (OPD)", new List<string> { "Johny Sin" } },
        { "KIDAPAWAN (CASHIER)", new List<string> { "Mang Kanor" } },
        { "COTABATO (SALES)", new List<string> { "Eva" } },
        { "COTABATO (OPD)", new List<string> { "Freddie" } },
        { "COTABATO (CASHIER)", new List<string> { "Aguilar" } },
    };

        public static readonly Dictionary<string, List<string>> LocationDepartments = new()
    {
        { "MAIN OFFICE", new List<string> { "MAIN (SALES)", "MAIN (OPD)", "MAIN (CASHIER)", "HR", "IT" } },
        { "DANA OFFICE", new List<string> { "DANA" } },
        { "DIGOS OFFICE", new List<string> { "DIGOS (SALES)", "DIGOS (OPD)", "DIGOS (CASHIER)" } },
        { "KIDAPAWAN OFFICE", new List<string> { "KIDAPAWAN (SALES)", "KIDAPAWAN (OPD)", "KIDAPAWAN (CASHIER)" } },
        { "COTABATO OFFICE", new List<string> { "COTABATO (SALES)", "COTABATO (OPD)", "COTABATO (CASHIER)" } }
    };

        public Dictionary<string, List<string>> ResolverIncidentName { get; } = new()
    {
        { "Network Outage", new List<string> { "Gilbert" } },
        { "System Downtime", new List<string> { "Glen" } },
        { "Slow Service", new List<string> { "Emman" } },
        { "Hardware Failure", new List<string> { "Froilan" } },
        { "Software Issue", new List<string> { "Mae" } },
        { "System Crash", new List<string> { "Bless" } },
        { "Power Loss", new List<string> { "Mich" } },
        { "Security Breach", new List<string> { "Ray" } },
        { "Maintenance", new List<string> { "Mabbit" } },
    };

    }
}

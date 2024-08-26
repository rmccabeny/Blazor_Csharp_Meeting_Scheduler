namespace Blazor_Csharp_Meeting_Scheduler.Models
{
    public class ComboViewModel
    {
        public required string EmployeeName { get; set; }
        public required string EmployeeDepartment { get; set; }
        public required string EmployeeEmail { get; set; }
        public required string EmployeePhone { get; set; }
        public required string MeetingTitle { get; set; }
        public required DateTime MeetingDateTime{ get; set; }
        public required string MeetingDepartment { get; set; }

    }
}

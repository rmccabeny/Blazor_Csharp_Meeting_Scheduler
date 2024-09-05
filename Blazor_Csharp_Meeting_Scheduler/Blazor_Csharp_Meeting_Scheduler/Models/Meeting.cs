namespace Blazor_Csharp_Meeting_Scheduler.Models
{
    public class Meeting
    {
        // establish the properties of the meeting class
        public int MeetingId { get; set; }
        public required string MeetingTitle { get; set; } = string.Empty;
        public required string DepartmentName { get; set; } = string.Empty;
        public required string EmployeeName { get; set; } = string.Empty;
        public required string EmployeeEmail { get; set; } = string.Empty;
        public required string EmployeePhone { get; set; } = string.Empty;
        public required string ManagerName { get; set; } = string.Empty;
        public required DateTime MeetingDateTime { get; set; }
        
        
        
    }
}

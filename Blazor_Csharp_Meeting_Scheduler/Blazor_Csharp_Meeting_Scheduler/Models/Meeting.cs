namespace Blazor_Csharp_Meeting_Scheduler.Models
{
    public record Meeting
    {
        // establish the properties of the meeting class
        public int MeetingId { get; set; }
        public required string MeetingTitle { get; set; } 
        public int DepartmentId { get; set; }
        public required string DepartmentName { get; set; } 
        public int EmployeeId { get; set; }
        public required string EmployeeName { get; set; } 
        public required string EmployeeEmail { get; set; } 
        public required string EmployeePhone { get; set; } 
        public required string ManagerName { get; set; } 
        public required DateTime MeetingDateTime { get; set; }
        
        
        
    }
}

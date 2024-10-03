namespace Blazor_Csharp_Meeting_Scheduler.Models
{
    public record ComboViewModel
    {
        public int EmployeeId { get; set; }
        public required string EmployeeName { get; set; }
        public required string DepartmentName { get; set; }
        public required string EmployeeEmail { get; set; }
        public required string EmployeePhone { get; set; }
        public int MeetingId { get; set; }
        public required string MeetingTitle { get; set; }
        public required DateTime MeetingDateTime{ get; set; }
        

    }
}

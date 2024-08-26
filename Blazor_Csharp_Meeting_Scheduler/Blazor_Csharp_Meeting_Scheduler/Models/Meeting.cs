namespace Blazor_Csharp_Meeting_Scheduler.Models
{
    public class Meeting
    {
        // establish the properties of the meeting class
        public int MeetingId { get; set; }
        public required string MeetingTitle { get; set; } = string.Empty;
        public required string MeetingDepartment { get; set; } = string.Empty;
        public required string Employee { get; set; } = string.Empty;
        public required DateTime MeetingDateTime { get; set; }
        
        
        
    }
}

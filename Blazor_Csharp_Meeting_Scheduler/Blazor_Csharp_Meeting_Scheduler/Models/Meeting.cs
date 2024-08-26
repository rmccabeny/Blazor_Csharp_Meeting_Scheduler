namespace Blazor_Csharp_Meeting_Scheduler.Models
{
    public class Meeting
    {
        // establish the properties of the meeting class
        public int Id { get; set; }
        public required string Title { get; set; } = string.Empty;
        public required string Department { get; set; } = string.Empty;
        public required string Employee { get; set; } = string.Empty;
        public required string Date { get; set; } = DateTime.Now.ToShortDateString();
        public required string Time { get; set; } = DateTime.Now.ToShortTimeString();
        public required string Location { get; set; } = string.Empty;
        
    }
}

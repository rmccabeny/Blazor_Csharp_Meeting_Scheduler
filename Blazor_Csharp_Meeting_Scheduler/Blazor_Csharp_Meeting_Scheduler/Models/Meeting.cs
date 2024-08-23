namespace Blazor_Csharp_Meeting_Scheduler.Models
{
    public class Meeting
    {
        // establish the properties of the meeting class
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Department { get; set; }
        public required string Employee { get; set; }
        public required string Date { get; set; }
        public required string Time { get; set; }
        public required string Location { get; set; }
        
    }
}

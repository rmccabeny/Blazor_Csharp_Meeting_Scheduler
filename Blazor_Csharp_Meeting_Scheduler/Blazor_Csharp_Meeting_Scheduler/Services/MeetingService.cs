using Blazor_Csharp_Meeting_Scheduler.Models;


namespace Blazor_Csharp_Meeting_Scheduler.Services
{
    // create the functionality for the meeting service class
    public class MeetingService
    {
        private List<Meeting> meetings = new List<Meeting>();

        // get the list of meetings
        public List<Meeting> GetMeetings()
        {
            return meetings;
        }

        // add a meeting to the list
        public void AddMeeting(Meeting meeting)
        {
            meetings.Add(meeting);
        }

        // remove a meeting from the list
        public void RemoveMeeting(Meeting meeting)
        {
            meetings.Remove(meeting);
        }
    }
}

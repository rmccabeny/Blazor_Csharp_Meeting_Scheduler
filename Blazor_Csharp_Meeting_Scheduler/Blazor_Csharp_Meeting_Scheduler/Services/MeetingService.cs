using Blazor_Csharp_Meeting_Scheduler.Models;
using System.Collections.Generic;


namespace Blazor_Csharp_Meeting_Scheduler.Services
{
    // create the functionality for the meeting service class
    public class MeetingService
    {
        private List<Meeting> meetings = new List<Meeting>();

        // get the list of meetings
        public Task<IEnumerable<Meeting>> GetMeetingsAsync()
        {
            return Task.FromResult<IEnumerable<Meeting>>(meetings);
        }
            // add a meeting to the list
            public Task AddMeetingAync(Meeting meeting)
        {
            meetings.Add(meeting);
            return Task.CompletedTask;
        }

        // remove a meeting from the list
       public Task RemoveMeetingAsync(int id)
        {
            var meeting = meetings.FirstOrDefault(m => m.Id == id);
            if (meeting != null)
            {
                meetings.Remove(meeting);
            }
            return Task.CompletedTask;
        }
        
    }
}

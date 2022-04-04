using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatePractice
{
    internal class MeetingSchedule
    {
        List<Meeting> meetingList;

        public MeetingSchedule()
        {
            meetingList = new List<Meeting>();
        }

        public void SetMeeting(string name, DateTime fromDate, DateTime toDate)
        {
            Meeting newMeeting = new Meeting()
            {
                Name = name,
                FromDate = fromDate,
                ToDate = toDate
            };

            if(meetingList.Count == 0)
                meetingList.Add(newMeeting);
            else
            {
                bool check = false;
                foreach(Meeting meeting in meetingList)
                {
                    if(fromDate > meeting.ToDate || toDate < meeting.FromDate)
                    {
                        check = true;
                    }
                    else
                    {
                        throw new Exception("bu zamanda meeting var");
                    }
                }

                if (check)
                    meetingList.Add(newMeeting);
            }
        }
        public int FindMeetingsCount(DateTime dateTime)
        {
            int count = 0;
            foreach (var meeting in meetingList)
            {
                if (meeting.FromDate > dateTime)
                    count++;
            }

            return count;
        }
        public bool IsExistsMeetingByName(string search)
        {
            foreach (var meeting in meetingList)
            {
                if (meeting.Name.Contains(search))
                    return true;
            }

            //return meetingList.Exists(m => m.Name.Contains(search));

            return false;
        }
        public List<Meeting> GetExistMeetings(string search)
        {
            List<Meeting> filteredMeeting = new List<Meeting>();
            foreach (var meeting in meetingList)
            {
                if (meeting.Name.Contains(search))
                    filteredMeeting.Add(meeting);
            }

            return filteredMeeting;
        }
    }
}

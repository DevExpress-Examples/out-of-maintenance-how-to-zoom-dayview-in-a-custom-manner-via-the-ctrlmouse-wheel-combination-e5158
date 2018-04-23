using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraScheduler;

namespace DXApplication5
{
    public static class DataHelper
    {


        private static string[] Users = new string[] { "Peter Dolan", "Ryan Fischer", "Andrew Miller", "Tom Hamlett",
                                                            "Jerry Campbell", "Carl Lucas", "Mark Hamilton", "Steve Lee" };

        public static void FillResources(SchedulerStorage storage, int count)
        {
            ResourceCollection resources = storage.Resources.Items;
            storage.BeginUpdate();
            try
            {
                int cnt = Math.Min(count, Users.Length);
                for (int i = 1; i <= cnt; i++)
                {
                    Resource resource = storage.CreateResource(i);
                    resource.Caption = Users[i - 1];
                    resources.Add(resource);
                }
            }
            finally
            {
                storage.EndUpdate();
            }
        }

        public static void GenerateEvents(AppointmentCollection eventList, int count, ResourceCollection collection)
        {

            for (int i = 0; i < count; i++)
            {
                Resource resource = collection[i];
                string subjPrefix = resource.Caption + "'s ";
                eventList.Add(CreateEvent(subjPrefix + "meeting", resource.Id, 2, 5));
                eventList.Add(CreateEvent(subjPrefix + "travel",   resource.Id, 3, 6));
                eventList.Add(CreateEvent(subjPrefix + "phone call", resource.Id, 0, 10));
            }
        }

        public static void GenerateEventsWithSharedResource(AppointmentCollection eventList, int count, ResourceCollection collection)
        {
            for (int i = 0; i < count; i++)
            {
                string subjPrefix = "Appt " + i;
                eventList.Add(AddSharedResources(subjPrefix, 1, 1, collection));
            }
        }

        private static Appointment AddSharedResources(string subject, int status, int label, ResourceCollection collection)
        {
            Appointment apt = new Appointment();
            apt.Subject = subject;
            for (int i = 0; i < collection.Count; i++)
            {
                object resourceId = ((Resource)collection[i]).Id;
                apt.ResourceIds.Add(resourceId);
            }
            

            Random rnd = new Random();
            int rangeInMinutes = 60 * 24;
            apt.Start = DateTime.Today.AddDays(1) + TimeSpan.FromMinutes(rnd.Next(0, rangeInMinutes));
            apt.End = apt.Start + TimeSpan.FromMinutes(rnd.Next(0, rangeInMinutes / 4));
            apt.StatusId = status;
            apt.LabelId = label;
            return apt;
        }

        private static Appointment CreateEvent(string subject, object resourceId, int status, int label)
        {
            Appointment apt = new Appointment();
            apt.Subject = subject;
            apt.ResourceId = resourceId;
            
            Random rnd = new Random();
            int rangeInMinutes = 60 * 24;
            apt.Start = DateTime.Today + TimeSpan.FromMinutes(rnd.Next(0, rangeInMinutes));
            apt.End = apt.Start + TimeSpan.FromMinutes(rnd.Next(0, rangeInMinutes / 4));
            apt.StatusId = status;
            apt.LabelId = label;
            return apt;
        }

        public static void AddRecurrentAppointment(AppointmentCollection eventList)
        {
            Appointment aptPattern = new Appointment(AppointmentType.Pattern);
            aptPattern.Subject = "Pattern";

            aptPattern.RecurrenceInfo.Type = RecurrenceType.Hourly;
            aptPattern.RecurrenceInfo.Periodicity = 4;
            aptPattern.RecurrenceInfo.Duration = new TimeSpan(0, 30, 0);
            aptPattern.RecurrenceInfo.Range = RecurrenceRange.OccurrenceCount;
            aptPattern.RecurrenceInfo.OccurrenceCount = 10;
            aptPattern.RecurrenceInfo.Start = DateTime.Now.AddDays(2);
            aptPattern.StatusId = 2;
            aptPattern.ResourceId = 1;

            eventList.Add(aptPattern);
        }
    
    }
}

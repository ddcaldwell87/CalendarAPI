using System;

namespace Appointments.Models
{
    internal class AppointmentCreate
    {
        public Guid OwnerId { get; set; }
        public string Title { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public TimeOnly Time { get; set; }
        public string Category { get; set; }
    }
}

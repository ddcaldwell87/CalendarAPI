using System;

namespace Tasks.Models
{
    internal class TaskCreate
    {
        public Guid OwnerId { get; set; }
        public string Title { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }
        public string Category { get; set; }
    }
}

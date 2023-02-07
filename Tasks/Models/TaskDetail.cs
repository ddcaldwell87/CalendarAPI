using System;

namespace Tasks.Models
{
    internal class TaskDetail
    {
        public Guid OwnerId { get; set; }
        public int TaskId { get; set; }
        public string Title { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }
        public string Category { get; set; }
    }
}

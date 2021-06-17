using System;

namespace CrossCuttingLayer
{
    public class Todo
    {
        public string Id { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.UtcNow;
        public string TaskDescription { get; set; }
        public bool IsCompleted { get; set; }
    }

}

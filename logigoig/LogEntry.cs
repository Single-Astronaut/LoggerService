﻿namespace logigoig
{
    public class LogEntry
    {
        public string UserId { get; set; }
        public string Action { get; set; }
        public string Description { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;

    }
}
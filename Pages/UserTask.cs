﻿namespace дз9.Pages
{
    public class UserTask
    {
        public required string Title { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
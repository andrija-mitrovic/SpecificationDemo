﻿namespace Domain.Entities
{
    public class Technology
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Producer Producer { get; set; }
    }
}
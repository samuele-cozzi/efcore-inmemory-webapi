using System;

namespace efcore_inmemory_webapi.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}

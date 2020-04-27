using System;
using System.Collections.Generic;

namespace ListViewScheduleTest.Models
{
    public class ItemsList
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Item> Items { get; set; } = new List<Item>();

        public ItemsList(string name, string description, List<Item> items)
        {
            Name = name;
            Description = description;
            Items = items;
        }
    }
}

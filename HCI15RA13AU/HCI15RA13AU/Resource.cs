using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HCI15RA13AU
{
    public enum Unit
    {
        MERICA, BAREL, TONA, KILOGRAM
    }

    public enum Frequency
    {
        RARE, FREQUENT, UNIVERSAL
    }

    public class Resource
    {
        public string Id { get; set; }
        public string Description { get; set; }
        //public string Type { get; set; }        // id, name, icon, desc
        public string Name { get; set; }
        public Frequency Frequency { get; set; }
        public bool Renewable { get; set; }
        public bool Accessable { get; set; }
        public bool Important { get; set; }
        public double Cost { get; set; }
        public DateTime Discovered { get; set; }
        public Unit Unit { get; set; }
        public string IconFileName { get; set; }

        // collection of tags
    }
}

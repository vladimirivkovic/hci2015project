using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HCI15RA13AU
{
    class Resource
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }        // id, name, icon, desc
        public string Name { get; set; }
        public int Frequency { get; set; }      // enum
        public bool Renewable { get; set; }
        public bool Accessable { get; set; }
        public bool Important { get; set; }
        public double Cost { get; set; }
        public DateTime Discovered { get; set; }
        // jedinica mere
        // ikonica

        // collection of tags
    }
}

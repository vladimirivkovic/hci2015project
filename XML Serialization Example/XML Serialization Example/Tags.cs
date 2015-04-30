using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace XML_Serialization_Example
{
    public class Tags
    {
        public Dictionary<string, Tag> Items;

        public Tags()
        {
            Items = new Dictionary<string, Tag>();
        }
    }

    public class Item
    {
        [XmlElement]
        public string ID;
        [XmlElement]
        public Tag tg;
    }
}

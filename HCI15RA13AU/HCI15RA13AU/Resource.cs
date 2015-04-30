using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Xml.Serialization;

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
        [XmlElement]
        public string ID { get; set; }
        [XmlElement]
        public string Description { get; set; }
        [XmlElement]
        public Type Type { get; set; }
        [XmlElement]
        public string Name { get; set; }
        [XmlElement]
        public Frequency Frequency { get; set; }
        [XmlElement]
        public bool Renewable { get; set; }
        [XmlElement]
        public bool Exploatable { get; set; }
        [XmlElement]
        public bool Important { get; set; }
        [XmlElement]
        public double Cost { get; set; }
        [XmlElement]
        public DateTime Discovered { get; set; }
        [XmlElement]
        public Unit Unit { get; set; }
        [XmlElement]
        public string IconFileName { get; set; }

        [XmlElement]
        public Dictionary<string, Tag> Tags { get; set; }

        public static string UnitToString(Unit u)
        {
            switch (u)
            {
                case Unit.BAREL:
                    return "barel";
                case Unit.MERICA:
                    return "merica";
                case Unit.TONA:
                    return "tona";
                case Unit.KILOGRAM:
                    return "kilogram";
                default:
                    return "";
            }
        }

        public static string FrequencyToString(Frequency f)
        {
            switch (f)
            {
                case Frequency.FREQUENT:
                    return "čest";
                case Frequency.RARE:
                    return "redak";
                case Frequency.UNIVERSAL:
                    return "univezalan";
                default:
                    return "";
            }
        }

        public static Unit StringToUnit(string s)
        {
            switch (s)
            {
                case "merica":
                    return Unit.MERICA;
                case "barel":
                    return Unit.BAREL;
                case "tona":
                    return Unit.TONA;
                default:
                    return Unit.KILOGRAM;
            }
        }
    }

    public class Type
    {
        [XmlElement]
        public string ID { get; set; }
        [XmlElement]
        public string Name { get; set; }
        [XmlElement]
        public string IconFileName { get; set; }
        [XmlElement]
        public string Description { get; set; }

        public Type()
        {
        }

        public Type(Type t)
        {
            ID = t.ID;
            Name = t.Name;
            IconFileName = t.IconFileName;
            Description = t.Description;
        }
    }

    public class Tag
    {
        [XmlElement]
        public string ID { get; set; }
        public Color Color { get; set; }
        [XmlElement]
        public string Description { get; set; }

        public Tag()
        {
        }

        public Tag(Tag t)
        {
            ID = t.ID;
            Color = t.Color;
            Description = t.Description;
        }

        public Tag(TagItem ti)
        {
            ID = ti.ID;
            Color = Color.FromArgb(ti.A, ti.R, ti.G, ti.B);
            Description = ti.Description;
        }
    }

    public class TagItem : Tag
    {
        [XmlElement]
        public int A { get; set; }
        [XmlElement]
        public int B { get; set; }
        [XmlElement]
        public int G { get; set; }
        [XmlElement]
        public int R { get; set; }

        public TagItem()
        {
        }

        public TagItem(Tag t)
        {
            ID = t.ID;
            Description = t.Description;
            Color = t.Color;
            A = t.Color.A;
            B = t.Color.B;
            G = t.Color.G;
            R = t.Color.R;
        }
    }
}

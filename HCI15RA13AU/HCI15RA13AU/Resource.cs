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
        public string SecondID { get; set; }
        [XmlElement]
        public string Description { get; set; }
        [XmlIgnore]
        public Type Type { get; set; }
        [XmlElement]
        public string Name { get; set; }
        [XmlIgnore]
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
        public ApproxDate ApproxDiscovered { get; set; }
        [XmlIgnore]
        public Unit Unit { get; set; }
        [XmlElement]
        public string IconFileName { get; set; }

        [XmlIgnore]
        public Dictionary<string, Tag> Tags;

        public Resource()
        {

        }

        public Resource(Resource r)
        {
            ID = r.ID;
            SecondID = r.SecondID;
            Description = r.Description;
            Type = r.Type;
            Name = r.Name;
            Frequency = r.Frequency;
            Renewable = r.Renewable;
            Exploatable = r.Exploatable;
            Important = r.Important;
            Cost = r.Cost;
            Discovered = r.Discovered;
            Unit = r.Unit;
            IconFileName = r.IconFileName;
            Tags = r.Tags;
        }

        public Resource(ResourceItem r)
        {
            ID = r.ID;
            SecondID = r.SecondID;
            Description = r.Description;
            Type = r.Type;
            Name = r.Name;
            Frequency = r.Frequency;
            Renewable = r.Renewable;
            Exploatable = r.Exploatable;
            Important = r.Important;
            Cost = r.Cost;
            Discovered = r.Discovered;
            ApproxDiscovered = r.ApproxDiscovered;
            Unit = StringToUnit(r.UnitName);
            Frequency = StringToFrequency(r.FrequencyName);
            IconFileName = r.IconFileName;
            if (MainForm.types.ContainsKey(r.TypeName))
            {
                Type = MainForm.types[r.TypeName];
            }
            IconFileName = r.IconFileName;

            Tags = new Dictionary<string, Tag>();
            foreach (string s in r.TagIds)
            {
                if (MainForm.tags.ContainsKey(s))
                {
                    Tags.Add(s, MainForm.tags[s]);
                }
            }
        }

        private static Frequency StringToFrequency(string p)
        {
            switch (p)
            {
                case "čest" :
                    return Frequency.FREQUENT;
                case "redak":
                    return  Frequency.RARE;
                case "univerzalan":
                    return Frequency.UNIVERSAL;
                default:
                    return Frequency.UNIVERSAL;
            }
        }

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
                    return "univerzalan";
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
        public string SecondID { get; set; }
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
            SecondID = t.SecondID;
            Name = t.Name;
            IconFileName = t.IconFileName;
            Description = t.Description;
        }
    }

    public class Tag
    {
        [XmlElement]
        public string ID { get; set; }
        [XmlElement]
        public string SecondID { get; set; }
        public Color Color { get; set; }
        [XmlElement]
        public string Description { get; set; }

        public Tag()
        {
        }

        public Tag(Tag t)
        {
            ID = t.ID;
            SecondID = t.SecondID;
            Color = t.Color;
            Description = t.Description;
        }

        public Tag(TagItem ti)
        {
            ID = ti.ID;
            SecondID = ti.SecondID;
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
            SecondID = t.SecondID;
            Description = t.Description;
            Color = t.Color;
            A = t.Color.A;
            B = t.Color.B;
            G = t.Color.G;
            R = t.Color.R;
        }
    }

    public class ResourceItem : Resource
    {
        [XmlElement]
        public string UnitName { get; set; }
        [XmlElement]
        public string FrequencyName { get; set; }
        [XmlElement]
        public string TypeName { get; set; }

        [XmlArray("listOfTags")]
        [XmlArrayItem("tag", typeof(string))]
        public List<string> TagIds;

        public ResourceItem()
        {
            TagIds = new List<string>();
        }

        public ResourceItem(Resource r)
        {
            ID = r.ID;
            SecondID = r.SecondID;
            Description = r.Description;
            Type = r.Type;
            Name = r.Name;
            Frequency = r.Frequency;
            Renewable = r.Renewable;
            Exploatable = r.Exploatable;
            Important = r.Important;
            Cost = r.Cost;
            Discovered = r.Discovered;
            Unit = r.Unit;
            IconFileName = r.IconFileName;
            Tags = r.Tags;
            IconFileName = r.IconFileName;
            UnitName = Resource.UnitToString(Unit);
            FrequencyName = Resource.FrequencyToString(Frequency);
            TypeName = r.Type.ID;
            ApproxDiscovered = r.ApproxDiscovered;

            TagIds = new List<string>();
            foreach (string key in Tags.Keys)
            {
                TagIds.Add(key);
            }
        }
    }

    public class ResourcePosition
    {
        [XmlElement]
        public string ID { get; set; }
        [XmlElement]
        public int X { get; set; }
        [XmlElement]
        public int Y { get; set; }

        public ResourcePosition()
        {

        }

        public ResourcePosition(Resource res, int x, int y)
        {
            ID = res.ID;
            X = x;
            Y = y;
        }

        public ResourcePosition(ResourcePosition rp)
        {
            ID = rp.ID;
            X = rp.X;
            Y = rp.Y;
        }
    }

    public class ApproxDate
    {
        [XmlElement]
        public int Year { get; set; }
        [XmlElement]
        public int Century { get; set; }
        [XmlElement]
        public bool AD { get; set; }
        [XmlElement]
        public bool Unknown { get; set; }

        public ApproxDate()
        {

        }

        public ApproxDate(int y, int c, bool ad, bool un)
        {
            Year = y;
            Century = c;
            AD = ad;
            Unknown = un;
        }

        public override string ToString()
        {
            if (Unknown)
            {
                return "nepoznat";
            }
            else
            {
                if (Year >= 0)
                {
                    return Year + ". g." + (AD ? "" : " p.") + "n.e.";
                }
                else
                {
                    return Century + ". vek " + (AD ? "" : " p.") + "n.e.";
                }
            }
        }
    }
}

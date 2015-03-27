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
                    return "frequent";
                case Frequency.RARE:
                    return "rare";
                case Frequency.UNIVERSAL:
                    return "universal";
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
}

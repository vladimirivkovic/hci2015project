﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

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
        public string ID { get; set; }
        public string Description { get; set; }
        public Type Type { get; set; }
        public string Name { get; set; }
        public Frequency Frequency { get; set; }
        public bool Renewable { get; set; }
        public bool Exploatable { get; set; }
        public bool Important { get; set; }
        public double Cost { get; set; }
        public DateTime Discovered { get; set; }
        public Unit Unit { get; set; }
        public string IconFileName { get; set; }

        public List<Tag> Tags { get; set; }

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
        public string ID { get; set; }
        public string Name { get; set; }
        public string IconFileName { get; set; }
        public string Description { get; set; }
    }

    public class Tag
    {
        public string ID { get; set; }
        public Color Color { get; set; }
        public string Description { get; set; }
    }
}

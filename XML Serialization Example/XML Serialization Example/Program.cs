using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace XML_Serialization_Example
{
    class Program
    {
        private static int count = 10;
        static Tags tags = new Tags();
        static Type[] types;

        static void Main(string[] args)
        {
            //init();
            //SerializeTags();
            //SerializeTypes();
            DeserializeTags();
        }

        static void SerializeTags()
        {
            XmlSerializer xmlserizalizer = new XmlSerializer(typeof(Item[]), new XmlRootAttribute() { ElementName = "items" });
            FileStream buffer = File.Create("tags.xml");

            xmlserizalizer.Serialize(buffer, tags.Items.Select(kv=>new Item() {ID=kv.Key, tg = kv.Value}).ToArray());
            
            buffer.Close();
        }

        static void DeserializeTags()
        {
            XmlSerializer xmlserizalizer = new XmlSerializer(typeof(Item[]), new XmlRootAttribute() { ElementName = "items" });
            FileStream buffer = File.Open("tags.xml", FileMode.Open);

            //Tag t = xmlserizalizer.Deserialize(XmlReader.Create(buffer)) as Tag;
            //Console.WriteLine(t.ID + ";" + t.Name);
            Item[] items = xmlserizalizer.Deserialize(buffer) as Item[];
            foreach (Item i in items)
            {
                Console.WriteLine(i.tg);
            }
            Console.ReadKey();
        }

        static void SerializeTypes()
        {
            XmlSerializer xmlserizalizer = new XmlSerializer(typeof(Type));
            FileStream buffer = File.Create("types.xml");

            foreach (Type t in types)
            {
                xmlserizalizer.Serialize(buffer, t);
            }

            buffer.Close();
        }

        static void init()
        {
            types = new Type[count];
            for (int i = 0; i < count; i++)
            {
                Tag t = new Tag();
                t.ID = "tg" + i;
                t.Name = "tagno_" + i;
                tags.Items.Add(t.ID, t);
                types[i] = new Type();
                types[i].ID = "tp" + i;
                types[i].Name = "typeno_" + i;
            }
        }
    }
}

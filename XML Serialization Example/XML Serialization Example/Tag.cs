using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace XML_Serialization_Example
{
    [Serializable]
    public class Tag
    {
        [XmlAttribute]
        public string ID { get; set; }
        [XmlAttribute]
        public string Name { get; set; }

        public Tag()
        {

        }

        public override string ToString()
        {
            return this.ID + " : " + this.Name;
        }

        //public Tag(SerializationInfo info, StreamingContext context)
        //{
        //    this.ID = info.GetValue("ID", typeof(string)).ToString();
        //    this.Name = info.GetValue("Name", typeof(string)).ToString();
        //}

        //public void GetObjectData(SerializationInfo info, StreamingContext context)
        //{
        //    info.AddValue("ID", this.ID);
        //    info.AddValue("Name", this.Name);
        //}

        //public override string ToString()
        //{
        //    return this.ID + ":" + this.Name;
        //}
    }

}

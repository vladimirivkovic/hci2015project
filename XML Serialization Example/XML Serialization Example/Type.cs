using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace XML_Serialization_Example
{
    [Serializable]
    public class Type :ISerializable
    {
        public string ID { get; set; }
        public string Name { get; set; }

        public Type()
        {

        }

        public Type(SerializationInfo info, StreamingContext context)
        {
            this.ID = info.GetValue("ID", typeof(string)).ToString();
            this.Name = info.GetValue("Name", typeof(string)).ToString();
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("ID", this.ID);
            info.AddValue("Name", this.Name);
        }

 
    }
}

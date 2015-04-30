using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace XML_Serialization_Example
{
    [Serializable]
    public class Resource : ISerializable
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string TypeID { get; set; }
        public Dictionary<string, string> Tags { get; set; }

        public Resource()
        {

        }

        public Resource(SerializationInfo info, StreamingContext context)
        {
            this.ID = info.GetValue("ID", typeof(string)).ToString();
            this.Name = info.GetValue("Name", typeof(string)).ToString();
            this.TypeID = info.GetValue("TypeID", typeof(string)).ToString();
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("ID", this.ID);
            info.AddValue("Name", this.Name);
            info.AddValue("TypeID", this.TypeID);
        }
    }
}

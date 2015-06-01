using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HCI15RA13AU
{
    class Tutorial
    {
        private MainForm form;
        Resource[] resources;

        public Tutorial(MainForm form)
        {
            this.form = form;
        }

        public Resource[] GenerateDummyResources()
        {
            Type t = new Type();
            t.ID = "oznTipa";
            t.SecondID = "oznTipa";
            t.Name = "nazivTipa";
            t.Description = "";
            t.IconFileName = "";

            resources = new Resource[3];

            for (int i = 0; i < 3; i++)
            {
                resources[i] = new Resource();
                resources[i].ID = "resurs" + i;
                resources[i].SecondID = "resurs" + i;
                resources[i].Name = "naziv" + i;
                resources[i].Discovered = DateTime.Now;
                resources[i].IconFileName = "";
                resources[i].Type = t;
                resources[i].Tags = new Dictionary<string, Tag>();
            }

            return resources;
        }
    }
}

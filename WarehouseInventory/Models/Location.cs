using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseInventory.Models
{
    public class Location
    {
        public int LocationID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }


        public Location(string name, string description)
        {
            this.Name = name;
            this.Description = description;

        }
    }
}

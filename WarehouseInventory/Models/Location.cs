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
        public string Zone { get; set; }
        public string Row { get; set; }
        public string Shelf { get; set; }
        public string Bin { get; set; }
        public string Description { get; set; }


       
    }
}

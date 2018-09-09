using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseInventory.Models
{
   public abstract class WarehouseItem
    {
        public int WarehouseItemID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Location Zone { get; set; }
        public Location Row { get; set; }
        public Location Shelf { get; set; }
        public Location Bin { get; set; }
        public int WarehouseId { get; set; }
        public virtual Warehouse Warehouse { get; set; }
    }
}

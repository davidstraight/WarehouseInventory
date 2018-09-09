using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseInventory.Models
{
    public class Warehouse
    {
        public int WarehouseID { get; set; }
        public string Name;
        public string Description;
        public virtual ObservableCollection<WarehouseItem> WarehouseItems { get; private set; }

        public Warehouse()
        {
            this.WarehouseItems = new ObservableCollection<WarehouseItem>();
        }
       
    }
}


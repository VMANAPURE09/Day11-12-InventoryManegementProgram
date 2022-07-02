using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDataMangement
{
    public class Inventory
    {
        public List<Item> TypesOfRice { get; set; }
        public List<Item> TypesOfGrains { get; set; }
        public List<Item> TypesOfWheats { get; set; }
    }


    public class Item
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Price { get; set; }
    }

   
}


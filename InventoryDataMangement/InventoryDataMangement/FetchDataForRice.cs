using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDataMangement
{
    public class FetchDataForRice
    {
        public Inventory Read(string Path)
        {
            using (StreamReader file = new StreamReader(Path))
            {
                try
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<Inventory>(json);

                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }
    }
}

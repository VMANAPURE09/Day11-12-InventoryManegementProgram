using System;

namespace InventoryDataMangement
{
    internal class Program
    {
        int a = 0;
        static void Main(string[] args)
        {
            string path = @"E:\BridgeLabz2\PraticeProblem\Day11-12-InventoryManegementProgram\InventoryDataMangement\InventoryDataMangement\Inventory.json";

            FetchDataForRice fetchDataForRice = new FetchDataForRice();
             var data = fetchDataForRice.Read(path);

            for (int i = 0; i < data.TypesOfRice.Count; i++)
            {
                Console.WriteLine(data.TypesOfRice[i].Name);
                Console.WriteLine(data.TypesOfRice[i].Weight);
                Console.WriteLine(data.TypesOfRice[i].Price);
                int value = data.TypesOfRice[i].Weight * data.TypesOfRice[i].Price;
                Console.WriteLine("The value of " + data.TypesOfRice[i].Name + " Rice Inventory is :" + value);
                Console.WriteLine();
            }

            Console.WriteLine("--------------");
            for (int i = 0; i < data.TypesOfGrains.Count; i++)
            {
                Console.WriteLine(data.TypesOfGrains[i].Name);
                Console.WriteLine(data.TypesOfGrains[i].Weight);
                Console.WriteLine(data.TypesOfGrains[i].Price);
                int value = data.TypesOfGrains[i].Weight * data.TypesOfGrains[i].Price;
                Console.WriteLine("The value of " + data.TypesOfGrains[i].Name + " Grain Inventory is :" + value);
                Console.WriteLine();
            }

            Console.WriteLine("--------------");
            for (int i = 0; i < data.TypesOfWheats.Count; i++)
            {
                Console.WriteLine(data.TypesOfWheats[i].Name);
                Console.WriteLine(data.TypesOfWheats[i].Weight);
                Console.WriteLine(data.TypesOfWheats[i].Price);
                int value = data.TypesOfWheats[i].Weight * data.TypesOfWheats[i].Price;
                Console.WriteLine("The value of " + data.TypesOfWheats[i].Name + " Inventory is :" + value);
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}

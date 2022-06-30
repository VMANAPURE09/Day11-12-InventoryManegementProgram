using System;

namespace InventoryDataMangement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "E:/BridgeLabz/Object_Oriented_Problem/Object_Oriented_Problem/ConsoleApp1/ConsoleApp1/json1.json";

            FetchDataForRice fetchDataForRice = new FetchDataForRice();
            Rice data = fetchDataForRice.Read(path);

            for (int i = 0; i < data.typesOfRice.Count; i++)
            {
                Console.WriteLine(data.typesOfRice[i].Name);
                Console.WriteLine(data.typesOfRice[i].Weight);
                Console.WriteLine(data.typesOfRice[i].Price);
                int value = data.typesOfRice[i].Weight * data.typesOfRice[i].Price;
                Console.WriteLine("The value of " + data.typesOfRice[i].Name + " Rice Inventory is :" + value);
                Console.WriteLine();
            }

            Console.WriteLine("--------------");
            for (int i = 0; i < data.typesOfGrains.Count; i++)
            {
                Console.WriteLine(data.typesOfGrains[i].Name);
                Console.WriteLine(data.typesOfGrains[i].Weight);
                Console.WriteLine(data.typesOfGrains[i].Price);
                int value = data.typesOfGrains[i].Weight * data.typesOfGrains[i].Price;
                Console.WriteLine("The value of " + data.typesOfGrains[i].Name + " Grain Inventory is :" + value);
                Console.WriteLine();
            }

            Console.WriteLine("--------------");
            for (int i = 0; i < data.typesOfWheats.Count; i++)
            {
                Console.WriteLine(data.typesOfWheats[i].Name);
                Console.WriteLine(data.typesOfWheats[i].Weight);
                Console.WriteLine(data.typesOfWheats[i].Price);
                int value = data.typesOfWheats[i].Weight * data.typesOfWheats[i].Price;
                Console.WriteLine("The value of " + data.typesOfWheats[i].Name + " Inventory is :" + value);
                Console.WriteLine();
            }


        }
    }
}

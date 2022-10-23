namespace inventory1
{
    class program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\DELL\source\repos\inventory1\inventory1\inventory.json";

            fetchdata FetchData = new fetchdata();
            inventory data = FetchData.Read(path);
            Console.WriteLine("inventory details");

            Console.WriteLine("-----------------");
            Console.WriteLine("Types of Rice");


            for (int i = 0; i < data.typesofrice.Count; i++)
            {
                Console.WriteLine(data.typesofrice[i].name);
                Console.WriteLine(data.typesofrice[i].weight);
                Console.WriteLine(data.typesofrice[i].price);
                Console.WriteLine("------------------------");
            }
            Console.WriteLine("-----------------");

            Console.WriteLine("-----------------");
            Console.WriteLine("Types of Pulses");
            for (int i = 0; i < data.typesofpulses.Count; i++)
            {

                Console.WriteLine(data.typesofpulses[i].name);
                Console.WriteLine(data.typesofpulses[i].weight);
                Console.WriteLine(data.typesofpulses[i].price);
                Console.WriteLine("------------------------");
            }
            Console.WriteLine("-----------------");

            Console.WriteLine("-----------------");
            Console.WriteLine("Types of Wheat");
            for (int i = 0; i < data.typesofwheat.Count; i++)
            {

                Console.WriteLine(data.typesofwheat[i].name);
                Console.WriteLine(data.typesofwheat[i].weight);
                Console.WriteLine(data.typesofwheat[i].price);
                Console.WriteLine("------------------------");
            }
            Console.WriteLine("-----------------");

        }
    }
}


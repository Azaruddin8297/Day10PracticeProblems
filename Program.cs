namespace JasonFile
{
    public class JasonFile
    {
        public static void Main(string[] args)
        {
            string path = "D:\\Java\\JasonFile\\JasonFile\\Inventory.json";
            ReadInventory obj = new ReadInventory();
            InventoryDetails data = obj.Read(path);
            Console.WriteLine("Types of Rices");
            Console.WriteLine("****************************");
            for (int i = 0;i<data.typesofRice.Count;i++) 
            {
                Console.WriteLine(data.typesofRice[i].Name);
                Console.WriteLine(data.typesofRice[i].Weight);
                Console.WriteLine(data.typesofRice[i].Price);
                int val = data.typesofRice[i].Weight* data.typesofRice[i].Price;
                Console.WriteLine("the price of {0} for {1} is {2}rs", data.typesofRice[i].Name, data.typesofRice[i].Price, val);
                Console.WriteLine("-----------------------------");
                
            }
            Console.WriteLine("Types of Wheat");
            Console.WriteLine("****************************");
            for (int i = 0; i < data.typesofWheat.Count; i++)
            {
                Console.WriteLine(data.typesofWheat[i].Name);
                Console.WriteLine(data.typesofWheat[i].Weight);
                Console.WriteLine(data.typesofWheat[i].Price);
                int val = data.typesofWheat[i].Weight * data.typesofWheat[i].Price;
                Console.WriteLine("the price of {0} for {1} is {2}rs", data.typesofWheat[i].Name, data.typesofWheat[i].Price, val);
                Console.WriteLine("-----------------------------");
            }

            Console.WriteLine("Types of pulses");
            Console.WriteLine("****************************");
            for (int i = 0; i < data.typesofpulses.Count; i++)
            {
                Console.WriteLine(data.typesofpulses[i].Name);
                Console.WriteLine(data.typesofpulses[i].Weight);
                Console.WriteLine(data.typesofpulses[i].Price);
                int val = data.typesofpulses[i].Weight * data.typesofpulses[i].Price;
                Console.WriteLine("the price of {0} for {1} is {2}rs", data.typesofpulses[i].Name, data.typesofpulses[i].Price, val);
                Console.WriteLine("-----------------------------");
            }

        }
    }
}
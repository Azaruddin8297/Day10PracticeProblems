namespace StockMarketProgram
{
    public class StockMarketProgram
    {
        public static void Main(string[] args)
        {
            ReadInventory readInventory = new ReadInventory();
            string path = "D:\\C#\\StockMarketProgram\\StockMarketProgram\\StocksInventory.json";
            IventoryDetails inv = readInventory.Read(path);
            Console.WriteLine("Types of StockMarkets");
            Console.WriteLine("***********************");
            for(int i = 0;i<inv.typesofStocks.Count;i++)
            {
                Console.WriteLine("Stock Name is :"+inv.typesofStocks[i].stockName);
                Console.WriteLine("Stock Numbers are :"+inv.typesofStocks[i].Numberofstocks);
                Console.WriteLine("Price of stocks is :"+inv.typesofStocks[i].stockPrice);
                int val = inv.typesofStocks[i].Numberofstocks * inv.typesofStocks[i].stockPrice;
                Console.WriteLine("The Price of Stock {0} is {1} RS", inv.typesofStocks[i].stockName,val);
                Console.WriteLine("-------------------------------");
            }
        }
    }
}
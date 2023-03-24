using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarketProgram
{
    public class IventoryDetails
    {
        public List<TypesofStocks> typesofStocks;
    }
    public class TypesofStocks
    {
        public string stockName;
        public int Numberofstocks;
        public int stockPrice;
    }
}

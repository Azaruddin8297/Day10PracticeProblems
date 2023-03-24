using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace StockMarketProgram
{
    public class ReadInventory
    {
        public IventoryDetails Read(string path)
        {
            try
            {
                using (StreamReader file = new StreamReader(path))
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<IventoryDetails>(json);
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}

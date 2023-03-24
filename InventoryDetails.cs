using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JasonFile
{
    public class InventoryDetails
    {
        public List<TypesofRice> typesofRice;
        public List<TypesofWheat> typesofWheat;
        public List<TypesofPulses> typesofpulses;
    }
    public class TypesofRice
    {
        public string Name;
        public int Weight;
        public int Price;
    }
    public class TypesofWheat
    {
        public string Name;
        public int Weight;
        public int Price;
    }
    public class TypesofPulses
    {
        public string Name;
        public int Weight;
        public int Price;
    }
}

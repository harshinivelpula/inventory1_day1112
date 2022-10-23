using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory1
{
    internal class inventory
    {
        public List<TypesofRice> typesofrice;
        public List<TypesofPulses> typesofpulses;
        public List<TypesofWheat> typesofwheat;
    }
    public class TypesofRice
    {
        public string name;
        public int weight;
        public int price;
    }
    public class TypesofPulses
    {
        public string name;
        public int weight;
        public int price;
    }
    public class TypesofWheat
    {
        public string name;
        public int weight;
        public int price;
    }
}

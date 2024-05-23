using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._Vehicle_Catalog
{
    internal class Catalog
    {
        public Catalog(string collection) 
        { 
            Collection = collection;
        }
        public string Collection {  get; set; }
    }
}

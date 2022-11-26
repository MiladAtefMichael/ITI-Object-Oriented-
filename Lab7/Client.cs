using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public void ShowClientDetaila()
        {
            Console.WriteLine($"client id {Id} and Name is {Name} from City {City}");
        }
    }
}

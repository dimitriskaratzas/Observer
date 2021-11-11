using After.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After.ConcreteObservers
{
    public class SpreadSheet : IObserver
    {
        public void Update()
        {
            Console.WriteLine("Spreadsheet got notified");
        }
    }
}

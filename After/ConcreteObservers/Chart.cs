using After.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After.ConcreteObservers
{
    public class Chart : IObserver
    {
        public void Update(int val)
        {
            Console.WriteLine("Chart got notified " + val);
        }
    }
}

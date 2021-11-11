using After.ConcreteSubject;
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
        private DataSource _dataSource;

        public Chart(DataSource dataSource)
        {
            _dataSource = dataSource;
        }
        public void Update()
        {
            Console.WriteLine("Chart got notified " + _dataSource.Value);
        }
    }
}

using After.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After.ConcreteSubject
{
    public class DataSource : MySubject
    {
        private int _value;

        public int Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
                NotifyObservers(_value);
            }
        }
    }
}

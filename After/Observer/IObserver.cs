﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After.Observer
{
    public interface IObserver
    {
        void Update(int val);
    }
}

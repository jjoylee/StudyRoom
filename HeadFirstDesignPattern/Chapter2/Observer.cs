﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2
{
    public interface Observer
    {
        void update(float temp, float humidity, float pressure);
    }
}

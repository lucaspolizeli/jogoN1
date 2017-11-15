﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace pingPong
{
    public static class Time
    {
        public static Timer InternalTimer { get; private set; }

        public static void Setup()
        {
            InternalTimer = new Timer();
            InternalTimer.Interval = 20;
            InternalTimer.Start();
        }
    }
}

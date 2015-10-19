﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RpgLibrary
{
    public class Modifier
    {
        #region Field region

        public string Modifying;
        public int Amount;
        public int Duration;
        public TimeSpan TimeLeft;

        #endregion

        #region Constructor region

        public Modifier(string modifying, int amount)
        {
            Modifying = modifying;
            Amount = amount;
            Duration = -1;
            TimeLeft = TimeSpan.Zero;
        }

        public Modifier(string modifying, int amount, int duration)
        {
            Modifying = modifying;
            Amount = amount;
            Duration = duration;
            TimeLeft = TimeSpan.FromSeconds(duration);
        }

        #endregion

        #region Method region

        public void Update(TimeSpan elapsedTime)
        {
            if (Duration == -1)
            {
                return;
            }

            TimeLeft -= elapsedTime;
            if (TimeLeft.TotalMilliseconds < 0)
            {
                TimeLeft = TimeSpan.Zero;
                Amount = 0;
            }
        }

        #endregion

        #region Virtual Method region



        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RpgLibrary
{
    public enum DieType { 
        D4 = 4,
        D6 = 6,
        D8 = 8,
        D10 = 10,
        D12 = 12,
        D20 = 20,
        D100 = 100
    }

    public static class Mechanics
    {
        #region Field region

        static Random random = new Random();

        #endregion

        #region Property region



        #endregion

        #region Constructor region



        #endregion

        #region Method region

        public static int RollDie(DieType die)
        {
            return random.Next(0, (int)die) + 1;
        }

        #endregion

        #region Virtual Method region



        #endregion
    }
}

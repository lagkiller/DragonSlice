using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RpgLibrary.ItemClasses
{
    public class KeyData
    {
        #region Field region

        public string Name;
        public string Type;

        #endregion

        #region Constructor region

        public KeyData()
        {

        }

        #endregion

        #region Method region

        public override string ToString()
        {
            string toString = Name + ", ";
            toString += Type;

            return toString;
        }

        #endregion
    }
}

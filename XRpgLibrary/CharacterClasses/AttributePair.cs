using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XRpgLibrary.CharacterClasses
{
    public class AttributePair
    {
        #region Field region

        int currentValue;
        int maximumValue;

        #endregion

        #region Property region

        public int CurrentValue
        {
            get
            {
                return currentValue;
            }
        }

        public int MaximumValue
        {
            get
            {
                return maximumValue;
            }
        }

        public static AttributePair Zero
        {
            get
            {
                return new AttributePair();
            }
        }

        #endregion

        #region Constructor region

        private AttributePair()
        {
            currentValue = 0;
            maximumValue = 0;
        }

        public AttributePair(int maxValue)
        {
            currentValue = maxValue;
            maximumValue = maxValue;
        }

        #endregion

        #region Method region

        public void Heal(ushort value)
        {
            currentValue += value;
            if (currentValue > maximumValue)
            {
                currentValue = maximumValue;
            }
        }

        public void Damage(ushort value)
        {
            currentValue -= value;
            if (currentValue < 0)
            {
                currentValue = 0;
            }
        }

        public void SetCurrent(int value)
        {
            currentValue = value;
            if (currentValue > maximumValue)
            {
                currentValue = maximumValue;
            }
        }

        public void SetMaximum(int value)
        {
            maximumValue = value;
            if (currentValue > maximumValue)
            {
                currentValue = maximumValue;
            }
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using XRpgLibrary.SkillClasses;

namespace XRpgLibrary.ItemClasses
{
    public class ChestData
    {
        public string Name;
        public DifficultyLevel DifficultyLevel;
        public bool IsTrapped;
        public bool IsLocked;
        public string TrapName;
        public string KeyName;
        public string KeyType;
        public int KeysRequired;
        public int MinGold;
        public int MaxGold;
        public Dictionary<string, string> ItemCollection;

        public ChestData()
        {
            ItemCollection = new Dictionary<string, string>();
        }

        public override string ToString()
        {
            string toString = Name + ", ";
            toString += DifficultyLevel.ToString() + ", ";
            toString += IsTrapped.ToString() + ", ";
            toString += IsLocked.ToString() + ", ";
            toString += TrapName + ", ";
            toString += KeyName + ", ";
            toString += KeyType + ", ";
            toString += KeysRequired.ToString() + ", ";
            toString += MinGold.ToString() + ", ";
            toString += MaxGold.ToString();

            foreach (KeyValuePair<string, string> pair in ItemCollection)
            {
                toString += ", " + pair.Key + ":" + pair.Value;
            }

            return toString;
        }
    }
}

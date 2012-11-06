using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RpgLibrary.ItemClasses
{
    public enum Hands { One, Two }

    public enum ArmorLocation { Body, Head, Hands, Feet }

    public abstract class BaseItem
    {
        #region Field region

        protected List<Type> allowableClasses = new List<Type>();

        string name;
        string type;
        int price;
        float weight;
        bool equipped;

        #endregion

        #region Property region

        public List<Type> AllowableClasses
        {
            get
            {
                return allowableClasses;
            }
            protected set
            {
                allowableClasses = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }
            protected set
            {
                type = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            protected set
            {
                name = value;
            }
        }

        public int Price
        {
            get
            {
                return price;
            }
            protected set
            {
                price = value;
            }
        }

        public float Weight
        {
            get
            {
                return weight;
            }
            protected set
            {
                weight = value;
            }
        }

        public bool IsEquipped
        {
            get
            {
                return equipped;
            }
            protected set
            {
                equipped = value;
            }
        }

        #endregion

        #region Constructor region

        public BaseItem(string name, string type, int price, float weight, params Type[] allowableClasses)
        {
            foreach (Type t in allowableClasses)
            {
                AllowableClasses.Add(t);
            }

            Name = name;
            Type = type;
            Price = price;
            Weight = weight;
            IsEquipped = false;
        }

        #endregion

        #region Abstract method region

        public abstract object Clone();

        public virtual bool CanEquip(Type characterType)
        {
            return allowableClasses.Contains(characterType);
        }

        public override string  ToString()
        {
 	        string itemString = "";

            itemString += Name + ", ";
            itemString += Type + ", ";
            itemString += Price.ToString() + ", ";
            itemString += Weight.ToString();

            return itemString;
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XRpgLibrary.ItemClasses
{
    public class ItemManager
    {
        #region Fields region

        Dictionary<string, Weapon> weapons = new Dictionary<string, Weapon>();
        Dictionary<string, Armor> armors = new Dictionary<string, Armor>();
        Dictionary<string, Shield> shields = new Dictionary<string, Shield>();

        #endregion

        #region Keys Property region

        public Dictionary<string, Weapon>.KeyCollection WeaponKeys
        {
            get
            {
                return weapons.Keys;
            }
        }

        public Dictionary<string, Armor>.KeyCollection ArmorKeys
        {
            get
            {
                return armors.Keys;
            }
        }

        public Dictionary<string, Shield>.KeyCollection ShieldKeys
        {
            get
            {
                return shields.Keys;
            }
        }

        #endregion

        #region Constructor region

        public ItemManager()
        {

        }

        #endregion

        #region Weapon methods

        public void AddWeapon(Weapon weapon)
        {
            if (!weapons.ContainsKey(weapon.Name))
            {
                weapons.Add(weapon.Name, weapon);
            }
        }

        public Weapon GetWeapon(string name)
        {
            if (weapons.ContainsKey(name))
            {
                return (Weapon)weapons[name].Clone();
            }

            return null;
        }

        public bool ContainsWeapon(string name)
        {
            return weapons.ContainsKey(name);
        }

        #endregion

        #region Armor methods

        public void AddArmor(Armor armor)
        {
            if (!armors.ContainsKey(armor.Name))
            {
                armors.Add(armor.Name, armor);
            }
        }

        public Armor GetArmor(string name)
        {
            if (armors.ContainsKey(name))
            {
                return (Armor)armors[name].Clone();
            }

            return null;
        }

        public bool ContainsArmor(string name)
        {
            return armors.ContainsKey(name);
        }

        #endregion

        #region Shield methods

        public void AddShield(Shield shield)
        {
            if (!shields.ContainsKey(shield.Name))
            {
                shields.Add(shield.Name, shield);
            }
        }

        public Shield GetShield(string name)
        {
            if (shields.ContainsKey(name))
            {
                return (Shield)shields[name].Clone();
            }

            return null;
        }

        public bool ContainsShield(string name)
        {
            return shields.ContainsKey(name);
        }

        #endregion
    }
}

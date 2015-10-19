﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RpgLibrary.ItemClasses
{
    public class ItemDataManager
    {
        #region Field region

        readonly Dictionary<string, ArmorData> armorData = new Dictionary<string, ArmorData>();
        readonly Dictionary<string, ShieldData> shieldData = new Dictionary<string, ShieldData>();
        readonly Dictionary<string, WeaponData> weaponData = new Dictionary<string, WeaponData>();
        readonly Dictionary<string, IngredientData> ingredientData = new Dictionary<string, IngredientData>();
        readonly Dictionary<string, KeyData> keyData = new Dictionary<string, KeyData>();
        readonly Dictionary<string, ChestData> chestData = new Dictionary<string, ChestData>();

        #endregion

        #region Property region

        public Dictionary<string, ArmorData> ArmorData
        {
            get
            {
                return armorData;
            }
        }

        public Dictionary<string, ShieldData> ShieldData
        {
            get
            {
                return shieldData;
            }
        }

        public Dictionary<string, WeaponData> WeaponData
        {
            get
            {
                return weaponData;
            }
        }

        public Dictionary<string, IngredientData> IngredientData
        {
            get
            {
                return ingredientData;
            }
        }

        public Dictionary<string, KeyData> KeyData
        {
            get
            {
                return keyData;
            }
        }

        public Dictionary<string, ChestData> ChestData
        {
            get
            {
                return chestData;
            }
        }

        #endregion

        #region Constructor region



        #endregion

        #region Method region



        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RpgLibrary.CharacterClasses
{
    public enum EntityGender { Male, Female, Unknown };

    public abstract class Entity
    {
        #region Vital Field and Property region

        protected string entityType;
        protected EntityGender gender;

        public string EntityType
        {
            get
            {
                return entityType;
            }
        }

        public EntityGender Gender
        {
            get
            {
                return gender;
            }
            protected set
            {
                gender = value;
            }
        }

        #endregion

        #region Basic Attribute and Property region

        protected int strength;
        protected int dexterity;
        protected int intelligence;
        protected int agility;
        protected int wisdom;
        protected int vitality;

        protected int strengthModifier;
        protected int dexterityModifier;
        protected int intelligenceModifier;
        protected int agilityModifier;
        protected int wisdomModifier;
        protected int vitalityModifier;

        public int Strength
        {
            get
            {
                return strength + strengthModifier;
            }
            protected set
            {
                strength = value;
            }
        }

        public int Dexterity
        {
            get
            {
                return dexterity + dexterityModifier;
            }
            protected set
            {
                dexterity = value;
            }
        }

        public int Intelligence
        {
            get
            {
                return intelligence + intelligenceModifier;
            }
            protected set
            {
                intelligence = value;
            }
        }

        public int Agility
        {
            get
            {
                return agility + agilityModifier;
            }
            protected set
            {
                agility = value;
            }
        }

        public int Wisdom
        {
            get
            {
                return wisdom + wisdomModifier;
            }
            protected set
            {
                wisdom = value;
            }
        }

        public int Vitality
        {
            get
            {
                return vitality + vitalityModifier;
            }
            protected set
            {
                vitality = value;
            }
        }

        #endregion

        #region Calculated Attribute Field and Property region

        protected AttributePair health;
        protected AttributePair stamina;
        protected AttributePair mana;

        public AttributePair Health
        {
            get
            {
                return health;
            }
        }

        public AttributePair Stamina
        {
            get
            {
                return stamina;
            }
        }

        public AttributePair Mana
        {
            get
            {
                return mana;
            }
        }

        protected int attack;
        protected int damage;
        protected int defense;

        #endregion

        #region Level Field and Property region

        protected int level;
        protected long experience;

        public int Level
        {
            get
            {
                return level;
            }
            protected set
            {
                level = value;
            }
        }

        public long Experience
        {
            get
            {
                return experience;
            }
            protected set
            {
                experience = value;
            }
        }

        #endregion

        #region Constructor region

        private Entity()
        {
            Strength = 0;
            Dexterity = 0;
            Intelligence = 0;
            Agility = 0;
            Wisdom = 0;
            Vitality = 0;

            health = new AttributePair(0);
            stamina = new AttributePair(0);
            mana = new AttributePair(0);
        }

        public Entity(EntityData entityData)
        {
            entityType = entityData.EntityName;
            Strength = entityData.Strength;
            Dexterity = entityData.Dexterity;
            Intelligence = entityData.Intelligence;
            Agility = entityData.Agility;
            Wisdom = entityData.Wisdom;
            vitality = entityData.Vitality;

            health = new AttributePair(0);
            stamina = new AttributePair(0);
            mana = new AttributePair(0);
        }

        #endregion
    }
}

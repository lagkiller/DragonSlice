using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RpgLibrary.CharacterClasses
{
    public enum EntityGender { Male, Female, Unknown };
    public enum EntityType { Character, NPC, Monster, Creature };

    public sealed class Entity
    {
        #region Vital Field and Property region

        private string entityName;
        private string entityClass;
        private EntityGender gender;
        private EntityType entityType;

        public string EntityName
        {
            get
            {
                return entityName;
            }
            private set
            {
                entityName = value;
            }
        }

        public string EntityClass
        {
            get
            {
                return entityClass;
            }
            private set
            {
                entityClass = value;
            }
        }

        public EntityType EntityType
        {
            get
            {
                return entityType;
            }
            private set
            {
                entityType = value;
            }
        }

        public EntityGender Gender
        {
            get
            {
                return gender;
            }
            private set
            {
                gender = value;
            }
        }

        #endregion

        #region Basic Attribute and Property region

        private int strength;
        private int dexterity;
        private int intelligence;
        private int agility;
        private int wisdom;
        private int vitality;

        private int strengthModifier;
        private int dexterityModifier;
        private int intelligenceModifier;
        private int agilityModifier;
        private int wisdomModifier;
        private int vitalityModifier;

        public int Strength
        {
            get
            {
                return strength + strengthModifier;
            }
            private set
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
            private set
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
            private set
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
            private set
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
            private set
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
            private set
            {
                vitality = value;
            }
        }

        #endregion

        #region Calculated Attribute Field and Property region

        private AttributePair health;
        private AttributePair stamina;
        private AttributePair mana;

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

        private int attack;
        private int damage;
        private int defense;

        #endregion

        #region Level Field and Property region

        private int level;
        private long experience;

        public int Level
        {
            get
            {
                return level;
            }
            private set
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
            private set
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

        public Entity(string name, EntityData entityData, EntityGender gender, EntityType entityType)
        {
            EntityName = name;
            EntityClass = entityData.EntityName;
            Gender = gender;
            EntityType = entityType;
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

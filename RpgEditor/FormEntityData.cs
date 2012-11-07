using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using RpgLibrary.CharacterClasses;

namespace RpgEditor
{
    public partial class FormEntityData : Form
    {
        #region Field region

        EntityData entityData = null;

        #endregion

        #region Property region

        public EntityData EntityData
        {
            get
            {
                return entityData;
            }
            set
            {
                entityData = value;
            }
        }

        #endregion

        #region Constructor region

        public FormEntityData()
        {
            InitializeComponent();

            this.Load += new EventHandler(FormEntityData_Load);
            this.FormClosing += new FormClosingEventHandler(FormEntityData_FormClosing);

            btnOK.Click += new EventHandler(btnOK_Click);
            btnCancel.Click +=new EventHandler(btnCancel_Click);
        }

        #endregion

        #region Event Handler region

        void FormEntityData_Load(object sender, EventArgs e)
        {
            if (entityData != null)
            {
                tbName.Text = entityData.EntityName;
                mtbStrength.Text = entityData.Strength.ToString();
                mtbDexterity.Text = entityData.Dexterity.ToString();
                mtbIntelligence.Text = entityData.Intelligence.ToString();
                mtbAgility.Text = entityData.Agility.ToString();
                mtbWisdom.Text = entityData.Wisdom.ToString();
                mtbVitality.Text = entityData.Vitality.ToString();
                tbHealth.Text = entityData.HealthFormula;
                tbStamina.Text = entityData.StaminaFormula;
                tbMana.Text = entityData.ManaFormula;
            }
        }

        void FormEntityData_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }

        void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbName.Text) || string.IsNullOrEmpty(tbHealth.Text) ||
                string.IsNullOrEmpty(tbStamina.Text) || string.IsNullOrEmpty(tbMana.Text))
            {
                MessageBox.Show("Name, Health Formula, Stamina Formula, and Mana Formula must not be blank");
                return;
            }

            int str = 0;
            int dex = 0;
            int inte = 0;
            int agi = 0;
            int wis = 0;
            int vit = 0;

            if (!int.TryParse(mtbStrength.Text, out str))
            {
                MessageBox.Show("Strength must not be blank");
                return;
            }

            if (!int.TryParse(mtbDexterity.Text, out dex))
            {
                MessageBox.Show("Dexterity must not be blank");
                return;
            }

            if (!int.TryParse(mtbIntelligence.Text, out inte))
            {
                MessageBox.Show("Intelligence must not be blank");
                return;
            }

            if (!int.TryParse(mtbAgility.Text, out agi))
            {
                MessageBox.Show("Agility must not be blank");
                return;
            }

            if (!int.TryParse(mtbWisdom.Text, out wis))
            {
                MessageBox.Show("Wisdom must not be blank");
                return;
            }

            if (!int.TryParse(mtbVitality.Text, out vit))
            {
                MessageBox.Show("Vitality must not be blank");
                return;
            }

            entityData = new EntityData(
                tbName.Text,
                str,
                dex,
                inte,
                agi,
                wis,
                vit,
                tbHealth.Text,
                tbStamina.Text,
                tbMana.Text);

            this.FormClosing -= FormEntityData_FormClosing;
            this.Close();
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            entityData = null;

            this.FormClosing -= FormEntityData_FormClosing;
            this.Close();
        }

        #endregion
    }
}

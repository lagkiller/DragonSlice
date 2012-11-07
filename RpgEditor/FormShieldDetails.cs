using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using RpgLibrary.ItemClasses;

namespace RpgEditor
{
    public partial class FormShieldDetails : Form
    {
        #region Field region

        ShieldData shield = null;

        #endregion

        #region Property region

        public ShieldData Shield
        {
            get
            {
                return shield;
            }
            set
            {
                shield = value;
            }
        }

        #endregion

        #region Constructor region

        public FormShieldDetails()
        {
            InitializeComponent();

            this.Load += new EventHandler(FormShieldDetails_Load);
            this.FormClosing += new FormClosingEventHandler(FormShieldDetails_FormClosing);

            btnMoveAllowed.Click += new EventHandler(btnMoveAllowed_Click);
            btnRemoveAllowed.Click += new EventHandler(btnRemoveAllowed_Click);
            btnOK.Click += new EventHandler(btnOK_Click);
            btnCancel.Click += new EventHandler(btnCancel_Click);
        }

        #endregion

        #region Event Handler region

        void btnCancel_Click(object sender, EventArgs e)
        {
            shield = null;

            this.FormClosing -= FormShieldDetails_FormClosing;
            this.Close();
        }

        void btnOK_Click(object sender, EventArgs e)
        {
            int price = 0;
            float weight = 0f;
            int defVal = 0;
            int defMod = 0;

            if (string.IsNullOrEmpty(tbName.Text))
            {
                MessageBox.Show("Name must not be blank.");
            }

            if (!int.TryParse(mtbPrice.Text, out price))
            {
                MessageBox.Show("Price must not be blank.");
            }

            weight = (float)nudWeight.Value;

            if (!int.TryParse(mtbDefenseValue.Text, out defVal))
            {
                MessageBox.Show("Defense Value must not be blank.");
            }

            if (!int.TryParse(mtbDefenseModifier.Text, out defMod))
            {
                MessageBox.Show("Defense Modifier must not be blank.");
            }

            List<string> allowedClasses = new List<string>();

            foreach (object o in lbAllowedClasses.Items)
            {
                allowedClasses.Add(o.ToString());
            }

            shield = new ShieldData();
            shield.Name = tbName.Text;
            shield.Type = tbType.Text;
            shield.Price = price;
            shield.Weight = weight;
            shield.DefenseValue = defVal;
            shield.DefenseModifier = defMod;
            shield.AllowableClasses = allowedClasses.ToArray();

            this.FormClosing -= FormShieldDetails_FormClosing;
            this.Close();
        }

        void FormShieldDetails_Load(object sender, EventArgs e)
        {
            foreach (string s in FormDetails.EntityDataManager.EntityData.Keys)
            {
                lbClasses.Items.Add(s);
            }

            if (shield != null)
            {
                tbName.Text = shield.Name;
                tbType.Text = shield.Type;
                mtbPrice.Text = shield.Price.ToString();
                nudWeight.Value = (decimal)shield.Weight;
                mtbDefenseValue.Text = shield.DefenseValue.ToString();
                mtbDefenseModifier.Text = shield.DefenseModifier.ToString();

                foreach (string s in shield.AllowableClasses)
                {
                    if (lbClasses.Items.Contains(s))
                    {
                        lbClasses.Items.Remove(s);
                    }

                    lbAllowedClasses.Items.Add(s);
                }
            }
        }

        void FormShieldDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }

        void btnRemoveAllowed_Click(object sender, EventArgs e)
        {
            if (lbAllowedClasses.SelectedItem != null)
            {
                lbClasses.Items.Add(lbAllowedClasses.SelectedItem);
                lbAllowedClasses.Items.RemoveAt(lbAllowedClasses.SelectedIndex);
            }
        }

        void btnMoveAllowed_Click(object sender, EventArgs e)
        {
            if (lbClasses.SelectedItem != null)
            {
                lbAllowedClasses.Items.Add(lbClasses.SelectedItem);
                lbClasses.Items.RemoveAt(lbClasses.SelectedIndex);
            }
        }

        #endregion
    }
}

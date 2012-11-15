using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using XRpgLibrary.SkillClasses;

namespace RpgEditor
{
    public partial class FormSkillDetails : Form
    {
        #region Field region

        SkillData skill;

        #endregion

        #region Property region

        public SkillData Skill
        {
            get
            {
                return skill;
            }
            set
            {
                skill = value;
            }
        }

        #endregion

        #region Constructor region

        public FormSkillDetails()
        {
            InitializeComponent();

            this.Load += new EventHandler(FormSkillDetails_Load);
            this.FormClosing += new FormClosingEventHandler(FormSkillDetails_FormClosing);

            btnOK.Click += new EventHandler(btnOK_Click);
            btnCancel.Click += new EventHandler(btnCancel_Click);
        }

        #endregion

        #region Form Event Handler region

        void FormSkillDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }

        void FormSkillDetails_Load(object sender, EventArgs e)
        {
            if (Skill != null)
            {
                tbName.Text = Skill.Name;
                switch (Skill.PrimaryAttribute.ToLower())
                {
                    case "strength":
                        rbStrength.Checked = true;
                        break;
                    case "dexterity":
                        rbDexterity.Checked = true;
                        break;
                    case "intelligence":
                        rbIntelligence.Checked = true;
                        break;
                    case "agility":
                        rbAgility.Checked = true;
                        break;
                    case "wisdom":
                        rbWisdom.Checked = true;
                        break;
                    case "vitality":
                        rbVitality.Checked = true;
                        break;
                }

                foreach (string s in Skill.ClassModifiers.Keys)
                {
                    string data = s + ", " + Skill.ClassModifiers[s].ToString();
                    lbModifiers.Items.Add(data);
                }
            }
        }

        #endregion

        #region Button Event Handler region

        void btnCancel_Click(object sender, EventArgs e)
        {
            skill = null;
            this.FormClosing -= FormSkillDetails_FormClosing;
            this.Close();
        }

        void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbName.Text))
            {
                MessageBox.Show("You must give the skill a name.");
                return;
            }
            SkillData newSkill = new SkillData();
            newSkill.Name = tbName.Text;
            if (rbStrength.Checked)
            {
                newSkill.PrimaryAttribute = "Strength";
            }
            else if (rbDexterity.Checked)
            {
                newSkill.PrimaryAttribute = "Dexterity";
            }
            else if (rbIntelligence.Checked)
            {
                newSkill.PrimaryAttribute = "Intelligence";
            }
            else if (rbAgility.Checked)
            {
                newSkill.PrimaryAttribute = "Agility";
            }
            else if (rbWisdom.Checked)
            {
                newSkill.PrimaryAttribute = "Wisdom";
            }
            else if (rbVitality.Checked)
            {
                newSkill.PrimaryAttribute = "Vitality";
            }

            skill = newSkill;
            this.FormClosing -= FormSkillDetails_FormClosing;
            this.Close();
        }

        #endregion
    }
}

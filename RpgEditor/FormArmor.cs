using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RpgEditor
{
    public partial class FormArmor : FormDetails
    {
        #region Field region



        #endregion

        #region Property region



        #endregion

        #region Constructor region

        public FormArmor()
        {
            InitializeComponent();

            btnAdd.Click += new EventHandler(btnAdd_Click);
            btnEdit.Click += new EventHandler(btnEdit_Click);
            btnDelete.Click += new EventHandler(btnDelete_Click);
        }

        #endregion

        #region Button Event Handler region

        void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

        void btnEdit_Click(object sender, EventArgs e)
        {

        }

        void btnAdd_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Method region

        public void FillListBox()
        {
            lbDetails.Items.Clear();

            foreach (string s in FormDetails.ItemManager.ArmorData.Keys)
            {
                lbDetails.Items.Add(FormDetails.ItemManager.ArmorData[s]);
            }
        }

        #endregion
    }
}

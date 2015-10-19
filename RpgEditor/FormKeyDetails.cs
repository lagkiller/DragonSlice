using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using XRpgLibrary.ItemClasses;

namespace RpgEditor
{
    public partial class FormKeyDetails : Form
    {
        #region Field region

        KeyData key;

        #endregion

        #region Property region

        public KeyData Key
        {
            get
            {
                return key;
            }
            set
            {
                key = value;
            }
        }

        #endregion

        #region Constructor region

        public FormKeyDetails()
        {
            InitializeComponent();

            this.Load += new EventHandler(FormKeyDetails_Load);
            this.FormClosing += new FormClosingEventHandler(FormKeyDetails_FormClosing);

            btnOK.Click += new EventHandler(btnOK_Click);
            btnCancel.Click += new EventHandler(btnCancel_Click);
        }

        #endregion

        #region Event Handler region

        void btnCancel_Click(object sender, EventArgs e)
        {
            key = null;
            this.FormClosing -= FormKeyDetails_FormClosing;
            this.Close();
        }

        void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbName.Text))
            {
                MessageBox.Show("You must give the key a name.");
                return;
            }

            key = new KeyData();
            key.Name = tbName.Text;
            key.Type = tbType.Text;

            this.FormClosing -= FormKeyDetails_FormClosing;
            this.Close();
        }

        void FormKeyDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }

        void FormKeyDetails_Load(object sender, EventArgs e)
        {
            if (key != null)
            {
                tbName.Text = key.Name;
                tbType.Text = key.Type;
            }
        }

        #endregion
    }
}

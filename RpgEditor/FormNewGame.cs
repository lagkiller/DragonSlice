﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using XRpgLibrary;

namespace RpgEditor
{
    public partial class FormNewGame : Form
    {
        #region Field region

        RolePlayingGame rpg;

        #endregion

        #region Property region

        public RolePlayingGame RolePlayingGame
        {
            get
            {
                return rpg;
            }
        }

        #endregion

        #region Constructor region

        public FormNewGame()
        {
            InitializeComponent();
            btnOK.Click += new EventHandler(btnOK_Click);
        }

        #endregion

        #region Event Handler region

        void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbName.Text) || string.IsNullOrEmpty(tbDescription.Text))
            {
                MessageBox.Show("You must enter a name and description", "Error");
                return;
            }

            rpg = new RolePlayingGame(tbName.Text, tbDescription.Text);

            this.Close();
        }

        #endregion
    }
}

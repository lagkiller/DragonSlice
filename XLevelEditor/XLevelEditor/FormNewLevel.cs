using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using XRpgLibrary.WorldClasses;

namespace XLevelEditor
{
    public partial class FormNewLevel : Form
    {
        #region Field region

        bool okPressed;
        LevelData levelData;

        #endregion

        #region Property region

        public bool OKPressed
        {
            get
            {
                return okPressed;
            }
        }

        public LevelData LevelData
        {
            get
            {
                return levelData;
            }
        }

        #endregion

        #region Constructor region

        public FormNewLevel()
        {
            InitializeComponent();

            btnOK.Click += new EventHandler(btnOK_Click);
            btnCancel.Click += new EventHandler(btnCancel_Click);

            SetDefaultValues();
        }

        private void SetDefaultValues()
        {
            tbLevelName.Text = "New Level";
            tbMapName.Text = "New Map";
            mtbWidth.Text = "100";
            mtbHeight.Text = "100";
        }

        #endregion

        #region Button Event Handler region

        void btnCancel_Click(object sender, EventArgs e)
        {
            okPressed = false;
            this.Close();
        }

        void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbLevelName.Text))
            {
                MessageBox.Show("You must enter a level name.", "Missing Level Name");
                return;
            }
            if (string.IsNullOrEmpty(tbMapName.Text))
            {
                MessageBox.Show("You must enter a map name.", "Missing Map Name");
                return;
            }
            int mapWidth = 0;
            int mapHeight = 0;
            if (!int.TryParse(mtbWidth.Text, out mapWidth) || mapWidth < 1)
            {
                MessageBox.Show("The width of the map must be greater than or equal to one.", "Map Size Error");
                return;
            }
            if (!int.TryParse(mtbHeight.Text, out mapHeight) || mapHeight < 1)
            {
                MessageBox.Show("The height of the map must be greater than or equal to one.", "Map Size Error");
                return;
            }

            levelData = new XRpgLibrary.WorldClasses.LevelData(
                tbLevelName.Text,
                tbMapName.Text,
                mapWidth,
                mapHeight,
                new List<string>(),
                new List<string>(),
                new List<string>());

            okPressed = true;
            this.Close();
        }

        #endregion

        #region Virtual Method region



        #endregion
    }
}

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
    public partial class FormNewLayer : Form
    {
        #region Field region

        bool okPressed;

        int LayerWidth;
        int LayerHeight;

        MapLayerData mapLayerData;

        #endregion

        #region Property region

        public bool OKPressed
        {
            get
            {
                return okPressed;
            }
        }

        public MapLayerData MapLayerData
        {
            get
            {
                return mapLayerData;
            }
        }

        #endregion

        #region Constructor region

        public FormNewLayer(int width, int height)
        {
            InitializeComponent();

            LayerWidth = width;
            LayerHeight = height;

            btnOK.Click += new EventHandler(btnOK_Click);
            btnCancel.Click += new EventHandler(btnCancel_Click);
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
            if (string.IsNullOrEmpty(tbLayerName.Text))
            {
                MessageBox.Show("You must enter a layer name.", "Missing Layer Name");
                return;
            }

            if (cbFill.Checked)
            {
                mapLayerData = new MapLayerData(
                    tbLayerName.Text,
                    LayerWidth,
                    LayerHeight,
                    (int)nudTile.Value,
                    (int)nudTileset.Value);
            }
            else
            {
                mapLayerData = new MapLayerData(
                    tbLayerName.Text,
                    LayerWidth,
                    LayerHeight);
            }

            okPressed = true;
            this.Close();
        }

        #endregion
    }
}

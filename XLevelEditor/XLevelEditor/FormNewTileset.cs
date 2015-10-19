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
    public partial class FormNewTileset : Form
    {
        #region Field region

        bool okPressed;
        TilesetData tilesetData;

        #endregion

        #region Property region

        public TilesetData TilesetData
        {
            get
            {
                return tilesetData;
            }
        }

        public bool OKPressed
        {
            get
            {
                return okPressed;
            }
        }

        #endregion

        #region Constructor region

        public FormNewTileset()
        {
            InitializeComponent();

            btnSelectImage.Click += new EventHandler(btnSelectImage_Click);
            btnOK.Click += new EventHandler(btnOK_Click);
            btnCancel.Click += new EventHandler(btnCancel_Click);

            SetDefaultValues();
        }

        private void SetDefaultValues()
        {
            tbTilesetName.Text = "New Tileset";
            mtbTileWidth.Text = "32";
            mtbTileHeight.Text = "32";
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
            if (string.IsNullOrEmpty(tbTilesetName.Text))
            {
                MessageBox.Show("You must enter a tileset name.");
            }

            if (string.IsNullOrEmpty(tbTilesetImage.Text))
            {
                MessageBox.Show("You must select a tileset image.");
                return;
            }

            int tileWidth = 0;
            int tileHeight = 0;
            int tilesWide = 0;
            int tilesHigh = 0;

            if (!int.TryParse(mtbTileWidth.Text, out tileWidth))
            {
                MessageBox.Show("You must enter a tile width.");
                return;
            }
            else if (tileWidth < 1)
            {
                MessageBox.Show("Tile width must be greater than zero.");
                return;
            }

            if (!int.TryParse(mtbTileHeight.Text, out tileHeight))
            {
                MessageBox.Show("You must enter a tile height.");
                return;
            }
            else if (tileHeight < 1)
            {
                MessageBox.Show("Tile height must be greater than zero.");
                return;
            }

            Image tileSet = (Image)Bitmap.FromFile(tbTilesetImage.Text);
            tilesWide = tileSet.Width / tileWidth;
            tilesHigh = tileSet.Height / tileHeight;

            tilesetData = new TilesetData();

            tilesetData.TilesetName = tbTilesetName.Text;
            tilesetData.TilesetImageName = tbTilesetImage.Text;
            tilesetData.TileWidthInPixels = tileWidth;
            tilesetData.TileHeightInPixels = tileHeight;
            tilesetData.TilesWide = tilesWide;
            tilesetData.TilesHigh = tilesHigh;

            okPressed = true;
            this.Close();
        }

        void btnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofDialog = new OpenFileDialog();
            ofDialog.Filter = "Image Files|*.BMP;*.GIF;*.JPG;*.TGA;*.PNG";
            ofDialog.CheckFileExists = true;
            ofDialog.CheckPathExists = true;
            ofDialog.Multiselect = false;

            DialogResult result = ofDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                tbTilesetImage.Text = ofDialog.FileName;
            }
        }

        #endregion

        #region Virtual Method region



        #endregion
    }
}

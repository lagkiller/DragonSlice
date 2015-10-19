namespace XLevelEditor
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.levelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tilesetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTilesetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTilesetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTilesetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeTilesetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapLayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newLayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openLayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveLayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.charactersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabProperties = new System.Windows.Forms.TabControl();
            this.tabTilesets = new System.Windows.Forms.TabPage();
            this.lbTileset = new System.Windows.Forms.ListBox();
            this.pbTilesetPreview = new System.Windows.Forms.PictureBox();
            this.lblTilesets = new System.Windows.Forms.Label();
            this.lblCurrentTileset = new System.Windows.Forms.Label();
            this.nudCurrentTile = new System.Windows.Forms.NumericUpDown();
            this.gbDrawMode = new System.Windows.Forms.GroupBox();
            this.rbErase = new System.Windows.Forms.RadioButton();
            this.rbDraw = new System.Windows.Forms.RadioButton();
            this.pbTilePreview = new System.Windows.Forms.PictureBox();
            this.lblTile = new System.Windows.Forms.Label();
            this.tabLayers = new System.Windows.Forms.TabPage();
            this.clbLayers = new System.Windows.Forms.CheckedListBox();
            this.tabCharacters = new System.Windows.Forms.TabPage();
            this.tabChests = new System.Windows.Forms.TabPage();
            this.tabKeys = new System.Windows.Forms.TabPage();
            this.controlTimer = new System.Windows.Forms.Timer(this.components);
            this.lblCursor = new System.Windows.Forms.Label();
            this.tbMapLocation = new System.Windows.Forms.TextBox();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brushesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yellowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapDisplay = new XLevelEditor.MapDisplay();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabProperties.SuspendLayout();
            this.tabTilesets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTilesetPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCurrentTile)).BeginInit();
            this.gbDrawMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTilePreview)).BeginInit();
            this.tabLayers.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.levelToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.tilesetToolStripMenuItem,
            this.mapLayerToolStripMenuItem,
            this.charactersToolStripMenuItem,
            this.chestsToolStripMenuItem,
            this.keysToolStripMenuItem,
            this.brushesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // levelToolStripMenuItem
            // 
            this.levelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newLevelToolStripMenuItem,
            this.openLevelToolStripMenuItem,
            this.saveLevelToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.levelToolStripMenuItem.Name = "levelToolStripMenuItem";
            this.levelToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.levelToolStripMenuItem.Text = "&Level";
            // 
            // newLevelToolStripMenuItem
            // 
            this.newLevelToolStripMenuItem.Name = "newLevelToolStripMenuItem";
            this.newLevelToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.newLevelToolStripMenuItem.Text = "&New Level";
            // 
            // openLevelToolStripMenuItem
            // 
            this.openLevelToolStripMenuItem.Name = "openLevelToolStripMenuItem";
            this.openLevelToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.openLevelToolStripMenuItem.Text = "&Open Level";
            // 
            // saveLevelToolStripMenuItem
            // 
            this.saveLevelToolStripMenuItem.Name = "saveLevelToolStripMenuItem";
            this.saveLevelToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.saveLevelToolStripMenuItem.Text = "&Save Level";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(130, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // tilesetToolStripMenuItem
            // 
            this.tilesetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTilesetToolStripMenuItem,
            this.openTilesetToolStripMenuItem,
            this.saveTilesetToolStripMenuItem,
            this.removeTilesetToolStripMenuItem});
            this.tilesetToolStripMenuItem.Name = "tilesetToolStripMenuItem";
            this.tilesetToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.tilesetToolStripMenuItem.Text = "&Tileset";
            // 
            // newTilesetToolStripMenuItem
            // 
            this.newTilesetToolStripMenuItem.Name = "newTilesetToolStripMenuItem";
            this.newTilesetToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.newTilesetToolStripMenuItem.Text = "&New Tileset";
            // 
            // openTilesetToolStripMenuItem
            // 
            this.openTilesetToolStripMenuItem.Name = "openTilesetToolStripMenuItem";
            this.openTilesetToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.openTilesetToolStripMenuItem.Text = "&Open Tileset";
            // 
            // saveTilesetToolStripMenuItem
            // 
            this.saveTilesetToolStripMenuItem.Name = "saveTilesetToolStripMenuItem";
            this.saveTilesetToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.saveTilesetToolStripMenuItem.Text = "&Save Tileset";
            // 
            // removeTilesetToolStripMenuItem
            // 
            this.removeTilesetToolStripMenuItem.Name = "removeTilesetToolStripMenuItem";
            this.removeTilesetToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.removeTilesetToolStripMenuItem.Text = "&Remove Tileset";
            // 
            // mapLayerToolStripMenuItem
            // 
            this.mapLayerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newLayerToolStripMenuItem,
            this.openLayerToolStripMenuItem,
            this.saveLayerToolStripMenuItem});
            this.mapLayerToolStripMenuItem.Name = "mapLayerToolStripMenuItem";
            this.mapLayerToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.mapLayerToolStripMenuItem.Text = "&Map Layer";
            // 
            // newLayerToolStripMenuItem
            // 
            this.newLayerToolStripMenuItem.Name = "newLayerToolStripMenuItem";
            this.newLayerToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.newLayerToolStripMenuItem.Text = "&New Layer";
            // 
            // openLayerToolStripMenuItem
            // 
            this.openLayerToolStripMenuItem.Name = "openLayerToolStripMenuItem";
            this.openLayerToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.openLayerToolStripMenuItem.Text = "&Open Layer";
            // 
            // saveLayerToolStripMenuItem
            // 
            this.saveLayerToolStripMenuItem.Name = "saveLayerToolStripMenuItem";
            this.saveLayerToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.saveLayerToolStripMenuItem.Text = "&Save Layer";
            // 
            // charactersToolStripMenuItem
            // 
            this.charactersToolStripMenuItem.Name = "charactersToolStripMenuItem";
            this.charactersToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.charactersToolStripMenuItem.Text = "&Characters";
            // 
            // chestsToolStripMenuItem
            // 
            this.chestsToolStripMenuItem.Name = "chestsToolStripMenuItem";
            this.chestsToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.chestsToolStripMenuItem.Text = "C&hests";
            // 
            // keysToolStripMenuItem
            // 
            this.keysToolStripMenuItem.Name = "keysToolStripMenuItem";
            this.keysToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.keysToolStripMenuItem.Text = "&Keys";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.mapDisplay);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabProperties);
            this.splitContainer1.Size = new System.Drawing.Size(1008, 658);
            this.splitContainer1.SplitterDistance = 800;
            this.splitContainer1.TabIndex = 1;
            // 
            // tabProperties
            // 
            this.tabProperties.Controls.Add(this.tabTilesets);
            this.tabProperties.Controls.Add(this.tabLayers);
            this.tabProperties.Controls.Add(this.tabCharacters);
            this.tabProperties.Controls.Add(this.tabChests);
            this.tabProperties.Controls.Add(this.tabKeys);
            this.tabProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabProperties.Location = new System.Drawing.Point(0, 0);
            this.tabProperties.Name = "tabProperties";
            this.tabProperties.SelectedIndex = 0;
            this.tabProperties.Size = new System.Drawing.Size(204, 658);
            this.tabProperties.TabIndex = 1;
            // 
            // tabTilesets
            // 
            this.tabTilesets.Controls.Add(this.tbMapLocation);
            this.tabTilesets.Controls.Add(this.lblCursor);
            this.tabTilesets.Controls.Add(this.lbTileset);
            this.tabTilesets.Controls.Add(this.pbTilesetPreview);
            this.tabTilesets.Controls.Add(this.lblTilesets);
            this.tabTilesets.Controls.Add(this.lblCurrentTileset);
            this.tabTilesets.Controls.Add(this.nudCurrentTile);
            this.tabTilesets.Controls.Add(this.gbDrawMode);
            this.tabTilesets.Controls.Add(this.pbTilePreview);
            this.tabTilesets.Controls.Add(this.lblTile);
            this.tabTilesets.Location = new System.Drawing.Point(4, 22);
            this.tabTilesets.Name = "tabTilesets";
            this.tabTilesets.Size = new System.Drawing.Size(196, 632);
            this.tabTilesets.TabIndex = 0;
            this.tabTilesets.Text = "Tiles";
            this.tabTilesets.UseVisualStyleBackColor = true;
            // 
            // lbTileset
            // 
            this.lbTileset.FormattingEnabled = true;
            this.lbTileset.Location = new System.Drawing.Point(7, 352);
            this.lbTileset.Name = "lbTileset";
            this.lbTileset.Size = new System.Drawing.Size(180, 212);
            this.lbTileset.TabIndex = 6;
            // 
            // pbTilesetPreview
            // 
            this.pbTilesetPreview.Location = new System.Drawing.Point(7, 138);
            this.pbTilesetPreview.Name = "pbTilesetPreview";
            this.pbTilesetPreview.Size = new System.Drawing.Size(180, 180);
            this.pbTilesetPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTilesetPreview.TabIndex = 5;
            this.pbTilesetPreview.TabStop = false;
            // 
            // lblTilesets
            // 
            this.lblTilesets.Location = new System.Drawing.Point(7, 321);
            this.lblTilesets.Name = "lblTilesets";
            this.lblTilesets.Size = new System.Drawing.Size(180, 23);
            this.lblTilesets.TabIndex = 4;
            this.lblTilesets.Text = "Tilesets";
            this.lblTilesets.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCurrentTileset
            // 
            this.lblCurrentTileset.Location = new System.Drawing.Point(7, 112);
            this.lblCurrentTileset.Name = "lblCurrentTileset";
            this.lblCurrentTileset.Size = new System.Drawing.Size(180, 23);
            this.lblCurrentTileset.TabIndex = 4;
            this.lblCurrentTileset.Text = "Current Tileset";
            this.lblCurrentTileset.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nudCurrentTile
            // 
            this.nudCurrentTile.Location = new System.Drawing.Point(7, 83);
            this.nudCurrentTile.Name = "nudCurrentTile";
            this.nudCurrentTile.Size = new System.Drawing.Size(180, 20);
            this.nudCurrentTile.TabIndex = 3;
            // 
            // gbDrawMode
            // 
            this.gbDrawMode.Controls.Add(this.rbErase);
            this.gbDrawMode.Controls.Add(this.rbDraw);
            this.gbDrawMode.Location = new System.Drawing.Point(63, 7);
            this.gbDrawMode.Name = "gbDrawMode";
            this.gbDrawMode.Size = new System.Drawing.Size(128, 70);
            this.gbDrawMode.TabIndex = 2;
            this.gbDrawMode.TabStop = false;
            this.gbDrawMode.Text = "Draw Mode";
            // 
            // rbErase
            // 
            this.rbErase.AutoSize = true;
            this.rbErase.Location = new System.Drawing.Point(7, 43);
            this.rbErase.Name = "rbErase";
            this.rbErase.Size = new System.Drawing.Size(52, 17);
            this.rbErase.TabIndex = 0;
            this.rbErase.Text = "Erase";
            this.rbErase.UseVisualStyleBackColor = true;
            // 
            // rbDraw
            // 
            this.rbDraw.AutoSize = true;
            this.rbDraw.Checked = true;
            this.rbDraw.Location = new System.Drawing.Point(7, 20);
            this.rbDraw.Name = "rbDraw";
            this.rbDraw.Size = new System.Drawing.Size(50, 17);
            this.rbDraw.TabIndex = 0;
            this.rbDraw.TabStop = true;
            this.rbDraw.Text = "Draw";
            this.rbDraw.UseVisualStyleBackColor = true;
            // 
            // pbTilePreview
            // 
            this.pbTilePreview.Location = new System.Drawing.Point(7, 27);
            this.pbTilePreview.Name = "pbTilePreview";
            this.pbTilePreview.Size = new System.Drawing.Size(50, 50);
            this.pbTilePreview.TabIndex = 1;
            this.pbTilePreview.TabStop = false;
            // 
            // lblTile
            // 
            this.lblTile.Location = new System.Drawing.Point(7, 7);
            this.lblTile.Name = "lblTile";
            this.lblTile.Size = new System.Drawing.Size(50, 17);
            this.lblTile.TabIndex = 0;
            this.lblTile.Text = "Tile";
            this.lblTile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabLayers
            // 
            this.tabLayers.Controls.Add(this.clbLayers);
            this.tabLayers.Location = new System.Drawing.Point(4, 22);
            this.tabLayers.Name = "tabLayers";
            this.tabLayers.Size = new System.Drawing.Size(196, 632);
            this.tabLayers.TabIndex = 1;
            this.tabLayers.Text = "Map Layers";
            this.tabLayers.UseVisualStyleBackColor = true;
            // 
            // clbLayers
            // 
            this.clbLayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbLayers.FormattingEnabled = true;
            this.clbLayers.Location = new System.Drawing.Point(0, 0);
            this.clbLayers.Name = "clbLayers";
            this.clbLayers.Size = new System.Drawing.Size(196, 632);
            this.clbLayers.TabIndex = 0;
            // 
            // tabCharacters
            // 
            this.tabCharacters.Location = new System.Drawing.Point(4, 22);
            this.tabCharacters.Name = "tabCharacters";
            this.tabCharacters.Size = new System.Drawing.Size(196, 632);
            this.tabCharacters.TabIndex = 2;
            this.tabCharacters.Text = "Characters";
            this.tabCharacters.UseVisualStyleBackColor = true;
            // 
            // tabChests
            // 
            this.tabChests.Location = new System.Drawing.Point(4, 22);
            this.tabChests.Name = "tabChests";
            this.tabChests.Size = new System.Drawing.Size(196, 632);
            this.tabChests.TabIndex = 3;
            this.tabChests.Text = "Chests";
            this.tabChests.UseVisualStyleBackColor = true;
            // 
            // tabKeys
            // 
            this.tabKeys.Location = new System.Drawing.Point(4, 22);
            this.tabKeys.Name = "tabKeys";
            this.tabKeys.Size = new System.Drawing.Size(196, 632);
            this.tabKeys.TabIndex = 4;
            this.tabKeys.Text = "Keys";
            this.tabKeys.UseVisualStyleBackColor = true;
            // 
            // lblCursor
            // 
            this.lblCursor.Location = new System.Drawing.Point(8, 567);
            this.lblCursor.Name = "lblCursor";
            this.lblCursor.Size = new System.Drawing.Size(180, 23);
            this.lblCursor.TabIndex = 7;
            this.lblCursor.Text = "Map Location";
            this.lblCursor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbMapLocation
            // 
            this.tbMapLocation.Enabled = false;
            this.tbMapLocation.Location = new System.Drawing.Point(8, 590);
            this.tbMapLocation.Name = "tbMapLocation";
            this.tbMapLocation.Size = new System.Drawing.Size(180, 20);
            this.tbMapLocation.TabIndex = 8;
            this.tbMapLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayGridToolStripMenuItem,
            this.gridColorToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // displayGridToolStripMenuItem
            // 
            this.displayGridToolStripMenuItem.Checked = true;
            this.displayGridToolStripMenuItem.CheckOnClick = true;
            this.displayGridToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.displayGridToolStripMenuItem.Name = "displayGridToolStripMenuItem";
            this.displayGridToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.displayGridToolStripMenuItem.Text = "&Display Grid";
            // 
            // brushesToolStripMenuItem
            // 
            this.brushesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x1ToolStripMenuItem,
            this.x2ToolStripMenuItem,
            this.x4ToolStripMenuItem,
            this.x8ToolStripMenuItem});
            this.brushesToolStripMenuItem.Name = "brushesToolStripMenuItem";
            this.brushesToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.brushesToolStripMenuItem.Text = "&Brushes";
            // 
            // x1ToolStripMenuItem
            // 
            this.x1ToolStripMenuItem.Checked = true;
            this.x1ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.x1ToolStripMenuItem.Name = "x1ToolStripMenuItem";
            this.x1ToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.x1ToolStripMenuItem.Text = "1 x 1";
            // 
            // x2ToolStripMenuItem
            // 
            this.x2ToolStripMenuItem.Name = "x2ToolStripMenuItem";
            this.x2ToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.x2ToolStripMenuItem.Text = "2 x 2";
            // 
            // x4ToolStripMenuItem
            // 
            this.x4ToolStripMenuItem.Name = "x4ToolStripMenuItem";
            this.x4ToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.x4ToolStripMenuItem.Text = "4 x 4";
            // 
            // x8ToolStripMenuItem
            // 
            this.x8ToolStripMenuItem.Name = "x8ToolStripMenuItem";
            this.x8ToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.x8ToolStripMenuItem.Text = "8 x 8";
            // 
            // gridColorToolStripMenuItem
            // 
            this.gridColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blackToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.redToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.yellowToolStripMenuItem,
            this.whiteToolStripMenuItem});
            this.gridColorToolStripMenuItem.Name = "gridColorToolStripMenuItem";
            this.gridColorToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.gridColorToolStripMenuItem.Text = "&Grid Color";
            // 
            // blackToolStripMenuItem
            // 
            this.blackToolStripMenuItem.Checked = true;
            this.blackToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.blackToolStripMenuItem.Name = "blackToolStripMenuItem";
            this.blackToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.blackToolStripMenuItem.Text = "&Black";
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.blueToolStripMenuItem.Text = "B&lue";
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.redToolStripMenuItem.Text = "R&ed";
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.greenToolStripMenuItem.Text = "&Green";
            // 
            // yellowToolStripMenuItem
            // 
            this.yellowToolStripMenuItem.Name = "yellowToolStripMenuItem";
            this.yellowToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.yellowToolStripMenuItem.Text = "&Yellow";
            // 
            // whiteToolStripMenuItem
            // 
            this.whiteToolStripMenuItem.Name = "whiteToolStripMenuItem";
            this.whiteToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.whiteToolStripMenuItem.Text = "&White";
            // 
            // mapDisplay
            // 
            this.mapDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapDisplay.Location = new System.Drawing.Point(0, 0);
            this.mapDisplay.Name = "mapDisplay";
            this.mapDisplay.Size = new System.Drawing.Size(800, 658);
            this.mapDisplay.TabIndex = 0;
            this.mapDisplay.Text = "mapDisplay1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 682);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabProperties.ResumeLayout(false);
            this.tabTilesets.ResumeLayout(false);
            this.tabTilesets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTilesetPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCurrentTile)).EndInit();
            this.gbDrawMode.ResumeLayout(false);
            this.gbDrawMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTilePreview)).EndInit();
            this.tabLayers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem levelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tilesetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTilesetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openTilesetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTilesetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeTilesetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mapLayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newLayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openLayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveLayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem charactersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keysToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MapDisplay mapDisplay;
        private System.Windows.Forms.TabControl tabProperties;
        private System.Windows.Forms.TabPage tabTilesets;
        private System.Windows.Forms.Label lblCurrentTileset;
        private System.Windows.Forms.NumericUpDown nudCurrentTile;
        private System.Windows.Forms.GroupBox gbDrawMode;
        private System.Windows.Forms.RadioButton rbErase;
        private System.Windows.Forms.RadioButton rbDraw;
        private System.Windows.Forms.PictureBox pbTilePreview;
        private System.Windows.Forms.Label lblTile;
        private System.Windows.Forms.TabPage tabLayers;
        private System.Windows.Forms.TabPage tabCharacters;
        private System.Windows.Forms.TabPage tabChests;
        private System.Windows.Forms.TabPage tabKeys;
        private System.Windows.Forms.ListBox lbTileset;
        private System.Windows.Forms.PictureBox pbTilesetPreview;
        private System.Windows.Forms.Label lblTilesets;
        private System.Windows.Forms.CheckedListBox clbLayers;
        private System.Windows.Forms.Timer controlTimer;
        private System.Windows.Forms.TextBox tbMapLocation;
        private System.Windows.Forms.Label lblCursor;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brushesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yellowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whiteToolStripMenuItem;
    }
}
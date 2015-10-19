﻿namespace XLevelEditor
{
    partial class FormNewLayer
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
            this.lblLayerName = new System.Windows.Forms.Label();
            this.tbLayerName = new System.Windows.Forms.TextBox();
            this.cbFill = new System.Windows.Forms.CheckBox();
            this.gbFillLayer = new System.Windows.Forms.GroupBox();
            this.nudTileset = new System.Windows.Forms.NumericUpDown();
            this.nudTile = new System.Windows.Forms.NumericUpDown();
            this.lblTilesetIndex = new System.Windows.Forms.Label();
            this.lblTileIndex = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbFillLayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTileset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTile)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLayerName
            // 
            this.lblLayerName.AutoSize = true;
            this.lblLayerName.Location = new System.Drawing.Point(27, 15);
            this.lblLayerName.Name = "lblLayerName";
            this.lblLayerName.Size = new System.Drawing.Size(67, 13);
            this.lblLayerName.TabIndex = 0;
            this.lblLayerName.Text = "Layer Name:";
            // 
            // tbLayerName
            // 
            this.tbLayerName.Location = new System.Drawing.Point(100, 12);
            this.tbLayerName.Name = "tbLayerName";
            this.tbLayerName.Size = new System.Drawing.Size(100, 20);
            this.tbLayerName.TabIndex = 1;
            // 
            // cbFill
            // 
            this.cbFill.AutoSize = true;
            this.cbFill.Checked = true;
            this.cbFill.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFill.Location = new System.Drawing.Point(12, 44);
            this.cbFill.Name = "cbFill";
            this.cbFill.Size = new System.Drawing.Size(73, 17);
            this.cbFill.TabIndex = 2;
            this.cbFill.Text = "Fill Layer?";
            this.cbFill.UseVisualStyleBackColor = true;
            // 
            // gbFillLayer
            // 
            this.gbFillLayer.Controls.Add(this.nudTileset);
            this.gbFillLayer.Controls.Add(this.nudTile);
            this.gbFillLayer.Controls.Add(this.lblTilesetIndex);
            this.gbFillLayer.Controls.Add(this.lblTileIndex);
            this.gbFillLayer.Location = new System.Drawing.Point(12, 71);
            this.gbFillLayer.Name = "gbFillLayer";
            this.gbFillLayer.Size = new System.Drawing.Size(210, 79);
            this.gbFillLayer.TabIndex = 3;
            this.gbFillLayer.TabStop = false;
            this.gbFillLayer.Text = "Fill With";
            // 
            // nudTileset
            // 
            this.nudTileset.Location = new System.Drawing.Point(88, 45);
            this.nudTileset.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.nudTileset.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudTileset.Name = "nudTileset";
            this.nudTileset.Size = new System.Drawing.Size(84, 20);
            this.nudTileset.TabIndex = 1;
            this.nudTileset.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // nudTile
            // 
            this.nudTile.Location = new System.Drawing.Point(88, 19);
            this.nudTile.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.nudTile.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudTile.Name = "nudTile";
            this.nudTile.Size = new System.Drawing.Size(84, 20);
            this.nudTile.TabIndex = 1;
            this.nudTile.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // lblTilesetIndex
            // 
            this.lblTilesetIndex.AutoSize = true;
            this.lblTilesetIndex.Location = new System.Drawing.Point(12, 47);
            this.lblTilesetIndex.Name = "lblTilesetIndex";
            this.lblTilesetIndex.Size = new System.Drawing.Size(70, 13);
            this.lblTilesetIndex.TabIndex = 0;
            this.lblTilesetIndex.Text = "Tileset Index:";
            // 
            // lblTileIndex
            // 
            this.lblTileIndex.AutoSize = true;
            this.lblTileIndex.Location = new System.Drawing.Point(26, 21);
            this.lblTileIndex.Name = "lblTileIndex";
            this.lblTileIndex.Size = new System.Drawing.Size(56, 13);
            this.lblTileIndex.TabIndex = 0;
            this.lblTileIndex.Text = "Tile Index:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(30, 167);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(125, 167);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FormNewLayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 202);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gbFillLayer);
            this.Controls.Add(this.cbFill);
            this.Controls.Add(this.tbLayerName);
            this.Controls.Add(this.lblLayerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormNewLayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Layer";
            this.gbFillLayer.ResumeLayout(false);
            this.gbFillLayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTileset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLayerName;
        private System.Windows.Forms.TextBox tbLayerName;
        private System.Windows.Forms.CheckBox cbFill;
        private System.Windows.Forms.GroupBox gbFillLayer;
        private System.Windows.Forms.NumericUpDown nudTileset;
        private System.Windows.Forms.NumericUpDown nudTile;
        private System.Windows.Forms.Label lblTilesetIndex;
        private System.Windows.Forms.Label lblTileIndex;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}
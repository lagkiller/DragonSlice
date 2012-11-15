namespace RpgEditor
{
    partial class FormSkillDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbStrength = new System.Windows.Forms.RadioButton();
            this.rbDexterity = new System.Windows.Forms.RadioButton();
            this.rbIntelligence = new System.Windows.Forms.RadioButton();
            this.rbAgility = new System.Windows.Forms.RadioButton();
            this.rbWisdom = new System.Windows.Forms.RadioButton();
            this.rbVitality = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbModifiers = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Skill Name:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(78, 12);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(173, 20);
            this.tbName.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbVitality);
            this.groupBox1.Controls.Add(this.rbWisdom);
            this.groupBox1.Controls.Add(this.rbAgility);
            this.groupBox1.Controls.Add(this.rbIntelligence);
            this.groupBox1.Controls.Add(this.rbDexterity);
            this.groupBox1.Controls.Add(this.rbStrength);
            this.groupBox1.Location = new System.Drawing.Point(15, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 162);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Primary Attribute";
            // 
            // rbStrength
            // 
            this.rbStrength.AutoSize = true;
            this.rbStrength.Location = new System.Drawing.Point(6, 19);
            this.rbStrength.Name = "rbStrength";
            this.rbStrength.Size = new System.Drawing.Size(65, 17);
            this.rbStrength.TabIndex = 0;
            this.rbStrength.TabStop = true;
            this.rbStrength.Text = "Strength";
            this.rbStrength.UseVisualStyleBackColor = true;
            // 
            // rbDexterity
            // 
            this.rbDexterity.AutoSize = true;
            this.rbDexterity.Location = new System.Drawing.Point(6, 42);
            this.rbDexterity.Name = "rbDexterity";
            this.rbDexterity.Size = new System.Drawing.Size(66, 17);
            this.rbDexterity.TabIndex = 0;
            this.rbDexterity.TabStop = true;
            this.rbDexterity.Text = "Dexterity";
            this.rbDexterity.UseVisualStyleBackColor = true;
            // 
            // rbIntelligence
            // 
            this.rbIntelligence.AutoSize = true;
            this.rbIntelligence.Location = new System.Drawing.Point(6, 65);
            this.rbIntelligence.Name = "rbIntelligence";
            this.rbIntelligence.Size = new System.Drawing.Size(79, 17);
            this.rbIntelligence.TabIndex = 0;
            this.rbIntelligence.TabStop = true;
            this.rbIntelligence.Text = "Intelligence";
            this.rbIntelligence.UseVisualStyleBackColor = true;
            // 
            // rbAgility
            // 
            this.rbAgility.AutoSize = true;
            this.rbAgility.Location = new System.Drawing.Point(6, 88);
            this.rbAgility.Name = "rbAgility";
            this.rbAgility.Size = new System.Drawing.Size(52, 17);
            this.rbAgility.TabIndex = 0;
            this.rbAgility.TabStop = true;
            this.rbAgility.Text = "Agility";
            this.rbAgility.UseVisualStyleBackColor = true;
            // 
            // rbWisdom
            // 
            this.rbWisdom.AutoSize = true;
            this.rbWisdom.Location = new System.Drawing.Point(6, 111);
            this.rbWisdom.Name = "rbWisdom";
            this.rbWisdom.Size = new System.Drawing.Size(63, 17);
            this.rbWisdom.TabIndex = 0;
            this.rbWisdom.TabStop = true;
            this.rbWisdom.Text = "Wisdom";
            this.rbWisdom.UseVisualStyleBackColor = true;
            // 
            // rbVitality
            // 
            this.rbVitality.AutoSize = true;
            this.rbVitality.Location = new System.Drawing.Point(6, 134);
            this.rbVitality.Name = "rbVitality";
            this.rbVitality.Size = new System.Drawing.Size(55, 17);
            this.rbVitality.TabIndex = 0;
            this.rbVitality.TabStop = true;
            this.rbVitality.Text = "Vitality";
            this.rbVitality.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.lbModifiers);
            this.groupBox2.Location = new System.Drawing.Point(185, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 162);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Class Modifiers";
            // 
            // lbModifiers
            // 
            this.lbModifiers.FormattingEnabled = true;
            this.lbModifiers.Location = new System.Drawing.Point(6, 19);
            this.lbModifiers.Name = "lbModifiers";
            this.lbModifiers.Size = new System.Drawing.Size(315, 108);
            this.lbModifiers.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(50, 133);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(131, 133);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(212, 133);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(176, 212);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(257, 212);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FormSkillDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 247);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Name = "FormSkillDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormSkillDetails";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbVitality;
        private System.Windows.Forms.RadioButton rbWisdom;
        private System.Windows.Forms.RadioButton rbAgility;
        private System.Windows.Forms.RadioButton rbIntelligence;
        private System.Windows.Forms.RadioButton rbDexterity;
        private System.Windows.Forms.RadioButton rbStrength;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lbModifiers;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}
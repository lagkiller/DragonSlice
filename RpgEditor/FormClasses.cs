using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using XRpgLibrary.CharacterClasses;

namespace RpgEditor
{
    public partial class FormClasses : FormDetails
    {
        #region Field region

        

        #endregion

        #region Constructor region

        public FormClasses()
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
            if (lbDetails.SelectedItem != null)
            {
                string detail = (string)lbDetails.SelectedItem;
                string[] parts = detail.Split(',');
                string entity = parts[0].Trim();

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete " + entity + "?",
                    "Confirm",
                    MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    lbDetails.Items.RemoveAt(lbDetails.SelectedIndex);
                    entityDataManager.EntityData.Remove(entity);

                    if (File.Exists(FormMain.ClassPath + @"\" + entity + ".xml"))
                    {
                        File.Delete(FormMain.ClassPath + @"\" + entity + ".xml");
                    }
                }
            }
        }

        void btnEdit_Click(object sender, EventArgs e)
        {
            if (lbDetails.SelectedItem != null)
            {
                string detail = (string)lbDetails.SelectedItem.ToString();
                string[] parts = detail.Split(',');
                string entity = parts[0].Trim();
                EntityData data = entityDataManager.EntityData[entity];
                EntityData newData = null;

                using (FormEntityData frmEntityData = new FormEntityData())
                {
                    frmEntityData.EntityData = data;
                    frmEntityData.ShowDialog();

                    if(frmEntityData.EntityData == null)
                    {
                        return;
                    }

                    if(frmEntityData.EntityData.EntityName == entity)
                    {
                        entityDataManager.EntityData[entity] = frmEntityData.EntityData;
                        FillListBox();
                        return;
                    }

                    newData = frmEntityData.EntityData;
                }

                DialogResult result = MessageBox.Show(
                    "Name changed. Do you want to add a new entry?",
                    "Confirm",
                    MessageBoxButtons.YesNo);

                if(result == DialogResult.No)
                {
                    return;
                }

                if (entityDataManager.EntityData.ContainsKey(newData.EntityName))
                {
                    MessageBox.Show("Entry already exists. Use Edit to modify the entry");
                    return;
                }

                lbDetails.Items.Add(newData);
                entityDataManager.EntityData.Add(newData.EntityName, newData);
            }
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            using (FormEntityData frmEntityData = new FormEntityData())
            {
                frmEntityData.ShowDialog();

                if (frmEntityData.EntityData != null)
                {
                    AddEntity(frmEntityData.EntityData);
                }
            }
        }

        #endregion

        #region Method region

        public void FillListBox()
        {
            lbDetails.Items.Clear();

            foreach (string s in FormDetails.EntityDataManager.EntityData.Keys)
            {
                lbDetails.Items.Add(FormDetails.EntityDataManager.EntityData[s]);
            }
        }

        private void AddEntity(EntityData entityData)
        {
            if (FormDetails.EntityDataManager.EntityData.ContainsKey(entityData.EntityName))
            {
                DialogResult result = MessageBox.Show(
                    entityData.EntityName + " already exists. Do you want to overwrite it?",
                    "Existing Character Class",
                    MessageBoxButtons.YesNo);

                if (result == DialogResult.No)
                {
                    return;
                }

                FormDetails.EntityDataManager.EntityData[entityData.EntityName] = entityData;

                FillListBox();
                return;
            }

            lbDetails.Items.Add(entityData.ToString());

            FormDetails.EntityDataManager.EntityData.Add(entityData.EntityName, entityData);
        }

        #endregion
    }
}

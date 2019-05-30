using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Novotel
{
    public partial class KeysUC : UserControl
    {
        public KeysUC()
        {
            InitializeComponent();
        }

        

        private void KeysUC_Load(object sender, EventArgs e)
        { 
            //fill table
            this.keyTableAdapter.Fill(this.hotelDbDataSet.key);
            keyBindingSource.DataSource = this.hotelDbDataSet.key;


            //setup controls properties
            groupboxKey.Enabled = false;
            dataGridViewKeys.RowHeadersVisible = false;
            dataGridViewKeys.MultiSelect = false;
        }

        //vars
        bool addingNew = false;

        //EDIT button clicked
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            groupboxKey.Enabled = true;
            addingNew = false;
        }

        ////NEW button clicked
        private void buttonNew_Click(object sender, EventArgs e)
        {
            groupboxKey.Enabled = true;
            groupBoxAddFromFile.Enabled = true;
            addingNew = true;

            //clear fields
            textBoxApartamnetId.Clear();
            textBoxKeyId.Clear();
            checkBoxActive.Checked = false;

        }


        //SAVE button
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                bool active = checkBoxActive.Checked;
                string key = textBoxKeyId.Text;
                int? apartament = null;
                try
                {
                    apartament = int.Parse(textBoxApartamnetId.Text);
                }
                catch (Exception ex) { } //textbox is empty
              

                if (addingNew)
                {
                    //TODO insert
                    keyTableAdapter.Insert(key, apartament, active);
                }
                else
                {
                    //TODO update
                    keyTableAdapter.UpdateQuery(apartament, active, key);
                }

                //refresh DataGridView
                this.keyTableAdapter.Fill(this.hotelDbDataSet.key);
                groupboxKey.Enabled = false;

            }
            catch (Exception ex) { }
        }

        //on keys DataGridView cell ENTER
        private void dataGridViewKeys_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               

                    DataGridViewCellCollection CellCol = dataGridViewKeys.CurrentRow.Cells;
                    textBoxKeyId.Text = CellCol[0].Value.ToString();
                    textBoxApartamnetId.Text = CellCol[1].Value.ToString();
                    checkBoxActive.Checked = (bool)CellCol[2].Value;
     
            }
            
            catch (Exception ex) { }
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            groupboxKey.Enabled = false;
            groupBoxAddFromFile.Enabled = false;
        }


        ///search 
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSearch.Text))
            {
                this.keyTableAdapter.Fill(this.hotelDbDataSet.key);
                keyBindingSource.DataSource = this.hotelDbDataSet.key;

            }
            else
            {
                var query = from o in this.hotelDbDataSet.key
                            where o.id.ToString().ToLower().Contains(textBoxSearch.Text.ToLower())
                            || o.apartament_id.ToString().ToLower().Contains(textBoxSearch.Text.ToLower())
                            select o;

                keyBindingSource.DataSource = query.ToList();

            }
        }

        //search all
        private void buttonAll_Click(object sender, EventArgs e)
        {
            this.keyTableAdapter.Fill(this.hotelDbDataSet.key);
            keyBindingSource.DataSource = this.hotelDbDataSet.key;
        }

        //handl error (leave it empty)
        private void dataGridViewKeys_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void checkBoxActive_CheckedChanged(object sender, EventArgs e)
        {

        }

       

        private void buttonChooseFile(object sender, EventArgs e)
        {
            //dialog 

            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBoxFileName.Text = ofd.FileName;
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(textBoxFileName.Text))
                {
                    using (StreamReader file = new StreamReader(textBoxFileName.Text))
                    {
                        string line;

                        while ((line = file.ReadLine()) != null)
                        {
                            keyTableAdapter.Insert(line, null, false);
                        }
                    }

                    this.keyTableAdapter.Fill(this.hotelDbDataSet.key);
                    groupboxKey.Enabled = false;
                    groupBoxAddFromFile.Enabled = false;

                }



            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}

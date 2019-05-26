using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            groupboxKey.Enabled = false;
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

       
    }
}

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
    public partial class RoomsUC : UserControl
    {
        public RoomsUC()
        {
            InitializeComponent();
        }

        private void RoomsUC_Load(object sender, EventArgs e)
        {
            try
            {
                //fill tables
                this.classTableAdapter.Fill(this.hotelDbDataSet._class);
                classBindingSource.DataSource = this.hotelDbDataSet._class;

                this.apartamentTableAdapter.Fill(this.hotelDbDataSet.apartament);
                apartamentBindingSource.DataSource = this.hotelDbDataSet.apartament;

                //hide start empty column on DataGridView
                //dataGridViewAparts.RowHeadersVisible = false;
                //dataGridViewClasses.RowHeadersVisible = false;

                //disable multiselect
                dataGridViewAparts.MultiSelect = false;
                dataGridViewClasses.MultiSelect = false;


                MakeEditingGroupboxesEnabled(false);
                UpdateComboboxClass();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        //update combobox
        void UpdateComboboxClass()
        {
            try
            {
                comboBoxClass.DataSource = classTableAdapter.GetAllClassesId();
                comboBoxClass.DisplayMember = "id";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        //disable / enable textboxes 
        void MakeEditingGroupboxesEnabled(bool enable)
        {
            groupBoxAddApart.Enabled = enable;
            groupBoxAddClass.Enabled = enable;
        }

        //edit
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            MakeEditingGroupboxesEnabled(true);
        }

        //insert apartament
        private void buttonAddApart_Click(object sender, EventArgs e)
        {
            try
           {
                apartamentTableAdapter.Insert(int.Parse(textBoxApart.Text), comboBoxClass.Text);
                this.apartamentTableAdapter.Fill(this.hotelDbDataSet.apartament);
                MakeEditingGroupboxesEnabled(false);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        //cancel
        private void buttonCancell_Click(object sender, EventArgs e)
        {
            MakeEditingGroupboxesEnabled(false);
        }

        //insert class
        private void buttonAddClass_Click(object sender, EventArgs e)
        {
            try
            {
                string id = textBox_class_class.Text;
                int places = int.Parse(textBox_class_places.Text);
                int rooms = int.Parse(textBox_class_rooms.Text);
                decimal price = decimal.Parse(textBox_class_price.Text);

                classTableAdapter.Insert(id, places, rooms, price);
                this.classTableAdapter.Fill(this.hotelDbDataSet._class);

                UpdateComboboxClass();
                MakeEditingGroupboxesEnabled(false);
            }
            catch (Exception ex) { MessageBox.Show("Error"); }
        }

        //update class
        private void buttonClassUpdate_Click(object sender, EventArgs e)
        {
           try
           {
                string id = textBox_class_class.Text;
                int places = int.Parse(textBox_class_places.Text);
                int rooms = int.Parse(textBox_class_rooms.Text);
                decimal price = decimal.Parse(textBox_class_price.Text);

                classTableAdapter.UpdateQuery(id, places, rooms, price, id);

              
                this.classTableAdapter.Fill(this.hotelDbDataSet._class);
                MakeEditingGroupboxesEnabled(false);

            }
            catch(Exception ex) { MessageBox.Show("Error"); }
        }

        //update apartament
        private void buttonUpdateApart_Click(object sender, EventArgs e)
        {
            //TODO UPDATE
            try
            {
                this.apartamentTableAdapter.UpdateQuery(int.Parse(textBoxApart.Text), comboBoxClass.Text, int.Parse(textBoxApart.Text));
                this.apartamentTableAdapter.Fill(this.hotelDbDataSet.apartament);
                MakeEditingGroupboxesEnabled(false);
            }
            catch (Exception ex) { MessageBox.Show("Error"); }
        }

        //on apartament DataGridView cell enter 
        private void dataGridViewAparts_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                
                DataGridViewCellCollection CellCol = dataGridViewAparts.CurrentRow.Cells;
                textBoxApart.Text = CellCol[0].Value.ToString();
                comboBoxClass.Text= CellCol[1].Value.ToString();
                

               
            

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        ////on class DataGridView cell enter 
        private void dataGridViewClasses_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewCellCollection CellCol = dataGridViewClasses.CurrentRow.Cells;
                textBox_class_class.Text = CellCol[0].Value.ToString();
                textBox_class_places.Text = CellCol[1].Value.ToString();
                textBox_class_price.Text = CellCol[2].Value.ToString();
                textBox_class_rooms.Text = CellCol[3].Value.ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}

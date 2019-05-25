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
            
            this.classTableAdapter.Fill(this.hotelDbDataSet._class);
            classBindingSource.DataSource = this.hotelDbDataSet._class;

            this.apartamentTableAdapter.Fill(this.hotelDbDataSet.apartament);
            apartamentBindingSource.DataSource = this.hotelDbDataSet.apartament;

            //hide start empty column on DataGridView
            dataGridViewAparts.RowHeadersVisible = false;
            dataGridViewClasses.RowHeadersVisible = false;

            MakeEditingGroupboxesEnabled(false);



            comboBoxClass.DataSource = classTableAdapter.GetAllClassesId();
            comboBoxClass.DisplayMember = "id";

        }

        void MakeEditingGroupboxesEnabled(bool enable)
        {
            groupBoxAddApart.Enabled = enable;
            groupBoxAddClass.Enabled = enable;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            MakeEditingGroupboxesEnabled(true);
        }

        private void buttonAddApart_Click(object sender, EventArgs e)
        {
            try
           {
                apartamentTableAdapter.Insert(int.Parse(textBoxApart.Text), comboBoxClass.Text);
                this.apartamentTableAdapter.Fill(this.hotelDbDataSet.apartament);
                MakeEditingGroupboxesEnabled(false);

            }
           catch(Exception ex) { }
        }

        private void buttonCancell_Click(object sender, EventArgs e)
        {
            MakeEditingGroupboxesEnabled(false);
        }

        private void buttonAddClass_Click(object sender, EventArgs e)
        {
            string id = textBox_addclass_class.Text;
            int places = int.Parse(textBox_addclass_places.Text);
            int rooms = int.Parse(textBox_addclass_rooms.Text);
            decimal price = decimal.Parse(textBox_addclass_price.Text);

            classTableAdapter.Insert(id, places, rooms, price);
            this.classTableAdapter.Fill(this.hotelDbDataSet._class);

            //TODO ADD CLASS
            MakeEditingGroupboxesEnabled(false);
        }

        private void buttonClassUpdate_Click(object sender, EventArgs e)
        {
           try
           {
                string id = textBox_addclass_class.Text;
                int places = int.Parse(textBox_addclass_places.Text);
                int rooms = int.Parse(textBox_addclass_rooms.Text);
                decimal price = decimal.Parse(textBox_addclass_price.Text);

            classTableAdapter.UpdateQuery(id, places, rooms, price, id);
            

            this.classTableAdapter.Fill(this.hotelDbDataSet._class);
            
                
                //this.apartamentTableAdapter.Fill(this.hotelDbDataSet.apartament);


            }
            catch(Exception ex) { }
        }
    }
}

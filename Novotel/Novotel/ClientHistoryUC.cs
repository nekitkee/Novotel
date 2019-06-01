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
    public partial class ClientHistoryUC : UserControl
    {
        public ClientHistoryUC()
        {
            InitializeComponent();
        }


        private void ClientHistoryUC_Load(object sender, EventArgs e)
        {

            //fill client table

            try
            {
                clientTableAdapter.Fill(hotelDbDataSet.client);
                clientBindingSource.DataSource = hotelDbDataSet.client;

                bookingBindingSource.DataSource = hotelDbDataSet.booking;

            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void dataGridViewClients_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try { 
            DataGridViewCellCollection CellCol = dataGridViewClients.CurrentRow.Cells;
            string PC = CellCol[0].Value.ToString();

            bookingTableAdapter.FillBookingsByPC(hotelDbDataSet.booking, PC);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        //show ALL clients
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {

                textBoxSearch.Clear();
                clientTableAdapter.Fill(hotelDbDataSet.client);
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
}

        //find client 
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {

                string searchParam = textBoxSearch.Text;
                clientTableAdapter.FindAndFill(hotelDbDataSet.client, searchParam, searchParam, searchParam);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}

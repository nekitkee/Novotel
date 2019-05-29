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
    public partial class BookingList : UserControl
    {
        public BookingList()
        {
            InitializeComponent();
        }
        //on cell ENTER - FILL client window with related data
        private void dataGridViewBooking_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewCellCollection CellCol = dataGridViewBooking.CurrentRow.Cells;
                int bookingId = (int)CellCol[0].Value;
                clientBookingTableAdapter.FillByBookingId(hotelDbDataSet.clientBooking, bookingId);

                textBoxBookingId.Text = CellCol[0].Value.ToString();
                textBoxApartament.Text = CellCol[4].Value.ToString();
                textBoxPrice.Text = CellCol[3].Value.ToString();

                dateTimePickerFrom.Value = (DateTime)CellCol[1].Value;
                dateTimePickerTo.Value = (DateTime)CellCol[2].Value;

            }catch(Exception ex) { }

        }

        private void BookingList_Load(object sender, EventArgs e)
        { 
            //fill and bind
            bookingTableAdapter.Fill(hotelDbDataSet.booking);
            bookingBindingSource.DataSource = hotelDbDataSet.booking;

            clientBookingBindingSource.DataSource = hotelDbDataSet.clientBooking;

          


        }

        //on cell ENTER in client grid
        private void dataGridViewClientBooking_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection CellCol = dataGridViewClientBooking.CurrentRow.Cells;

            textBoxPC.Text = CellCol[0].Value.ToString();
            textBoxKey.Text = CellCol[1].Value.ToString();



        }


        //EDIT
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            groupBoxChangeBookingClient.Enabled = true;
            groupBoxChangeBooking.Enabled = true;
            MessageBox.Show("THIS IS ADVANTAGE SETTINGS , PLEASE BE CAREFUL WHEN CHANGING DATA");
           
        }

        ////CANCEL
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            groupBoxChangeBookingClient.Enabled = false;
            groupBoxChangeBooking.Enabled = false;
        }

        //ADD CLIENT TO BOOKING
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string PC = textBoxPC.Text;
                int bookingId = int.Parse(textBoxBookingId.Text);
                string key = textBoxKey.Text;
                int apartament = int.Parse(textBoxApartament.Text);

                int? clientExist = queriesTableAdapter1.PCexist(PC);
                if (clientExist.Value == 0)
                    throw new Exception("client doesnt exist");

                bool? keyExist = keyTableAdapter1.KeyActivity(key);
                if (!keyExist.HasValue)
                    throw new Exception("key doesnt exist");

                clientBookingTableAdapter.Insert(PC, bookingId, key);
                keyTableAdapter1.UpdateQuery(apartament, true, key);
                clientBookingTableAdapter.FillByBookingId(hotelDbDataSet.clientBooking, bookingId);

                groupBoxChangeBookingClient.Enabled = false;
                groupBoxChangeBooking.Enabled = false;

            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }


        //UPDATE CLIENT TO BOOKING
        private void buttonClientBookingUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string PC = textBoxPC.Text;
                int bookingId = int.Parse(textBoxBookingId.Text);
                string key = textBoxKey.Text;
                int apartament = int.Parse(textBoxApartament.Text);

                int? clientExist = queriesTableAdapter1.PCexist(PC);
                if (clientExist.Value == 0)
                    throw new Exception("client doesnt exist");

                bool? keyExist = keyTableAdapter1.KeyActivity(key);
                if (!keyExist.HasValue)
                    throw new Exception("key doesnt exist");


                clientBookingTableAdapter.UpdateQuery(bookingId, key, PC);
                keyTableAdapter1.UpdateQuery(apartament, true, key);


              

                clientBookingTableAdapter.FillByBookingId(hotelDbDataSet.clientBooking, bookingId);

                groupBoxChangeBookingClient.Enabled = false;
                groupBoxChangeBooking.Enabled = false;

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        //delete client from booking
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string PC = textBoxPC.Text;
                int bookingId = int.Parse(textBoxBookingId.Text);
                string key = textBoxKey.Text;
                int apartament = int.Parse(textBoxApartament.Text);


                clientBookingTableAdapter.Delete(PC, bookingId, key);
                keyTableAdapter1.UpdateQuery(apartament, false, key);
                clientBookingTableAdapter.FillByBookingId(hotelDbDataSet.clientBooking, bookingId);

                groupBoxChangeBookingClient.Enabled = false;
                groupBoxChangeBooking.Enabled = false;

            }
            catch (Exception ex) { }
        }

        //update booking info
        private void buttonBookingSave_Click(object sender, EventArgs e)
        {
            try
            {
               
                int bookingId = int.Parse(textBoxBookingId.Text);
                int apartament = int.Parse(textBoxApartament.Text);

                DateTime from = dateTimePickerFrom.Value;
                DateTime to = dateTimePickerTo.Value;
                decimal price = decimal.Parse(textBoxPrice.Text);

                // check dates SQL
                int? intersec = queriesTableAdapter1.BookingIntersectionCount(bookingId, from, to, bookingId, from, to, bookingId, from, to);
                if (intersec.Value != 0)
                    throw new Exception("Apartament is not free on this days");
               

                bookingTableAdapter.UpdateQuery(from, to, price, apartament, bookingId);

                bookingTableAdapter.Fill(hotelDbDataSet.booking);

                groupBoxChangeBookingClient.Enabled = false;
                groupBoxChangeBooking.Enabled = false;

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}

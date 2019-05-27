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
            DataGridViewCellCollection CellCol = dataGridViewBooking.CurrentRow.Cells;
            int booking_id = (int)CellCol[0].Value;
            clientBookingTableAdapter.FillByBookingId(hotelDbDataSet.clientBooking, booking_id);
        }

        private void BookingList_Load(object sender, EventArgs e)
        { 
            //fill and bind
            bookingTableAdapter.Fill(hotelDbDataSet.booking);
            bookingBindingSource.DataSource = hotelDbDataSet.booking;

            clientBookingBindingSource.DataSource = hotelDbDataSet.clientBooking;

            //dataGridViewClientBooking.DataMember = "PC";
            //dataGridViewClientBooking.DataMember = "key_id";


        }
    }
}

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
    public partial class MakeBooking1 : UserControl
    {


        public MakeBooking1()
        {
            InitializeComponent();
        }

        private void MakeBooking1_Load(object sender, EventArgs e)
        {
            comboBoxClass.DataSource = classTableAdapter.GetAllClassesId();
            comboBoxClass.DisplayMember = "id";
            
            
        }

        public bool AddClientToBooking(string personalCode)
        {
            dataGridViewList.Rows.Add(personalCode, "");
            //TODO count max
            return true;
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            // dataGridViewFreeApart.DataSource = 
            HotelDbDataSet.apartamentDataTable allfreerooms =  apartamentTableAdapter.GetDataByFreeRooms(
                dateFrom.Value, dateTo.Value,
                dateFrom.Value, dateTo.Value,
                dateFrom.Value, dateTo.Value);

            var query = from o in allfreerooms
                        where o.class_id == comboBoxClass.Text
                        select o;
            DataView res = query.AsDataView();

            dataGridViewFreeApart.DataSource = res;
            dataGridViewFreeApart.Columns["class_id"].Visible = false;
            dataGridViewFreeApart.Columns[0].HeaderCell.Value = "Room";
            dataGridViewFreeApart.RowHeadersVisible = false;
                
            //dataGridViewFreeApart.DataMember = "id";

        }

        //calculation of prise
        void CountPrice()
        {
            try
            {
                string class_id = comboBoxClass.Text;
                decimal? tarif = classTableAdapter.GetPrice(class_id);
                if (tarif.HasValue && textBoxRoom.Text!="")
                {
                    TimeSpan period = dateTo.Value.Subtract(dateFrom.Value);
                    int periodDays = Convert.ToInt32(period.TotalDays);
                    decimal price = periodDays * tarif.Value;
                    textBoxPrice.Text = price.ToString();

                }
            }catch(Exception e) {}
        }

        //choose room
        private void dataGridViewFreeApart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxRoom.Text = dataGridViewFreeApart.CurrentCell.Value.ToString();
            CountPrice();
        }


        //recalculate prise if date was changed
        private void dateTo_ValueChanged(object sender, EventArgs e)
        {
            CountPrice();
        }

        private void dateFrom_ValueChanged(object sender, EventArgs e)
        {
            CountPrice();
        }


        //MAKE BOOKING
        private void makeBooking_Click(object sender, EventArgs e)
        {

            //try
            //{
                //TODO if verified

                bookingTableAdapter1.Insert(dateFrom.Value, dateTo.Value,
                    Decimal.Parse(textBoxPrice.Text), int.Parse(textBoxRoom.Text));

                int? lastid = bookingTableAdapter1.LastId();

           

                for (int i = 0; i < dataGridViewList.Rows.Count - 1; i++) { 
                    clientBookingTableAdapter1.Insert(
                        dataGridViewList.Rows[i].Cells[0].Value.ToString(), //pc 
                        lastid.Value, //booking id
                        dataGridViewList.Rows[i].Cells[1].Value.ToString()); //key
                }

                //TODO UPDATE KEYS

                //if succesful 

                dataGridViewList.Rows.Clear();

                //else error

           // }catch(Exception ex) { }

        }
    }
}

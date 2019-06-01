using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            
            dateTo.Value = dateTo.Value.AddDays(1);
            
            
        }

        public bool AddClientToBooking(string personalCode)
        {
            dataGridViewList.Rows.Add(personalCode, "");
            //TODO count max
            return true;
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            try
            {

                HotelDbDataSet.apartamentDataTable allfreerooms = apartamentTableAdapter.GetDataByFreeRooms(
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

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }


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
            try
            {
                CountPrice();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
}

        private void dateFrom_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                CountPrice();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        //MAKE BOOKING
        private void makeBooking_Click(object sender, EventArgs e)
        {

            try
            {
                

                //verifing data in booking list
                if (checkBox1.Checked)
                {
                    int clientInBookingCount = 0;

                    for (int i = 0; i < dataGridViewList.Rows.Count - 1; i++)
                    {

                        if (dataGridViewList.Rows[i].Cells[0].Value == null)
                            continue;

                        string PC = dataGridViewList.Rows[i].Cells[0].Value.ToString();
                        string key = dataGridViewList.Rows[i].Cells[1].Value.ToString();

                        if (string.IsNullOrEmpty(key)) 
                            throw new Exception($"All clients must have the keys");
                       
                        if (queriesTableAdapter1.PCexist(PC).Value == 0)
                            throw new Exception($"Client: {PC} from booking list, doesnt exist in database");

                        if (!keyTableAdapter1.KeyActivity(key).HasValue)
                            throw new Exception($"Key: {key} from booking list, doesnt exis");

                        if (keyTableAdapter1.KeyActivity(key).Value)
                            throw new Exception($"Key: {key} is already active now");

                        clientInBookingCount++;
                    }

                    int? clientMaxInApart = queriesTableAdapter1.MaxCountInApartClass(comboBoxClass.Text);

                    if (clientInBookingCount > clientMaxInApart.Value)
                        throw new Exception($"Max client count in {comboBoxClass.Text} class apartaments is {clientMaxInApart.Value} people .");

                    if (clientInBookingCount == 0 )
                        throw new Exception("Please, add clients to booking");

                    if (string.IsNullOrEmpty(textBoxRoom.Text))
                        throw new Exception("Please, choose apartament");

                    if (DateTime.Compare(dateFrom.Value , dateTo.Value) > 0)
                        throw new Exception("Inccorect date period");

                    if (decimal.Parse(textBoxPrice.Text) < 0)
                        throw new Exception("incorect price");


                    DateTime to = dateTo.Value;
                    DateTime from = dateFrom.Value;
                    int apart = int.Parse(textBoxRoom.Text);

                    int? intersec = queriesTableAdapter1.BookingIntersectionCount(apart, from, to,
                        apart, from, to,
                        apart, from, to);

                    if (intersec.Value != 0)
                        throw new Exception("Apartament is not free for this day");

                    //string checkin = dateFrom.Value.ToString();
                    //string checkout = dateTo.Value.ToString();
                    //string quaryString = $"SELECT COUNT(*) AS result FROM booking WHERE(apartament_id = {textBoxRoom.Text}) AND((checkin <= {checkin}) AND(checkout >= {checkout}) OR((checkin > {checkin}) AND(checkin < {checkout})) OR ((checkout >= {checkin}) AND(checkout <={checkout})))";

                    //SqlConnection con = new SqlConnection(classTableAdapter.Connection.ConnectionString);
                    //SqlCommand command = new SqlCommand(quaryString, con);
                    //object res = command.ExecuteScalar();
                }


                int apartament = int.Parse(textBoxRoom.Text);

                bookingTableAdapter1.Insert(dateFrom.Value, dateTo.Value,
                    Decimal.Parse(textBoxPrice.Text), apartament );

                int? lastid = bookingTableAdapter1.LastId();

           

                for (int i = 0; i < dataGridViewList.Rows.Count - 1; i++) {

                if (dataGridViewList.Rows[i].Cells[0].Value == null)
                    continue;

                    clientBookingTableAdapter1.Insert(
                        dataGridViewList.Rows[i].Cells[0].Value.ToString(), //pc 
                        lastid.Value, //booking id
                        dataGridViewList.Rows[i].Cells[1].Value.ToString()); //key

                keyTableAdapter1.UpdateQuery(apartament, true, dataGridViewList.Rows[i].Cells[1].Value.ToString());

                }

               

                //if succesful 

                dataGridViewList.Rows.Clear();

                //else error

           }catch(Exception ex) { MessageBox.Show(ex.Message); }

            
        }
    }
}

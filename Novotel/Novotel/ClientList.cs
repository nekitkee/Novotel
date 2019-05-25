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

    

    public partial class ClientList : UserControl
    {
        public ClientList()
        {
            InitializeComponent();

        }

        //SETUP UI
        private void ClientList_Load(object sender, EventArgs e)
        {
            this.clientTableAdapter.Fill(this.hotelDbDataSet.client);
            clientBindingSource.DataSource = this.hotelDbDataSet.client;

            groupBoxPerson.Enabled = false;

            dataGridViewClients.MultiSelect = false;

            dataGridViewClients.DataError += DataGridView1_DataError;
        }

        //context menu vars
        int currentMouseOverRow;
        public delegate bool AddClientToBookingHandler(string PersonalCode);
        public AddClientToBookingHandler AddClientToBookingEvent;
        //add new client to database
        bool addingNew = false;

        //DataGridView Error handler
        private void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {
            //MessageBox.Show("Error happened " );
        }


            

       

      
        //click on DataGridVew Cell to parse it into GroupBoxes 
        private void dataGridViewClients_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

           try
           {
                
                //curentrow
                DataGridViewCellCollection CellCol = dataGridViewClients.CurrentRow.Cells;

                bool gender = (bool)CellCol[4].Value;

                if (gender)
                    this.radioButtonMale.Checked = true;
                else
                    this.radioButtonFemale.Checked = true;

                string PC = CellCol[0].Value.ToString();
                
                //get clientBooking by Personal Code for current row
                DataTable allClientBookingTable = this.clientBookingTableAdapter.GetDataBy(PC);

                if (allClientBookingTable.Rows.Count > 0)
                {
                    DataRow LastClientBooking =  allClientBookingTable.AsEnumerable().ElementAt(allClientBookingTable.Rows.Count - 1);
                    this.labelKey.Text = LastClientBooking["key_id"].ToString();

                    string booking_id = LastClientBooking["booking_id"].ToString();

                    DataTable bookingTable = tableAdapterManager.bookingTableAdapter.GetDataBy(int.Parse(booking_id));
                    DataRow booking = bookingTable.AsEnumerable().ElementAt(0);
                    this.labelRoom.Text = booking["apartament_id"].ToString();
                    this.labelCheckin.Text = booking["checkin"].ToString();
                    this.labelCheckout.Text = booking["checkout"].ToString();

                }
                else
                {
                //set default values
                this.labelKey.Text = "-";
                this.labelRoom.Text = "-";
                this.labelCheckin.Text = "-";
                this.labelCheckout.Text = "-";

                }

            }
           catch(Exception ex) {}
            
            
        }

        //show all clients
        private void buttonAll_Click(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
            textBoxSearch_TextChanged(sender,  e);
        }


        //find clients 
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            //without this rises error ...
            dataGridViewClients.ClearSelection();
            dataGridViewClients.Update();
            //dataGridViewClients.se

            if (string.IsNullOrEmpty(textBoxSearch.Text))
            {
                this.clientTableAdapter.Fill(this.hotelDbDataSet.client);
                clientBindingSource.DataSource = this.hotelDbDataSet.client;

            }
            else
            {
                var query = from o in this.hotelDbDataSet.client
                            where o.firstname.ToString().ToLower().Contains(textBoxSearch.Text.ToLower())
                            || o.lastname.ToString().ToLower().Contains(textBoxSearch.Text.ToLower())
                            || o.PC.ToString().Contains(textBoxSearch.Text)
                            select o;

                clientBindingSource.DataSource = query.ToList();

            }
        }

        //edit start
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            groupBoxPerson.Enabled = true;
            textBoxFirstName.Focus();
        }

        //cancel editing
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            clientBindingSource.CancelEdit();
            groupBoxPerson.Enabled = false;
            dataGridViewClients.Enabled = true;
            clientBindingSource.ResetBindings(false);
            addingNew = false;
        }

        //save edited or new client 
        private void buttonSave_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (addingNew)
                {
                    //add one
                   
                    clientTableAdapter.Insert(textBoxPC.Text , textBoxFirstName.Text, textBoxLastName.Text,
                        dateTimeBirthday.Value , radioButtonMale.Checked);
                    

                    addingNew = false;
                    groupBoxPerson.Enabled = false;
                    dataGridViewClients.Enabled = true;
                    buttonAll_Click(sender, e);

                }
                else
                {
                    clientBindingSource.EndEdit();
                    clientTableAdapter.Update(this.hotelDbDataSet.client);
                    groupBoxPerson.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                    MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clientBindingSource.ResetBindings(false);
            }
        }

        //starting process for NEW CLIENT adding to DB
        private void buttonNew_Click(object sender, EventArgs e)
        {

            clientBindingSource.AddNew();
            clientBindingSource.MoveLast();


            dataGridViewClients.Enabled = false;
            addingNew = true;
            groupBoxPerson.Enabled = true;
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxPC.Clear();
            textBoxFirstName.Focus();
        }

       

        

        //create context menu
        private void dataGridViewClients_MouseClick(object sender, MouseEventArgs e)
        {
            //TODO : select cell 

            if (e.Button == MouseButtons.Right)
            {
                
                currentMouseOverRow = dataGridViewClients.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    ContextMenuStrip m = new ContextMenuStrip();
                    m.Items.Add("add to booking").Name = "Add";
                    m.Show(dataGridViewClients, new Point(e.X, e.Y));
                    m.ItemClicked += M_ItemClicked;
                }

                

            }
        }

        //context menu CLICK on "add client to booklist"
        private void M_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {


            string personalCode = dataGridViewClients.Rows[currentMouseOverRow].Cells[0].Value.ToString();
            
            //TODO new tread for label

            //result
            if (AddClientToBookingEvent(personalCode))
            {
                labelClientAddResult.Text = dataGridViewClients.Rows[currentMouseOverRow].Cells[1].Value.ToString() + " " +
                    dataGridViewClients.Rows[currentMouseOverRow].Cells[2].Value.ToString() + " added succesfuly";
                labelClientAddResult.ForeColor = Color.Green;
                labelClientAddResult.Visible = true;
            }
            else
            {
                labelClientAddResult.Text = "Errpr/Booking list is full";
                labelClientAddResult.ForeColor = Color.Red;
            }

        }
    }
}

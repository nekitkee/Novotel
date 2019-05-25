using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Novotel
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            clientList1.AddClientToBookingEvent += makeBooking11.AddClientToBooking;
        }


        private void clientListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clientList1.BringToFront();
        }

        private void makeBooking11_Load(object sender, EventArgs e)
        {

        }

        private void bookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            makeBooking11.BringToFront();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            roomsUC1.BringToFront();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void contactsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello", "test", MessageBoxButtons.OK);
        }
    }
}

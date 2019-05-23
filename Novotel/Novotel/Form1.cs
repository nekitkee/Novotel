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
    }
}

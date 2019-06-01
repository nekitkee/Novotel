using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        

        private void MainForm_Load(object sender, EventArgs e)
        {

        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void contactsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("EMAIL : nekitkee@gmail.com \n\nGITHUB: nekitkee");
        }

        private void openclosedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            roomsStateUC1.BringToFront();

        }

        private void listAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bookingList1.BringToFront();
        }


        private void apartamnetsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            roomsUC1.BringToFront();
        }

        private void makeBookingToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            makeBooking11.BringToFront();
        }

        private void bookingListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bookingList1.BringToFront();
        }

        private void clientHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clientHistoryUC1.BringToFront();
        }

        private void numbersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statisticUC1.BringToFront();
        }

        private void keyListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            keysUC1.BringToFront();
        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"""man\man.html""";
                Process.Start(path);
            }catch(Exception ex) { MessageBox.Show("MANUAL NOT FOUND"); }
        }
    }
}

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
    public partial class StatisticUC : UserControl
    {
        public StatisticUC()
        {
            InitializeComponent();
        }


        private void CalculateStatistic()
        {
            try
            {
                //client count
                int? clientCount = queriesTableAdapter1.ClientsCount();
                labelClientsCount.Text = clientCount.HasValue ? clientCount.Value.ToString() : "0";

                //booking count
                int? bookingCount = queriesTableAdapter1.BookingsCount();
                labelBookingsCount.Text = bookingCount.HasValue ? bookingCount.Value.ToString() : "0";

                //total earned
                decimal? totalEarned = queriesTableAdapter1.TotalEarned();
                labelTotalMoney.Text = totalEarned.HasValue ? totalEarned.Value.ToString() + " EUR" : "0 EUR";

                //average Bill
                labelAvgBill.Text = totalEarned.HasValue & bookingCount.HasValue ?
                    (totalEarned.Value / bookingCount.Value).ToString() + " EUR" : "0 EUR";

                //active keys 
                int? activeKeys = queriesTableAdapter1.ActiveKeys();
                labelActiveKeys.Text = activeKeys.HasValue ? activeKeys.Value.ToString() : "0";

                //apartament count
                int? apartCount = queriesTableAdapter1.CountOfApartament();
                LabelApartTotal.Text = apartCount.Value.ToString();

                //free apart
                int? freeApart = queriesTableAdapter1.CountOfFreeApart(DateTime.Now, DateTime.Now);
                labelFreeApart.Text = freeApart.Value.ToString();

                //busy apart
                labelBusyAparts.Text = (apartCount.Value - freeApart.Value).ToString();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void StatisticUC_Load(object sender, EventArgs e)
        {
            CalculateStatistic();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            CalculateStatistic();
        }
    }
}

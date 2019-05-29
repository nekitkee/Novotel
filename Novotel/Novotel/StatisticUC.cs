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

        private void StatisticUC_Load(object sender, EventArgs e)
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
                    (totalEarned.Value / bookingCount.Value).ToString() + " EUR": "0 EUR";

                //active keys 
                int? activeKeys = queriesTableAdapter1.ActiveKeys();
                labelActiveKeys.Text = activeKeys.HasValue ? activeKeys.Value.ToString() : "0";

            }catch(Exception ex) { }

        }
    }
}

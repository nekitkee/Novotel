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
    public partial class RoomsStateUC : UserControl
    {
        public RoomsStateUC()
        {
            InitializeComponent();

           
        }

        private void RoomsStateUC_Load(object sender, EventArgs e)
        {
            try
            {

                dataGridViewClosedRooms.DataSource = hotelDbDataSet.apartament;
                HotelDbDataSet.apartamentDataTable openTable = new HotelDbDataSet.apartamentDataTable();
                dataGridViewOpened.DataSource = openTable;


                HotelDbDataSet.apartamentDataTable apartaments = apartamentTableAdapter.GetData();

                foreach (HotelDbDataSet.apartamentRow row in apartaments.Rows)
                {

                    bool? state = lockHistoryTableAdapter1.ApartamentState((int)row[0]);
                    if (state.HasValue)
                    {
                        if (state.Value)
                            hotelDbDataSet.apartament.ImportRow(row);
                        else
                            openTable.ImportRow(row);
                    }

                }
            }
            catch (Exception ex) { }

            
        }

        private void dataGridViewClosedRooms_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                DataGridViewCellCollection CellCol = dataGridViewClosedRooms.CurrentRow.Cells;
                int apart = (int)CellCol[0].Value;

                DataRow row = lockHistoryTableAdapter1.LastLockGet(apart).Rows[0];

                labelTime.Text = row[0].ToString();
                string key = row[1].ToString();
                labelKey.Text = key;
                string PC = queriesTableAdapter1.GetLastPCforKey(key);

                DataRow client = clientTableAdapter1.GetDataBy(PC).Rows[0];


                labelHolder.Text = client[1].ToString() + " " + client[2].ToString();

            }catch(Exception ex) { }
            



        }
    }
}

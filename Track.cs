using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainOrgnz
{
    public partial class Track : Form
    {
        public Track()
        {
            InitializeComponent();
        }

        private void Track_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trainDataSet.route_train". При необходимости она может быть перемещена или удалена.
            this.route_trainTableAdapter.Fill(this.trainDataSet.route_train);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trainDataSet.station". При необходимости она может быть перемещена или удалена.
            this.stationTableAdapter.Fill(this.trainDataSet.station);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = train.mdb"))
            {
                try
                {
                    if (comboBox1.SelectedItem != null)
                    {
                string FrSelect = @"select * from route_train where station_start =" + comboBox1.SelectedIndex + "and id_tckt = 1";
                OleDbDataAdapter comm = new OleDbDataAdapter(FrSelect, conn);
                DataTable dt = new DataTable();
                comm.Fill(dt);
                dataGridView1.DataSource = dt; //выводим в грид
                }
                if (comboBox2.SelectedItem != null)
                {
                    string FrSelect = @"select * from route_train where station_start =" + comboBox2.SelectedIndex + "";
                    OleDbDataAdapter comm = new OleDbDataAdapter(FrSelect, conn);
                    DataTable dt = new DataTable();
                    comm.Fill(dt);
                    dataGridView1.DataSource = dt; //выводим в грид
                }
                    if (dateTimePicker1.Value != null)
                    {
                        string FrSelect = @"select * from route_train where begin_date =" + dateTimePicker1 + "";
                        OleDbDataAdapter comm = new OleDbDataAdapter(FrSelect, conn);
                        DataTable dt = new DataTable();
                        comm.Fill(dt);
                        dataGridView1.DataSource = dt; //выводим в грид
                    }
                    if (dateTimePicker2.Value != null)
                    {
                        string FrSelect = @"select * from route_train where end_date =" + dateTimePicker2 + "";
                        OleDbDataAdapter comm = new OleDbDataAdapter(FrSelect, conn);
                        DataTable dt = new DataTable();
                        comm.Fill(dt);
                        dataGridView1.DataSource = dt; //выводим в грид
                    }
                }
                catch
                {
                    MessageBox.Show("Нет совпадений в данных");
                }
               

            }

            MessageBox.Show("Готово");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}

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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trainDataSet.station". При необходимости она может быть перемещена или удалена.
            this.stationTableAdapter.Fill(this.trainDataSet.station);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = train.mdb"))
            {
                OrgnzForm ooo = new OrgnzForm();
                conn.Open();
                OleDbCommand myOleDbCommand = conn.CreateCommand();
                OleDbParameter @station_start = new OleDbParameter("@station_start", OleDbType.Numeric);
                @station_start.Value = this.comboBox1.SelectedValue;
                myOleDbCommand.Parameters.Add(@station_start);
                myOleDbCommand.CommandText = @"select * from route_train where [station_start] = @station_start";
                OleDbDataAdapter comm = new OleDbDataAdapter(myOleDbCommand.CommandText, conn);
                DataTable dt = new DataTable();
                comm.Fill(dt);
                myOleDbCommand.ExecuteNonQuery();
                ooo.dataGridView1.DataSource = dt; //выводим в грид
            }
            this.Close();
        }
    }
}

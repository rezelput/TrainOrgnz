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
    public partial class AddRouteTrain : Form
    {

        
        public AddRouteTrain()
        {
            InitializeComponent();
           
        }

        private void AddRouteTrain_Load(object sender, EventArgs e)
        {

            ConnectDB conn = new ConnectDB();
            conn.openConnection();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trainDataSet.ticket". При необходимости она может быть перемещена или удалена.
            this.ticketTableAdapter.Fill(this.trainDataSet.ticket);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trainDataSet.station". При необходимости она может быть перемещена или удалена.
            this.stationTableAdapter.Fill(this.trainDataSet.station);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trainDataSet.track". При необходимости она может быть перемещена или удалена.
            this.trackTableAdapter.Fill(this.trainDataSet.track);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trainDataSet.type_wagon". При необходимости она может быть перемещена или удалена.
            this.type_wagonTableAdapter.Fill(this.trainDataSet.type_wagon);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trainDataSet.train". При необходимости она может быть перемещена или удалена.
            this.trainTableAdapter.Fill(this.trainDataSet.train);

        }

        private void button1_Click(object sender, EventArgs e)

        {
            OrgnzForm ogf = new OrgnzForm();
            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = train.mdb"))
            {
                string commText = "insert into route_train (id_track,id_train,id_tp_w,id_tckt," +
                    "begin_date, end_date, station_start, station_end) values (?, ?,?,?,?,?,?,?)";
                OleDbCommand comm = new OleDbCommand(commText, conn);
                comm.Parameters.AddWithValue("@id_track", (int)comboBox3.SelectedValue);
                comm.Parameters.AddWithValue("@id_train", (int)comboBox1.SelectedValue);
                comm.Parameters.AddWithValue("@id_tp_w", (int)comboBox2.SelectedValue);
                comm.Parameters.AddWithValue("@id_tckt", (int)comboBox6.SelectedValue);
                comm.Parameters.Add("@begin_date", OleDbType.Date).Value = dateTimePicker1.Value.ToShortDateString();
                comm.Parameters.Add("@end_date", OleDbType.Date).Value = dateTimePicker2.Value.ToShortDateString();
                comm.Parameters.AddWithValue("@station_start", (int)comboBox4.SelectedValue);
                comm.Parameters.AddWithValue("@station_end", (int)comboBox5.SelectedValue);
                conn.Open();
                try
                {
                    comm.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Добавить не удалось!");
                }
            }

        }
    }
}

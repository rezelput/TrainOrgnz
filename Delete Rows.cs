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
    public partial class Delete_Rows : Form
    {
        public Delete_Rows()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = train.mdb"))
                try
                {
                    //SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                int id_rt = int.Parse(this.textBox1.Text);
                string CommandText = "delete from route_train where id=@id_rt";
                OleDbCommand comm = new OleDbCommand(CommandText, conn);
                    comm.Parameters.Add("@id_rt", SqlDbType.Int);
                    comm.Parameters["@id_rt"].Value = id_rt;
                int UspeshnoeIzmenenie = comm.ExecuteNonQuery();
                    this.Close();
                if (UspeshnoeIzmenenie != 0)
                {
                    MessageBox.Show("Изменения внесены", "Изменение записи");
                }
                else
                {
                    MessageBox.Show("Не удалось внести изменения", "Изменение записи");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

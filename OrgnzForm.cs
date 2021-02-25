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
    public partial class OrgnzForm : Form
    {

        public OrgnzForm()
        {
            InitializeComponent();
            
        }

        private void OrgnzForm_Load(object sender, EventArgs e)
        {
            ConnectDB conn = new ConnectDB();
            conn.openConnection();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trainDataSet.route_train". При необходимости она может быть перемещена или удалена.
            this.route_trainTableAdapter.Fill(this.trainDataSet.route_train);

        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRouteTrain art = new AddRouteTrain();
            art.Show();
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditData ed = new EditData();
            ed.Show();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.route_trainTableAdapter.Fill(trainDataSet.route_train);
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.route_trainTableAdapter.Update(this.trainDataSet.route_train);
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete_Rows drt = new Delete_Rows();
            drt.Show();
            
        }
    }
}

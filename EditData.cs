using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainOrgnz
{
    public partial class EditData : Form
    {
        public EditData()
        {
            InitializeComponent();

        }

        private void EditTrack_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = EditTrack.Checked;
            comboBox2.Enabled = EditTrack.Checked;
            comboBox3.Enabled = EditTrack.Checked;
            comboBox6.Enabled = EditTrack.Checked;
        }

        private void EditTime_CheckedChanged(object sender, EventArgs e)
        {
            startDate.Enabled = EditTime.Checked;
            endDate.Enabled = EditTime.Checked;
        }

        private void EditData_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trainDataSet.ticket". При необходимости она может быть перемещена или удалена.
            this.ticketTableAdapter.Fill(this.trainDataSet.ticket);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trainDataSet.track". При необходимости она может быть перемещена или удалена.
            this.trackTableAdapter.Fill(this.trainDataSet.track);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trainDataSet.type_wagon". При необходимости она может быть перемещена или удалена.
            this.type_wagonTableAdapter.Fill(this.trainDataSet.type_wagon);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trainDataSet.train". При необходимости она может быть перемещена или удалена.
            this.trainTableAdapter.Fill(this.trainDataSet.train);

        }

        private void startDate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            this.startDate.Mask = @"00/00/0000900:00";
        }

        private void endDate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            this.endDate.Mask = @"00/00/0000900:00";
            DateTime date = DateTime.Parse(endDate.Text);
            
        }
    }
}

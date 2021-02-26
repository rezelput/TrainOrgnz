
namespace TrainOrgnz
{
    partial class Track
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.trainDataSet = new TrainOrgnz.trainDataSet();
            this.stationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stationTableAdapter = new TrainOrgnz.trainDataSetTableAdapters.stationTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.routetrainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.route_trainTableAdapter = new TrainOrgnz.trainDataSetTableAdapters.route_trainTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtrackDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtrainDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtpwDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtcktDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.begindateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationstartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.stationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routetrainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 164);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Маршрут";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.stationBindingSource;
            this.comboBox1.DisplayMember = "station";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(62, 75);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(149, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "id";
            // 
            // trainDataSet
            // 
            this.trainDataSet.DataSetName = "trainDataSet";
            this.trainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stationBindingSource
            // 
            this.stationBindingSource.DataMember = "station";
            this.stationBindingSource.DataSource = this.trainDataSet;
            // 
            // stationTableAdapter
            // 
            this.stationTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Станция отправления";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(307, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 135);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Время движения поезда";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Время прибытия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Время отправления";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Применить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idtrackDataGridViewTextBoxColumn,
            this.idtrainDataGridViewTextBoxColumn,
            this.idtpwDataGridViewTextBoxColumn,
            this.idtcktDataGridViewTextBoxColumn,
            this.begindateDataGridViewTextBoxColumn,
            this.enddateDataGridViewTextBoxColumn,
            this.stationstartDataGridViewTextBoxColumn,
            this.stationendDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.routetrainBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 235);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(563, 275);
            this.dataGridView1.TabIndex = 2;
            // 
            // routetrainBindingSource
            // 
            this.routetrainBindingSource.DataMember = "route_train";
            this.routetrainBindingSource.DataSource = this.trainDataSet;
            // 
            // route_trainTableAdapter
            // 
            this.route_trainTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // idtrackDataGridViewTextBoxColumn
            // 
            this.idtrackDataGridViewTextBoxColumn.DataPropertyName = "id_track";
            this.idtrackDataGridViewTextBoxColumn.HeaderText = "id_track";
            this.idtrackDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idtrackDataGridViewTextBoxColumn.Name = "idtrackDataGridViewTextBoxColumn";
            this.idtrackDataGridViewTextBoxColumn.Width = 125;
            // 
            // idtrainDataGridViewTextBoxColumn
            // 
            this.idtrainDataGridViewTextBoxColumn.DataPropertyName = "id_train";
            this.idtrainDataGridViewTextBoxColumn.HeaderText = "id_train";
            this.idtrainDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idtrainDataGridViewTextBoxColumn.Name = "idtrainDataGridViewTextBoxColumn";
            this.idtrainDataGridViewTextBoxColumn.Width = 125;
            // 
            // idtpwDataGridViewTextBoxColumn
            // 
            this.idtpwDataGridViewTextBoxColumn.DataPropertyName = "id_tp_w";
            this.idtpwDataGridViewTextBoxColumn.HeaderText = "id_tp_w";
            this.idtpwDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idtpwDataGridViewTextBoxColumn.Name = "idtpwDataGridViewTextBoxColumn";
            this.idtpwDataGridViewTextBoxColumn.Width = 125;
            // 
            // idtcktDataGridViewTextBoxColumn
            // 
            this.idtcktDataGridViewTextBoxColumn.DataPropertyName = "id_tckt";
            this.idtcktDataGridViewTextBoxColumn.HeaderText = "id_tckt";
            this.idtcktDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idtcktDataGridViewTextBoxColumn.Name = "idtcktDataGridViewTextBoxColumn";
            this.idtcktDataGridViewTextBoxColumn.Width = 125;
            // 
            // begindateDataGridViewTextBoxColumn
            // 
            this.begindateDataGridViewTextBoxColumn.DataPropertyName = "begin_date";
            this.begindateDataGridViewTextBoxColumn.HeaderText = "begin_date";
            this.begindateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.begindateDataGridViewTextBoxColumn.Name = "begindateDataGridViewTextBoxColumn";
            this.begindateDataGridViewTextBoxColumn.Width = 125;
            // 
            // enddateDataGridViewTextBoxColumn
            // 
            this.enddateDataGridViewTextBoxColumn.DataPropertyName = "end_date";
            this.enddateDataGridViewTextBoxColumn.HeaderText = "end_date";
            this.enddateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.enddateDataGridViewTextBoxColumn.Name = "enddateDataGridViewTextBoxColumn";
            this.enddateDataGridViewTextBoxColumn.Width = 125;
            // 
            // stationstartDataGridViewTextBoxColumn
            // 
            this.stationstartDataGridViewTextBoxColumn.DataPropertyName = "station_start";
            this.stationstartDataGridViewTextBoxColumn.HeaderText = "station_start";
            this.stationstartDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stationstartDataGridViewTextBoxColumn.Name = "stationstartDataGridViewTextBoxColumn";
            this.stationstartDataGridViewTextBoxColumn.Width = 125;
            // 
            // stationendDataGridViewTextBoxColumn
            // 
            this.stationendDataGridViewTextBoxColumn.DataPropertyName = "station_end";
            this.stationendDataGridViewTextBoxColumn.HeaderText = "station_end";
            this.stationendDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stationendDataGridViewTextBoxColumn.Name = "stationendDataGridViewTextBoxColumn";
            this.stationendDataGridViewTextBoxColumn.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Станция прибытия";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.stationBindingSource1;
            this.comboBox2.DisplayMember = "station";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(62, 125);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(149, 24);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.ValueMember = "id";
            // 
            // stationBindingSource1
            // 
            this.stationBindingSource1.DataMember = "station";
            this.stationBindingSource1.DataSource = this.trainDataSet;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(10, 52);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(170, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(10, 107);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(170, 22);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.Location = new System.Drawing.Point(148, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 27);
            this.button2.TabIndex = 3;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Track
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 520);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Track";
            this.Text = "Track";
            this.Load += new System.EventHandler(this.Track_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routetrainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private trainDataSet trainDataSet;
        private System.Windows.Forms.BindingSource stationBindingSource;
        private trainDataSetTableAdapters.stationTableAdapter stationTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource routetrainBindingSource;
        private trainDataSetTableAdapters.route_trainTableAdapter route_trainTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtrackDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtrainDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtpwDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtcktDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn begindateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationstartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationendDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource stationBindingSource1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button2;
    }
}
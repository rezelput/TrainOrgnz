
namespace TrainOrgnz
{
    partial class EditData
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
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainDataSet = new TrainOrgnz.trainDataSet();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.trackBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.trainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.typewagonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.MaskedTextBox();
            this.startDate = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.EditTime = new System.Windows.Forms.RadioButton();
            this.EditTrack = new System.Windows.Forms.RadioButton();
            this.trainTableAdapter = new TrainOrgnz.trainDataSetTableAdapters.trainTableAdapter();
            this.type_wagonTableAdapter = new TrainOrgnz.trainDataSetTableAdapters.type_wagonTableAdapter();
            this.trackTableAdapter = new TrainOrgnz.trainDataSetTableAdapters.trackTableAdapter();
            this.ticketTableAdapter = new TrainOrgnz.trainDataSetTableAdapters.ticketTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typewagonBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBox6);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 321);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные поездки";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Наличие билетов";
            // 
            // comboBox6
            // 
            this.comboBox6.DataSource = this.ticketBindingSource;
            this.comboBox6.DisplayMember = "cnt_ticket";
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(9, 271);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(152, 24);
            this.comboBox6.TabIndex = 7;
            this.comboBox6.ValueMember = "id";
            // 
            // ticketBindingSource
            // 
            this.ticketBindingSource.DataMember = "ticket";
            this.ticketBindingSource.DataSource = this.trainDataSet;
            // 
            // trainDataSet
            // 
            this.trainDataSet.DataSetName = "trainDataSet";
            this.trainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.trackBindingSource;
            this.comboBox3.DisplayMember = "name_track";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(9, 215);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(152, 24);
            this.comboBox3.TabIndex = 9;
            this.comboBox3.ValueMember = "id";
            // 
            // trackBindingSource
            // 
            this.trackBindingSource.DataMember = "track";
            this.trackBindingSource.DataSource = this.trainDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Номер поезда";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.trainBindingSource;
            this.comboBox1.DisplayMember = "name_train";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(9, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 24);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.ValueMember = "id";
            // 
            // trainBindingSource
            // 
            this.trainBindingSource.DataMember = "train";
            this.trainBindingSource.DataSource = this.trainDataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Тип вагона";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Направление";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.typewagonBindingSource;
            this.comboBox2.DisplayMember = "name_type";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(9, 124);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(152, 24);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.ValueMember = "id";
            // 
            // typewagonBindingSource
            // 
            this.typewagonBindingSource.DataMember = "type_wagon";
            this.typewagonBindingSource.DataSource = this.trainDataSet;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.endDate);
            this.groupBox2.Controls.Add(this.startDate);
            this.groupBox2.Location = new System.Drawing.Point(310, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 165);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Время движения поезда";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Дата и время прибытия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Дата и время отправления";
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(6, 125);
            this.endDate.Mask = "00/00/0000 90:00";
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(175, 22);
            this.endDate.TabIndex = 1;
            this.endDate.ValidatingType = typeof(System.DateTime);
            this.endDate.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.endDate_MaskInputRejected);
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(6, 54);
            this.startDate.Mask = "00/00/0000 90:00";
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(175, 22);
            this.startDate.TabIndex = 0;
            this.startDate.ValidatingType = typeof(System.DateTime);
            this.startDate.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.startDate_MaskInputRejected);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(395, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "Применить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditTime
            // 
            this.EditTime.AutoSize = true;
            this.EditTime.Location = new System.Drawing.Point(310, 46);
            this.EditTime.Name = "EditTime";
            this.EditTime.Size = new System.Drawing.Size(219, 21);
            this.EditTime.TabIndex = 5;
            this.EditTime.TabStop = true;
            this.EditTime.Text = "Редактировать время и дату";
            this.EditTime.UseVisualStyleBackColor = true;
            this.EditTime.CheckedChanged += new System.EventHandler(this.EditTime_CheckedChanged);
            // 
            // EditTrack
            // 
            this.EditTrack.AutoSize = true;
            this.EditTrack.Location = new System.Drawing.Point(21, 46);
            this.EditTrack.Name = "EditTrack";
            this.EditTrack.Size = new System.Drawing.Size(241, 21);
            this.EditTrack.TabIndex = 6;
            this.EditTrack.TabStop = true;
            this.EditTrack.Text = "Редактировать данные поездки";
            this.EditTrack.UseVisualStyleBackColor = true;
            this.EditTrack.CheckedChanged += new System.EventHandler(this.EditTrack_CheckedChanged);
            // 
            // trainTableAdapter
            // 
            this.trainTableAdapter.ClearBeforeFill = true;
            // 
            // type_wagonTableAdapter
            // 
            this.type_wagonTableAdapter.ClearBeforeFill = true;
            // 
            // trackTableAdapter
            // 
            this.trackTableAdapter.ClearBeforeFill = true;
            // 
            // ticketTableAdapter
            // 
            this.ticketTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Данные по id...";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.EditTrack);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.EditTime);
            this.groupBox3.Location = new System.Drawing.Point(12, 78);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(553, 415);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 9;
            // 
            // EditData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 505);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label7);
            this.Name = "EditData";
            this.Text = "EditData";
            this.Load += new System.EventHandler(this.EditData_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typewagonBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox endDate;
        private System.Windows.Forms.MaskedTextBox startDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton EditTime;
        private System.Windows.Forms.RadioButton EditTrack;
        private trainDataSet trainDataSet;
        private System.Windows.Forms.BindingSource trainBindingSource;
        private trainDataSetTableAdapters.trainTableAdapter trainTableAdapter;
        private System.Windows.Forms.BindingSource typewagonBindingSource;
        private trainDataSetTableAdapters.type_wagonTableAdapter type_wagonTableAdapter;
        private System.Windows.Forms.BindingSource trackBindingSource;
        private trainDataSetTableAdapters.trackTableAdapter trackTableAdapter;
        private System.Windows.Forms.BindingSource ticketBindingSource;
        private trainDataSetTableAdapters.ticketTableAdapter ticketTableAdapter;
        private System.Windows.Forms.ComboBox comboBox3;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
    }
}
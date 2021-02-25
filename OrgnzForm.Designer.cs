
namespace TrainOrgnz
{
    partial class OrgnzForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtrackDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtrainDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtpwDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtcktDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.begindateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationstartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routetrainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainDataSet = new TrainOrgnz.trainDataSet();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.данныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.наличиеБилетовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выбранныйМаршрутToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.route_trainTableAdapter = new TrainOrgnz.trainDataSetTableAdapters.route_trainTableAdapter();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routetrainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(13, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(821, 356);
            this.dataGridView1.TabIndex = 0;
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
            // routetrainBindingSource
            // 
            this.routetrainBindingSource.DataMember = "route_train";
            this.routetrainBindingSource.DataSource = this.trainDataSet;
            // 
            // trainDataSet
            // 
            this.trainDataSet.DataSetName = "trainDataSet";
            this.trainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.данныеToolStripMenuItem,
            this.фильтрыToolStripMenuItem,
            this.закрытьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(846, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // данныеToolStripMenuItem
            // 
            this.данныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.обновитьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.данныеToolStripMenuItem.Name = "данныеToolStripMenuItem";
            this.данныеToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.данныеToolStripMenuItem.Text = "Данные";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.обновитьToolStripMenuItem.Text = "Обновить";
            this.обновитьToolStripMenuItem.Click += new System.EventHandler(this.обновитьToolStripMenuItem_Click);
            // 
            // фильтрыToolStripMenuItem
            // 
            this.фильтрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.наличиеБилетовToolStripMenuItem,
            this.выбранныйМаршрутToolStripMenuItem});
            this.фильтрыToolStripMenuItem.Name = "фильтрыToolStripMenuItem";
            this.фильтрыToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.фильтрыToolStripMenuItem.Text = "Фильтры";
            // 
            // наличиеБилетовToolStripMenuItem
            // 
            this.наличиеБилетовToolStripMenuItem.Name = "наличиеБилетовToolStripMenuItem";
            this.наличиеБилетовToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.наличиеБилетовToolStripMenuItem.Text = "Свободные места";
            // 
            // выбранныйМаршрутToolStripMenuItem
            // 
            this.выбранныйМаршрутToolStripMenuItem.Name = "выбранныйМаршрутToolStripMenuItem";
            this.выбранныйМаршрутToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.выбранныйМаршрутToolStripMenuItem.Text = "Выбранный маршрут";
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // route_trainTableAdapter
            // 
            this.route_trainTableAdapter.ClearBeforeFill = true;
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // OrgnzForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 417);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OrgnzForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.OrgnzForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routetrainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem данныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem наличиеБилетовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выбранныйМаршрутToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        public trainDataSet trainDataSet;
        public System.Windows.Forms.BindingSource routetrainBindingSource;
        public trainDataSetTableAdapters.route_trainTableAdapter route_trainTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtrackDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtrainDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtpwDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtcktDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn begindateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationstartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationendDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
    }
}


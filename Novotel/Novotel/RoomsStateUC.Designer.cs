namespace Novotel
{
    partial class RoomsStateUC
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewClosedRooms = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apartamentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDbDataSet = new Novotel.HotelDbDataSet();
            this.apartamentTableAdapter = new Novotel.HotelDbDataSetTableAdapters.apartamentTableAdapter();
            this.dataGridViewOpened = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apartamentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lockHistoryTableAdapter1 = new Novotel.HotelDbDataSetTableAdapters.lockHistoryTableAdapter();
            this.groupBoxClosed = new System.Windows.Forms.GroupBox();
            this.groupBoxOpen = new System.Windows.Forms.GroupBox();
            this.buttonImport = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelHolder = new System.Windows.Forms.Label();
            this.labelKey = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clientBookingTableAdapter1 = new Novotel.HotelDbDataSetTableAdapters.clientBookingTableAdapter();
            this.queriesTableAdapter1 = new Novotel.HotelDbDataSetTableAdapters.QueriesTableAdapter();
            this.clientTableAdapter1 = new Novotel.HotelDbDataSetTableAdapters.clientTableAdapter();
            this.buttonRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClosedRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartamentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOpened)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartamentBindingSource1)).BeginInit();
            this.groupBoxClosed.SuspendLayout();
            this.groupBoxOpen.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewClosedRooms
            // 
            this.dataGridViewClosedRooms.AutoGenerateColumns = false;
            this.dataGridViewClosedRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClosedRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClosedRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.classidDataGridViewTextBoxColumn});
            this.dataGridViewClosedRooms.DataSource = this.apartamentBindingSource;
            this.dataGridViewClosedRooms.Location = new System.Drawing.Point(24, 37);
            this.dataGridViewClosedRooms.Name = "dataGridViewClosedRooms";
            this.dataGridViewClosedRooms.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewClosedRooms.RowHeadersVisible = false;
            this.dataGridViewClosedRooms.RowTemplate.Height = 28;
            this.dataGridViewClosedRooms.Size = new System.Drawing.Size(403, 535);
            this.dataGridViewClosedRooms.TabIndex = 0;
            this.dataGridViewClosedRooms.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClosedRooms_CellEnter);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // classidDataGridViewTextBoxColumn
            // 
            this.classidDataGridViewTextBoxColumn.DataPropertyName = "class_id";
            this.classidDataGridViewTextBoxColumn.HeaderText = "class";
            this.classidDataGridViewTextBoxColumn.Name = "classidDataGridViewTextBoxColumn";
            // 
            // apartamentBindingSource
            // 
            this.apartamentBindingSource.DataMember = "apartament";
            this.apartamentBindingSource.DataSource = this.hotelDbDataSet;
            // 
            // hotelDbDataSet
            // 
            this.hotelDbDataSet.DataSetName = "HotelDbDataSet";
            this.hotelDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // apartamentTableAdapter
            // 
            this.apartamentTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewOpened
            // 
            this.dataGridViewOpened.AutoGenerateColumns = false;
            this.dataGridViewOpened.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOpened.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOpened.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.classidDataGridViewTextBoxColumn1});
            this.dataGridViewOpened.DataSource = this.apartamentBindingSource1;
            this.dataGridViewOpened.Location = new System.Drawing.Point(31, 37);
            this.dataGridViewOpened.Name = "dataGridViewOpened";
            this.dataGridViewOpened.RowHeadersVisible = false;
            this.dataGridViewOpened.RowTemplate.Height = 28;
            this.dataGridViewOpened.Size = new System.Drawing.Size(403, 535);
            this.dataGridViewOpened.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // classidDataGridViewTextBoxColumn1
            // 
            this.classidDataGridViewTextBoxColumn1.DataPropertyName = "class_id";
            this.classidDataGridViewTextBoxColumn1.HeaderText = "class";
            this.classidDataGridViewTextBoxColumn1.Name = "classidDataGridViewTextBoxColumn1";
            // 
            // apartamentBindingSource1
            // 
            this.apartamentBindingSource1.DataMember = "apartament";
            this.apartamentBindingSource1.DataSource = this.hotelDbDataSet;
            // 
            // lockHistoryTableAdapter1
            // 
            this.lockHistoryTableAdapter1.ClearBeforeFill = true;
            // 
            // groupBoxClosed
            // 
            this.groupBoxClosed.Controls.Add(this.dataGridViewClosedRooms);
            this.groupBoxClosed.Location = new System.Drawing.Point(29, 35);
            this.groupBoxClosed.Name = "groupBoxClosed";
            this.groupBoxClosed.Size = new System.Drawing.Size(455, 601);
            this.groupBoxClosed.TabIndex = 1;
            this.groupBoxClosed.TabStop = false;
            this.groupBoxClosed.Text = "Closed apartaments";
            // 
            // groupBoxOpen
            // 
            this.groupBoxOpen.Controls.Add(this.dataGridViewOpened);
            this.groupBoxOpen.Location = new System.Drawing.Point(833, 35);
            this.groupBoxOpen.Name = "groupBoxOpen";
            this.groupBoxOpen.Size = new System.Drawing.Size(455, 601);
            this.groupBoxOpen.TabIndex = 2;
            this.groupBoxOpen.TabStop = false;
            this.groupBoxOpen.Text = "Open apartaments";
            // 
            // buttonImport
            // 
            this.buttonImport.Location = new System.Drawing.Point(527, 406);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(100, 31);
            this.buttonImport.TabIndex = 3;
            this.buttonImport.Text = "import .txt";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelTime);
            this.groupBox1.Controls.Add(this.labelHolder);
            this.groupBox1.Controls.Add(this.labelKey);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(491, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 342);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Particular Info";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelTime.Location = new System.Drawing.Point(66, 276);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(14, 20);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "-";
            // 
            // labelHolder
            // 
            this.labelHolder.AutoSize = true;
            this.labelHolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelHolder.Location = new System.Drawing.Point(66, 194);
            this.labelHolder.Name = "labelHolder";
            this.labelHolder.Size = new System.Drawing.Size(14, 20);
            this.labelHolder.TabIndex = 0;
            this.labelHolder.Text = "-";
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelKey.Location = new System.Drawing.Point(66, 112);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(14, 20);
            this.labelKey.TabIndex = 0;
            this.labelKey.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Key holder:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Last used key:";
            // 
            // clientBookingTableAdapter1
            // 
            this.clientBookingTableAdapter1.ClearBeforeFill = true;
            // 
            // clientTableAdapter1
            // 
            this.clientTableAdapter1.ClearBeforeFill = true;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Image = global::Novotel.Properties.Resources.Refresh_icon;
            this.buttonRefresh.Location = new System.Drawing.Point(684, 406);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(96, 31);
            this.buttonRefresh.TabIndex = 3;
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // RoomsStateUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonImport);
            this.Controls.Add(this.groupBoxOpen);
            this.Controls.Add(this.groupBoxClosed);
            this.Name = "RoomsStateUC";
            this.Size = new System.Drawing.Size(1320, 660);
            this.Load += new System.EventHandler(this.RoomsStateUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClosedRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartamentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOpened)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartamentBindingSource1)).EndInit();
            this.groupBoxClosed.ResumeLayout(false);
            this.groupBoxOpen.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClosedRooms;
        private System.Windows.Forms.BindingSource apartamentBindingSource;
        private HotelDbDataSet hotelDbDataSet;
        private HotelDbDataSetTableAdapters.apartamentTableAdapter apartamentTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewOpened;
        private HotelDbDataSetTableAdapters.lockHistoryTableAdapter lockHistoryTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn classidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource apartamentBindingSource1;
        private System.Windows.Forms.GroupBox groupBoxClosed;
        private System.Windows.Forms.GroupBox groupBoxOpen;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelHolder;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private HotelDbDataSetTableAdapters.clientBookingTableAdapter clientBookingTableAdapter1;
        private HotelDbDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private HotelDbDataSetTableAdapters.clientTableAdapter clientTableAdapter1;
    }
}

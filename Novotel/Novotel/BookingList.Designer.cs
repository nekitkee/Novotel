namespace Novotel
{
    partial class BookingList
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
            this.dataGridViewBooking = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apartamentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDbDataSet = new Novotel.HotelDbDataSet();
            this.bookingTableAdapter = new Novotel.HotelDbDataSetTableAdapters.bookingTableAdapter();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new Novotel.HotelDbDataSetTableAdapters.clientTableAdapter();
            this.clientBookingTableAdapter = new Novotel.HotelDbDataSetTableAdapters.clientBookingTableAdapter();
            this.dataGridViewClientBooking = new System.Windows.Forms.DataGridView();
            this.pCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keyidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxBookings = new System.Windows.Forms.GroupBox();
            this.groupBoxChangeBooking = new System.Windows.Forms.GroupBox();
            this.buttonBookingSave = new System.Windows.Forms.Button();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBookingId = new System.Windows.Forms.TextBox();
            this.textBoxApartament = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxBookingClients = new System.Windows.Forms.GroupBox();
            this.groupBoxChangeBookingClient = new System.Windows.Forms.GroupBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonClientBookingUpdate = new System.Windows.Forms.Button();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.keyTableAdapter1 = new Novotel.HotelDbDataSetTableAdapters.keyTableAdapter();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.checkBoxVerify = new System.Windows.Forms.CheckBox();
            this.queriesTableAdapter1 = new Novotel.HotelDbDataSetTableAdapters.QueriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientBooking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBookingBindingSource)).BeginInit();
            this.groupBoxBookings.SuspendLayout();
            this.groupBoxChangeBooking.SuspendLayout();
            this.groupBoxBookingClients.SuspendLayout();
            this.groupBoxChangeBookingClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewBooking
            // 
            this.dataGridViewBooking.AutoGenerateColumns = false;
            this.dataGridViewBooking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.checkinDataGridViewTextBoxColumn,
            this.checkoutDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.apartamentidDataGridViewTextBoxColumn});
            this.dataGridViewBooking.DataSource = this.bookingBindingSource;
            this.dataGridViewBooking.Location = new System.Drawing.Point(17, 37);
            this.dataGridViewBooking.Name = "dataGridViewBooking";
            this.dataGridViewBooking.RowHeadersVisible = false;
            this.dataGridViewBooking.RowTemplate.Height = 28;
            this.dataGridViewBooking.Size = new System.Drawing.Size(654, 348);
            this.dataGridViewBooking.TabIndex = 0;
            this.dataGridViewBooking.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBooking_CellEnter);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // checkinDataGridViewTextBoxColumn
            // 
            this.checkinDataGridViewTextBoxColumn.DataPropertyName = "checkin";
            this.checkinDataGridViewTextBoxColumn.HeaderText = "checkin";
            this.checkinDataGridViewTextBoxColumn.Name = "checkinDataGridViewTextBoxColumn";
            // 
            // checkoutDataGridViewTextBoxColumn
            // 
            this.checkoutDataGridViewTextBoxColumn.DataPropertyName = "checkout";
            this.checkoutDataGridViewTextBoxColumn.HeaderText = "checkout";
            this.checkoutDataGridViewTextBoxColumn.Name = "checkoutDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // apartamentidDataGridViewTextBoxColumn
            // 
            this.apartamentidDataGridViewTextBoxColumn.DataPropertyName = "apartament_id";
            this.apartamentidDataGridViewTextBoxColumn.HeaderText = "apartament";
            this.apartamentidDataGridViewTextBoxColumn.Name = "apartamentidDataGridViewTextBoxColumn";
            // 
            // bookingBindingSource
            // 
            this.bookingBindingSource.DataMember = "booking";
            this.bookingBindingSource.DataSource = this.hotelDbDataSet;
            // 
            // hotelDbDataSet
            // 
            this.hotelDbDataSet.DataSetName = "HotelDbDataSet";
            this.hotelDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookingTableAdapter
            // 
            this.bookingTableAdapter.ClearBeforeFill = true;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "client";
            this.clientBindingSource.DataSource = this.hotelDbDataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // clientBookingTableAdapter
            // 
            this.clientBookingTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewClientBooking
            // 
            this.dataGridViewClientBooking.AutoGenerateColumns = false;
            this.dataGridViewClientBooking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClientBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientBooking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pCDataGridViewTextBoxColumn,
            this.keyidDataGridViewTextBoxColumn});
            this.dataGridViewClientBooking.DataSource = this.clientBookingBindingSource;
            this.dataGridViewClientBooking.Location = new System.Drawing.Point(25, 36);
            this.dataGridViewClientBooking.Name = "dataGridViewClientBooking";
            this.dataGridViewClientBooking.RowHeadersVisible = false;
            this.dataGridViewClientBooking.RowTemplate.Height = 28;
            this.dataGridViewClientBooking.Size = new System.Drawing.Size(542, 262);
            this.dataGridViewClientBooking.TabIndex = 1;
            this.dataGridViewClientBooking.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClientBooking_CellEnter);
            // 
            // pCDataGridViewTextBoxColumn
            // 
            this.pCDataGridViewTextBoxColumn.DataPropertyName = "PC";
            this.pCDataGridViewTextBoxColumn.HeaderText = "PC";
            this.pCDataGridViewTextBoxColumn.Name = "pCDataGridViewTextBoxColumn";
            // 
            // keyidDataGridViewTextBoxColumn
            // 
            this.keyidDataGridViewTextBoxColumn.DataPropertyName = "key_id";
            this.keyidDataGridViewTextBoxColumn.HeaderText = "key";
            this.keyidDataGridViewTextBoxColumn.Name = "keyidDataGridViewTextBoxColumn";
            // 
            // clientBookingBindingSource
            // 
            this.clientBookingBindingSource.DataMember = "clientBooking";
            this.clientBookingBindingSource.DataSource = this.hotelDbDataSet;
            // 
            // groupBoxBookings
            // 
            this.groupBoxBookings.Controls.Add(this.groupBoxChangeBooking);
            this.groupBoxBookings.Controls.Add(this.dataGridViewBooking);
            this.groupBoxBookings.Location = new System.Drawing.Point(17, 18);
            this.groupBoxBookings.Name = "groupBoxBookings";
            this.groupBoxBookings.Size = new System.Drawing.Size(690, 622);
            this.groupBoxBookings.TabIndex = 2;
            this.groupBoxBookings.TabStop = false;
            this.groupBoxBookings.Text = "Bookings";
            // 
            // groupBoxChangeBooking
            // 
            this.groupBoxChangeBooking.Controls.Add(this.buttonBookingSave);
            this.groupBoxChangeBooking.Controls.Add(this.dateTimePickerTo);
            this.groupBoxChangeBooking.Controls.Add(this.label1);
            this.groupBoxChangeBooking.Controls.Add(this.dateTimePickerFrom);
            this.groupBoxChangeBooking.Controls.Add(this.label4);
            this.groupBoxChangeBooking.Controls.Add(this.textBoxPrice);
            this.groupBoxChangeBooking.Controls.Add(this.label5);
            this.groupBoxChangeBooking.Controls.Add(this.label3);
            this.groupBoxChangeBooking.Controls.Add(this.textBoxBookingId);
            this.groupBoxChangeBooking.Controls.Add(this.textBoxApartament);
            this.groupBoxChangeBooking.Controls.Add(this.label2);
            this.groupBoxChangeBooking.Enabled = false;
            this.groupBoxChangeBooking.Location = new System.Drawing.Point(17, 396);
            this.groupBoxChangeBooking.Name = "groupBoxChangeBooking";
            this.groupBoxChangeBooking.Size = new System.Drawing.Size(654, 220);
            this.groupBoxChangeBooking.TabIndex = 4;
            this.groupBoxChangeBooking.TabStop = false;
            this.groupBoxChangeBooking.Text = "change";
            // 
            // buttonBookingSave
            // 
            this.buttonBookingSave.Image = global::Novotel.Properties.Resources.up_icon;
            this.buttonBookingSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBookingSave.Location = new System.Drawing.Point(477, 165);
            this.buttonBookingSave.Name = "buttonBookingSave";
            this.buttonBookingSave.Size = new System.Drawing.Size(154, 36);
            this.buttonBookingSave.TabIndex = 0;
            this.buttonBookingSave.Text = "update booking";
            this.buttonBookingSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBookingSave.UseVisualStyleBackColor = true;
            this.buttonBookingSave.Click += new System.EventHandler(this.buttonBookingSave_Click);
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(437, 89);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerTo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "booking id";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(437, 35);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerFrom.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "checkin";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(107, 147);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(187, 26);
            this.textBoxPrice.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(346, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "checkout";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "price";
            // 
            // textBoxBookingId
            // 
            this.textBoxBookingId.Location = new System.Drawing.Point(107, 35);
            this.textBoxBookingId.Name = "textBoxBookingId";
            this.textBoxBookingId.Size = new System.Drawing.Size(187, 26);
            this.textBoxBookingId.TabIndex = 2;
            // 
            // textBoxApartament
            // 
            this.textBoxApartament.Location = new System.Drawing.Point(107, 89);
            this.textBoxApartament.Name = "textBoxApartament";
            this.textBoxApartament.Size = new System.Drawing.Size(187, 26);
            this.textBoxApartament.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "apartament";
            // 
            // groupBoxBookingClients
            // 
            this.groupBoxBookingClients.Controls.Add(this.groupBoxChangeBookingClient);
            this.groupBoxBookingClients.Controls.Add(this.dataGridViewClientBooking);
            this.groupBoxBookingClients.Location = new System.Drawing.Point(714, 18);
            this.groupBoxBookingClients.Name = "groupBoxBookingClients";
            this.groupBoxBookingClients.Size = new System.Drawing.Size(589, 530);
            this.groupBoxBookingClients.TabIndex = 3;
            this.groupBoxBookingClients.TabStop = false;
            this.groupBoxBookingClients.Text = "Clients per booking";
            // 
            // groupBoxChangeBookingClient
            // 
            this.groupBoxChangeBookingClient.Controls.Add(this.buttonAdd);
            this.groupBoxChangeBookingClient.Controls.Add(this.buttonDelete);
            this.groupBoxChangeBookingClient.Controls.Add(this.buttonClientBookingUpdate);
            this.groupBoxChangeBookingClient.Controls.Add(this.textBoxKey);
            this.groupBoxChangeBookingClient.Controls.Add(this.label7);
            this.groupBoxChangeBookingClient.Controls.Add(this.textBoxPC);
            this.groupBoxChangeBookingClient.Controls.Add(this.label6);
            this.groupBoxChangeBookingClient.Enabled = false;
            this.groupBoxChangeBookingClient.Location = new System.Drawing.Point(26, 325);
            this.groupBoxChangeBookingClient.Name = "groupBoxChangeBookingClient";
            this.groupBoxChangeBookingClient.Size = new System.Drawing.Size(542, 183);
            this.groupBoxChangeBookingClient.TabIndex = 2;
            this.groupBoxChangeBookingClient.TabStop = false;
            this.groupBoxChangeBookingClient.Text = "cahnge";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Image = global::Novotel.Properties.Resources.add_icon__1_;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(402, 23);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(122, 36);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "add person";
            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Image = global::Novotel.Properties.Resources.delete_icon;
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.Location = new System.Drawing.Point(385, 131);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(139, 36);
            this.buttonDelete.TabIndex = 0;
            this.buttonDelete.Text = "delete person";
            this.buttonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonClientBookingUpdate
            // 
            this.buttonClientBookingUpdate.Image = global::Novotel.Properties.Resources.up_icon;
            this.buttonClientBookingUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClientBookingUpdate.Location = new System.Drawing.Point(402, 77);
            this.buttonClientBookingUpdate.Name = "buttonClientBookingUpdate";
            this.buttonClientBookingUpdate.Size = new System.Drawing.Size(122, 36);
            this.buttonClientBookingUpdate.TabIndex = 0;
            this.buttonClientBookingUpdate.Text = "update key";
            this.buttonClientBookingUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonClientBookingUpdate.UseVisualStyleBackColor = true;
            this.buttonClientBookingUpdate.Click += new System.EventHandler(this.buttonClientBookingUpdate_Click);
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(61, 80);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(242, 26);
            this.textBoxKey.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "key";
            // 
            // textBoxPC
            // 
            this.textBoxPC.Location = new System.Drawing.Point(61, 30);
            this.textBoxPC.Name = "textBoxPC";
            this.textBoxPC.Size = new System.Drawing.Size(242, 26);
            this.textBoxPC.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "PC";
            // 
            // keyTableAdapter1
            // 
            this.keyTableAdapter1.ClearBeforeFill = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Image = global::Novotel.Properties.Resources.Actions_edit_clear_icon;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(867, 579);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(105, 36);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "   cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Image = global::Novotel.Properties.Resources.Pencil_icon;
            this.buttonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEdit.Location = new System.Drawing.Point(739, 579);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(105, 36);
            this.buttonEdit.TabIndex = 0;
            this.buttonEdit.Text = "   edit...";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // checkBoxVerify
            // 
            this.checkBoxVerify.AutoSize = true;
            this.checkBoxVerify.Checked = true;
            this.checkBoxVerify.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxVerify.Location = new System.Drawing.Point(1006, 586);
            this.checkBoxVerify.Name = "checkBoxVerify";
            this.checkBoxVerify.Size = new System.Drawing.Size(71, 24);
            this.checkBoxVerify.TabIndex = 4;
            this.checkBoxVerify.Text = "verify";
            this.checkBoxVerify.UseVisualStyleBackColor = true;
            // 
            // BookingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBoxVerify);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.groupBoxBookings);
            this.Controls.Add(this.groupBoxBookingClients);
            this.Name = "BookingList";
            this.Size = new System.Drawing.Size(1320, 660);
            this.Load += new System.EventHandler(this.BookingList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientBooking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBookingBindingSource)).EndInit();
            this.groupBoxBookings.ResumeLayout(false);
            this.groupBoxChangeBooking.ResumeLayout(false);
            this.groupBoxChangeBooking.PerformLayout();
            this.groupBoxBookingClients.ResumeLayout(false);
            this.groupBoxChangeBookingClient.ResumeLayout(false);
            this.groupBoxChangeBookingClient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBooking;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private HotelDbDataSet hotelDbDataSet;
        private HotelDbDataSetTableAdapters.bookingTableAdapter bookingTableAdapter;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private HotelDbDataSetTableAdapters.clientTableAdapter clientTableAdapter;
        private HotelDbDataSetTableAdapters.clientBookingTableAdapter clientBookingTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewClientBooking;
        private System.Windows.Forms.BindingSource clientBookingBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartamentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBoxBookings;
        private System.Windows.Forms.TextBox textBoxBookingId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxBookingClients;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxApartament;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxChangeBooking;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonBookingSave;
        private System.Windows.Forms.Button buttonClientBookingUpdate;
        private System.Windows.Forms.GroupBox groupBoxChangeBookingClient;
        private System.Windows.Forms.TextBox textBoxPC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
        private HotelDbDataSetTableAdapters.keyTableAdapter keyTableAdapter1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.CheckBox checkBoxVerify;
        private HotelDbDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
    }
}

namespace Novotel
{
    partial class ClientList
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
            this.groupBoxPerson = new System.Windows.Forms.GroupBox();
            this.dateTimeBirthday = new System.Windows.Forms.DateTimePicker();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDbDataSet1 = new Novotel.HotelDbDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPC = new System.Windows.Forms.TextBox();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.pCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonAll = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.AditInf_groupBox = new System.Windows.Forms.GroupBox();
            this.labelCheckout = new System.Windows.Forms.Label();
            this.labelCheckoutText = new System.Windows.Forms.Label();
            this.labelCheckin = new System.Windows.Forms.Label();
            this.labelKey = new System.Windows.Forms.Label();
            this.labelCheckinText = new System.Windows.Forms.Label();
            this.labelRoom = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelRoomText = new System.Windows.Forms.Label();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.clientclientBookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDbDataSet = new Novotel.HotelDbDataSet();
            this.clientTableAdapter = new Novotel.HotelDbDataSetTableAdapters.clientTableAdapter();
            this.clientBookingTableAdapter = new Novotel.HotelDbDataSetTableAdapters.clientBookingTableAdapter();
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingTableAdapter = new Novotel.HotelDbDataSetTableAdapters.bookingTableAdapter();
            this.tableAdapterManager = new Novotel.HotelDbDataSetTableAdapters.TableAdapterManager();
            this.buttonNew = new System.Windows.Forms.Button();
            this.labelClientAddResult = new System.Windows.Forms.Label();
            this.groupBoxPerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.AditInf_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientclientBookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPerson
            // 
            this.groupBoxPerson.Controls.Add(this.dateTimeBirthday);
            this.groupBoxPerson.Controls.Add(this.label4);
            this.groupBoxPerson.Controls.Add(this.label3);
            this.groupBoxPerson.Controls.Add(this.textBoxPC);
            this.groupBoxPerson.Controls.Add(this.radioButtonFemale);
            this.groupBoxPerson.Controls.Add(this.label2);
            this.groupBoxPerson.Controls.Add(this.radioButtonMale);
            this.groupBoxPerson.Controls.Add(this.textBoxLastName);
            this.groupBoxPerson.Controls.Add(this.label1);
            this.groupBoxPerson.Controls.Add(this.textBoxFirstName);
            this.groupBoxPerson.Location = new System.Drawing.Point(44, 39);
            this.groupBoxPerson.Name = "groupBoxPerson";
            this.groupBoxPerson.Size = new System.Drawing.Size(437, 268);
            this.groupBoxPerson.TabIndex = 0;
            this.groupBoxPerson.TabStop = false;
            this.groupBoxPerson.Text = "person";
            // 
            // dateTimeBirthday
            // 
            this.dateTimeBirthday.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientBindingSource, "birthday", true));
            this.dateTimeBirthday.Location = new System.Drawing.Point(156, 167);
            this.dateTimeBirthday.Name = "dateTimeBirthday";
            this.dateTimeBirthday.Size = new System.Drawing.Size(235, 26);
            this.dateTimeBirthday.TabIndex = 4;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "client";
            this.clientBindingSource.DataSource = this.hotelDbDataSet1;
            // 
            // hotelDbDataSet1
            // 
            this.hotelDbDataSet1.DataSetName = "HotelDbDataSet";
            this.hotelDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Birthday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Person code";
            // 
            // textBoxPC
            // 
            this.textBoxPC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "PC", true));
            this.textBoxPC.Location = new System.Drawing.Point(156, 127);
            this.textBoxPC.Name = "textBoxPC";
            this.textBoxPC.Size = new System.Drawing.Size(235, 26);
            this.textBoxPC.TabIndex = 0;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(152, 212);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(82, 24);
            this.radioButtonFemale.TabIndex = 2;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lastname";
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(47, 212);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(68, 24);
            this.radioButtonMale.TabIndex = 2;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "lastname", true));
            this.textBoxLastName.Location = new System.Drawing.Point(156, 87);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(235, 26);
            this.textBoxLastName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Firstname";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "firstname", true));
            this.textBoxFirstName.Location = new System.Drawing.Point(156, 47);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(235, 26);
            this.textBoxFirstName.TabIndex = 0;
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.AutoGenerateColumns = false;
            this.dataGridViewClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pCDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.genderDataGridViewCheckBoxColumn});
            this.dataGridViewClients.DataSource = this.clientBindingSource;
            this.dataGridViewClients.Location = new System.Drawing.Point(524, 126);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.ReadOnly = true;
            this.dataGridViewClients.RowHeadersVisible = false;
            this.dataGridViewClients.RowTemplate.Height = 28;
            this.dataGridViewClients.Size = new System.Drawing.Size(765, 494);
            this.dataGridViewClients.TabIndex = 1;
            this.dataGridViewClients.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClients_CellEnter);
            this.dataGridViewClients.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewClients_MouseClick);
            // 
            // pCDataGridViewTextBoxColumn
            // 
            this.pCDataGridViewTextBoxColumn.DataPropertyName = "PC";
            this.pCDataGridViewTextBoxColumn.HeaderText = "PC";
            this.pCDataGridViewTextBoxColumn.Name = "pCDataGridViewTextBoxColumn";
            this.pCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "firstname";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "lastname";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "birthday";
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            this.birthdayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewCheckBoxColumn
            // 
            this.genderDataGridViewCheckBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewCheckBoxColumn.HeaderText = "gender";
            this.genderDataGridViewCheckBoxColumn.Name = "genderDataGridViewCheckBoxColumn";
            this.genderDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(166, 326);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(96, 30);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(275, 326);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(96, 30);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(384, 326);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(96, 30);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxSearch);
            this.groupBox2.Location = new System.Drawing.Point(524, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(445, 67);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(77, 25);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(351, 26);
            this.textBoxSearch.TabIndex = 0;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // buttonAll
            // 
            this.buttonAll.Location = new System.Drawing.Point(984, 64);
            this.buttonAll.Name = "buttonAll";
            this.buttonAll.Size = new System.Drawing.Size(96, 30);
            this.buttonAll.TabIndex = 3;
            this.buttonAll.Text = "all";
            this.buttonAll.UseVisualStyleBackColor = true;
            this.buttonAll.Click += new System.EventHandler(this.buttonAll_Click);
            // 
            // AditInf_groupBox
            // 
            this.AditInf_groupBox.Controls.Add(this.labelCheckout);
            this.AditInf_groupBox.Controls.Add(this.labelCheckoutText);
            this.AditInf_groupBox.Controls.Add(this.labelCheckin);
            this.AditInf_groupBox.Controls.Add(this.labelKey);
            this.AditInf_groupBox.Controls.Add(this.labelCheckinText);
            this.AditInf_groupBox.Controls.Add(this.labelRoom);
            this.AditInf_groupBox.Controls.Add(this.label6);
            this.AditInf_groupBox.Controls.Add(this.labelRoomText);
            this.AditInf_groupBox.Location = new System.Drawing.Point(44, 368);
            this.AditInf_groupBox.Name = "AditInf_groupBox";
            this.AditInf_groupBox.Size = new System.Drawing.Size(445, 225);
            this.AditInf_groupBox.TabIndex = 5;
            this.AditInf_groupBox.TabStop = false;
            this.AditInf_groupBox.Text = "additional info";
            // 
            // labelCheckout
            // 
            this.labelCheckout.AutoSize = true;
            this.labelCheckout.Location = new System.Drawing.Point(156, 182);
            this.labelCheckout.Name = "labelCheckout";
            this.labelCheckout.Size = new System.Drawing.Size(35, 20);
            this.labelCheckout.TabIndex = 1;
            this.labelCheckout.Text = "text";
            // 
            // labelCheckoutText
            // 
            this.labelCheckoutText.AutoSize = true;
            this.labelCheckoutText.Location = new System.Drawing.Point(35, 182);
            this.labelCheckoutText.Name = "labelCheckoutText";
            this.labelCheckoutText.Size = new System.Drawing.Size(77, 20);
            this.labelCheckoutText.TabIndex = 1;
            this.labelCheckoutText.Text = "Checkout";
            // 
            // labelCheckin
            // 
            this.labelCheckin.AutoSize = true;
            this.labelCheckin.Location = new System.Drawing.Point(156, 136);
            this.labelCheckin.Name = "labelCheckin";
            this.labelCheckin.Size = new System.Drawing.Size(35, 20);
            this.labelCheckin.TabIndex = 1;
            this.labelCheckin.Text = "text";
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.Location = new System.Drawing.Point(156, 90);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(35, 20);
            this.labelKey.TabIndex = 1;
            this.labelKey.Text = "text";
            // 
            // labelCheckinText
            // 
            this.labelCheckinText.AutoSize = true;
            this.labelCheckinText.Location = new System.Drawing.Point(46, 136);
            this.labelCheckinText.Name = "labelCheckinText";
            this.labelCheckinText.Size = new System.Drawing.Size(66, 20);
            this.labelCheckinText.TabIndex = 1;
            this.labelCheckinText.Text = "Checkin";
            // 
            // labelRoom
            // 
            this.labelRoom.AutoSize = true;
            this.labelRoom.Location = new System.Drawing.Point(156, 44);
            this.labelRoom.Name = "labelRoom";
            this.labelRoom.Size = new System.Drawing.Size(35, 20);
            this.labelRoom.TabIndex = 1;
            this.labelRoom.Text = "text";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Key";
            // 
            // labelRoomText
            // 
            this.labelRoomText.AutoSize = true;
            this.labelRoomText.Location = new System.Drawing.Point(60, 44);
            this.labelRoomText.Name = "labelRoomText";
            this.labelRoomText.Size = new System.Drawing.Size(52, 20);
            this.labelRoomText.TabIndex = 1;
            this.labelRoomText.Text = "Room";
            // 
            // hotelDbDataSet
            // 
            this.hotelDbDataSet.DataSetName = "HotelDbDataSet";
            this.hotelDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // clientBookingTableAdapter
            // 
            this.clientBookingTableAdapter.ClearBeforeFill = true;
            // 
            // bookingBindingSource
            // 
            this.bookingBindingSource.DataMember = "booking";
            this.bookingBindingSource.DataSource = this.hotelDbDataSet;
            // 
            // bookingTableAdapter
            // 
            this.bookingTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.apartamentTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bookingTableAdapter = this.bookingTableAdapter;
            this.tableAdapterManager.classTableAdapter = null;
            this.tableAdapterManager.clientBookingTableAdapter = this.clientBookingTableAdapter;
            this.tableAdapterManager.clientTableAdapter = this.clientTableAdapter;
            this.tableAdapterManager.keyTableAdapter = null;
            this.tableAdapterManager.lockHistoryTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Novotel.HotelDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(57, 326);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(96, 30);
            this.buttonNew.TabIndex = 6;
            this.buttonNew.Text = "new...";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // labelClientAddResult
            // 
            this.labelClientAddResult.AutoSize = true;
            this.labelClientAddResult.Location = new System.Drawing.Point(4, 627);
            this.labelClientAddResult.Name = "labelClientAddResult";
            this.labelClientAddResult.Size = new System.Drawing.Size(95, 20);
            this.labelClientAddResult.TabIndex = 7;
            this.labelClientAddResult.Text = "client added";
            this.labelClientAddResult.Visible = false;
            // 
            // ClientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelClientAddResult);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.AditInf_groupBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridViewClients);
            this.Controls.Add(this.buttonAll);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBoxPerson);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonEdit);
            this.Name = "ClientList";
            this.Size = new System.Drawing.Size(1320, 660);
            this.Load += new System.EventHandler(this.ClientList_Load);
            this.groupBoxPerson.ResumeLayout(false);
            this.groupBoxPerson.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.AditInf_groupBox.ResumeLayout(false);
            this.AditInf_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientclientBookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPerson;
        private System.Windows.Forms.DateTimePicker dateTimeBirthday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPC;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonAll;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox AditInf_groupBox;
        private System.Windows.Forms.Label labelCheckout;
        private System.Windows.Forms.Label labelCheckoutText;
        private System.Windows.Forms.Label labelCheckin;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.Label labelCheckinText;
        private System.Windows.Forms.Label labelRoom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelRoomText;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private HotelDbDataSet hotelDbDataSet;
        private HotelDbDataSetTableAdapters.clientTableAdapter clientTableAdapter;
        private System.Windows.Forms.BindingSource clientclientBookingBindingSource;
        private HotelDbDataSetTableAdapters.clientBookingTableAdapter clientBookingTableAdapter;
        private HotelDbDataSet hotelDbDataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn genderDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private HotelDbDataSetTableAdapters.bookingTableAdapter bookingTableAdapter;
        private HotelDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Label labelClientAddResult;
    }
}

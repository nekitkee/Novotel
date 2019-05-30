namespace Novotel
{
    partial class RoomsUC
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
            this.dataGridViewAparts = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apartamentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDbDataSet = new Novotel.HotelDbDataSet();
            this.dataGridViewClasses = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxAparts = new System.Windows.Forms.GroupBox();
            this.groupBoxAddApart = new System.Windows.Forms.GroupBox();
            this.labelApart = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.buttonUpdateApart = new System.Windows.Forms.Button();
            this.buttonAddApart = new System.Windows.Forms.Button();
            this.textBoxApart = new System.Windows.Forms.TextBox();
            this.groupBoxClasses = new System.Windows.Forms.GroupBox();
            this.groupBoxAddClass = new System.Windows.Forms.GroupBox();
            this.buttonClassUpdate = new System.Windows.Forms.Button();
            this.textBox_class_price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddClass = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelclass = new System.Windows.Forms.Label();
            this.textBox_class_rooms = new System.Windows.Forms.TextBox();
            this.textBox_class_places = new System.Windows.Forms.TextBox();
            this.textBox_class_class = new System.Windows.Forms.TextBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonCancell = new System.Windows.Forms.Button();
            this.apartamentTableAdapter = new Novotel.HotelDbDataSetTableAdapters.apartamentTableAdapter();
            this.classTableAdapter = new Novotel.HotelDbDataSetTableAdapters.classTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAparts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartamentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            this.groupBoxAparts.SuspendLayout();
            this.groupBoxAddApart.SuspendLayout();
            this.groupBoxClasses.SuspendLayout();
            this.groupBoxAddClass.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewAparts
            // 
            this.dataGridViewAparts.AutoGenerateColumns = false;
            this.dataGridViewAparts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAparts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAparts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.classidDataGridViewTextBoxColumn});
            this.dataGridViewAparts.DataSource = this.apartamentBindingSource;
            this.dataGridViewAparts.Location = new System.Drawing.Point(18, 31);
            this.dataGridViewAparts.Name = "dataGridViewAparts";
            this.dataGridViewAparts.RowHeadersVisible = false;
            this.dataGridViewAparts.RowTemplate.Height = 28;
            this.dataGridViewAparts.Size = new System.Drawing.Size(279, 558);
            this.dataGridViewAparts.TabIndex = 0;
            this.dataGridViewAparts.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAparts_CellEnter);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "apartament";
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
            // dataGridViewClasses
            // 
            this.dataGridViewClasses.AutoGenerateColumns = false;
            this.dataGridViewClasses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClasses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.placesDataGridViewTextBoxColumn,
            this.roomsDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridViewClasses.DataSource = this.classBindingSource;
            this.dataGridViewClasses.Location = new System.Drawing.Point(6, 30);
            this.dataGridViewClasses.Name = "dataGridViewClasses";
            this.dataGridViewClasses.RowHeadersVisible = false;
            this.dataGridViewClasses.RowTemplate.Height = 28;
            this.dataGridViewClasses.Size = new System.Drawing.Size(570, 323);
            this.dataGridViewClasses.TabIndex = 1;
            this.dataGridViewClasses.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClasses_CellEnter);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "class";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // placesDataGridViewTextBoxColumn
            // 
            this.placesDataGridViewTextBoxColumn.DataPropertyName = "places";
            this.placesDataGridViewTextBoxColumn.HeaderText = "places";
            this.placesDataGridViewTextBoxColumn.Name = "placesDataGridViewTextBoxColumn";
            // 
            // roomsDataGridViewTextBoxColumn
            // 
            this.roomsDataGridViewTextBoxColumn.DataPropertyName = "rooms";
            this.roomsDataGridViewTextBoxColumn.HeaderText = "rooms";
            this.roomsDataGridViewTextBoxColumn.Name = "roomsDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataMember = "class";
            this.classBindingSource.DataSource = this.hotelDbDataSet;
            // 
            // groupBoxAparts
            // 
            this.groupBoxAparts.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxAparts.Controls.Add(this.groupBoxAddApart);
            this.groupBoxAparts.Controls.Add(this.dataGridViewAparts);
            this.groupBoxAparts.Location = new System.Drawing.Point(24, 17);
            this.groupBoxAparts.Name = "groupBoxAparts";
            this.groupBoxAparts.Size = new System.Drawing.Size(678, 610);
            this.groupBoxAparts.TabIndex = 3;
            this.groupBoxAparts.TabStop = false;
            this.groupBoxAparts.Text = "Apartaments";
            // 
            // groupBoxAddApart
            // 
            this.groupBoxAddApart.Controls.Add(this.labelApart);
            this.groupBoxAddApart.Controls.Add(this.label4);
            this.groupBoxAddApart.Controls.Add(this.comboBoxClass);
            this.groupBoxAddApart.Controls.Add(this.buttonUpdateApart);
            this.groupBoxAddApart.Controls.Add(this.buttonAddApart);
            this.groupBoxAddApart.Controls.Add(this.textBoxApart);
            this.groupBoxAddApart.Location = new System.Drawing.Point(303, 33);
            this.groupBoxAddApart.Name = "groupBoxAddApart";
            this.groupBoxAddApart.Size = new System.Drawing.Size(369, 199);
            this.groupBoxAddApart.TabIndex = 4;
            this.groupBoxAddApart.TabStop = false;
            this.groupBoxAddApart.Text = "add new";
            // 
            // labelApart
            // 
            this.labelApart.AutoSize = true;
            this.labelApart.Location = new System.Drawing.Point(242, 95);
            this.labelApart.Name = "labelApart";
            this.labelApart.Size = new System.Drawing.Size(72, 20);
            this.labelApart.TabIndex = 4;
            this.labelApart.Text = "apartam.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "class";
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Location = new System.Drawing.Point(19, 42);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(189, 28);
            this.comboBoxClass.TabIndex = 1;
            // 
            // buttonUpdateApart
            // 
            this.buttonUpdateApart.Image = global::Novotel.Properties.Resources.up_icon;
            this.buttonUpdateApart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUpdateApart.Location = new System.Drawing.Point(156, 143);
            this.buttonUpdateApart.Name = "buttonUpdateApart";
            this.buttonUpdateApart.Size = new System.Drawing.Size(104, 33);
            this.buttonUpdateApart.TabIndex = 2;
            this.buttonUpdateApart.Text = "  update";
            this.buttonUpdateApart.UseVisualStyleBackColor = true;
            this.buttonUpdateApart.Click += new System.EventHandler(this.buttonUpdateApart_Click);
            // 
            // buttonAddApart
            // 
            this.buttonAddApart.Image = global::Novotel.Properties.Resources.add_icon__1_;
            this.buttonAddApart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddApart.Location = new System.Drawing.Point(21, 143);
            this.buttonAddApart.Name = "buttonAddApart";
            this.buttonAddApart.Size = new System.Drawing.Size(109, 33);
            this.buttonAddApart.TabIndex = 2;
            this.buttonAddApart.Text = "  add";
            this.buttonAddApart.UseVisualStyleBackColor = true;
            this.buttonAddApart.Click += new System.EventHandler(this.buttonAddApart_Click);
            // 
            // textBoxApart
            // 
            this.textBoxApart.Location = new System.Drawing.Point(17, 92);
            this.textBoxApart.Name = "textBoxApart";
            this.textBoxApart.Size = new System.Drawing.Size(191, 26);
            this.textBoxApart.TabIndex = 3;
            // 
            // groupBoxClasses
            // 
            this.groupBoxClasses.Controls.Add(this.groupBoxAddClass);
            this.groupBoxClasses.Controls.Add(this.dataGridViewClasses);
            this.groupBoxClasses.Location = new System.Drawing.Point(708, 17);
            this.groupBoxClasses.Name = "groupBoxClasses";
            this.groupBoxClasses.Size = new System.Drawing.Size(582, 562);
            this.groupBoxClasses.TabIndex = 4;
            this.groupBoxClasses.TabStop = false;
            this.groupBoxClasses.Text = "Classes";
            // 
            // groupBoxAddClass
            // 
            this.groupBoxAddClass.Controls.Add(this.buttonClassUpdate);
            this.groupBoxAddClass.Controls.Add(this.textBox_class_price);
            this.groupBoxAddClass.Controls.Add(this.buttonAddClass);
            this.groupBoxAddClass.Controls.Add(this.label3);
            this.groupBoxAddClass.Controls.Add(this.label2);
            this.groupBoxAddClass.Controls.Add(this.label1);
            this.groupBoxAddClass.Controls.Add(this.labelclass);
            this.groupBoxAddClass.Controls.Add(this.textBox_class_rooms);
            this.groupBoxAddClass.Controls.Add(this.textBox_class_places);
            this.groupBoxAddClass.Controls.Add(this.textBox_class_class);
            this.groupBoxAddClass.Location = new System.Drawing.Point(6, 371);
            this.groupBoxAddClass.Name = "groupBoxAddClass";
            this.groupBoxAddClass.Size = new System.Drawing.Size(570, 185);
            this.groupBoxAddClass.TabIndex = 2;
            this.groupBoxAddClass.TabStop = false;
            this.groupBoxAddClass.Text = "change";
            // 
            // buttonClassUpdate
            // 
            this.buttonClassUpdate.Image = global::Novotel.Properties.Resources.up_icon;
            this.buttonClassUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClassUpdate.Location = new System.Drawing.Point(435, 131);
            this.buttonClassUpdate.Name = "buttonClassUpdate";
            this.buttonClassUpdate.Size = new System.Drawing.Size(109, 33);
            this.buttonClassUpdate.TabIndex = 5;
            this.buttonClassUpdate.Text = "  update";
            this.buttonClassUpdate.UseVisualStyleBackColor = true;
            this.buttonClassUpdate.Click += new System.EventHandler(this.buttonClassUpdate_Click);
            // 
            // textBox_class_price
            // 
            this.textBox_class_price.Location = new System.Drawing.Point(299, 83);
            this.textBox_class_price.Name = "textBox_class_price";
            this.textBox_class_price.Size = new System.Drawing.Size(143, 26);
            this.textBox_class_price.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(465, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(465, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "rooms";
            // 
            // buttonAddClass
            // 
            this.buttonAddClass.Image = global::Novotel.Properties.Resources.add_icon__1_;
            this.buttonAddClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddClass.Location = new System.Drawing.Point(299, 131);
            this.buttonAddClass.Name = "buttonAddClass";
            this.buttonAddClass.Size = new System.Drawing.Size(109, 33);
            this.buttonAddClass.TabIndex = 2;
            this.buttonAddClass.Text = "  add";
            this.buttonAddClass.UseVisualStyleBackColor = true;
            this.buttonAddClass.Click += new System.EventHandler(this.buttonAddClass_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "places";
            // 
            // labelclass
            // 
            this.labelclass.AutoSize = true;
            this.labelclass.Location = new System.Drawing.Point(205, 43);
            this.labelclass.Name = "labelclass";
            this.labelclass.Size = new System.Drawing.Size(45, 20);
            this.labelclass.TabIndex = 4;
            this.labelclass.Text = "class";
            // 
            // textBox_class_rooms
            // 
            this.textBox_class_rooms.Location = new System.Drawing.Point(299, 37);
            this.textBox_class_rooms.Name = "textBox_class_rooms";
            this.textBox_class_rooms.Size = new System.Drawing.Size(143, 26);
            this.textBox_class_rooms.TabIndex = 0;
            // 
            // textBox_class_places
            // 
            this.textBox_class_places.Location = new System.Drawing.Point(39, 83);
            this.textBox_class_places.Name = "textBox_class_places";
            this.textBox_class_places.Size = new System.Drawing.Size(143, 26);
            this.textBox_class_places.TabIndex = 0;
            // 
            // textBox_class_class
            // 
            this.textBox_class_class.Location = new System.Drawing.Point(39, 37);
            this.textBox_class_class.Name = "textBox_class_class";
            this.textBox_class_class.Size = new System.Drawing.Size(143, 26);
            this.textBox_class_class.TabIndex = 0;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Image = global::Novotel.Properties.Resources.Pencil_icon;
            this.buttonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEdit.Location = new System.Drawing.Point(717, 590);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(104, 33);
            this.buttonEdit.TabIndex = 5;
            this.buttonEdit.Text = "   edit...";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonCancell
            // 
            this.buttonCancell.Image = global::Novotel.Properties.Resources.Actions_edit_clear_icon;
            this.buttonCancell.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancell.Location = new System.Drawing.Point(836, 590);
            this.buttonCancell.Name = "buttonCancell";
            this.buttonCancell.Size = new System.Drawing.Size(104, 33);
            this.buttonCancell.TabIndex = 2;
            this.buttonCancell.Text = "     cancel";
            this.buttonCancell.UseVisualStyleBackColor = true;
            this.buttonCancell.Click += new System.EventHandler(this.buttonCancell_Click);
            // 
            // apartamentTableAdapter
            // 
            this.apartamentTableAdapter.ClearBeforeFill = true;
            // 
            // classTableAdapter
            // 
            this.classTableAdapter.ClearBeforeFill = true;
            // 
            // RoomsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.groupBoxClasses);
            this.Controls.Add(this.groupBoxAparts);
            this.Controls.Add(this.buttonCancell);
            this.Name = "RoomsUC";
            this.Size = new System.Drawing.Size(1320, 660);
            this.Load += new System.EventHandler(this.RoomsUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAparts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartamentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            this.groupBoxAparts.ResumeLayout(false);
            this.groupBoxAddApart.ResumeLayout(false);
            this.groupBoxAddApart.PerformLayout();
            this.groupBoxClasses.ResumeLayout(false);
            this.groupBoxAddClass.ResumeLayout(false);
            this.groupBoxAddClass.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAparts;
        private System.Windows.Forms.BindingSource apartamentBindingSource;
        private HotelDbDataSet hotelDbDataSet;
        private HotelDbDataSetTableAdapters.apartamentTableAdapter apartamentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridViewClasses;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn placesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource classBindingSource;
        private HotelDbDataSetTableAdapters.classTableAdapter classTableAdapter;
        private System.Windows.Forms.GroupBox groupBoxAparts;
        private System.Windows.Forms.GroupBox groupBoxClasses;
        private System.Windows.Forms.TextBox textBoxApart;
        private System.Windows.Forms.Button buttonAddApart;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.GroupBox groupBoxAddApart;
        private System.Windows.Forms.Label labelApart;
        private System.Windows.Forms.Label labelclass;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonCancell;
        private System.Windows.Forms.GroupBox groupBoxAddClass;
        private System.Windows.Forms.TextBox textBox_class_price;
        private System.Windows.Forms.TextBox textBox_class_rooms;
        private System.Windows.Forms.TextBox textBox_class_places;
        private System.Windows.Forms.TextBox textBox_class_class;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddClass;
        private System.Windows.Forms.Button buttonClassUpdate;
        private System.Windows.Forms.Button buttonUpdateApart;
    }
}

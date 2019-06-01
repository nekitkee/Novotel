namespace Novotel
{
    partial class KeysUC
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
            this.dataGridViewKeys = new System.Windows.Forms.DataGridView();
            this.keyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDbDataSet = new Novotel.HotelDbDataSet();
            this.keyTableAdapter = new Novotel.HotelDbDataSetTableAdapters.keyTableAdapter();
            this.groupboxKey = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.checkBoxActive = new System.Windows.Forms.CheckBox();
            this.labelApartament = new System.Windows.Forms.Label();
            this.textBoxApartamnetId = new System.Windows.Forms.TextBox();
            this.textBoxKeyId = new System.Windows.Forms.TextBox();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonAll = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxAddFromFile = new System.Windows.Forms.GroupBox();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonChoose = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apartamentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activityDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKeys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDbDataSet)).BeginInit();
            this.groupboxKey.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxAddFromFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewKeys
            // 
            this.dataGridViewKeys.AutoGenerateColumns = false;
            this.dataGridViewKeys.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKeys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKeys.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.apartamentidDataGridViewTextBoxColumn,
            this.activityDataGridViewCheckBoxColumn});
            this.dataGridViewKeys.DataSource = this.keyBindingSource;
            this.dataGridViewKeys.Location = new System.Drawing.Point(20, 25);
            this.dataGridViewKeys.Name = "dataGridViewKeys";
            this.dataGridViewKeys.ReadOnly = true;
            this.dataGridViewKeys.RowTemplate.Height = 28;
            this.dataGridViewKeys.Size = new System.Drawing.Size(521, 563);
            this.dataGridViewKeys.TabIndex = 0;
            this.dataGridViewKeys.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKeys_CellEnter);
            this.dataGridViewKeys.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewKeys_DataError);
            // 
            // keyBindingSource
            // 
            this.keyBindingSource.DataMember = "key";
            this.keyBindingSource.DataSource = this.hotelDbDataSet;
            // 
            // hotelDbDataSet
            // 
            this.hotelDbDataSet.DataSetName = "HotelDbDataSet";
            this.hotelDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // keyTableAdapter
            // 
            this.keyTableAdapter.ClearBeforeFill = true;
            // 
            // groupboxKey
            // 
            this.groupboxKey.Controls.Add(this.label2);
            this.groupboxKey.Controls.Add(this.buttonSave);
            this.groupboxKey.Controls.Add(this.checkBoxActive);
            this.groupboxKey.Controls.Add(this.labelApartament);
            this.groupboxKey.Controls.Add(this.textBoxApartamnetId);
            this.groupboxKey.Controls.Add(this.textBoxKeyId);
            this.groupboxKey.Location = new System.Drawing.Point(565, 107);
            this.groupboxKey.Name = "groupboxKey";
            this.groupboxKey.Size = new System.Drawing.Size(688, 200);
            this.groupboxKey.TabIndex = 1;
            this.groupboxKey.TabStop = false;
            this.groupboxKey.Text = "key info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "key";
            // 
            // buttonSave
            // 
            this.buttonSave.Image = global::Novotel.Properties.Resources.Floppy_Small_icon__2_;
            this.buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSave.Location = new System.Drawing.Point(555, 139);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(110, 36);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "   save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // checkBoxActive
            // 
            this.checkBoxActive.AutoSize = true;
            this.checkBoxActive.Location = new System.Drawing.Point(408, 146);
            this.checkBoxActive.Name = "checkBoxActive";
            this.checkBoxActive.Size = new System.Drawing.Size(76, 24);
            this.checkBoxActive.TabIndex = 1;
            this.checkBoxActive.Text = "active";
            this.checkBoxActive.UseVisualStyleBackColor = true;
            this.checkBoxActive.CheckedChanged += new System.EventHandler(this.checkBoxActive_CheckedChanged);
            // 
            // labelApartament
            // 
            this.labelApartament.AutoSize = true;
            this.labelApartament.Location = new System.Drawing.Point(404, 100);
            this.labelApartament.Name = "labelApartament";
            this.labelApartament.Size = new System.Drawing.Size(91, 20);
            this.labelApartament.TabIndex = 3;
            this.labelApartament.Text = "apartament";
            // 
            // textBoxApartamnetId
            // 
            this.textBoxApartamnetId.Location = new System.Drawing.Point(31, 94);
            this.textBoxApartamnetId.Name = "textBoxApartamnetId";
            this.textBoxApartamnetId.Size = new System.Drawing.Size(351, 26);
            this.textBoxApartamnetId.TabIndex = 0;
            // 
            // textBoxKeyId
            // 
            this.textBoxKeyId.Location = new System.Drawing.Point(31, 44);
            this.textBoxKeyId.Name = "textBoxKeyId";
            this.textBoxKeyId.Size = new System.Drawing.Size(351, 26);
            this.textBoxKeyId.TabIndex = 0;
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.textBoxSearch);
            this.groupBoxSearch.Controls.Add(this.buttonAll);
            this.groupBoxSearch.Location = new System.Drawing.Point(565, 34);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(688, 67);
            this.groupBoxSearch.TabIndex = 6;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Search";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(31, 25);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(351, 26);
            this.textBoxSearch.TabIndex = 0;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // buttonAll
            // 
            this.buttonAll.Image = global::Novotel.Properties.Resources.Search_icon;
            this.buttonAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAll.Location = new System.Drawing.Point(555, 20);
            this.buttonAll.Name = "buttonAll";
            this.buttonAll.Size = new System.Drawing.Size(110, 36);
            this.buttonAll.TabIndex = 5;
            this.buttonAll.Text = "  all";
            this.buttonAll.UseVisualStyleBackColor = true;
            this.buttonAll.Click += new System.EventHandler(this.buttonAll_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBoxAddFromFile);
            this.groupBox1.Controls.Add(this.dataGridViewKeys);
            this.groupBox1.Controls.Add(this.buttonNew);
            this.groupBox1.Controls.Add(this.buttonCancel);
            this.groupBox1.Controls.Add(this.groupBoxSearch);
            this.groupBox1.Controls.Add(this.buttonEdit);
            this.groupBox1.Controls.Add(this.groupboxKey);
            this.groupBox1.Location = new System.Drawing.Point(24, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1271, 614);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Keys";
            // 
            // groupBoxAddFromFile
            // 
            this.groupBoxAddFromFile.Controls.Add(this.textBoxFileName);
            this.groupBoxAddFromFile.Controls.Add(this.label1);
            this.groupBoxAddFromFile.Controls.Add(this.buttonLoad);
            this.groupBoxAddFromFile.Controls.Add(this.buttonChoose);
            this.groupBoxAddFromFile.Enabled = false;
            this.groupBoxAddFromFile.Location = new System.Drawing.Point(565, 337);
            this.groupBoxAddFromFile.Name = "groupBoxAddFromFile";
            this.groupBoxAddFromFile.Size = new System.Drawing.Size(688, 173);
            this.groupBoxAddFromFile.TabIndex = 7;
            this.groupBoxAddFromFile.TabStop = false;
            this.groupBoxAddFromFile.Text = "Load from .txt";
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(31, 112);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(633, 26);
            this.textBoxFileName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Keys source file:";
            // 
            // buttonLoad
            // 
            this.buttonLoad.Image = global::Novotel.Properties.Resources.up_icon;
            this.buttonLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLoad.Location = new System.Drawing.Point(554, 37);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(110, 36);
            this.buttonLoad.TabIndex = 0;
            this.buttonLoad.Text = "  load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonChoose
            // 
            this.buttonChoose.Image = global::Novotel.Properties.Resources.page_white_get_icon;
            this.buttonChoose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChoose.Location = new System.Drawing.Point(402, 37);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(110, 36);
            this.buttonChoose.TabIndex = 0;
            this.buttonChoose.Text = "      choose..";
            this.buttonChoose.UseVisualStyleBackColor = true;
            this.buttonChoose.Click += new System.EventHandler(this.buttonChooseFile);
            // 
            // buttonNew
            // 
            this.buttonNew.Image = global::Novotel.Properties.Resources.add_icon__1_;
            this.buttonNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNew.Location = new System.Drawing.Point(1120, 543);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(110, 36);
            this.buttonNew.TabIndex = 2;
            this.buttonNew.Text = "  new";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Image = global::Novotel.Properties.Resources.Actions_edit_clear_icon;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(812, 543);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(110, 36);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "   cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Image = global::Novotel.Properties.Resources.Pencil_icon;
            this.buttonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEdit.Location = new System.Drawing.Point(967, 543);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(110, 36);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "  edit...";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apartamentidDataGridViewTextBoxColumn
            // 
            this.apartamentidDataGridViewTextBoxColumn.DataPropertyName = "apartament_id";
            this.apartamentidDataGridViewTextBoxColumn.HeaderText = "apartment";
            this.apartamentidDataGridViewTextBoxColumn.Name = "apartamentidDataGridViewTextBoxColumn";
            this.apartamentidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // activityDataGridViewCheckBoxColumn
            // 
            this.activityDataGridViewCheckBoxColumn.DataPropertyName = "activity";
            this.activityDataGridViewCheckBoxColumn.HeaderText = "activity";
            this.activityDataGridViewCheckBoxColumn.Name = "activityDataGridViewCheckBoxColumn";
            this.activityDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // KeysUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "KeysUC";
            this.Size = new System.Drawing.Size(1320, 660);
            this.Load += new System.EventHandler(this.KeysUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKeys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDbDataSet)).EndInit();
            this.groupboxKey.ResumeLayout(false);
            this.groupboxKey.PerformLayout();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBoxAddFromFile.ResumeLayout(false);
            this.groupBoxAddFromFile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewKeys;
        private System.Windows.Forms.BindingSource keyBindingSource;
        private HotelDbDataSet hotelDbDataSet;
        private HotelDbDataSetTableAdapters.keyTableAdapter keyTableAdapter;
        private System.Windows.Forms.GroupBox groupboxKey;
        private System.Windows.Forms.CheckBox checkBoxActive;
        private System.Windows.Forms.TextBox textBoxApartamnetId;
        private System.Windows.Forms.TextBox textBoxKeyId;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelApartament;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonAll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxAddFromFile;
        private System.Windows.Forms.Button buttonChoose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartamentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activityDataGridViewCheckBoxColumn;
    }
}

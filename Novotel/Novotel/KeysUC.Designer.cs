﻿namespace Novotel
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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apartamentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activityDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.keyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDbDataSet = new Novotel.HotelDbDataSet();
            this.keyTableAdapter = new Novotel.HotelDbDataSetTableAdapters.keyTableAdapter();
            this.groupboxKey = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxActive = new System.Windows.Forms.CheckBox();
            this.labelApartament = new System.Windows.Forms.Label();
            this.textBoxApartamnetId = new System.Windows.Forms.TextBox();
            this.textBoxKeyId = new System.Windows.Forms.TextBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonAll = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKeys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDbDataSet)).BeginInit();
            this.groupboxKey.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.dataGridViewKeys.RowTemplate.Height = 28;
            this.dataGridViewKeys.Size = new System.Drawing.Size(521, 563);
            this.dataGridViewKeys.TabIndex = 0;
            this.dataGridViewKeys.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKeys_CellEnter);
            this.dataGridViewKeys.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewKeys_DataError);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // apartamentidDataGridViewTextBoxColumn
            // 
            this.apartamentidDataGridViewTextBoxColumn.DataPropertyName = "apartament_id";
            this.apartamentidDataGridViewTextBoxColumn.HeaderText = "apartament";
            this.apartamentidDataGridViewTextBoxColumn.Name = "apartamentidDataGridViewTextBoxColumn";
            // 
            // activityDataGridViewCheckBoxColumn
            // 
            this.activityDataGridViewCheckBoxColumn.DataPropertyName = "activity";
            this.activityDataGridViewCheckBoxColumn.HeaderText = "activity";
            this.activityDataGridViewCheckBoxColumn.Name = "activityDataGridViewCheckBoxColumn";
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
            this.groupboxKey.Controls.Add(this.buttonCancel);
            this.groupboxKey.Controls.Add(this.labelApartament);
            this.groupboxKey.Controls.Add(this.textBoxApartamnetId);
            this.groupboxKey.Controls.Add(this.textBoxKeyId);
            this.groupboxKey.Location = new System.Drawing.Point(616, 143);
            this.groupboxKey.Name = "groupboxKey";
            this.groupboxKey.Size = new System.Drawing.Size(607, 246);
            this.groupboxKey.TabIndex = 1;
            this.groupboxKey.TabStop = false;
            this.groupboxKey.Text = "key info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "key";
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
            this.labelApartament.Location = new System.Drawing.Point(430, 97);
            this.labelApartament.Name = "labelApartament";
            this.labelApartament.Size = new System.Drawing.Size(91, 20);
            this.labelApartament.TabIndex = 3;
            this.labelApartament.Text = "apartament";
            // 
            // textBoxApartamnetId
            // 
            this.textBoxApartamnetId.Location = new System.Drawing.Point(31, 94);
            this.textBoxApartamnetId.Name = "textBoxApartamnetId";
            this.textBoxApartamnetId.Size = new System.Drawing.Size(278, 26);
            this.textBoxApartamnetId.TabIndex = 0;
            // 
            // textBoxKeyId
            // 
            this.textBoxKeyId.Location = new System.Drawing.Point(31, 44);
            this.textBoxKeyId.Name = "textBoxKeyId";
            this.textBoxKeyId.Size = new System.Drawing.Size(278, 26);
            this.textBoxKeyId.TabIndex = 0;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Image = global::Novotel.Properties.Resources.Pencil_icon;
            this.buttonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEdit.Location = new System.Drawing.Point(981, 552);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(110, 36);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "  edit...";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Image = global::Novotel.Properties.Resources.Floppy_Small_icon__2_;
            this.buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSave.Location = new System.Drawing.Point(163, 188);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(110, 36);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "   save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Image = global::Novotel.Properties.Resources.add_icon__1_;
            this.buttonNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNew.Location = new System.Drawing.Point(1134, 552);
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
            this.buttonCancel.Location = new System.Drawing.Point(31, 188);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(110, 36);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "   cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.textBoxSearch);
            this.groupBoxSearch.Controls.Add(this.buttonAll);
            this.groupBoxSearch.Location = new System.Drawing.Point(616, 34);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(607, 67);
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
            this.buttonAll.Location = new System.Drawing.Point(424, 23);
            this.buttonAll.Name = "buttonAll";
            this.buttonAll.Size = new System.Drawing.Size(96, 36);
            this.buttonAll.TabIndex = 5;
            this.buttonAll.Text = "  all";
            this.buttonAll.UseVisualStyleBackColor = true;
            this.buttonAll.Click += new System.EventHandler(this.buttonAll_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewKeys);
            this.groupBox1.Controls.Add(this.buttonNew);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartamentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activityDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonAll;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

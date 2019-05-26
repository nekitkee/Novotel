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
            this.hotelDbDataSet = new Novotel.HotelDbDataSet();
            this.keyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.keyTableAdapter = new Novotel.HotelDbDataSetTableAdapters.keyTableAdapter();
            this.groupboxKey = new System.Windows.Forms.GroupBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxKeyId = new System.Windows.Forms.TextBox();
            this.textBoxApartamnetId = new System.Windows.Forms.TextBox();
            this.labelApartament = new System.Windows.Forms.Label();
            this.checkBoxActive = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonNew = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apartamentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activityDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKeys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyBindingSource)).BeginInit();
            this.groupboxKey.SuspendLayout();
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
            this.dataGridViewKeys.Location = new System.Drawing.Point(79, 73);
            this.dataGridViewKeys.Name = "dataGridViewKeys";
            this.dataGridViewKeys.RowTemplate.Height = 28;
            this.dataGridViewKeys.Size = new System.Drawing.Size(521, 443);
            this.dataGridViewKeys.TabIndex = 0;
            this.dataGridViewKeys.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKeys_CellEnter);
            // 
            // hotelDbDataSet
            // 
            this.hotelDbDataSet.DataSetName = "HotelDbDataSet";
            this.hotelDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // keyBindingSource
            // 
            this.keyBindingSource.DataMember = "key";
            this.keyBindingSource.DataSource = this.hotelDbDataSet;
            // 
            // keyTableAdapter
            // 
            this.keyTableAdapter.ClearBeforeFill = true;
            // 
            // groupboxKey
            // 
            this.groupboxKey.Controls.Add(this.label2);
            this.groupboxKey.Controls.Add(this.checkBoxActive);
            this.groupboxKey.Controls.Add(this.labelApartament);
            this.groupboxKey.Controls.Add(this.textBoxApartamnetId);
            this.groupboxKey.Controls.Add(this.textBoxKeyId);
            this.groupboxKey.Location = new System.Drawing.Point(664, 73);
            this.groupboxKey.Name = "groupboxKey";
            this.groupboxKey.Size = new System.Drawing.Size(439, 204);
            this.groupboxKey.TabIndex = 1;
            this.groupboxKey.TabStop = false;
            this.groupboxKey.Text = "groupBox1";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(664, 306);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(110, 36);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "edit...";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(951, 306);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(110, 36);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxKeyId
            // 
            this.textBoxKeyId.Location = new System.Drawing.Point(17, 42);
            this.textBoxKeyId.Name = "textBoxKeyId";
            this.textBoxKeyId.Size = new System.Drawing.Size(278, 26);
            this.textBoxKeyId.TabIndex = 0;
            // 
            // textBoxApartamnetId
            // 
            this.textBoxApartamnetId.Location = new System.Drawing.Point(17, 92);
            this.textBoxApartamnetId.Name = "textBoxApartamnetId";
            this.textBoxApartamnetId.Size = new System.Drawing.Size(278, 26);
            this.textBoxApartamnetId.TabIndex = 0;
            // 
            // labelApartament
            // 
            this.labelApartament.AutoSize = true;
            this.labelApartament.Location = new System.Drawing.Point(329, 98);
            this.labelApartament.Name = "labelApartament";
            this.labelApartament.Size = new System.Drawing.Size(91, 20);
            this.labelApartament.TabIndex = 3;
            this.labelApartament.Text = "apartament";
            // 
            // checkBoxActive
            // 
            this.checkBoxActive.AutoSize = true;
            this.checkBoxActive.Location = new System.Drawing.Point(308, 148);
            this.checkBoxActive.Name = "checkBoxActive";
            this.checkBoxActive.Size = new System.Drawing.Size(76, 24);
            this.checkBoxActive.TabIndex = 1;
            this.checkBoxActive.Text = "active";
            this.checkBoxActive.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "key";
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(803, 306);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(110, 36);
            this.buttonNew.TabIndex = 2;
            this.buttonNew.Text = "new";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
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
            // KeysUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.groupboxKey);
            this.Controls.Add(this.dataGridViewKeys);
            this.Name = "KeysUC";
            this.Size = new System.Drawing.Size(1320, 660);
            this.Load += new System.EventHandler(this.KeysUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKeys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyBindingSource)).EndInit();
            this.groupboxKey.ResumeLayout(false);
            this.groupboxKey.PerformLayout();
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
    }
}
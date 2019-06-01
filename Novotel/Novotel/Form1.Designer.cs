namespace Novotel
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripClient = new System.Windows.Forms.ToolStripMenuItem();
            this.clientListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apartamnetsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openclosedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keyListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numbersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apartamentTableAdapter1 = new Novotel.HotelDbDataSetTableAdapters.apartamentTableAdapter();
            this.clientList1 = new Novotel.ClientList();
            this.makeBooking11 = new Novotel.MakeBooking1();
            this.bookingList1 = new Novotel.BookingList();
            this.keysUC1 = new Novotel.KeysUC();
            this.roomsUC1 = new Novotel.RoomsUC();
            this.clientHistoryUC1 = new Novotel.ClientHistoryUC();
            this.roomsStateUC1 = new Novotel.RoomsStateUC();
            this.statisticUC1 = new Novotel.StatisticUC();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripClient,
            this.bookingToolStripMenuItem,
            this.roomsToolStripMenuItem,
            this.keysToolStripMenuItem,
            this.statisticToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1320, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripClient
            // 
            this.toolStripClient.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientListToolStripMenuItem,
            this.clientHistoryToolStripMenuItem});
            this.toolStripClient.Name = "toolStripClient";
            this.toolStripClient.Size = new System.Drawing.Size(68, 29);
            this.toolStripClient.Text = "Client";
            // 
            // clientListToolStripMenuItem
            // 
            this.clientListToolStripMenuItem.Name = "clientListToolStripMenuItem";
            this.clientListToolStripMenuItem.Size = new System.Drawing.Size(199, 30);
            this.clientListToolStripMenuItem.Text = "Client list";
            this.clientListToolStripMenuItem.Click += new System.EventHandler(this.clientListToolStripMenuItem_Click);
            // 
            // clientHistoryToolStripMenuItem
            // 
            this.clientHistoryToolStripMenuItem.Name = "clientHistoryToolStripMenuItem";
            this.clientHistoryToolStripMenuItem.Size = new System.Drawing.Size(199, 30);
            this.clientHistoryToolStripMenuItem.Text = "Client history";
            this.clientHistoryToolStripMenuItem.Click += new System.EventHandler(this.clientHistoryToolStripMenuItem_Click);
            // 
            // bookingToolStripMenuItem
            // 
            this.bookingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeBookingToolStripMenuItem,
            this.bookingListToolStripMenuItem});
            this.bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            this.bookingToolStripMenuItem.Size = new System.Drawing.Size(90, 29);
            this.bookingToolStripMenuItem.Text = "Booking";
            // 
            // makeBookingToolStripMenuItem
            // 
            this.makeBookingToolStripMenuItem.Name = "makeBookingToolStripMenuItem";
            this.makeBookingToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.makeBookingToolStripMenuItem.Text = "Make booking";
            this.makeBookingToolStripMenuItem.Click += new System.EventHandler(this.makeBookingToolStripMenuItem_Click_1);
            // 
            // bookingListToolStripMenuItem
            // 
            this.bookingListToolStripMenuItem.Name = "bookingListToolStripMenuItem";
            this.bookingListToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.bookingListToolStripMenuItem.Text = "Booking list";
            this.bookingListToolStripMenuItem.Click += new System.EventHandler(this.bookingListToolStripMenuItem_Click);
            // 
            // roomsToolStripMenuItem
            // 
            this.roomsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apartamnetsListToolStripMenuItem,
            this.openclosedToolStripMenuItem});
            this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            this.roomsToolStripMenuItem.Size = new System.Drawing.Size(72, 29);
            this.roomsToolStripMenuItem.Text = "Room";
            // 
            // apartamnetsListToolStripMenuItem
            // 
            this.apartamnetsListToolStripMenuItem.Name = "apartamnetsListToolStripMenuItem";
            this.apartamnetsListToolStripMenuItem.Size = new System.Drawing.Size(217, 30);
            this.apartamnetsListToolStripMenuItem.Text = "Apartament list";
            this.apartamnetsListToolStripMenuItem.Click += new System.EventHandler(this.apartamnetsListToolStripMenuItem_Click);
            // 
            // openclosedToolStripMenuItem
            // 
            this.openclosedToolStripMenuItem.Name = "openclosedToolStripMenuItem";
            this.openclosedToolStripMenuItem.Size = new System.Drawing.Size(217, 30);
            this.openclosedToolStripMenuItem.Text = "Open/closed";
            this.openclosedToolStripMenuItem.Click += new System.EventHandler(this.openclosedToolStripMenuItem_Click);
            // 
            // keysToolStripMenuItem
            // 
            this.keysToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keyListToolStripMenuItem});
            this.keysToolStripMenuItem.Name = "keysToolStripMenuItem";
            this.keysToolStripMenuItem.Size = new System.Drawing.Size(52, 29);
            this.keysToolStripMenuItem.Text = "Key";
            // 
            // keyListToolStripMenuItem
            // 
            this.keyListToolStripMenuItem.Name = "keyListToolStripMenuItem";
            this.keyListToolStripMenuItem.Size = new System.Drawing.Size(151, 30);
            this.keyListToolStripMenuItem.Text = "Key list";
            this.keyListToolStripMenuItem.Click += new System.EventHandler(this.keyListToolStripMenuItem_Click);
            // 
            // statisticToolStripMenuItem
            // 
            this.statisticToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numbersToolStripMenuItem});
            this.statisticToolStripMenuItem.Name = "statisticToolStripMenuItem";
            this.statisticToolStripMenuItem.Size = new System.Drawing.Size(84, 29);
            this.statisticToolStripMenuItem.Text = "Statistic";
            // 
            // numbersToolStripMenuItem
            // 
            this.numbersToolStripMenuItem.Name = "numbersToolStripMenuItem";
            this.numbersToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.numbersToolStripMenuItem.Text = "Numbers";
            this.numbersToolStripMenuItem.Click += new System.EventHandler(this.numbersToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualToolStripMenuItem,
            this.contactsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.manualToolStripMenuItem.Text = "manual";
            this.manualToolStripMenuItem.Click += new System.EventHandler(this.manualToolStripMenuItem_Click);
            // 
            // contactsToolStripMenuItem
            // 
            this.contactsToolStripMenuItem.Name = "contactsToolStripMenuItem";
            this.contactsToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.contactsToolStripMenuItem.Text = "contacts";
            this.contactsToolStripMenuItem.Click += new System.EventHandler(this.contactsToolStripMenuItem_Click);
            // 
            // apartamentTableAdapter1
            // 
            this.apartamentTableAdapter1.ClearBeforeFill = true;
            // 
            // clientList1
            // 
            this.clientList1.BackColor = System.Drawing.SystemColors.Control;
            this.clientList1.Location = new System.Drawing.Point(0, 40);
            this.clientList1.Name = "clientList1";
            this.clientList1.Size = new System.Drawing.Size(1320, 660);
            this.clientList1.TabIndex = 1;
            // 
            // makeBooking11
            // 
            this.makeBooking11.Location = new System.Drawing.Point(0, 42);
            this.makeBooking11.Name = "makeBooking11";
            this.makeBooking11.Size = new System.Drawing.Size(1320, 660);
            this.makeBooking11.TabIndex = 2;
            // 
            // bookingList1
            // 
            this.bookingList1.Location = new System.Drawing.Point(1, 43);
            this.bookingList1.Name = "bookingList1";
            this.bookingList1.Size = new System.Drawing.Size(1320, 660);
            this.bookingList1.TabIndex = 5;
            // 
            // keysUC1
            // 
            this.keysUC1.Location = new System.Drawing.Point(1, 42);
            this.keysUC1.Name = "keysUC1";
            this.keysUC1.Size = new System.Drawing.Size(1320, 660);
            this.keysUC1.TabIndex = 4;
            // 
            // roomsUC1
            // 
            this.roomsUC1.BackColor = System.Drawing.SystemColors.Control;
            this.roomsUC1.Location = new System.Drawing.Point(1, 43);
            this.roomsUC1.Name = "roomsUC1";
            this.roomsUC1.Size = new System.Drawing.Size(1320, 660);
            this.roomsUC1.TabIndex = 3;
            // 
            // clientHistoryUC1
            // 
            this.clientHistoryUC1.Location = new System.Drawing.Point(1, 42);
            this.clientHistoryUC1.Name = "clientHistoryUC1";
            this.clientHistoryUC1.Size = new System.Drawing.Size(1320, 660);
            this.clientHistoryUC1.TabIndex = 7;
            // 
            // roomsStateUC1
            // 
            this.roomsStateUC1.Location = new System.Drawing.Point(1, 42);
            this.roomsStateUC1.Name = "roomsStateUC1";
            this.roomsStateUC1.Size = new System.Drawing.Size(1320, 660);
            this.roomsStateUC1.TabIndex = 6;
            // 
            // statisticUC1
            // 
            this.statisticUC1.BackColor = System.Drawing.SystemColors.Control;
            this.statisticUC1.Location = new System.Drawing.Point(1, 43);
            this.statisticUC1.Name = "statisticUC1";
            this.statisticUC1.Size = new System.Drawing.Size(1320, 660);
            this.statisticUC1.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1320, 702);
            this.Controls.Add(this.clientList1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.makeBooking11);
            this.Controls.Add(this.bookingList1);
            this.Controls.Add(this.keysUC1);
            this.Controls.Add(this.roomsUC1);
            this.Controls.Add(this.clientHistoryUC1);
            this.Controls.Add(this.roomsStateUC1);
            this.Controls.Add(this.statisticUC1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novotel";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripClient;
        private System.Windows.Forms.ToolStripMenuItem clientListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactsToolStripMenuItem;
        private ClientList clientList1;
        private MakeBooking1 makeBooking11;
        private HotelDbDataSetTableAdapters.apartamentTableAdapter apartamentTableAdapter1;
        private RoomsUC roomsUC1;
        private System.Windows.Forms.ToolStripMenuItem apartamnetsListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openclosedToolStripMenuItem;
        private KeysUC keysUC1;
        private System.Windows.Forms.ToolStripMenuItem makeBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingListToolStripMenuItem;
        private BookingList bookingList1;
        private System.Windows.Forms.ToolStripMenuItem clientHistoryToolStripMenuItem;
        private RoomsStateUC roomsStateUC1;
        private ClientHistoryUC clientHistoryUC1;
        private System.Windows.Forms.ToolStripMenuItem numbersToolStripMenuItem;
        private StatisticUC statisticUC1;
        private System.Windows.Forms.ToolStripMenuItem keyListToolStripMenuItem;
    }
}


namespace SSConstruction_Windows
{
    partial class AddRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRoom));
            this.button_Back = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox_Plot_No = new System.Windows.Forms.ComboBox();
            this.pLOTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database2DataSet = new SSConstruction_Windows.Database2DataSet();
            this.pLOTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pLOTTableAdapter = new SSConstruction_Windows.Database2DataSetTableAdapters.PLOTTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_Floor = new System.Windows.Forms.ComboBox();
            this.comboBox_BathRoom = new System.Windows.Forms.ComboBox();
            this.comboBox_Balcony = new System.Windows.Forms.ComboBox();
            this.comboBox_BedRoom = new System.Windows.Forms.ComboBox();
            this.comboBox_RoomNo = new System.Windows.Forms.ComboBox();
            this.button_Add_Room = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_RoomArea = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_RoomPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pLOTBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLOTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Back
            // 
            this.button_Back.BackColor = System.Drawing.Color.Transparent;
            this.button_Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Back.BackgroundImage")));
            this.button_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Back.FlatAppearance.BorderSize = 0;
            this.button_Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Back.Location = new System.Drawing.Point(12, 12);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(47, 48);
            this.button_Back.TabIndex = 30;
            this.button_Back.UseVisualStyleBackColor = false;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.AutoSize = true;
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(1049, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 30);
            this.button3.TabIndex = 28;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(997, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(36, 30);
            this.button4.TabIndex = 29;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBox_Plot_No
            // 
            this.comboBox_Plot_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Plot_No.BackColor = System.Drawing.Color.LightGreen;
            this.comboBox_Plot_No.DataSource = this.pLOTBindingSource1;
            this.comboBox_Plot_No.DisplayMember = "PlotId";
            this.comboBox_Plot_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Plot_No.FormattingEnabled = true;
            this.comboBox_Plot_No.Location = new System.Drawing.Point(576, 149);
            this.comboBox_Plot_No.Name = "comboBox_Plot_No";
            this.comboBox_Plot_No.Size = new System.Drawing.Size(321, 33);
            this.comboBox_Plot_No.TabIndex = 31;
            // 
            // pLOTBindingSource1
            // 
            this.pLOTBindingSource1.DataMember = "PLOT";
            this.pLOTBindingSource1.DataSource = this.database2DataSet;
            // 
            // database2DataSet
            // 
            this.database2DataSet.DataSetName = "Database2DataSet";
            this.database2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pLOTBindingSource
            // 
            this.pLOTBindingSource.DataMember = "PLOT";
            this.pLOTBindingSource.DataSource = this.database2DataSet;
            // 
            // pLOTTableAdapter
            // 
            this.pLOTTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Plot Number :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(292, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 33;
            this.label2.Text = "Room Number :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(342, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 34;
            this.label3.Text = "Bedroom :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(336, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 25);
            this.label4.TabIndex = 35;
            this.label4.Text = "Bathroom :";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(351, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 36;
            this.label5.Text = "Balcony :";
            // 
            // comboBox_Floor
            // 
            this.comboBox_Floor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBox_Floor.BackColor = System.Drawing.Color.LightGreen;
            this.comboBox_Floor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Floor.FormattingEnabled = true;
            this.comboBox_Floor.Items.AddRange(new object[] {
            "G00",
            "G01",
            "G02",
            "G03",
            "G04",
            "G05",
            "G06",
            "G07",
            "G08",
            "G09",
            "G10",
            "G11",
            "G12",
            "G13",
            "G14",
            "G15",
            "G16",
            "G17",
            "G18",
            "G19",
            "G20",
            "G21",
            "G22",
            "G23",
            "G24",
            "G25",
            "G26",
            "G27",
            "G28",
            "G29",
            "G30\'"});
            this.comboBox_Floor.Location = new System.Drawing.Point(576, 216);
            this.comboBox_Floor.Name = "comboBox_Floor";
            this.comboBox_Floor.Size = new System.Drawing.Size(161, 33);
            this.comboBox_Floor.TabIndex = 37;
            // 
            // comboBox_BathRoom
            // 
            this.comboBox_BathRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_BathRoom.BackColor = System.Drawing.Color.LightGreen;
            this.comboBox_BathRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_BathRoom.FormattingEnabled = true;
            this.comboBox_BathRoom.Items.AddRange(new object[] {
            "01",
            "02",
            "03"});
            this.comboBox_BathRoom.Location = new System.Drawing.Point(576, 346);
            this.comboBox_BathRoom.Name = "comboBox_BathRoom";
            this.comboBox_BathRoom.Size = new System.Drawing.Size(321, 33);
            this.comboBox_BathRoom.TabIndex = 38;
            // 
            // comboBox_Balcony
            // 
            this.comboBox_Balcony.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Balcony.BackColor = System.Drawing.Color.LightGreen;
            this.comboBox_Balcony.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Balcony.FormattingEnabled = true;
            this.comboBox_Balcony.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.comboBox_Balcony.Location = new System.Drawing.Point(576, 414);
            this.comboBox_Balcony.Name = "comboBox_Balcony";
            this.comboBox_Balcony.Size = new System.Drawing.Size(321, 33);
            this.comboBox_Balcony.TabIndex = 39;
            // 
            // comboBox_BedRoom
            // 
            this.comboBox_BedRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_BedRoom.BackColor = System.Drawing.Color.LightGreen;
            this.comboBox_BedRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_BedRoom.FormattingEnabled = true;
            this.comboBox_BedRoom.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05"});
            this.comboBox_BedRoom.Location = new System.Drawing.Point(576, 282);
            this.comboBox_BedRoom.Name = "comboBox_BedRoom";
            this.comboBox_BedRoom.Size = new System.Drawing.Size(321, 33);
            this.comboBox_BedRoom.TabIndex = 40;
            // 
            // comboBox_RoomNo
            // 
            this.comboBox_RoomNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_RoomNo.BackColor = System.Drawing.Color.LightGreen;
            this.comboBox_RoomNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_RoomNo.FormattingEnabled = true;
            this.comboBox_RoomNo.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10"});
            this.comboBox_RoomNo.Location = new System.Drawing.Point(743, 216);
            this.comboBox_RoomNo.Name = "comboBox_RoomNo";
            this.comboBox_RoomNo.Size = new System.Drawing.Size(154, 33);
            this.comboBox_RoomNo.TabIndex = 41;
            this.comboBox_RoomNo.SelectedIndexChanged += new System.EventHandler(this.comboBox_RoomNo_SelectedIndexChanged);
            // 
            // button_Add_Room
            // 
            this.button_Add_Room.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Add_Room.BackColor = System.Drawing.Color.Transparent;
            this.button_Add_Room.FlatAppearance.BorderSize = 0;
            this.button_Add_Room.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Add_Room.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Add_Room.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Add_Room.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Add_Room.Image = ((System.Drawing.Image)(resources.GetObject("button_Add_Room.Image")));
            this.button_Add_Room.Location = new System.Drawing.Point(451, 611);
            this.button_Add_Room.Name = "button_Add_Room";
            this.button_Add_Room.Size = new System.Drawing.Size(238, 146);
            this.button_Add_Room.TabIndex = 42;
            this.button_Add_Room.UseVisualStyleBackColor = false;
            this.button_Add_Room.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(327, 486);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 25);
            this.label6.TabIndex = 43;
            this.label6.Text = "Room Area:";
            // 
            // textBox_RoomArea
            // 
            this.textBox_RoomArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_RoomArea.BackColor = System.Drawing.Color.LightGreen;
            this.textBox_RoomArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_RoomArea.Location = new System.Drawing.Point(576, 486);
            this.textBox_RoomArea.Name = "textBox_RoomArea";
            this.textBox_RoomArea.Size = new System.Drawing.Size(321, 30);
            this.textBox_RoomArea.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(324, 549);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 25);
            this.label7.TabIndex = 45;
            this.label7.Text = "Room Price:";
            // 
            // textBox_RoomPrice
            // 
            this.textBox_RoomPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_RoomPrice.BackColor = System.Drawing.Color.LightGreen;
            this.textBox_RoomPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_RoomPrice.Location = new System.Drawing.Point(576, 546);
            this.textBox_RoomPrice.Name = "textBox_RoomPrice";
            this.textBox_RoomPrice.Size = new System.Drawing.Size(321, 30);
            this.textBox_RoomPrice.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Sitka Subheading", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Coral;
            this.label8.Location = new System.Drawing.Point(258, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(699, 87);
            this.label8.TabIndex = 47;
            this.label8.Text = "ADD OR UPDATE ROOM";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUpdate.BackColor = System.Drawing.Color.Transparent;
            this.buttonUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUpdate.BackgroundImage")));
            this.buttonUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Location = new System.Drawing.Point(777, 627);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(135, 108);
            this.buttonUpdate.TabIndex = 48;
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // AddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1101, 769);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_RoomPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_RoomArea);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_Add_Room);
            this.Controls.Add(this.comboBox_RoomNo);
            this.Controls.Add(this.comboBox_BedRoom);
            this.Controls.Add(this.comboBox_Balcony);
            this.Controls.Add(this.comboBox_BathRoom);
            this.Controls.Add(this.comboBox_Floor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Plot_No);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddRoom";
            this.Text = "AddRoom";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pLOTBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLOTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox_Plot_No;
        private Database2DataSet database2DataSet;
        private System.Windows.Forms.BindingSource pLOTBindingSource;
        private Database2DataSetTableAdapters.PLOTTableAdapter pLOTTableAdapter;
        private System.Windows.Forms.BindingSource pLOTBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_Floor;
        private System.Windows.Forms.ComboBox comboBox_BathRoom;
        private System.Windows.Forms.ComboBox comboBox_Balcony;
        private System.Windows.Forms.ComboBox comboBox_BedRoom;
        private System.Windows.Forms.ComboBox comboBox_RoomNo;
        private System.Windows.Forms.Button button_Add_Room;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_RoomArea;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_RoomPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonUpdate;
    }
}
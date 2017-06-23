namespace SSConstruction_Windows
{
    partial class Available
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Available));
            this.database2DataSet1 = new SSConstruction_Windows.Database2DataSet1();
            this.pLOTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pLOTTableAdapter = new SSConstruction_Windows.Database2DataSet1TableAdapters.PLOTTableAdapter();
            this.dataAvailable = new System.Windows.Forms.DataGridView();
            this.button_Back = new System.Windows.Forms.Button();
            this.button_Minimized = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.comboBox_PlotAddress = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.database2DataSet2 = new SSConstruction_Windows.Database2DataSet2();
            this.rOOMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rOOMTableAdapter = new SSConstruction_Windows.Database2DataSet2TableAdapters.ROOMTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_BookRoom = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLOTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAvailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOOMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // database2DataSet1
            // 
            this.database2DataSet1.DataSetName = "Database2DataSet1";
            this.database2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pLOTBindingSource
            // 
            this.pLOTBindingSource.DataMember = "PLOT";
            this.pLOTBindingSource.DataSource = this.database2DataSet1;
            // 
            // pLOTTableAdapter
            // 
            this.pLOTTableAdapter.ClearBeforeFill = true;
            // 
            // dataAvailable
            // 
            this.dataAvailable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataAvailable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataAvailable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataAvailable.BackgroundColor = System.Drawing.Color.Bisque;
            this.dataAvailable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataAvailable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAvailable.Location = new System.Drawing.Point(105, 200);
            this.dataAvailable.MultiSelect = false;
            this.dataAvailable.Name = "dataAvailable";
            this.dataAvailable.ReadOnly = true;
            this.dataAvailable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataAvailable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataAvailable.RowTemplate.Height = 24;
            this.dataAvailable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataAvailable.Size = new System.Drawing.Size(925, 475);
            this.dataAvailable.TabIndex = 2;
            this.dataAvailable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataAvailable_CellClick);
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
            this.button_Back.TabIndex = 27;
            this.button_Back.UseVisualStyleBackColor = false;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // button_Minimized
            // 
            this.button_Minimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Minimized.BackColor = System.Drawing.Color.Transparent;
            this.button_Minimized.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Minimized.BackgroundImage")));
            this.button_Minimized.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Minimized.FlatAppearance.BorderSize = 0;
            this.button_Minimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Minimized.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Minimized.Image = ((System.Drawing.Image)(resources.GetObject("button_Minimized.Image")));
            this.button_Minimized.Location = new System.Drawing.Point(994, 12);
            this.button_Minimized.Name = "button_Minimized";
            this.button_Minimized.Size = new System.Drawing.Size(36, 30);
            this.button_Minimized.TabIndex = 26;
            this.button_Minimized.UseVisualStyleBackColor = false;
            this.button_Minimized.Click += new System.EventHandler(this.button_Minimized_Click);
            // 
            // button_Close
            // 
            this.button_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Close.AutoSize = true;
            this.button_Close.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_Close.BackColor = System.Drawing.Color.Transparent;
            this.button_Close.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_Close.FlatAppearance.BorderSize = 0;
            this.button_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.Image = ((System.Drawing.Image)(resources.GetObject("button_Close.Image")));
            this.button_Close.Location = new System.Drawing.Point(1063, 12);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(30, 30);
            this.button_Close.TabIndex = 25;
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // comboBox_PlotAddress
            // 
            this.comboBox_PlotAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_PlotAddress.BackColor = System.Drawing.Color.Bisque;
            this.comboBox_PlotAddress.DataSource = this.pLOTBindingSource;
            this.comboBox_PlotAddress.DisplayMember = "Plot_Address";
            this.comboBox_PlotAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_PlotAddress.FormattingEnabled = true;
            this.comboBox_PlotAddress.Location = new System.Drawing.Point(359, 49);
            this.comboBox_PlotAddress.Name = "comboBox_PlotAddress";
            this.comboBox_PlotAddress.Size = new System.Drawing.Size(513, 33);
            this.comboBox_PlotAddress.TabIndex = 0;
            this.comboBox_PlotAddress.SelectedIndexChanged += new System.EventHandler(this.comboBox_PlotAddress_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Plot Address :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(197, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Bed Room:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05"});
            this.comboBox1.Location = new System.Drawing.Point(359, 111);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 33);
            this.comboBox1.TabIndex = 29;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // database2DataSet2
            // 
            this.database2DataSet2.DataSetName = "Database2DataSet2";
            this.database2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rOOMBindingSource
            // 
            this.rOOMBindingSource.DataMember = "ROOM";
            this.rOOMBindingSource.DataSource = this.database2DataSet2;
            // 
            // rOOMTableAdapter
            // 
            this.rOOMTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "01",
            "02",
            "03"});
            this.comboBox2.Location = new System.Drawing.Point(751, 106);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 33);
            this.comboBox2.TabIndex = 31;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(532, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 30;
            this.label3.Text = "Bath Room:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button_BookRoom
            // 
            this.button_BookRoom.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_BookRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_BookRoom.Location = new System.Drawing.Point(499, 709);
            this.button_BookRoom.Name = "button_BookRoom";
            this.button_BookRoom.Size = new System.Drawing.Size(176, 48);
            this.button_BookRoom.TabIndex = 32;
            this.button_BookRoom.Text = "Book Room";
            this.button_BookRoom.UseVisualStyleBackColor = true;
            this.button_BookRoom.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUpdate.BackgroundImage")));
            this.buttonUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Location = new System.Drawing.Point(908, 52);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(96, 90);
            this.buttonUpdate.TabIndex = 33;
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(888, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 25);
            this.label4.TabIndex = 34;
            this.label4.Text = "Update Room";
            // 
            // Available
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1106, 789);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.button_BookRoom);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.button_Minimized);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.dataAvailable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_PlotAddress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Available";
            this.Text = "Floor :";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Available_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLOTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAvailable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOOMBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Database2DataSet1 database2DataSet1;
        private System.Windows.Forms.BindingSource pLOTBindingSource;
        private Database2DataSet1TableAdapters.PLOTTableAdapter pLOTTableAdapter;
        private System.Windows.Forms.DataGridView dataAvailable;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Button button_Minimized;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.ComboBox comboBox_PlotAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private Database2DataSet2 database2DataSet2;
        private System.Windows.Forms.BindingSource rOOMBindingSource;
        private Database2DataSet2TableAdapters.ROOMTableAdapter rOOMTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_BookRoom;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label label4;
    }
}
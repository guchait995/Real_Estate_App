using System.Data;
using System.Data.SqlClient;

namespace SSConstruction_Windows
{
    partial class AddPlot
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


        //Finding Available PlotId
        string FindPlot()
        {
            string PlotId = null;
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\SOURAV\Documents\Visual Studio 2015\Projects\SSConstruction_Windows\SSConstruction_Windows\Database2.mdf; Integrated Security = True");
            string query = "select PlotId From PLOT";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataAdapter DataAdapter=new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            DataAdapter.Fill(dt);
            string i=((dt.Rows.Count)+1).ToString();
            PlotId ="00"+i;


            return PlotId;
        }






        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPlot));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Plot_Address = new System.Windows.Forms.TextBox();
            this.textBox_Plot_Owner = new System.Windows.Forms.TextBox();
            this.label_Owner = new System.Windows.Forms.Label();
            this.textBox_Plot_Area = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Save = new System.Windows.Forms.Button();
            this.label_Plot_Number = new System.Windows.Forms.Label();
            this.button_Back = new System.Windows.Forms.Button();
            this.button_Minimized = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_AddRoom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plot Address :";
            // 
            // textBox_Plot_Address
            // 
            this.textBox_Plot_Address.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Plot_Address.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textBox_Plot_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Plot_Address.Location = new System.Drawing.Point(335, 102);
            this.textBox_Plot_Address.Name = "textBox_Plot_Address";
            this.textBox_Plot_Address.Size = new System.Drawing.Size(469, 30);
            this.textBox_Plot_Address.TabIndex = 1;
            // 
            // textBox_Plot_Owner
            // 
            this.textBox_Plot_Owner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Plot_Owner.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textBox_Plot_Owner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Plot_Owner.Location = new System.Drawing.Point(335, 154);
            this.textBox_Plot_Owner.Name = "textBox_Plot_Owner";
            this.textBox_Plot_Owner.Size = new System.Drawing.Size(469, 30);
            this.textBox_Plot_Owner.TabIndex = 3;
            // 
            // label_Owner
            // 
            this.label_Owner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Owner.AutoSize = true;
            this.label_Owner.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Owner.Location = new System.Drawing.Point(166, 159);
            this.label_Owner.Name = "label_Owner";
            this.label_Owner.Size = new System.Drawing.Size(136, 22);
            this.label_Owner.TabIndex = 2;
            this.label_Owner.Text = "Owner Name :";
            // 
            // textBox_Plot_Area
            // 
            this.textBox_Plot_Area.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Plot_Area.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textBox_Plot_Area.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Plot_Area.Location = new System.Drawing.Point(335, 208);
            this.textBox_Plot_Area.Name = "textBox_Plot_Area";
            this.textBox_Plot_Area.Size = new System.Drawing.Size(469, 30);
            this.textBox_Plot_Area.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(166, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Plot Area :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(348, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Plot Number :";
            // 
            // button_Save
            // 
            this.button_Save.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_Save.FlatAppearance.BorderSize = 0;
            this.button_Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Save.Image = ((System.Drawing.Image)(resources.GetObject("button_Save.Image")));
            this.button_Save.Location = new System.Drawing.Point(458, 282);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(203, 149);
            this.button_Save.TabIndex = 7;
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_Plot_Number
            // 
            this.label_Plot_Number.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Plot_Number.AutoSize = true;
            this.label_Plot_Number.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Plot_Number.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label_Plot_Number.Location = new System.Drawing.Point(608, 21);
            this.label_Plot_Number.Name = "label_Plot_Number";
            this.label_Plot_Number.Size = new System.Drawing.Size(0, 31);
            this.label_Plot_Number.TabIndex = 8;
            this.label_Plot_Number.Text = FindPlot();
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
            this.button_Back.Location = new System.Drawing.Point(2, 2);
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
            this.button_Minimized.Location = new System.Drawing.Point(958, 2);
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
            this.button_Close.Location = new System.Drawing.Point(1027, 2);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(30, 30);
            this.button_Close.TabIndex = 25;
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_AddRoom
            // 
            this.button_AddRoom.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_AddRoom.FlatAppearance.BorderSize = 0;
            this.button_AddRoom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_AddRoom.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddRoom.Location = new System.Drawing.Point(335, 520);
            this.button_AddRoom.Name = "button_AddRoom";
            this.button_AddRoom.Size = new System.Drawing.Size(469, 78);
            this.button_AddRoom.TabIndex = 28;
            this.button_AddRoom.Text = "Add Room To this Plot";
            this.button_AddRoom.UseVisualStyleBackColor = true;
            this.button_AddRoom.Click += new System.EventHandler(this.button_AddRoom_Click);
            // 
            // AddPlot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1061, 669);
            this.Controls.Add(this.button_AddRoom);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.button_Minimized);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.label_Plot_Number);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Plot_Area);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Plot_Owner);
            this.Controls.Add(this.label_Owner);
            this.Controls.Add(this.textBox_Plot_Address);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddPlot";
            this.Text = "AddPlot";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddPlot_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Plot_Address;
        private System.Windows.Forms.TextBox textBox_Plot_Owner;
        private System.Windows.Forms.Label label_Owner;
        private System.Windows.Forms.TextBox textBox_Plot_Area;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Label label_Plot_Number;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Button button_Minimized;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_AddRoom;
    }
}
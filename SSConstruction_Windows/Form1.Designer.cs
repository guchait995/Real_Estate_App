using System.Windows.Forms;

namespace SSConstruction_Windows
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.button_Close = new System.Windows.Forms.Button();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBox_LoginPassword = new System.Windows.Forms.TextBox();
            this.button_Login = new System.Windows.Forms.Button();
            this.pictureBox_AdminLogo = new System.Windows.Forms.PictureBox();
            this.button_Exit = new System.Windows.Forms.Button();
            this.panel_Login = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Minimized = new System.Windows.Forms.Button();
            this.label_SSConstructon = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AdminLogo)).BeginInit();
            this.panel_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Close
            // 
            this.button_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Close.AutoSize = true;
            this.button_Close.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_Close.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_Close.FlatAppearance.BorderSize = 0;
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.Image = ((System.Drawing.Image)(resources.GetObject("button_Close.Image")));
            this.button_Close.Location = new System.Drawing.Point(1256, -1);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(30, 30);
            this.button_Close.TabIndex = 0;
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserName.Location = new System.Drawing.Point(196, 27);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(255, 30);
            this.textBoxUserName.TabIndex = 1;
            this.textBoxUserName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox_LoginPassword
            // 
            this.textBox_LoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_LoginPassword.Location = new System.Drawing.Point(196, 80);
            this.textBox_LoginPassword.Name = "textBox_LoginPassword";
            this.textBox_LoginPassword.Size = new System.Drawing.Size(255, 30);
            this.textBox_LoginPassword.TabIndex = 2;
            textBox_LoginPassword.PasswordChar = '*';
            // 
            // button_Login
            // 
            this.button_Login.FlatAppearance.BorderSize = 0;
            this.button_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Login.Image = ((System.Drawing.Image)(resources.GetObject("button_Login.Image")));
            this.button_Login.Location = new System.Drawing.Point(196, 116);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(119, 47);
            this.button_Login.TabIndex = 3;
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox_AdminLogo
            // 
            this.pictureBox_AdminLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_AdminLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox_AdminLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_AdminLogo.Image")));
            this.pictureBox_AdminLogo.Location = new System.Drawing.Point(17, -10);
            this.pictureBox_AdminLogo.Name = "pictureBox_AdminLogo";
            this.pictureBox_AdminLogo.Size = new System.Drawing.Size(163, 163);
            this.pictureBox_AdminLogo.TabIndex = 4;
            this.pictureBox_AdminLogo.TabStop = false;
            this.pictureBox_AdminLogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.FlatAppearance.BorderSize = 0;
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Exit.Image = ((System.Drawing.Image)(resources.GetObject("button_Exit.Image")));
            this.button_Exit.Location = new System.Drawing.Point(321, 116);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(130, 47);
            this.button_Exit.TabIndex = 5;
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // panel_Login
            // 
            this.panel_Login.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel_Login.BackColor = System.Drawing.Color.Transparent;
            this.panel_Login.Controls.Add(this.label2);
            this.panel_Login.Controls.Add(this.label1);
            this.panel_Login.Controls.Add(this.textBoxUserName);
            this.panel_Login.Controls.Add(this.button_Exit);
            this.panel_Login.Controls.Add(this.textBox_LoginPassword);
            this.panel_Login.Controls.Add(this.pictureBox_AdminLogo);
            this.panel_Login.Controls.Add(this.button_Login);
            this.panel_Login.Location = new System.Drawing.Point(447, 402);
            this.panel_Login.Name = "panel_Login";
            this.panel_Login.Size = new System.Drawing.Size(495, 254);
            this.panel_Login.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(193, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Password";
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
            this.button_Minimized.Location = new System.Drawing.Point(1187, -1);
            this.button_Minimized.Name = "button_Minimized";
            this.button_Minimized.Size = new System.Drawing.Size(36, 40);
            this.button_Minimized.TabIndex = 7;
            this.button_Minimized.UseVisualStyleBackColor = false;
            this.button_Minimized.Click += new System.EventHandler(this.button4_Click);
            // 
            // label_SSConstructon
            // 
            this.label_SSConstructon.AutoSize = true;
            this.label_SSConstructon.BackColor = System.Drawing.Color.Transparent;
            this.label_SSConstructon.Font = new System.Drawing.Font("Monotype Corsiva", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SSConstructon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label_SSConstructon.Location = new System.Drawing.Point(39, 23);
            this.label_SSConstructon.Name = "label_SSConstructon";
            this.label_SSConstructon.Size = new System.Drawing.Size(783, 147);
            this.label_SSConstructon.TabIndex = 8;
            this.label_SSConstructon.Text = "S.S Construction";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LogIn
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1296, 654);
            this.Controls.Add(this.label_SSConstructon);
            this.Controls.Add(this.button_Minimized);
            this.Controls.Add(this.panel_Login);
            this.Controls.Add(this.button_Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogIn";
            this.Text = "S.S.Construction";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AdminLogo)).EndInit();
            this.panel_Login.ResumeLayout(false);
            this.panel_Login.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_Close;
        private TextBox textBoxUserName;
        private TextBox textBox_LoginPassword;
        private Button button_Login;
        private PictureBox pictureBox_AdminLogo;
        private Button button_Exit;
        private Panel panel_Login;
        private Button button_Minimized;
        private Label label_SSConstructon;
        private Timer timer1;
        private Label label2;
        private Label label1;
    }
}


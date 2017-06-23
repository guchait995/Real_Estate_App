namespace SSConstruction_Windows
{
    partial class Pay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pay));
            this.textBoxPay = new System.Windows.Forms.TextBox();
            this.textBoxPayConfirm = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Minimized = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPay
            // 
            this.textBoxPay.BackColor = System.Drawing.Color.MistyRose;
            this.textBoxPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPay.Location = new System.Drawing.Point(287, 110);
            this.textBoxPay.Name = "textBoxPay";
            this.textBoxPay.Size = new System.Drawing.Size(244, 30);
            this.textBoxPay.TabIndex = 0;
            // 
            // textBoxPayConfirm
            // 
            this.textBoxPayConfirm.BackColor = System.Drawing.Color.MistyRose;
            this.textBoxPayConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPayConfirm.Location = new System.Drawing.Point(287, 175);
            this.textBoxPayConfirm.Name = "textBoxPayConfirm";
            this.textBoxPayConfirm.Size = new System.Drawing.Size(244, 30);
            this.textBoxPayConfirm.TabIndex = 1;
            this.textBoxPayConfirm.TextChanged += new System.EventHandler(this.textBoxPayConfirm_TextChanged);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(374, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 124);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Amount  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Confirm Amount  :";
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
            this.button_Minimized.Location = new System.Drawing.Point(541, 12);
            this.button_Minimized.Name = "button_Minimized";
            this.button_Minimized.Size = new System.Drawing.Size(36, 30);
            this.button_Minimized.TabIndex = 28;
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
            this.button_Close.Location = new System.Drawing.Point(610, 12);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(30, 30);
            this.button_Close.TabIndex = 27;
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
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
            this.button_Back.TabIndex = 29;
            this.button_Back.UseVisualStyleBackColor = false;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // Pay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(653, 423);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.button_Minimized);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxPayConfirm);
            this.Controls.Add(this.textBoxPay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pay";
            this.Text = "Pay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPay;
        private System.Windows.Forms.TextBox textBoxPayConfirm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Minimized;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_Back;
    }
}
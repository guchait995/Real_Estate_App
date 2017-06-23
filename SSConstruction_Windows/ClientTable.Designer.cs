namespace SSConstruction_Windows
{
    partial class ClientTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientTable));
            this.textBox_SearchQuery = new System.Windows.Forms.TextBox();
            this.labelUsernameOrAadharNumber = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dataTableClient = new System.Windows.Forms.DataGridView();
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.button_Minimized = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableClient)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_SearchQuery
            // 
            this.textBox_SearchQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_SearchQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_SearchQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SearchQuery.Location = new System.Drawing.Point(384, 56);
            this.textBox_SearchQuery.Name = "textBox_SearchQuery";
            this.textBox_SearchQuery.Size = new System.Drawing.Size(476, 30);
            this.textBox_SearchQuery.TabIndex = 0;
            this.textBox_SearchQuery.TextChanged += new System.EventHandler(this.textBox_SearchQuery_TextChanged);
            // 
            // labelUsernameOrAadharNumber
            // 
            this.labelUsernameOrAadharNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUsernameOrAadharNumber.AutoSize = true;
            this.labelUsernameOrAadharNumber.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsernameOrAadharNumber.Location = new System.Drawing.Point(59, 61);
            this.labelUsernameOrAadharNumber.Name = "labelUsernameOrAadharNumber";
            this.labelUsernameOrAadharNumber.Size = new System.Drawing.Size(281, 22);
            this.labelUsernameOrAadharNumber.TabIndex = 1;
            this.labelUsernameOrAadharNumber.Text = "Username or Aadhar number :";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSearch.BackColor = System.Drawing.Color.Transparent;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearch.Image")));
            this.buttonSearch.Location = new System.Drawing.Point(384, 92);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(121, 91);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataTableClient
            // 
            this.dataTableClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataTableClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTableClient.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataTableClient.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.dataTableClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTableClient.Location = new System.Drawing.Point(34, 240);
            this.dataTableClient.MultiSelect = false;
            this.dataTableClient.Name = "dataTableClient";
            this.dataTableClient.ReadOnly = true;
            this.dataTableClient.RowTemplate.Height = 24;
            this.dataTableClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTableClient.Size = new System.Drawing.Size(876, 397);
            this.dataTableClient.TabIndex = 3;
            this.dataTableClient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTableClient_CellClick);
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonShowAll.FlatAppearance.BorderSize = 0;
            this.buttonShowAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonShowAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowAll.Image = ((System.Drawing.Image)(resources.GetObject("buttonShowAll.Image")));
            this.buttonShowAll.Location = new System.Drawing.Point(511, 92);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(108, 91);
            this.buttonShowAll.TabIndex = 4;
            this.buttonShowAll.UseVisualStyleBackColor = true;
            this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);
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
            this.button_Minimized.Location = new System.Drawing.Point(843, 3);
            this.button_Minimized.Name = "button_Minimized";
            this.button_Minimized.Size = new System.Drawing.Size(36, 30);
            this.button_Minimized.TabIndex = 23;
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
            this.button_Close.Location = new System.Drawing.Point(912, 3);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(30, 30);
            this.button_Close.TabIndex = 22;
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
            this.button_Back.Location = new System.Drawing.Point(3, 3);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(47, 48);
            this.button_Back.TabIndex = 24;
            this.button_Back.UseVisualStyleBackColor = false;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // ClientTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(947, 670);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.button_Minimized);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.buttonShowAll);
            this.Controls.Add(this.dataTableClient);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelUsernameOrAadharNumber);
            this.Controls.Add(this.textBox_SearchQuery);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientTable";
            this.Text = "ClientTable";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataTableClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_SearchQuery;
        private System.Windows.Forms.Label labelUsernameOrAadharNumber;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView dataTableClient;
        private System.Windows.Forms.Button buttonShowAll;
        private System.Windows.Forms.Button button_Minimized;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_Back;
    }
}
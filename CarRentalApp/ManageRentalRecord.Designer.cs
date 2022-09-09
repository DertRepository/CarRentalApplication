namespace CarRentalApp
{
    partial class ManageRentalRecord
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
            this.btnRefreshRental = new System.Windows.Forms.Button();
            this.btnDeleteRental = new System.Windows.Forms.Button();
            this.btnEditRental = new System.Windows.Forms.Button();
            this.btnAddRental = new System.Windows.Forms.Button();
            this.lbl_header_title = new System.Windows.Forms.Label();
            this.gvRentalList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvRentalList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefreshRental
            // 
            this.btnRefreshRental.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshRental.Location = new System.Drawing.Point(891, 69);
            this.btnRefreshRental.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefreshRental.Name = "btnRefreshRental";
            this.btnRefreshRental.Size = new System.Drawing.Size(165, 61);
            this.btnRefreshRental.TabIndex = 12;
            this.btnRefreshRental.Text = "REFRESH";
            this.btnRefreshRental.UseVisualStyleBackColor = true;
            // 
            // btnDeleteRental
            // 
            this.btnDeleteRental.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRental.Location = new System.Drawing.Point(891, 493);
            this.btnDeleteRental.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteRental.Name = "btnDeleteRental";
            this.btnDeleteRental.Size = new System.Drawing.Size(165, 61);
            this.btnDeleteRental.TabIndex = 11;
            this.btnDeleteRental.Text = "DELETE";
            this.btnDeleteRental.UseVisualStyleBackColor = true;
            this.btnDeleteRental.Click += new System.EventHandler(this.btnDeleteRental_Click);
            // 
            // btnEditRental
            // 
            this.btnEditRental.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditRental.Location = new System.Drawing.Point(891, 405);
            this.btnEditRental.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditRental.Name = "btnEditRental";
            this.btnEditRental.Size = new System.Drawing.Size(165, 61);
            this.btnEditRental.TabIndex = 10;
            this.btnEditRental.Text = "EDIT";
            this.btnEditRental.UseVisualStyleBackColor = true;
            this.btnEditRental.Click += new System.EventHandler(this.btnEditRental_Click);
            // 
            // btnAddRental
            // 
            this.btnAddRental.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRental.Location = new System.Drawing.Point(891, 316);
            this.btnAddRental.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddRental.Name = "btnAddRental";
            this.btnAddRental.Size = new System.Drawing.Size(165, 61);
            this.btnAddRental.TabIndex = 9;
            this.btnAddRental.Text = "ADD";
            this.btnAddRental.UseVisualStyleBackColor = true;
            this.btnAddRental.Click += new System.EventHandler(this.btnAddRental_Click);
            // 
            // lbl_header_title
            // 
            this.lbl_header_title.AutoSize = true;
            this.lbl_header_title.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold);
            this.lbl_header_title.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_header_title.Location = new System.Drawing.Point(210, 18);
            this.lbl_header_title.Name = "lbl_header_title";
            this.lbl_header_title.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_header_title.Size = new System.Drawing.Size(460, 47);
            this.lbl_header_title.TabIndex = 8;
            this.lbl_header_title.Text = "MANAGE RENTAL RECORD";
            // 
            // gvRentalList
            // 
            this.gvRentalList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRentalList.Location = new System.Drawing.Point(12, 69);
            this.gvRentalList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gvRentalList.Name = "gvRentalList";
            this.gvRentalList.RowHeadersWidth = 51;
            this.gvRentalList.RowTemplate.Height = 24;
            this.gvRentalList.Size = new System.Drawing.Size(860, 485);
            this.gvRentalList.TabIndex = 7;
            // 
            // ManageRentalRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 567);
            this.Controls.Add(this.btnRefreshRental);
            this.Controls.Add(this.btnDeleteRental);
            this.Controls.Add(this.btnEditRental);
            this.Controls.Add(this.btnAddRental);
            this.Controls.Add(this.lbl_header_title);
            this.Controls.Add(this.gvRentalList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ManageRentalRecord";
            this.Text = "Manage Rental Record";
            this.Load += new System.EventHandler(this.ManageRentalRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvRentalList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefreshRental;
        private System.Windows.Forms.Button btnDeleteRental;
        private System.Windows.Forms.Button btnEditRental;
        private System.Windows.Forms.Button btnAddRental;
        private System.Windows.Forms.Label lbl_header_title;
        private System.Windows.Forms.DataGridView gvRentalList;
    }
}
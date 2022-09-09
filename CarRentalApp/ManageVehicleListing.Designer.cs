namespace CarRentalApp
{
    partial class ManageVehicleListing
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
            this.gvVehicleList = new System.Windows.Forms.DataGridView();
            this.lbl_header_title = new System.Windows.Forms.Label();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnEditCar = new System.Windows.Forms.Button();
            this.btnDeleteCar = new System.Windows.Forms.Button();
            this.btnRefreshCar = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvVehicleList)).BeginInit();
            this.SuspendLayout();
            // 
            // gvVehicleList
            // 
            this.gvVehicleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvVehicleList.Location = new System.Drawing.Point(14, 62);
            this.gvVehicleList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gvVehicleList.Name = "gvVehicleList";
            this.gvVehicleList.RowHeadersWidth = 51;
            this.gvVehicleList.RowTemplate.Height = 24;
            this.gvVehicleList.Size = new System.Drawing.Size(860, 485);
            this.gvVehicleList.TabIndex = 0;
            this.gvVehicleList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lbl_header_title
            // 
            this.lbl_header_title.AutoSize = true;
            this.lbl_header_title.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold);
            this.lbl_header_title.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_header_title.Location = new System.Drawing.Point(186, 11);
            this.lbl_header_title.Name = "lbl_header_title";
            this.lbl_header_title.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_header_title.Size = new System.Drawing.Size(504, 47);
            this.lbl_header_title.TabIndex = 2;
            this.lbl_header_title.Text = "MANAGE VEHICLE LISTING";
            // 
            // btnAddCar
            // 
            this.btnAddCar.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCar.Location = new System.Drawing.Point(893, 195);
            this.btnAddCar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(165, 61);
            this.btnAddCar.TabIndex = 3;
            this.btnAddCar.Text = "ADD";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // btnEditCar
            // 
            this.btnEditCar.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCar.Location = new System.Drawing.Point(893, 284);
            this.btnEditCar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditCar.Name = "btnEditCar";
            this.btnEditCar.Size = new System.Drawing.Size(165, 61);
            this.btnEditCar.TabIndex = 4;
            this.btnEditCar.Text = "EDIT";
            this.btnEditCar.UseVisualStyleBackColor = true;
            this.btnEditCar.Click += new System.EventHandler(this.btnEditCar_Click);
            // 
            // btnDeleteCar
            // 
            this.btnDeleteCar.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCar.Location = new System.Drawing.Point(893, 372);
            this.btnDeleteCar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteCar.Name = "btnDeleteCar";
            this.btnDeleteCar.Size = new System.Drawing.Size(165, 61);
            this.btnDeleteCar.TabIndex = 5;
            this.btnDeleteCar.Text = "DELETE";
            this.btnDeleteCar.UseVisualStyleBackColor = true;
            this.btnDeleteCar.Click += new System.EventHandler(this.btnDeleteCar_Click);
            // 
            // btnRefreshCar
            // 
            this.btnRefreshCar.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshCar.Location = new System.Drawing.Point(893, 62);
            this.btnRefreshCar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefreshCar.Name = "btnRefreshCar";
            this.btnRefreshCar.Size = new System.Drawing.Size(165, 61);
            this.btnRefreshCar.TabIndex = 6;
            this.btnRefreshCar.Text = "REFRESH";
            this.btnRefreshCar.UseVisualStyleBackColor = true;
            this.btnRefreshCar.Click += new System.EventHandler(this.btnRefreshCar_Click);
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(893, 486);
            this.btnExport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(165, 61);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "EXPORT";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // ManageVehicleListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 562);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnRefreshCar);
            this.Controls.Add(this.btnDeleteCar);
            this.Controls.Add(this.btnEditCar);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.lbl_header_title);
            this.Controls.Add(this.gvVehicleList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ManageVehicleListing";
            this.Text = "Manage Vehicle Listing";
            this.Load += new System.EventHandler(this.ManageVehicleListing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvVehicleList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvVehicleList;
        private System.Windows.Forms.Label lbl_header_title;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnEditCar;
        private System.Windows.Forms.Button btnDeleteCar;
        private System.Windows.Forms.Button btnRefreshCar;
        private System.Windows.Forms.Button btnExport;
    }
}
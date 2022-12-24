namespace Services
{
    partial class FormServices
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
            System.Windows.Forms.Label label1;
            this.dataGridServices = new System.Windows.Forms.DataGridView();
            this.startService = new System.Windows.Forms.Button();
            this.stopService = new System.Windows.Forms.Button();
            this.serviceStartType = new System.Windows.Forms.ComboBox();
            this.LogFile = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridServices)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(566, 606);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(144, 20);
            label1.TabIndex = 14;
            label1.Text = "Change Startmode";
            // 
            // dataGridServices
            // 
            this.dataGridServices.AllowUserToAddRows = false;
            this.dataGridServices.AllowUserToDeleteRows = false;
            this.dataGridServices.AllowUserToResizeRows = false;
            this.dataGridServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridServices.Location = new System.Drawing.Point(0, 0);
            this.dataGridServices.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridServices.MultiSelect = false;
            this.dataGridServices.Name = "dataGridServices";
            this.dataGridServices.RowHeadersVisible = false;
            this.dataGridServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridServices.ShowCellErrors = false;
            this.dataGridServices.ShowEditingIcon = false;
            this.dataGridServices.ShowRowErrors = false;
            this.dataGridServices.Size = new System.Drawing.Size(998, 574);
            this.dataGridServices.TabIndex = 10;
            this.dataGridServices.SelectionChanged += new System.EventHandler(this.dataGridServices_SelectionChanged);
            // 
            // startService
            // 
            this.startService.Location = new System.Drawing.Point(13, 606);
            this.startService.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startService.Name = "startService";
            this.startService.Size = new System.Drawing.Size(158, 72);
            this.startService.TabIndex = 11;
            this.startService.Text = "Start Service";
            this.startService.UseVisualStyleBackColor = true;
            this.startService.Click += new System.EventHandler(this.startservice_Click);
            // 
            // stopService
            // 
            this.stopService.Location = new System.Drawing.Point(184, 606);
            this.stopService.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stopService.Name = "stopService";
            this.stopService.Size = new System.Drawing.Size(153, 72);
            this.stopService.TabIndex = 12;
            this.stopService.Text = "Stop Service";
            this.stopService.UseVisualStyleBackColor = true;
            this.stopService.Click += new System.EventHandler(this.stopservice_Click);
            // 
            // serviceStartType
            // 
            this.serviceStartType.AllowDrop = true;
            this.serviceStartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serviceStartType.FormattingEnabled = true;
            this.serviceStartType.Items.AddRange(new object[] {
            "Manual",
            "Disabled",
            "Auto"});
            this.serviceStartType.Location = new System.Drawing.Point(530, 629);
            this.serviceStartType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.serviceStartType.Name = "serviceStartType";
            this.serviceStartType.Size = new System.Drawing.Size(180, 28);
            this.serviceStartType.TabIndex = 13;
            this.serviceStartType.SelectedIndexChanged += new System.EventHandler(this.servicestarttype_SelectedIndexChanged);
            // 
            // LogFile
            // 
            this.LogFile.Location = new System.Drawing.Point(356, 606);
            this.LogFile.Name = "LogFile";
            this.LogFile.Size = new System.Drawing.Size(139, 72);
            this.LogFile.TabIndex = 15;
            this.LogFile.Text = "LogFile";
            this.LogFile.UseVisualStyleBackColor = true;
            this.LogFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 791);
            this.Controls.Add(this.LogFile);
            this.Controls.Add(label1);
            this.Controls.Add(this.serviceStartType);
            this.Controls.Add(this.stopService);
            this.Controls.Add(this.startService);
            this.Controls.Add(this.dataGridServices);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FormServices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Services";
            this.Load += new System.EventHandler(this.FormServices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridServices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.DataGridView dataGridServices;
		private System.Windows.Forms.Button startService;
		private System.Windows.Forms.Button stopService;
		private System.Windows.Forms.ComboBox serviceStartType;
        private System.Windows.Forms.Button LogFile;
    }
}


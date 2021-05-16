namespace DemoJSON
{
    partial class FormMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.min_age_limit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbPinCodes = new System.Windows.Forms.ListBox();
            this.lbDates = new System.Windows.Forms.ListBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vaccineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availablecapacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pincodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.min_age_limit,
            this.vaccineDataGridViewTextBoxColumn,
            this.availablecapacityDataGridViewTextBoxColumn,
            this.pincodeDataGridViewTextBoxColumn,
            this.date});
            this.dataGridView1.DataSource = this.sessionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(238, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1074, 355);
            this.dataGridView1.TabIndex = 0;
            // 
            // min_age_limit
            // 
            this.min_age_limit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.min_age_limit.DataPropertyName = "min_age_limit";
            this.min_age_limit.HeaderText = "min_age_limit";
            this.min_age_limit.MinimumWidth = 6;
            this.min_age_limit.Name = "min_age_limit";
            this.min_age_limit.ReadOnly = true;
            this.min_age_limit.Width = 123;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.date.DataPropertyName = "date";
            dataGridViewCellStyle1.Format = "M";
            dataGridViewCellStyle1.NullValue = null;
            this.date.DefaultCellStyle = dataGridViewCellStyle1;
            this.date.HeaderText = "date";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 65;
            // 
            // lbPinCodes
            // 
            this.lbPinCodes.FormattingEnabled = true;
            this.lbPinCodes.ItemHeight = 16;
            this.lbPinCodes.Location = new System.Drawing.Point(5, 55);
            this.lbPinCodes.Name = "lbPinCodes";
            this.lbPinCodes.Size = new System.Drawing.Size(96, 356);
            this.lbPinCodes.TabIndex = 2;
            this.lbPinCodes.SelectedIndexChanged += new System.EventHandler(this.lbPinCodes_SelectedIndexChanged);
            // 
            // lbDates
            // 
            this.lbDates.FormattingEnabled = true;
            this.lbDates.ItemHeight = 16;
            this.lbDates.Location = new System.Drawing.Point(127, 55);
            this.lbDates.Name = "lbDates";
            this.lbDates.Size = new System.Drawing.Size(96, 356);
            this.lbDates.TabIndex = 3;
            this.lbDates.SelectedIndexChanged += new System.EventHandler(this.lbDates_SelectedIndexChanged);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(725, 426);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(117, 17);
            this.lblMessage.TabIndex = 4;
            this.lblMessage.Text = "Centers Found: 0";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vaccineDataGridViewTextBoxColumn
            // 
            this.vaccineDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.vaccineDataGridViewTextBoxColumn.DataPropertyName = "vaccine";
            this.vaccineDataGridViewTextBoxColumn.HeaderText = "vaccine";
            this.vaccineDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vaccineDataGridViewTextBoxColumn.Name = "vaccineDataGridViewTextBoxColumn";
            this.vaccineDataGridViewTextBoxColumn.ReadOnly = true;
            this.vaccineDataGridViewTextBoxColumn.Width = 85;
            // 
            // availablecapacityDataGridViewTextBoxColumn
            // 
            this.availablecapacityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.availablecapacityDataGridViewTextBoxColumn.DataPropertyName = "available_capacity";
            this.availablecapacityDataGridViewTextBoxColumn.HeaderText = "available_capacity";
            this.availablecapacityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.availablecapacityDataGridViewTextBoxColumn.Name = "availablecapacityDataGridViewTextBoxColumn";
            this.availablecapacityDataGridViewTextBoxColumn.ReadOnly = true;
            this.availablecapacityDataGridViewTextBoxColumn.Width = 153;
            // 
            // pincodeDataGridViewTextBoxColumn
            // 
            this.pincodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pincodeDataGridViewTextBoxColumn.DataPropertyName = "pincode";
            this.pincodeDataGridViewTextBoxColumn.HeaderText = "pincode";
            this.pincodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pincodeDataGridViewTextBoxColumn.Name = "pincodeDataGridViewTextBoxColumn";
            this.pincodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.pincodeDataGridViewTextBoxColumn.Width = 87;
            // 
            // sessionBindingSource
            // 
            this.sessionBindingSource.DataSource = typeof(DemoJSON.Session);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 456);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lbDates);
            this.Controls.Add(this.lbPinCodes);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormMain";
            this.Text = "Covid Vaccination Center Information";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource sessionBindingSource;
        private System.Windows.Forms.ListBox lbPinCodes;
        private System.Windows.Forms.ListBox lbDates;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn min_age_limit;
        private System.Windows.Forms.DataGridViewTextBoxColumn vaccineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availablecapacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pincodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.Label lblMessage;
    }
}


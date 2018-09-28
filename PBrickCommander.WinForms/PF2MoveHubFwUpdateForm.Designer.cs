namespace PBrickCommander.WinForms
{
    partial class PF2MoveHubFwUpdateForm
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
            if (disposing && (components != null)) {
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
      this.label1 = new System.Windows.Forms.Label();
      this.dataGridView = new System.Windows.Forms.DataGridView();
      this.pF2MoveHubFwUpdateDeviceViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.BDAddrColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.FwVersionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ProgressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pF2MoveHubFwUpdateDeviceViewModelBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(390, 22);
      this.label1.TabIndex = 0;
      this.label1.Text = "Press and hold green button for 5 seconds to activate the firmware updater.";
      this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // dataGridView
      // 
      this.dataGridView.AllowUserToAddRows = false;
      this.dataGridView.AllowUserToDeleteRows = false;
      this.dataGridView.AllowUserToResizeColumns = false;
      this.dataGridView.AllowUserToResizeRows = false;
      this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataGridView.AutoGenerateColumns = false;
      this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.BDAddrColumn,
            this.FwVersionColumn,
            this.ProgressColumn});
      this.dataGridView.DataSource = this.pF2MoveHubFwUpdateDeviceViewModelBindingSource;
      this.dataGridView.Location = new System.Drawing.Point(15, 34);
      this.dataGridView.Name = "dataGridView";
      this.dataGridView.ReadOnly = true;
      this.dataGridView.RowHeadersVisible = false;
      this.dataGridView.Size = new System.Drawing.Size(387, 140);
      this.dataGridView.TabIndex = 1;
      this.dataGridView.TabStop = false;
      // 
      // pF2MoveHubFwUpdateDeviceViewModelBindingSource
      // 
      this.pF2MoveHubFwUpdateDeviceViewModelBindingSource.DataSource = typeof(PBrickCommander.PF2MoveHubFwUpdateDeviceViewModel);
      // 
      // NameColumn
      // 
      this.NameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.NameColumn.DataPropertyName = "Name";
      this.NameColumn.HeaderText = "Name";
      this.NameColumn.Name = "NameColumn";
      this.NameColumn.ReadOnly = true;
      this.NameColumn.Width = 60;
      // 
      // BDAddrColumn
      // 
      this.BDAddrColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.BDAddrColumn.DataPropertyName = "BDAddr";
      this.BDAddrColumn.HeaderText = "Bluetooth Address";
      this.BDAddrColumn.Name = "BDAddrColumn";
      this.BDAddrColumn.ReadOnly = true;
      this.BDAddrColumn.Width = 108;
      // 
      // FwVersionColumn
      // 
      this.FwVersionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.FwVersionColumn.DataPropertyName = "FwVersion";
      this.FwVersionColumn.HeaderText = "Firmware Version";
      this.FwVersionColumn.Name = "FwVersionColumn";
      this.FwVersionColumn.ReadOnly = true;
      this.FwVersionColumn.Width = 103;
      // 
      // ProgressColumn
      // 
      this.ProgressColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.ProgressColumn.HeaderText = "Progress";
      this.ProgressColumn.Name = "ProgressColumn";
      this.ProgressColumn.ReadOnly = true;
      // 
      // PF2MoveHubFwUpdateForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(414, 186);
      this.Controls.Add(this.dataGridView);
      this.Controls.Add(this.label1);
      this.HelpButton = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "PF2MoveHubFwUpdateForm";
      this.Text = "Move Hub Firmware Update";
      this.Load += new System.EventHandler(this.PF2MoveHubFwUpdateForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pF2MoveHubFwUpdateDeviceViewModelBindingSource)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource pF2MoveHubFwUpdateDeviceViewModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BDAddrColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FwVersionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProgressColumn;
    }
}
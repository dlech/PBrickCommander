namespace PBrickCommander.WinForms
{
  partial class mainForm
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
      this.nxtFwUpdateButton = new System.Windows.Forms.Button();
      this.ev3FwUpdateButton = new System.Windows.Forms.Button();
      this.boostFwUpdateButton = new System.Windows.Forms.Button();
      this.smartHubFwUpdateButton = new System.Windows.Forms.Button();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.nameDataGridViewTextBoxColumn1 = new PBrickCommander.WinForms.AsyncTextBoxColumn();
      this.firmwareVersionDataGridViewTextBoxColumn1 = new PBrickCommander.WinForms.AsyncTextBoxColumn();
      this.pBrickDeviceViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.nameDataGridViewTextBoxColumn = new PBrickCommander.WinForms.AsyncTextBoxColumn();
      this.firmwareVersionDataGridViewTextBoxColumn = new PBrickCommander.WinForms.AsyncTextBoxColumn();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pBrickDeviceViewModelBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // nxtFwUpdateButton
      // 
      this.nxtFwUpdateButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.nxtFwUpdateButton.Location = new System.Drawing.Point(22, 22);
      this.nxtFwUpdateButton.Margin = new System.Windows.Forms.Padding(6);
      this.nxtFwUpdateButton.Name = "nxtFwUpdateButton";
      this.nxtFwUpdateButton.Size = new System.Drawing.Size(1378, 42);
      this.nxtFwUpdateButton.TabIndex = 0;
      this.nxtFwUpdateButton.Text = "Update NXT Firmware";
      this.nxtFwUpdateButton.UseVisualStyleBackColor = true;
      // 
      // ev3FwUpdateButton
      // 
      this.ev3FwUpdateButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.ev3FwUpdateButton.Location = new System.Drawing.Point(22, 76);
      this.ev3FwUpdateButton.Margin = new System.Windows.Forms.Padding(6);
      this.ev3FwUpdateButton.Name = "ev3FwUpdateButton";
      this.ev3FwUpdateButton.Size = new System.Drawing.Size(1378, 42);
      this.ev3FwUpdateButton.TabIndex = 1;
      this.ev3FwUpdateButton.Text = "Update EV3 Firmware";
      this.ev3FwUpdateButton.UseVisualStyleBackColor = true;
      // 
      // boostFwUpdateButton
      // 
      this.boostFwUpdateButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.boostFwUpdateButton.Location = new System.Drawing.Point(22, 129);
      this.boostFwUpdateButton.Margin = new System.Windows.Forms.Padding(6);
      this.boostFwUpdateButton.Name = "boostFwUpdateButton";
      this.boostFwUpdateButton.Size = new System.Drawing.Size(1378, 42);
      this.boostFwUpdateButton.TabIndex = 2;
      this.boostFwUpdateButton.Text = "Update BOOST Move Hub Firmware";
      this.boostFwUpdateButton.UseVisualStyleBackColor = true;
      this.boostFwUpdateButton.Click += new System.EventHandler(this.boostFwUpdateButton_Click);
      // 
      // smartHubFwUpdateButton
      // 
      this.smartHubFwUpdateButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.smartHubFwUpdateButton.Location = new System.Drawing.Point(22, 183);
      this.smartHubFwUpdateButton.Margin = new System.Windows.Forms.Padding(6);
      this.smartHubFwUpdateButton.Name = "smartHubFwUpdateButton";
      this.smartHubFwUpdateButton.Size = new System.Drawing.Size(1378, 42);
      this.smartHubFwUpdateButton.TabIndex = 3;
      this.smartHubFwUpdateButton.Text = "Update Powered Up Smart Hub Firmware";
      this.smartHubFwUpdateButton.UseVisualStyleBackColor = true;
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataGridView1.AutoGenerateColumns = false;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.firmwareVersionDataGridViewTextBoxColumn1});
      this.dataGridView1.DataSource = this.pBrickDeviceViewModelBindingSource;
      this.dataGridView1.Location = new System.Drawing.Point(22, 248);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.RowHeadersVisible = false;
      this.dataGridView1.RowTemplate.Height = 31;
      this.dataGridView1.Size = new System.Drawing.Size(1378, 462);
      this.dataGridView1.TabIndex = 4;
      // 
      // nameDataGridViewTextBoxColumn1
      // 
      this.nameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
      this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
      this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
      this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
      this.nameDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.nameDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
      this.nameDataGridViewTextBoxColumn1.Width = 105;
      // 
      // firmwareVersionDataGridViewTextBoxColumn1
      // 
      this.firmwareVersionDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.firmwareVersionDataGridViewTextBoxColumn1.DataPropertyName = "FirmwareVersion";
      this.firmwareVersionDataGridViewTextBoxColumn1.HeaderText = "FirmwareVersion";
      this.firmwareVersionDataGridViewTextBoxColumn1.Name = "firmwareVersionDataGridViewTextBoxColumn1";
      this.firmwareVersionDataGridViewTextBoxColumn1.ReadOnly = true;
      this.firmwareVersionDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.firmwareVersionDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
      this.firmwareVersionDataGridViewTextBoxColumn1.Width = 200;
      // 
      // pBrickDeviceViewModelBindingSource
      // 
      this.pBrickDeviceViewModelBindingSource.DataSource = typeof(PBrickCommander.PBrickDeviceViewModel);
      // 
      // nameDataGridViewTextBoxColumn
      // 
      this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
      this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
      this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
      this.nameDataGridViewTextBoxColumn.ReadOnly = true;
      this.nameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.nameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
      // 
      // firmwareVersionDataGridViewTextBoxColumn
      // 
      this.firmwareVersionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.firmwareVersionDataGridViewTextBoxColumn.DataPropertyName = "FirmwareVersion";
      this.firmwareVersionDataGridViewTextBoxColumn.HeaderText = "Firmware Version";
      this.firmwareVersionDataGridViewTextBoxColumn.Name = "firmwareVersionDataGridViewTextBoxColumn";
      this.firmwareVersionDataGridViewTextBoxColumn.ReadOnly = true;
      this.firmwareVersionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.firmwareVersionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
      this.dataGridViewTextBoxColumn1.HeaderText = "Name";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.dataGridViewTextBoxColumn2.DataPropertyName = "FirmwareVersion";
      this.dataGridViewTextBoxColumn2.HeaderText = "Firmware Version";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      // 
      // mainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1422, 722);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.smartHubFwUpdateButton);
      this.Controls.Add(this.boostFwUpdateButton);
      this.Controls.Add(this.ev3FwUpdateButton);
      this.Controls.Add(this.nxtFwUpdateButton);
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "mainForm";
      this.Text = "P-Brick Commander";
      this.Load += new System.EventHandler(this.mainForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pBrickDeviceViewModelBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button nxtFwUpdateButton;
    private System.Windows.Forms.Button ev3FwUpdateButton;
    private System.Windows.Forms.Button boostFwUpdateButton;
    private System.Windows.Forms.Button smartHubFwUpdateButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource pBrickDeviceViewModelBindingSource;
        private AsyncTextBoxColumn nameDataGridViewTextBoxColumn;
        private AsyncTextBoxColumn firmwareVersionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private AsyncTextBoxColumn nameDataGridViewTextBoxColumn1;
        private AsyncTextBoxColumn firmwareVersionDataGridViewTextBoxColumn1;
    }
}


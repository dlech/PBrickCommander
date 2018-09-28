namespace PBrickCommander.WinForms
{
  partial class NxtFwUpdateForm
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
      this.browseButton = new System.Windows.Forms.Button();
      this.fwFileTextBox = new System.Windows.Forms.TextBox();
      this.deviceDataGridView = new System.Windows.Forms.DataGridView();
      this.closeButton = new System.Windows.Forms.Button();
      this.startButton = new System.Windows.Forms.Button();
      this.fwFileLabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.deviceDataGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // browseButton
      // 
      this.browseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.browseButton.Location = new System.Drawing.Point(470, 12);
      this.browseButton.Name = "browseButton";
      this.browseButton.Size = new System.Drawing.Size(75, 23);
      this.browseButton.TabIndex = 0;
      this.browseButton.Text = "&Browse...";
      this.browseButton.UseVisualStyleBackColor = true;
      // 
      // fwFileTextBox
      // 
      this.fwFileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.fwFileTextBox.Location = new System.Drawing.Point(86, 14);
      this.fwFileTextBox.Name = "fwFileTextBox";
      this.fwFileTextBox.Size = new System.Drawing.Size(378, 20);
      this.fwFileTextBox.TabIndex = 1;
      // 
      // deviceDataGridView
      // 
      this.deviceDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.deviceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.deviceDataGridView.Location = new System.Drawing.Point(12, 55);
      this.deviceDataGridView.Name = "deviceDataGridView";
      this.deviceDataGridView.Size = new System.Drawing.Size(533, 133);
      this.deviceDataGridView.TabIndex = 2;
      // 
      // closeButton
      // 
      this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.closeButton.Location = new System.Drawing.Point(470, 207);
      this.closeButton.Name = "closeButton";
      this.closeButton.Size = new System.Drawing.Size(75, 23);
      this.closeButton.TabIndex = 3;
      this.closeButton.Text = "&Close";
      this.closeButton.UseVisualStyleBackColor = true;
      // 
      // startButton
      // 
      this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.startButton.Location = new System.Drawing.Point(389, 207);
      this.startButton.Name = "startButton";
      this.startButton.Size = new System.Drawing.Size(75, 23);
      this.startButton.TabIndex = 4;
      this.startButton.Text = "&Start";
      this.startButton.UseVisualStyleBackColor = true;
      // 
      // fwFileLabel
      // 
      this.fwFileLabel.AutoSize = true;
      this.fwFileLabel.Location = new System.Drawing.Point(12, 17);
      this.fwFileLabel.Name = "fwFileLabel";
      this.fwFileLabel.Size = new System.Drawing.Size(68, 13);
      this.fwFileLabel.TabIndex = 5;
      this.fwFileLabel.Text = "Firmware file:";
      // 
      // NxtFwUpdateForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(557, 242);
      this.ControlBox = false;
      this.Controls.Add(this.fwFileLabel);
      this.Controls.Add(this.startButton);
      this.Controls.Add(this.closeButton);
      this.Controls.Add(this.deviceDataGridView);
      this.Controls.Add(this.fwFileTextBox);
      this.Controls.Add(this.browseButton);
      this.Name = "NxtFwUpdateForm";
      this.ShowInTaskbar = false;
      this.Text = "NXT Firmware Update";
      ((System.ComponentModel.ISupportInitialize)(this.deviceDataGridView)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox fwFileTextBox;
        private System.Windows.Forms.DataGridView deviceDataGridView;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label fwFileLabel;
    }
}
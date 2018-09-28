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
      this.nxtFwUpdateButton = new System.Windows.Forms.Button();
      this.ev3FwUpdateButton = new System.Windows.Forms.Button();
      this.boostFwUpdateButton = new System.Windows.Forms.Button();
      this.smartHubFwUpdateButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // nxtFwUpdateButton
      // 
      this.nxtFwUpdateButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.nxtFwUpdateButton.Location = new System.Drawing.Point(12, 12);
      this.nxtFwUpdateButton.Name = "nxtFwUpdateButton";
      this.nxtFwUpdateButton.Size = new System.Drawing.Size(232, 23);
      this.nxtFwUpdateButton.TabIndex = 0;
      this.nxtFwUpdateButton.Text = "Update NXT Firmware";
      this.nxtFwUpdateButton.UseVisualStyleBackColor = true;
      // 
      // ev3FwUpdateButton
      // 
      this.ev3FwUpdateButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.ev3FwUpdateButton.Location = new System.Drawing.Point(12, 41);
      this.ev3FwUpdateButton.Name = "ev3FwUpdateButton";
      this.ev3FwUpdateButton.Size = new System.Drawing.Size(232, 23);
      this.ev3FwUpdateButton.TabIndex = 1;
      this.ev3FwUpdateButton.Text = "Update EV3 Firmware";
      this.ev3FwUpdateButton.UseVisualStyleBackColor = true;
      // 
      // boostFwUpdateButton
      // 
      this.boostFwUpdateButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.boostFwUpdateButton.Location = new System.Drawing.Point(12, 70);
      this.boostFwUpdateButton.Name = "boostFwUpdateButton";
      this.boostFwUpdateButton.Size = new System.Drawing.Size(232, 23);
      this.boostFwUpdateButton.TabIndex = 2;
      this.boostFwUpdateButton.Text = "Update BOOST Move Hub Firmware";
      this.boostFwUpdateButton.UseVisualStyleBackColor = true;
      this.boostFwUpdateButton.Click += new System.EventHandler(this.boostFwUpdateButton_Click);
      // 
      // smartHubFwUpdateButton
      // 
      this.smartHubFwUpdateButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.smartHubFwUpdateButton.Location = new System.Drawing.Point(12, 99);
      this.smartHubFwUpdateButton.Name = "smartHubFwUpdateButton";
      this.smartHubFwUpdateButton.Size = new System.Drawing.Size(232, 23);
      this.smartHubFwUpdateButton.TabIndex = 3;
      this.smartHubFwUpdateButton.Text = "Update Powered Up Smart Hub Firmware";
      this.smartHubFwUpdateButton.UseVisualStyleBackColor = true;
      // 
      // mainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(256, 139);
      this.Controls.Add(this.smartHubFwUpdateButton);
      this.Controls.Add(this.boostFwUpdateButton);
      this.Controls.Add(this.ev3FwUpdateButton);
      this.Controls.Add(this.nxtFwUpdateButton);
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "mainForm";
      this.Text = "P-Brick Commander";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button nxtFwUpdateButton;
    private System.Windows.Forms.Button ev3FwUpdateButton;
    private System.Windows.Forms.Button boostFwUpdateButton;
    private System.Windows.Forms.Button smartHubFwUpdateButton;
  }
}


namespace LG_PWGen {
  partial class mainForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }
    private void manualInit() {
      this.textBoxes = new System.Windows.Forms.TextBox[10];
      int xDrawingCoord = 51;   //this remains constant
      int yDrawingCoord = 55;   //y-coordinate for first textbox only

      for (int x = 0; x < 10; x++) {
        this.textBoxes[x] = new System.Windows.Forms.TextBox();
        this.textBoxes[x].Location = new System.Drawing.Point(xDrawingCoord, yDrawingCoord);
        this.textBoxes[x].Name = "textBox" + (x + 1);
        this.textBoxes[x].Size = new System.Drawing.Size(322, 20);
        this.textBoxes[x].TabIndex = x + 4;  //adjusted for automatically generated UI elements
        this.textBoxes[x].Text = "";
        this.textBoxes[x].GotFocus += new System.EventHandler(OnGotFocus);
        this.Controls.Add(this.textBoxes[x]);
        yDrawingCoord += 26;  //increment to properly position next textbox
      }
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
      this.generateButton = new System.Windows.Forms.Button();
      this.selectButton = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.selectedPWLabel = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.settingsMenu = new System.Windows.Forms.ToolStripMenuItem();

      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // generateButton
      // 
      this.generateButton.Location = new System.Drawing.Point(59, 374);
      this.generateButton.Name = "generateButton";
      this.generateButton.Size = new System.Drawing.Size(152, 27);
      this.generateButton.TabIndex = 0;
      this.generateButton.Text = "Generate";
      this.generateButton.UseVisualStyleBackColor = true;
      this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
      // 
      // selectButton
      // 
      this.selectButton.Enabled = false;
      this.selectButton.Location = new System.Drawing.Point(218, 374);
      this.selectButton.Name = "selectButton";
      this.selectButton.Size = new System.Drawing.Size(152, 27);
      this.selectButton.TabIndex = 1;
      this.selectButton.Text = "Select";
      this.selectButton.UseVisualStyleBackColor = true;
      this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(56, 341);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(52, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Selected:";
      // 
      // selectedPWLabel
      // 
      this.selectedPWLabel.Location = new System.Drawing.Point(114, 341);
      this.selectedPWLabel.Name = "selectedPWLabel";
      this.selectedPWLabel.Size = new System.Drawing.Size(256, 13);
      this.selectedPWLabel.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.ForeColor = System.Drawing.Color.Red;
      this.label2.Location = new System.Drawing.Point(84, 25);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(256, 13);
      this.label2.TabIndex = 4;
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsMenu});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(424, 24);
      this.menuStrip1.TabIndex = 5;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // settingsMenu
      // 
      this.settingsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverSetup});
      this.settingsMenu.Name = "settingsMenu";
      this.settingsMenu.Size = new System.Drawing.Size(61, 20);
      this.settingsMenu.Text = "Settings";
      // 
      // serverSetup
      // 
      this.serverSetup = new System.Windows.Forms.ToolStripMenuItem();
      this.serverSetup.Name = "serverSetup";
      this.serverSetup.Size = new System.Drawing.Size(152, 22);
      this.serverSetup.Text = "Server Setup";
      this.serverSetup.Click += new System.EventHandler(OpenServerSetup);


      // 
      // mainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(424, 431);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.selectedPWLabel);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.selectButton);
      this.Controls.Add(this.generateButton);
      this.Controls.Add(this.menuStrip1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menuStrip1;
      this.MaximizeBox = false;
      this.Name = "mainForm";
      this.RightToLeftLayout = true;
      this.Text = "PW Generator";
      this.Load += new System.EventHandler(this.mainForm_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }
    #endregion

    private System.Windows.Forms.Button generateButton;
    private System.Windows.Forms.Button selectButton;
    private System.Windows.Forms.TextBox[] textBoxes;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label selectedPWLabel;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem settingsMenu;
    private System.Windows.Forms.ToolStripMenuItem serverSetup;
  }
}


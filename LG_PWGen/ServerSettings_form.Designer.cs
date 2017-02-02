namespace LG_PWGen {
  partial class ServerSettings_form {
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.button1 = new System.Windows.Forms.Button();
      this.hostname_Label = new System.Windows.Forms.Label();
      this.hostname_TextBox = new System.Windows.Forms.TextBox();
      this.username_Label = new System.Windows.Forms.Label();
      this.username_TextBox = new System.Windows.Forms.TextBox();
      this.password_Label = new System.Windows.Forms.Label();
      this.password_TextBox = new System.Windows.Forms.TextBox();
      this.database_Label = new System.Windows.Forms.Label();
      this.database_TextBox = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(107, 128);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "OK";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // hostname_Label
      // 
      this.hostname_Label.AutoSize = true;
      this.hostname_Label.Location = new System.Drawing.Point(6, 15);
      this.hostname_Label.Name = "hostname_Label";
      this.hostname_Label.Size = new System.Drawing.Size(73, 13);
      this.hostname_Label.TabIndex = 2;
      this.hostname_Label.Text = "Hostname/IP:";
      this.hostname_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.hostname_Label.Click += new System.EventHandler(this.label1_Click);
      // 
      // hostname_TextBox
      // 
      this.hostname_TextBox.Location = new System.Drawing.Point(85, 12);
      this.hostname_TextBox.Name = "hostname_TextBox";
      this.hostname_TextBox.Size = new System.Drawing.Size(185, 20);
      this.hostname_TextBox.TabIndex = 1;
      // 
      // username_Label
      // 
      this.username_Label.AutoSize = true;
      this.username_Label.Location = new System.Drawing.Point(6, 41);
      this.username_Label.Name = "username_Label";
      this.username_Label.Size = new System.Drawing.Size(58, 13);
      this.username_Label.TabIndex = 4;
      this.username_Label.Text = "Username:";
      this.username_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // username_TextBox
      // 
      this.username_TextBox.Location = new System.Drawing.Point(85, 38);
      this.username_TextBox.Name = "username_TextBox";
      this.username_TextBox.Size = new System.Drawing.Size(185, 20);
      this.username_TextBox.TabIndex = 3;
      // 
      // password_Label
      // 
      this.password_Label.AutoSize = true;
      this.password_Label.Location = new System.Drawing.Point(6, 67);
      this.password_Label.Name = "password_Label";
      this.password_Label.Size = new System.Drawing.Size(56, 13);
      this.password_Label.TabIndex = 6;
      this.password_Label.Text = "Password:";
      this.password_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // password_TextBox
      // 
      this.password_TextBox.Location = new System.Drawing.Point(85, 64);
      this.password_TextBox.Name = "password_TextBox";
      this.password_TextBox.Size = new System.Drawing.Size(185, 20);
      this.password_TextBox.TabIndex = 5;
      // 
      // database_Label
      // 
      this.database_Label.AutoSize = true;
      this.database_Label.Location = new System.Drawing.Point(6, 93);
      this.database_Label.Name = "database_Label";
      this.database_Label.Size = new System.Drawing.Size(56, 13);
      this.database_Label.TabIndex = 8;
      this.database_Label.Text = "Database:";
      this.database_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // database_TextBox
      // 
      this.database_TextBox.Location = new System.Drawing.Point(85, 90);
      this.database_TextBox.Name = "database_TextBox";
      this.database_TextBox.Size = new System.Drawing.Size(185, 20);
      this.database_TextBox.TabIndex = 7;
      // 
      // ServerSettings_form
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(293, 163);
      this.Controls.Add(this.database_Label);
      this.Controls.Add(this.database_TextBox);
      this.Controls.Add(this.password_Label);
      this.Controls.Add(this.password_TextBox);
      this.Controls.Add(this.username_Label);
      this.Controls.Add(this.username_TextBox);
      this.Controls.Add(this.hostname_Label);
      this.Controls.Add(this.hostname_TextBox);
      this.Controls.Add(this.button1);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ServerSettings_form";
      this.ShowIcon = false;
      this.Text = "Server Settings";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox hostname_TextBox;
    private System.Windows.Forms.Label hostname_Label;
    private System.Windows.Forms.Label username_Label;
    private System.Windows.Forms.TextBox username_TextBox;
    private System.Windows.Forms.Label password_Label;
    private System.Windows.Forms.TextBox password_TextBox;
    private System.Windows.Forms.Label database_Label;
    private System.Windows.Forms.TextBox database_TextBox;
  }
}
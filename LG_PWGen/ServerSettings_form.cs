using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LG_PWGen {
  public partial class ServerSettings_form : Form {
    string m_db_uid;
    string m_db_passwd;
    string m_db_svr;
    string m_db_name;
    public ServerSettings_form() {

      InitializeComponent();
      this.button1.Click += new EventHandler(button1Click_event);
      this.hostname_TextBox.KeyDown += new KeyEventHandler(enterKey_event);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.hostname_TextBox.Text = Program.DB_SERVER;
      this.username_TextBox.Text = Program.DB_USER_ID;
      this.password_TextBox.Text = Program.DB_PASSWD;
      this.database_TextBox.Text = Program.DATABASE;
      this.button1.Focus();
    }
    private void button1Click_event(object sender, EventArgs e) {
      Program.DB_SERVER = this.hostname_TextBox.Text;
      Program.DB_USER_ID = this.username_TextBox.Text;
      Program.DB_PASSWD = this.password_TextBox.Text;
      Program.DATABASE = this.database_TextBox.Text;

      this.Close();
    }

    private void enterKey_event(object sender, KeyEventArgs e) { 
      if (e.KeyCode == Keys.Enter) {
        Program.DB_SERVER = this.hostname_TextBox.Text;
        Program.DB_USER_ID = this.username_TextBox.Text;
        Program.DB_PASSWD = this.password_TextBox.Text;
        Program.DATABASE = this.database_TextBox.Text;
        this.Close();
      }
    }

    private void label1_Click(object sender, EventArgs e) {

    }
  }
}

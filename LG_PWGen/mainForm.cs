using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LG_PWGen {
  public partial class mainForm : Form {
    private TextBox boxWithFocus;
    private string[] passList = new string[10];

    public mainForm() {
      this.serverSetup = new System.Windows.Forms.ToolStripMenuItem();
      this.serverSetup.Name = "serverSetup";
      this.serverSetup.Size = new System.Drawing.Size(152, 22);
      this.serverSetup.Text = "Server Setup";
      this.serverSetup.Click += new System.EventHandler(OpenServerSetup);
      manualInit();

      InitializeComponent();
    }

    private void generateButton_Click(object sender, EventArgs e) {

      getPassList();
      setPassText();
      textBoxes[0].Focus();

      foreach (TextBox tb in textBoxes) {
        tb.Enabled = true;
      }
    }

    private string buildConnectionString() {
      return  "User Id=" + Program.DB_USER_ID + ";" +
              "password=" + Program.DB_PASSWD + ";" +
              "server=" + Program.DB_SERVER + ";" +
              "database=" + Program.DATABASE + ";" +
              "connection timeout=10";
    }

    private void selectButton_Click(object sender, EventArgs e) {
      Clipboard.SetText(boxWithFocus.Text);
      boxWithFocus.Enabled = false;

      SqlConnection conn = new SqlConnection(buildConnectionString());

      try {
        conn.Open();
        SqlCommand cmd = conn.CreateCommand();
        cmd.CommandType = CommandType.StoredProcedure;
        
        //NEED TO CHANGE STORED PROCEDURE NAME
        cmd.CommandText = "_SendPassword";
        //------------------------------------

        cmd.Parameters.AddWithValue("@usedPasswd", boxWithFocus.Text);
      }

      catch (SqlException ex) {
        Console.WriteLine("SQL EXCEPTION: " + ex.ToString());
        selectButton.Enabled = false;
        label2.ForeColor = System.Drawing.Color.Red;
        label2.Text = "Database Connection Failed!";
      }

      finally {
        conn.Close();
      }
    }

    /// <summary>
    /// This method is specific to textboxes.  It sets the private member variable with the
    /// currently selected textbox and updates the UI label to display the currently selected
    /// textbox.
    /// This really should be abstracted to handle other types of objects or be renamed to 
    /// reflect its specificity.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnGotFocus(object sender, EventArgs e) {
      boxWithFocus = (TextBox)sender;
      selectedPWLabel.Text = boxWithFocus.Text;
    }

    private void OpenServerSetup(object sender, EventArgs e) {
      ServerSettings_form serverSettings = new ServerSettings_form();
      serverSettings.Show();
      Console.WriteLine("SERVER SETTINGS OPEN");
    }

    private void setPassText() {
      for (int x = 0; x < 10; x++) {
        textBoxes[x].Text = passList[x];
      }
    }

    private void mainForm_Load(object sender, EventArgs e) {

    }

    private void getPassList() {
      SqlConnection conn = new SqlConnection(buildConnectionString());

      try {
        conn.Open();
        SqlCommand cmd = conn.CreateCommand();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "_PasswordGenerator";
        SqlDataReader rdr = cmd.ExecuteReader();
        label2.ForeColor = System.Drawing.Color.Green;
        label2.Text = "Connected to Database.";
        int x = 0;

        while (rdr.Read()) {
          passList[x] = rdr[0].ToString().Trim();
          x++;
        }
        rdr.Close();
        if (!selectButton.Enabled) {
          selectButton.Enabled = true;
        }
      }

      catch (SqlException ex) {
        selectButton.Enabled = false;
        label2.ForeColor = System.Drawing.Color.Red;
        label2.Text = "Database Connection Failed!";
        Console.WriteLine(ex.ToString());
      }

      finally {
        conn.Close();
      }
    }
  }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LG_PWGen {
  static class Program {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>

    public static string DB_USER_ID = "pwgen";
    public static string DB_PASSWD = "law-9090MK";
    public static string DB_SERVER = "lgvm-svr04";
    public static string DATABASE = "LGPWGen";

    [STAThread]
    static void Main() {
    
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new mainForm());
    }
  }
}

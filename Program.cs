using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace vizsgamunkaido
{
    static class Program
    {
        public static MySqlCommand sql = null;
        public static MySqlConnection conn = null;
        public static Form form_dolgozo = null;
        public static Form form_dolgozofelvesz = null;
        public static Form form_munkaido = null;
        [STAThread]
        static void Main()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "dolgozokmunkaido";
            conn = new MySqlConnection(sb.ToString());
            try
            {
                conn.Open();
                sql = conn.CreateCommand();
            }
            catch (MySqlException myex)
            {
                Console.WriteLine(myex.Message);
                Console.ReadKey();
                Environment.Exit(0);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form_dolgozo = new Form_Dolgozo();
            form_dolgozofelvesz = new Form_Dolgozofelvesz();
            form_munkaido = new Form_Munkaido();
            Application.Run(form_dolgozo);
        }
    }
}

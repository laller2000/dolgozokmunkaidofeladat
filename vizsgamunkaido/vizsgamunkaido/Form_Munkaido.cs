using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace vizsgamunkaido
{
    public partial class Form_Munkaido : Form
    {
        List<Vizsga_Munkaido> munkaidok = new List<Vizsga_Munkaido>();
        int osszestulora = 0;
        int kifizetendoosszeg = 0;
        public Form_Munkaido()
        {
            InitializeComponent();
        }

        private void Form_Munkaido_Load(object sender, EventArgs e)
        {
            dataGridView1_Munkaido.ColumnCount = 3;
            dataGridView1_Munkaido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1_Munkaido.Columns[0].Name = "mettol";
            dataGridView1_Munkaido.Columns[0].HeaderText = "Mettől";
            dataGridView1_Munkaido.Columns[1].Name = "meddig";
            dataGridView1_Munkaido.Columns[1].HeaderText = "meddig";
            dataGridView1_Munkaido.Columns[2].Name = "tulora";
            dataGridView1_Munkaido.Columns[2].HeaderText = "Túlóra";
            try
            {
                Program.sql.CommandText = "SELECT  `mettol`, `meddig`, `tulora` FROM `vizsga_munkaido` WHERE 1";
                using (MySqlDataReader dr=Program.sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int ujsor_index = dataGridView1_Munkaido.Rows.Add();
                        DataGridViewRow ujsor = dataGridView1_Munkaido.Rows
                            [ujsor_index];
                        ujsor.Cells["mettol"].Value = dr.GetDateTime("mettol");
                        ujsor.Cells["meddig"].Value = dr.GetDateTime("meddig");
                        ujsor.Cells["tulora"].Value = dr.GetInt32("tulora");
                    }
                }
            }
            catch (MySqlException myex)
            {
                MessageBox.Show(myex.Message);
                return;
            }
            MunkaidokFeltoltese();
            for (int i = 0; i < munkaidok.Count; i++)
            {
                osszestulora += munkaidok[i].Tulora;
            }
            for (int j = 0; j < munkaidok.Count; j++)
            {
                kifizetendoosszeg += munkaidok[j].Tulora * 1750;
            }
            textBox1_Osszestul.Text = osszestulora.ToString();
            textBox2_Fizetes.Text = kifizetendoosszeg.ToString();
        }
        private void MunkaidokFeltoltese()
        {
            munkaidok.Clear();
            try
            {
                Program.sql.CommandText = "SELECT `id`, `dolgozoID`, `mettol`, `meddig`, `tulora` FROM `vizsga_munkaido` WHERE 1";
                using (MySqlDataReader dr=Program.sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        munkaidok.Add(new Vizsga_Munkaido(dr.GetInt32("id"),dr.GetInt32("dolgozoID"),dr.GetDateTime("mettol"),dr.GetDateTime("meddig"),dr.GetInt32("tulora")));
                    }
                }
            }
            catch (MySqlException myex)
            {
                MessageBox.Show(myex.Message);
                return;
            }
        }
    }
}

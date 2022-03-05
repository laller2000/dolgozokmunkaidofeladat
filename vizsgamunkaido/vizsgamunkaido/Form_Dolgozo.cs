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
    public partial class Form_Dolgozo : Form
    {
        public Form_Dolgozo()
        {
            InitializeComponent();
        }

        private void Form_Dolgozo_Load(object sender, EventArgs e)
        {
            dataGridView1_Dolgozok.ColumnCount = 5;
            dataGridView1_Dolgozok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1_Dolgozok.Columns[0].Name = "id";
            dataGridView1_Dolgozok.Columns[0].HeaderText = "Azonosító";
            dataGridView1_Dolgozok.Columns[1].Name = "vezeteknev";
            dataGridView1_Dolgozok.Columns[1].HeaderText = "Vezetéknév";
            dataGridView1_Dolgozok.Columns[2].Name = "keresztnev";
            dataGridView1_Dolgozok.Columns[2].HeaderText = "Keresztnév";
            dataGridView1_Dolgozok.Columns[3].Name = "adoszam";
            dataGridView1_Dolgozok.Columns[3].HeaderText = "Adószám";
            dataGridView1_Dolgozok.Columns[4].Name = "anyja_neve";
            dataGridView1_Dolgozok.Columns[4].HeaderText = "Anyja neve";
            try
            {
                Program.sql.CommandText = "SELECT `id`, `vezeteknev`, `keresztnev`, `adoszam`, `anyja_neve` FROM `vizsga_dolgozo` WHERE 1";
                using (MySqlDataReader dr=Program.sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int ujsor_index = dataGridView1_Dolgozok.Rows.Add();
                        DataGridViewRow ujsor = dataGridView1_Dolgozok.Rows
                            [ujsor_index];
                        ujsor.Cells["id"].Value = dr.GetInt32("id");
                        ujsor.Cells["vezeteknev"].Value = dr.GetString("vezeteknev");
                        ujsor.Cells["keresztnev"].Value = dr.GetString("keresztnev");
                        ujsor.Cells["adoszam"].Value = dr.GetString("adoszam");
                        ujsor.Cells["anyja_neve"].Value = dr.GetString("anyja_neve");
                    }
                }
            }
            catch (MySqlException myex)
            {
                MessageBox.Show(myex.Message);
                return;
            }
        }

        private void button1_UJdolgozo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.form_dolgozofelvesz.Show();
        }

        private void button2_Adatokfrissites_Click(object sender, EventArgs e)
        {
            dataGridView1_Dolgozok.ColumnCount = 5;
            dataGridView1_Dolgozok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1_Dolgozok.Columns[0].Name = "id";
            dataGridView1_Dolgozok.Columns[0].HeaderText = "Azonosító";
            dataGridView1_Dolgozok.Columns[1].Name = "vezeteknev";
            dataGridView1_Dolgozok.Columns[1].HeaderText = "Vezetéknév";
            dataGridView1_Dolgozok.Columns[2].Name = "keresztnev";
            dataGridView1_Dolgozok.Columns[2].HeaderText = "Keresztnév";
            dataGridView1_Dolgozok.Columns[3].Name = "adoszam";
            dataGridView1_Dolgozok.Columns[3].HeaderText = "Adószám";
            dataGridView1_Dolgozok.Columns[4].Name = "anyja_neve";
            dataGridView1_Dolgozok.Columns[4].HeaderText = "Anyja neve";
            try
            {
                Program.sql.CommandText = "SELECT `id`, `vezeteknev`, `keresztnev`, `adoszam`, `anyja_neve` FROM `vizsga_dolgozo` WHERE 1";
                using (MySqlDataReader dr = Program.sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int ujsor_index = dataGridView1_Dolgozok.Rows.Add();
                        DataGridViewRow ujsor = dataGridView1_Dolgozok.Rows
                            [ujsor_index];
                        ujsor.Cells["id"].Value = dr.GetInt32("id");
                        ujsor.Cells["vezeteknev"].Value = dr.GetString("vezeteknev");
                        ujsor.Cells["keresztnev"].Value = dr.GetString("keresztnev");
                        ujsor.Cells["adoszam"].Value = dr.GetString("adoszam");
                        ujsor.Cells["anyja_neve"].Value = dr.GetString("anyja_neve");
                    }
                }
            }
            catch (MySqlException myex)
            {
                MessageBox.Show(myex.Message);
                return;
            }
        }

        private void dataGridView1_Dolgozok_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();
            Program.form_munkaido.Show();
        }
    }
}

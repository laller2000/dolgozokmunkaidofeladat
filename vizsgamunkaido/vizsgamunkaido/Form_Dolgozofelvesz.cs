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
    public partial class Form_Dolgozofelvesz : Form
    {
        public Form_Dolgozofelvesz()
        {
            InitializeComponent();
        }

        private void button1_Rogzit_Click(object sender, EventArgs e)
        {
            string vezeteknev=textBox1_Vezeteknev.Text.ToString();
            string keresztnev=textBox2_Keresztnev.Text.ToString();
            string adoszam=textBox3_Adoszam.Text.ToString();
            string anyjaneve=textBox4_Anyjaneve.Text.ToString();

            if (String.IsNullOrEmpty(vezeteknev))
            {
                MessageBox.Show("Nem töltötted ki a vezeteknev mezőt!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(keresztnev))
            {
                MessageBox.Show("Nem töltötted ki a keresztnev mezőt!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(adoszam))
            {
                MessageBox.Show("Nem töltötted ki az adoszam mezőt!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(anyjaneve))
            {
                MessageBox.Show("Nem töltötted ki az anyjaneve mezőt!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                Program.sql.CommandText = "INSERT INTO `vizsga_dolgozo`(`id`, `vezeteknev`, `keresztnev`, `adoszam`, `anyja_neve`) VALUES (NULL,'"+vezeteknev+"','"+keresztnev+"','"+adoszam+"','"+anyjaneve+"')";
                Program.sql.ExecuteNonQuery();
            }
            catch (MySqlException myex)
            {
                MessageBox.Show(myex.Message);
                return;
            }
            MessageBox.Show("A rögzítés sikeres!");
            textBox1_Vezeteknev.Text = "";
            textBox2_Keresztnev.Text = "";
            textBox3_Adoszam.Text = "";
            textBox4_Anyjaneve.Text = "";
            this.Hide();
            Program.form_dolgozo.Show();
        }
    }
}

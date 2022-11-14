using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;

namespace gyumolcsok
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = null;
        MySqlCommand cmd = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "gyumolcsok";
            conn = new MySqlConnection(builder.ConnectionString);
            try
            {
                // terv szerint
                conn.Open();
                cmd = conn.CreateCommand();
            }
            catch (MySqlException ex)
            {
                // váratlan hiba
                MessageBox.Show(ex.Message + Environment.NewLine + "A program leáll!");
                Environment.Exit(0);
                throw;
            }
            finally
            {
                //hiba és terv szerinti esetén is lefut
                conn.Close();
            }
            gyumolcs_update();
            }
        private void gyumolcs_update()
        {
            gyumolcs.Items.Clear();
            cmd.CommandText = "SELECT `id`,`nev`,`egysegar`,`mennyiseg` FROM `gyumolcs` WHERE 1";
            conn.Open();
            using (MySqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    gyumadat uj = new gyumadat(dr.GetInt32("id"), dr.GetString("nev"), dr.GetInt32("egysegar"), dr.GetInt32("mennyiseg"));
                    gyumolcs.Items.Add(uj);
                }
            }
            conn.Close();
        }

        private void adattarol_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(egysegtxt.Text))
            {
                MessageBox.Show("adjon meg egyszégárat");
                egysegtxt.Focus();
                return;
            }
            if (mennyisegnum.Value>1000)
            {
                MessageBox.Show("Érvénytelen évjárat");
                mennyisegnum.Focus();
                return;
            }
            if (string.IsNullOrEmpty(nevtxt.Text))
            {
                MessageBox.Show("Nem adott meg nevet");
                nevtxt.Focus();
                return;
            }
            // Kiirjuk az adatbázisba
            cmd.CommandText = "INSERT INTO `gyumolcs` (`id`, `nev`, `egysegar`, `mennyiseg`) VALUES (NULL, @nev, @mennyiseg, @egysegar)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@nev", nevtxt.Text);
            cmd.Parameters.AddWithValue("@mennyiseg", mennyisegnum.Value.ToString());
            cmd.Parameters.AddWithValue("@egysegar", egysegtxt.Text);
            conn.Open();
            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Sikeresen rögzitettük az adatait");
                    IDtxt.Text = "";
                    nevtxt.Text = "";
                    mennyisegnum.Value = mennyisegnum.Minimum;
                    egysegtxt.Text = "";
                }
                else
                {
                    MessageBox.Show("Sikertelen a rögzités");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            gyumolcs_update();
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;

        public Form1()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=cs_harcosok;Uid=root;Pwd=");
            conn.Open();
            adatbazis_ellenorzes();
        }

        void adatbazis_ellenorzes() {
            var cmd_harcos_tabla = conn.CreateCommand();
            cmd_harcos_tabla.CommandText = @"CREATE TABLE IF NOT EXISTS `harcosok` (
              `id` int(11) NOT NULL AUTO_INCREMENT PRIMARY KEY,
              `nev` varchar(100) UNIQUE,
              `letrehozas` DATE
            )
            ";
            cmd_harcos_tabla.ExecuteNonQuery();

            var cmd_kepesseg_tabla = conn.CreateCommand();
            cmd_kepesseg_tabla.CommandText = @"CREATE TABLE IF NOT EXISTS `kepessegek` (
              `id` int(11) NOT NULL AUTO_INCREMENT PRIMARY KEY,
              `nev` varchar(100),
              `leiras` varchar(100),
              `harcos_id` int(11)
            )
            ";
            cmd_kepesseg_tabla.ExecuteNonQuery();
            hasznaloComboBox.DisplayMember = "Text";
            hasznaloComboBox.ValueMember = "Value";
            harcosokListBox.DisplayMember = "Text";
            harcosokListBox.ValueMember = "Value";
            kepessegekListBox.DisplayMember = "Text";
            kepessegekListBox.ValueMember = "Value";
            frissites();
        }
        void frissites() {
            harcosokListBox.Items.Clear();
            hasznaloComboBox.Items.Clear();
            var command = conn.CreateCommand();
            command.CommandText = @"
                SELECT nev, letrehozas, id
                FROM harcosok
                ";
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string nev = reader.GetString("nev");
                    DateTime letrehozas = reader.GetDateTime("letrehozas");
                    int id = reader.GetInt32("id");

                    string sor = string.Format("{1:yyyy.MM.dd.}: {0}", nev, letrehozas);
                    harcosokListBox.Items.Add(new { Text = sor, Value = id });
                    hasznaloComboBox.Items.Add(new { Text = nev, Value = id });
                }
            }
        }
        private void harcos_letrehozas_Click(object sender, EventArgs e)
        {
            String uj_harcos_nev = harcosNeveTextBox.Text;
            var lekerdezesCommand = conn.CreateCommand();
            lekerdezesCommand.CommandText = @"
                SELECT COUNT(*) FROM harcosok WHERE nev = @nev
            ";
            lekerdezesCommand.Parameters.AddWithValue("@nev", uj_harcos_nev);
            long db = (long)lekerdezesCommand.ExecuteScalar();
            if (db > 0)
            {
                MessageBox.Show("Ilyen harcos már van");
                return;
            }
            var command = conn.CreateCommand();
            command.CommandText = @"INSERT INTO harcosok
                (nev, letrehozas)
                VALUES
                (@nev, CURDATE())
            ";
            command.Parameters.AddWithValue("@nev", uj_harcos_nev);
            command.ExecuteNonQuery();
            frissites();
        }       
        private void kepesseg_letrehozas_Click(object sender, EventArgs e)
        {
            if (hasznaloComboBox.SelectedIndex > -1)
            {
                String kepesseg_nev = kepessegNeveTextBox.Text;
                String kepesseg_leiras = leirasTextBox.Text;
                int harcos_id = (hasznaloComboBox.SelectedItem as dynamic).Value;
                var command = conn.CreateCommand();
                command.CommandText = @"INSERT INTO kepessegek
                (nev, leiras, harcos_id)
                VALUES
                (@nev, @leiras, @harcos_id)
                ";
                command.Parameters.AddWithValue("@nev", kepesseg_nev);
                command.Parameters.AddWithValue("@leiras", kepesseg_leiras);
                command.Parameters.AddWithValue("@harcos_id", harcos_id);
                command.ExecuteNonQuery();
                kepessegNeveTextBox.Clear();
                leirasTextBox.Clear();
                frissites();
            } else
            {
                MessageBox.Show("Muszáj egy harcost kiválasztanod");
            }
        }
        private void harcosokListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            kepessegekListBox.Items.Clear();
            kepessegLeirasaTextBox.Clear();
            System.Reflection.PropertyInfo pi = harcosokListBox.SelectedItem.GetType().GetProperty("Value");
            int id = (int)(pi.GetValue(harcosokListBox.SelectedItem, null));

            var command = conn.CreateCommand();
            command.CommandText = @"
                SELECT nev, harcos_id, id
                FROM kepessegek
                ";
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string nev = reader.GetString("nev");
                    int harcos_id = reader.GetInt32("harcos_id");
                    int kepesseg_id = reader.GetInt32("id");

                    if (id == harcos_id)
                    {
                        kepessegekListBox.Items.Add(new { Text = nev, Value = kepesseg_id });
                    }
                }
            }
        }
        private void kepessegekListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(kepessegekListBox.SelectedItems.Count > 0)) return;
            kepessegLeirasaTextBox.Clear();
            System.Reflection.PropertyInfo pi = kepessegekListBox.SelectedItem.GetType().GetProperty("Value");
            int id = (int)(pi.GetValue(kepessegekListBox.SelectedItem, null));

            var command = conn.CreateCommand();
            command.CommandText = @"
                SELECT leiras, id
                FROM kepessegek
                ";
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string leiras = reader.GetString("leiras");
                    int kepesseg_id = reader.GetInt32("id");

                    if (id == kepesseg_id)
                    {
                        kepessegLeirasaTextBox.Text = leiras;
                    }
                }
            }
        }
        private void torlesButton_Click(object sender, EventArgs e)
        {
            if (kepessegekListBox.SelectedItems.Count > 0)
            {
                kepessegLeirasaTextBox.Clear();
                System.Reflection.PropertyInfo pi = kepessegekListBox.SelectedItem.GetType().GetProperty("Value");
                int id = (int)(pi.GetValue(kepessegekListBox.SelectedItem, null));
                kepessegekListBox.Items.RemoveAt(kepessegekListBox.SelectedIndex); 
                
                var command = conn.CreateCommand();
                command.CommandText = @"DELETE FROM kepessegek WHERE id = @id";
                command.Parameters.AddWithValue("@id", id);
                int sorok = command.ExecuteNonQuery();
                if (sorok == 0)
                {
                    MessageBox.Show("Sikertelen törlés");
                }
            } else
            {
                MessageBox.Show("Nincs kiválasztva képesség");
            }
        }
        private void modositButton_Click(object sender, EventArgs e)
        {
            if (kepessegekListBox.SelectedItems.Count > 0)
            {
                String leiras = kepessegLeirasaTextBox.Text;
                System.Reflection.PropertyInfo pi = kepessegekListBox.SelectedItem.GetType().GetProperty("Value");
                int id = (int)(pi.GetValue(kepessegekListBox.SelectedItem, null));
                var command = conn.CreateCommand();
                command.CommandText = @"
                UPDATE kepessegek
                SET leiras = @leiras
                WHERE id = @id
                ";
                command.Parameters.AddWithValue("@leiras", leiras);
                command.Parameters.AddWithValue("@id", id);
                int sorok = command.ExecuteNonQuery();
                if (sorok == 0)
                {
                    MessageBox.Show("Sikertelen módosítás");
                } else
                {
                    MessageBox.Show("Sikeres módosítás");
                }
            }
            else
            {
                MessageBox.Show("Nincs kiválasztva képesség");
            }
        }
    }
}

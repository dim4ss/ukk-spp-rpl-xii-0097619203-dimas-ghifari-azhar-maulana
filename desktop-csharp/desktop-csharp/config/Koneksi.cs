using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace desktop_csharp.config
{
    internal class Koneksi
    {
        private static string connectionString = "server=localhost;port=3306;database=db_spp_sekolah_xii;user=root;password=;";

        public static MySqlConnection GetConnection()
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                return conn;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Gagal terhubung ke database! Pastikan server MySQL (XAMPP) sudah aktif.\n\nDetail Error: " + ex.Message,
                                "Error Koneksi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}

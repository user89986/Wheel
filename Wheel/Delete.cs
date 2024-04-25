using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace Wheel
{
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        public object Middlename { get; private set; }
        public object Surname { get; private set; }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string BDPath = @"DataBase.db";
            using (var connection = new SqliteConnection($"Data Source = {BDPath}"))
            {
                connection.Open();
                string sql = $"SELECT COUNT(*) FROM DataBase WHERE Name = ('{Name1.Text}') AND Surname = ('{Surname1.Text}') AND Middlename = ('{Middlename1.Text}');";
                using (var command = new SqliteCommand(sql, connection))
                {

                    command.Parameters.AddWithValue($"('{Name1.Text}')", Name);
                    command.Parameters.AddWithValue($"('{Surname1.Text}')", Surname);
                    command.Parameters.AddWithValue($"('{Middlename1.Text}')",Middlename);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)
                    {
                        string sqlDelete = $"DELETE FROM DataBase WHERE  Name = ('{Name1.Text}') AND Surname = ('{Surname1.Text}') AND Middlename = ('{Middlename1.Text}')";
                        using (var commandDelete = new SqliteCommand(sqlDelete, connection))
                        {

                            int rowsAffected = commandDelete.ExecuteNonQuery();
                            command.Parameters.AddWithValue($"('{Name1.Text}')", Name);
                            command.Parameters.AddWithValue($"('{Surname1.Text}')", Surname);
                            command.Parameters.AddWithValue($"('{Middlename1.Text}')", Middlename);


                        }
                        MessageBox.Show("Удалено");
                    }

                
                    else
                    {
                        
                        MessageBox.Show("Не найдено");
                    }

                }

            }
        }

  
    }
}

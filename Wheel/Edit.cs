using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Wheel
{
    public partial class Edit : Form
    {
        public object NumberPhone { get; private set; }

        public Edit()
        {
            InitializeComponent();
        }

        private void Registration_Click(object sender, EventArgs e)
        {
            string BDPath = @"DataBase.db";
            using (var connection = new SqliteConnection($"Data Source = {BDPath}"))
            {
                connection.Open();
                string sql = $"SELECT COUNT(*) FROM DataBase WHERE NumberPhone = ('{User.Text}') AND Password = ('{Password.Text}')";
                using (var command = new SqliteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue($"('{User.Text}')", "849033453490");
                    command.Parameters.AddWithValue($"('{Password.Text}')", "@dm1n_0Progm.");

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)
                    {
                        // Успешный вход
                        Registration registration = new Registration();
                        registration.Show();
                        
                    }
                    else
                    {
                        // Ошибка входа
                        MessageBox.Show("Неверное имя пользователя или пароль.");
                    }

                }

            }
        }

        private void Delte_Click(object sender, EventArgs e)
        {
            string BDPath = @"DataBase.db";
            using (var connection = new SqliteConnection($"Data Source = {BDPath}"))
            {
                connection.Open();
                string sql = $"SELECT COUNT(*) FROM DataBase WHERE NumberPhone = ('{User.Text}') AND Password = ('{Password.Text}')";
                using (var command = new SqliteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue($"('{User.Text}')", "849033453490");
                    command.Parameters.AddWithValue($"('{Password.Text}')", "@dm1n_0Progm.");

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)
                    {
                        // Успешный вход
                        Delete form1 = new Delete();
                        form1.Show();


                    }
                    else
                    {
                        // Ошибка входа
                        MessageBox.Show("Неверное имя пользователя или пароль.");
                    }

                }

            }


        }

        private void User_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }

}
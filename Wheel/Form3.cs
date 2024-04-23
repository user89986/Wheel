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
    public partial class Form3 : Form
    {
        public object NumberPhone { get; private set; }

        public Form3()
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
                    command.Parameters.AddWithValue($"('{User.Text}')", NumberPhone);
                    command.Parameters.AddWithValue($"('{Password.Text}')", Password);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)
                    {
                        // Успешный вход
                        Form2 form2 = new Form2();
                        form2.Show();
                        this.Hide();
                        string sqlDelete = $"DELETE FROM DataBase WHERE NumberPhone = ('{User.Text}') AND Password = ('{Password.Text}')";
                        using (var commandDelete = new SqliteCommand(sqlDelete, connection))
                        {
                            commandDelete.Parameters.AddWithValue($"('{User.Text}')", NumberPhone);
                            commandDelete.Parameters.AddWithValue($"('{Password.Text}')", Password);
                            int rowsAffected = commandDelete.ExecuteNonQuery();
                        }
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
                string sqlCheck = $"SELECT COUNT(*) FROM DataBase WHERE NumberPhone = ('{User.Text}') AND Password = ('{Password.Text}')";
                using ( var commandCheck = new SqliteCommand( sqlCheck, connection))
                {
                    commandCheck.Parameters.AddWithValue($"('{User.Text}')", NumberPhone);
                    commandCheck.Parameters.AddWithValue($"('{Password.Text}')", Password);

                    int count = Convert.ToInt32(commandCheck.ExecuteScalar());

                    if (count > 0)
                    {
                        string sqlDelete = $"DELETE FROM DataBase WHERE NumberPhone = ('{User.Text}') AND Password = ('{Password.Text}')";
                        using (var commandDelete =  new SqliteCommand( sqlDelete, connection))
                        {
                            commandDelete.Parameters.AddWithValue($"('{User.Text}')", NumberPhone);
                            commandDelete.Parameters.AddWithValue($"('{Password.Text}')", Password);
                            int rowsAffected = commandDelete.ExecuteNonQuery();
                        }
                        MessageBox.Show("Удалено");
                    }
                    else
                    {
                        MessageBox.Show("Ошибка");
                    }
                }


            }

        }


    }

}
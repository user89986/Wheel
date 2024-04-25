using Microsoft.Data.Sqlite;
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

namespace Wheel
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                string BDPath = @"DataBase.db";
                using (var connection = new SqliteConnection($"Data Source = {BDPath}"))
                {
                    connection.Open();

                    if (Status.Checked)
                    {
                        Status.Text = "Готово";
                    }
                    else
                    {
                        Status.Text = "Не готово";
                    }
                    if (Name.Text == "" && Surname.Text == "" && Middlename.Text == "" && Number.Text == "" && Region.Text == "" && Breakage.Text == "" && Price.Text == "" && Status.Text == "" && Password.Text == ""&& Car.Text =="" && NumberPhone.Text =="")
                    {
                        MessageBox.Show("Введите данные!");
                    }
                    else if (Password.Text == Password.Text)
                    {
                        string sqlCheck = $"SELECT COUNT(*) FROM DataBase WHERE NumberPhone = ('{NumberPhone.Text}')";
                        using (var commandCheck = new SqliteCommand(sqlCheck, connection))
                        {

                            commandCheck.Parameters.AddWithValue($"'{NumberPhone.Text}'", NumberPhone);

                            int count = Convert.ToInt32(commandCheck.ExecuteScalar());

                            if (count > 0)
                            {
                                MessageBox.Show("Данный номер зарегестрирован!");

                                // Очистить поле ввода пароля (необязательно)
                                // txtPassword.Clear();
                            }
                            else
                            {
                                string sql = $"INSERT INTO DataBase ('Name', 'Surname', 'Middlename', 'Number', 'Region', 'Breakage', 'Price', 'Status','Password', 'Car','NumberPhone') VALUES ('{Name.Text}','{Surname.Text}','{Middlename.Text}','{Number.Text}','{Region.Text}','{Breakage.Text}','{Price.Text}','{Status.Text}','{Password.Text}','{Car.Text}','{NumberPhone.Text}')";
                                SqliteCommand command = new SqliteCommand(sql, connection);
                                command.ExecuteNonQuery();
                                MessageBox.Show("Вы успешно зарегистрировались!");

                            }

                        }
                    }

                }




            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
            }

        }

        private void NumberPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

        }
        private void Price_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}

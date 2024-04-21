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
    public partial class Form2 : Form
    {
        public Form2()
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
                    if (Name.Text == "" && Surname.Text == "" && Middlename.Text == "" && Number.Text == "" && Region.Text == "" && Breakage.Text == "" && Price.Text == "" && Status.Text == "" && Password.Text == ""&& Car.Text =="" && NumberPhone.Text =="")
                    {
                        MessageBox.Show("Ошибка");
                    }
                    else if (Password.Text == Password.Text)
                    {
                        string sqlCheck = $"SELECT COUNT(*) FROM DataBase WHERE Password = ('{Password.Text}')";
                        using (var commandCheck = new SqliteCommand(sqlCheck, connection))
                        {

                            commandCheck.Parameters.AddWithValue($"'{Password.Text}'", Password);

                            int count = Convert.ToInt32(commandCheck.ExecuteScalar());

                            if (count > 0)
                            {
                                MessageBox.Show("Такой пароль уже существует. Пожалуйста, введите другой пароль.");

                                // Очистить поле ввода пароля (необязательно)
                                // txtPassword.Clear();
                            }
                            else
                            {
                                string sql = $"INSERT INTO DataBase ('Name', 'Surname', 'Middlename', 'Number', 'Region', 'Breakage', 'Price', 'Status','Password', 'Car','NumberPhone') VALUES ('{Name.Text}','{Surname.Text}','{Middlename.Text}','{Number.Text}','{Region.Text}','{Breakage.Text}','{Price.Text}','{Status.Text}','{Password.Text}','{Car.Text}','{NumberPhone.Text}')";
                                SqliteCommand command = new SqliteCommand(sql, connection);
                                command.ExecuteNonQuery();
                                MessageBox.Show("Данные введены");

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


    }
}

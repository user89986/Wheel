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
using System.Xml.Linq;

namespace Wheel
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string BDPath = @"DataBase.db";
            using (var connection = new SqliteConnection($"Data Source = {BDPath}"))
            {
                connection.Open();
                string sqlSearch = $"SELECT * FROM DataBase WHERE Name = ('{Name.Text}') AND Surname = ('{Surname.Text}') AND Middlename = ('{Middlename.Text}')";
                using (var commandSearch = new SqliteCommand(sqlSearch, connection))
                {
                    commandSearch.Parameters.AddWithValue($"('{Name.Text}')", Name);
                    commandSearch.Parameters.AddWithValue($"('{Surname.Text}')", Surname);
                    commandSearch.Parameters.AddWithValue($"('{Middlename.Text}')", Middlename);
                    using (var reader = commandSearch.ExecuteReader())
                    {
                        StringBuilder resultsText = new StringBuilder();
                        // Вывод результатов
                        while (reader.Read())
                        {
                            resultsText.Append($"Данные: {reader["Name"]}, {reader["Surname"]}, {reader["Middlename"]},{reader["NumberPhone"]},{reader["Number"]},{reader["Region"]},{reader["Car"]},{reader["Breakage"]},{reader["Price"]},{reader["Status"]}\n");
                        }
                        MessageBox.Show(resultsText.ToString(), "Результаты поиска");

                    }
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string BDPath = @"DataBase.db";
            using (var connection = new SqliteConnection($"Data Source = {BDPath}"))
            {
                connection.Open();
                string sqlSearch = $"SELECT * FROM DataBase WHERE Number = ('{Number.Text}')";
                using (var commandSearch = new SqliteCommand(sqlSearch, connection))
                {
                    commandSearch.Parameters.AddWithValue($"('{Number.Text}')", Number);
                    using (var reader = commandSearch.ExecuteReader())
                    {
                        StringBuilder resultsText = new StringBuilder();
                        // Вывод результатов
                        while (reader.Read())
                        {
                            resultsText.Append($"Данные: {reader["Name"]}, {reader["Surname"]}, {reader["Middlename"]},{reader["NumberPhone"]},{reader["Number"]},{reader["Region"]},{reader["Car"]},{reader["Breakage"]},{reader["Price"]},{reader["Status"]}\n");
                        }
                        MessageBox.Show(resultsText.ToString(), "Результаты поиска");

                    }
                }
            }

        }

    }
}







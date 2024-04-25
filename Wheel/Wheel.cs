using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using Randomsss;

namespace Wheel
{
    public partial class Wheel : Form
    {
      
        public Wheel()
        {
            InitializeComponent();
            Connect();
        }
        public void Connect()
        {
            string BDPath = @"DataBase.db";
            using (var connection = new SqliteConnection($"Data Source = {BDPath}"))
            {
                connection.Open();
                

            }
            
        }

        private void ImputData_Click(object sender, EventArgs e)
        {
            Registration form2 = new Registration();
            form2.Show();
        }

        private void Editing_Click(object sender, EventArgs e)
        {
            Edit form3 = new Edit();
            form3.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Edit form3 = new Edit();
            form3.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Search form4 = new Search();
            form4.Show();
        }

 
    }
}

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

namespace Wheel
{
    public partial class Form1 : Form
    {
        public Form1()
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
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void Editing_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

    }
}

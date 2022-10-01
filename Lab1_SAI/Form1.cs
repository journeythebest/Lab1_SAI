using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Lab1_SAI
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();   
        }
        public static readonly string connectionStr = "Host=localhost;Username=postgres;Password=q123werty;Database=BDLab1";
        NpgsqlConnection conn = new NpgsqlConnection(connectionStr);
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        FormRoles fRoles;
        private void button1_Click(object sender, EventArgs e)
        { 
            fRoles = new FormRoles();
            fRoles.Show();
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
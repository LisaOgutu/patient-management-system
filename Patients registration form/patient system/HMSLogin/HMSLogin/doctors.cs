using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace HMSLogin
{
    public partial class Doctors : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ogutu\OneDrive\Documents\Logindb.mdf;Integrated Security=True;Connect Timeout=30");
        public Doctors()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void doctors_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (docid.Text == "" || docname.Text == "" || docpasswcd.Text == "")
            {
                MessageBox.Show("No Empty Fields Accepted");
            }
            else
            {
                Con.Open();
                string query = "INSERT INTO  Doctbl values (" + docid.Text + ",'" + docname.Text + "','" +docpasswcd.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Login Successful");
                Con.Close();
            }
        }
    }
}

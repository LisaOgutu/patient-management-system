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
    public partial class Contactus : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ogutu\OneDrive\Documents\Logindb.mdf;Integrated Security=True;Connect Timeout=30");
        public Contactus()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Fname.Text == "" || Patemail.Text == "" || Phoneno.Text == "" || Emergency.Text == "")
            {
                MessageBox.Show("No Empty Fields Accepted");
            }
            else
            {
                Con.Open();
                string query = "INSERT INTO  Contacttbl values ('" + Fname.Text + "','" + Patemail.Text + "','" + Phoneno.Text + "','" + Emergency.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Emergency submitted");
                Con.Close();
            }
        }
    }
}

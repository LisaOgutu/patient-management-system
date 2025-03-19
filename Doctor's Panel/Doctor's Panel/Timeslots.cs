using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doctor_s_Panel
{
    public partial class Timeslots: Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\G\OneDrive\Documents\patientdb.mdf;Integrated Security=True;Connect Timeout=30");

        public Timeslots()
        {
            InitializeComponent();
        }

        void populate()
        {
            con.Open();
            string query = "select * from TimeSlots";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            TimeslotsGV.DataSource = ds.Tables[0];
            con.Close();
        }

        string availability;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 dp = new Form1();
            dp.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "update TimeSlots set time = '" + time.Text + "', availability = '" + availability + "' where date = '" + date.Value + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("TimeSlot Updated Successfully");
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (time.Text == "" || availability == "")
            {
                MessageBox.Show("No Empty Fields Allowed");
            }
            else
            {
                con.Open();
                string query = "INSERT INTO TimeSlots values ('" + date.Value + "','" + time.Text + "','" + availability + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("TimeSlot Configured Successfully");
                con.Close();
            }
        }

        private void available_CheckedChanged(object sender, EventArgs e)
        {
            availability = "available";
        }

        private void unavailable_CheckedChanged(object sender, EventArgs e)
        {
            availability = "unavailable";
        }

        private void Timeslots_Load(object sender, EventArgs e)
        {
            populate();
        }
    }
}

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
    public partial class Surgeries : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\G\OneDrive\Documents\patientdb.mdf;Integrated Security=True;Connect Timeout=30");

        public Surgeries()
        {
            InitializeComponent();
        }

        void populate()
        {
            con.Open();
            string query = "select * from Surgeries";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            SurgeriesGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Surgeries_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 dp = new Form1();
            dp.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ptid.Text == "" || purpose.Text == "" || method.Text == "" || specialty.Text == "" || urgency.Text == "" || theatre.Text == "" || details.Text == "")
            {
                MessageBox.Show("No Empty Fields Allowed");
            }
            else
            {
                con.Open();
                string query = "INSERT INTO Surgeries values (" + ptid.Text + ",'" + purpose.Text + "','" + method.Text + "','" + specialty.Text + "','" + urgency.Text + "','" + theatre.Text + "','" + date.Value + "','" + details.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Surgery Record Added Successfully");
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "update Surgeries set purpose = '" + purpose.Text + "', method = '" + method.Text + "', specialty = '" + specialty.Text + "', urgency = '" + urgency.Text + "', theatre = '" + theatre.Text + "', date = '" + date.Value + "', details = '" + details.Text + "' where ptid= " + ptid.Text + "";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Surgery Record Updated Successfully");
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ptid.Text == "")
            {
                MessageBox.Show("No Empty Fields Allowed");
            }
            else
            {
                con.Open();
                string query = "delete from Surgeries where ptid=" + ptid.Text + "";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Surgery Record Deleted Successfully");
                con.Close();
            }
        }
    }
}
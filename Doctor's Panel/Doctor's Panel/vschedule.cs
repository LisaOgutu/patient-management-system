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
    public partial class vschedule: Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\G\OneDrive\Documents\patientdb.mdf;Integrated Security=True;Connect Timeout=30");

        public vschedule()
        {
            InitializeComponent();
        }

        void populate()
        {
            con.Open();
            string query = "select * from Schedule";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ScheduleGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
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
            if (pa_id.Text == "" || clinic.Text == "")
            {
                MessageBox.Show("No Empty Fields Allowed");
            }
            else
            {
                con.Open();
                string query = "INSERT INTO Schedule values (" + pa_id.Text + ",'" + clinic.Text + "','" + dates.Value + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Added Successfully");
                con.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pa_id.Text == "")
            {
                MessageBox.Show("No Empty Fields Allowed");
            }
            else
            {
                con.Open();
                string query = "delete from Schedule where pa_id=" + pa_id.Text + "";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted Successfully");
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "update Schedule set clinic = '" + clinic.Text + "', dates = '" + dates.Value + "' where pa_id= " + pa_id.Text + "";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Updated Successfully");
            con.Close();
        }

        private void vschedule_Load(object sender, EventArgs e)
        {
            populate();
        }
    }
}

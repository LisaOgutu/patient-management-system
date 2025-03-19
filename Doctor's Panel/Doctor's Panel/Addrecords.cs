using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Doctor_s_Panel
{
    public partial class Addrecords: Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\G\OneDrive\Documents\patientdb.mdf;Integrated Security=True;Connect Timeout=30");
        public Addrecords()
        {
            InitializeComponent();
        }
/*
        void populate()
        {
            con.Open();
            string query = "select * from Records";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            RecordsGV.DataSource = ds.Tables[0];
            con.Close();
        }
*/
        private void button4_Click(object sender, EventArgs e)
        {
            Form1 dp = new Form1();
            dp.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (pid.Text == "" || pname.Text == "" || allergies.Text == "" || history.Text == "" || past.Text == "" || present.Text == "" || medicine.Text == "" || summ.Text == "")
            {
                MessageBox.Show("No Empty Fields Allowed");
            }
            else
            {
                con.Open();
                string query = "INSERT INTO Records values (" + pid.Text + ",'" + pname.Text + "','" + allergies.Text + "','" + history.Text + "','" + past.Text + "','" + present.Text + "','" + medicine.Text + "','" + summ.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient Record Added Successfully");
                con.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (pid.Text == "")
            {
                MessageBox.Show("No Empty Fields Allowed");
            }
            else
            {
                con.Open();
                string query = "delete from Records where pid="+pid.Text+"";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient Record Deleted Successfully");
                con.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "update Records set pname = '"+pname.Text+"', allergies = '"+allergies.Text+"', history = '"+history.Text+"', past = '"+past.Text+"', present = '"+present.Text+"', medicine = '"+medicine.Text+"', summ = '"+summ.Text+"' where pid= "+ pid.Text +"";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Patient Record Updated Successfully");
            con.Close();
        }
    }
}

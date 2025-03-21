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
using System.Diagnostics.Eventing.Reader;

namespace Patients_registration_form
{
    public partial class Form1: Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ADMIN\OneDrive\Documents\Hospitaldb.mdf;Integrated Security=True;Connect Timeout=30");
        public Form1()
        {
            InitializeComponent();
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PatId.Text == "" || PatName.Text == "" || PatDob.Text == "" || PatEmail.Text == "" || PatPhone.Text == "" || PatAddress.Text == "" || PatAge.Text == "" || PatHistory.Text == "" || PatGender.Text == "" || PatContact.Text == "" || PatBloodGrp.Text == "" || PatPhysician.Text == "") 
            MessageBox.Show("No Empty Fill Accepted");
            else
            {
                Con.Open();
                string query = "INSERT INTO RegistrationFormTable values(" + PatId.Text + ",'" + PatName.Text + "'," + PatDob.Text + ",'" + PatEmail.Text + "'," + PatPhone.Text + ",'" + PatAddress.Text + "'," + PatAge.Text + ",'" + PatHistory.Text + "','" + PatGender.Text + "'," + PatContact.Text + ",'" + PatBloodGrp.Text + "','" + PatPhysician.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient Successfully Added");
                Con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "update RegistrationFormTable set PatName='" + PatName.Text + "',PatDob=" + PatDob.Text + ",PatEmail='" + PatEmail.Text + "',PatPhone=" + PatPhone.Text + ",PatAddress='" + PatAddress.Text + "',PatAge=" + PatAge.Text + ",PatHistory='" + PatHistory.Text + "',PatGender='" + PatGender.Text + "',PatContact=" + PatContact.Text + ",PatBloodGrp='" + PatBloodGrp.Text + "',PatPhysician='" + PatPhysician.Text + "'where PatId=" + PatId.Text + "";        
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Patient Successfully updated");
            Con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 h = new Form1();
            h.Show();
            this.Hide();
        }

        private void PatBloodGrp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

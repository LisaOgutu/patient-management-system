using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doctor_s_Panel
{
    public partial class vrecords: Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\G\OneDrive\Documents\patientdb.mdf;Integrated Security=True;Connect Timeout=30");

        public vrecords()
        {
            InitializeComponent();
        }

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
        private void button4_Click(object sender, EventArgs e)
        {
            Form1 dp = new Form1();
            dp.Show();
            this.Hide();
        }

        private void vrecords_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void RecordsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

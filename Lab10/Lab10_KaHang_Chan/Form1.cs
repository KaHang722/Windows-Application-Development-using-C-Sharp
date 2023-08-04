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

namespace Lab10_KaHang_Chan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            string constr;
            //
            constr = @"Data Source=DESKTOP-J8N4H7L;Initial Catalog=MMABooks;Integrated Security=True";
            //
            conn = new SqlConnection(constr);

            // to open the connection
            conn.Open();

            MessageBox.Show("Connection Open!");

            // to close the connection
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            string constr = @"Data Source=DESKTOP-J8N4H7L;Initial Catalog=MMABooks;Integrated Security=True";
            SqlCommand cmd;
            string sql;
            sql = "Select * from States";
            conn = new SqlConnection(constr);
            cmd = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                listBox1.Items.Add(reader["StateCode"].ToString() + " " + reader["StateName"].ToString());
            }
            reader.Close();
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string st_name, st_code;

            st_name = textBox1.Text;
            st_code = textBox2.Text;
            SqlConnection conn;
            string constr = @"Data Source=DESKTOP-J8N4H7L;Initial Catalog=MMABooks;Integrated Security=True";
            SqlCommand cmd;
            SqlDataAdapter adap = new SqlDataAdapter();

            string sql;

            conn = new SqlConnection(constr);

            conn.Open();
            sql = "insert into States values('" + st_code + "', '" + st_name + "')";
            cmd = new SqlCommand(sql, conn);
            adap.InsertCommand = new SqlCommand(sql, conn);
            adap.InsertCommand.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string st_name, st_code;

            st_name = textBox1.Text;
            st_code = textBox2.Text;
            SqlConnection conn;
            string constr = @"Data Source=DESKTOP-J8N4H7L;Initial Catalog=MMABooks;Integrated Security=True";
            SqlCommand cmd;
            SqlDataAdapter adap = new SqlDataAdapter();

            string sql;

            conn = new SqlConnection(constr);

            conn.Open();
            sql = "Update States SET StateName = '" + st_name + "' Where StateCode = '" + st_code+ "' ";
            cmd = new SqlCommand(sql, conn);
            adap.InsertCommand = new SqlCommand(sql, conn);
            adap.InsertCommand.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            listBox1.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string st_name, st_code;

            st_name = textBox1.Text;
            st_code = textBox2.Text;
            SqlConnection conn;
            string constr = @"Data Source=DESKTOP-J8N4H7L;Initial Catalog=MMABooks;Integrated Security=True";
            SqlCommand cmd;
            SqlDataAdapter adap = new SqlDataAdapter();

            string sql;

            conn = new SqlConnection(constr);

            conn.Open();
            sql = "Delete From States Where StateCode = '" + st_code + "' ";
            cmd = new SqlCommand(sql, conn);
            adap.InsertCommand = new SqlCommand(sql, conn);
            adap.InsertCommand.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            listBox1.Items.Clear();
        }
    }
}

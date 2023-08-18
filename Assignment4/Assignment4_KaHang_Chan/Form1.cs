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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment4_KaHang_Chan
{
    public partial class frmProductMaintenance : Form
    {

        public frmProductMaintenance()
        {
            InitializeComponent();
        }

        private void btnGetProduct_Click(object sender, EventArgs e)
        {
            try
            {
                string p_code;

                p_code = txtProductCode.Text;
                SqlConnection conn;
                string constr = @"Data Source=DESKTOP-J8N4H7L;Initial Catalog=MMABooks;Integrated Security=True";
                SqlCommand cmd;
                SqlDataAdapter adap = new SqlDataAdapter();

                string sql;
                conn = new SqlConnection(constr);
                conn.Open();
                sql = "Select * from Products Where ProductCode = '" + p_code + "'";

                cmd = new SqlCommand(sql, conn);
                adap.SelectCommand = new SqlCommand(sql, conn);
                adap.SelectCommand.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    txtDescription.Text = reader["Description"].ToString();
                    txtUnitPrice.Text = reader["UnitPrice"].ToString();
                    txtOnHand.Text = reader["OnHandQuantity"].ToString();

                }
                cmd.Dispose();
                reader.Close();
                conn.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.txtClear();
            frmDataInput form2 = new frmDataInput();
            form2.ShowDialog();
            if(form2.btnAccept.DialogResult == DialogResult.OK)
            {
                try
                {
                    string p_code, description;
                    decimal unit_price;
                    int on_hand;

                    p_code = form2.ProductCode;
                    description = form2.Description;
                    unit_price = form2.UnitPrice;
                    on_hand = form2.OnHandQuantity;

                    SqlConnection conn;
                    string constr = @"Data Source=DESKTOP-J8N4H7L;Initial Catalog=MMABooks;Integrated Security=True";
                    SqlCommand cmd;
                    SqlDataAdapter adap = new SqlDataAdapter();

                    string sql;

                    conn = new SqlConnection(constr);

                    conn.Open();
                    sql = "insert into Products values('" + p_code + "', '" + description + "', '" + unit_price + "','" + on_hand + "')";
                    cmd = new SqlCommand(sql, conn);
                    adap.InsertCommand = new SqlCommand(sql, conn);
                    adap.InsertCommand.ExecuteNonQuery();
                    MessageBox.Show("Added");
                    cmd.Dispose();
                    conn.Close();
                }
                catch(SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            this.txtClear();
            frmDataInput form2 = new frmDataInput();
            form2.ShowDialog();
            if (form2.btnAccept.DialogResult == DialogResult.OK)
            {
                try
                {
                    string p_code, description;
                    decimal unit_price;
                    int on_hand;

                    p_code = form2.ProductCode;
                    description = form2.Description;
                    unit_price = form2.UnitPrice;
                    on_hand = form2.OnHandQuantity;
                    SqlConnection conn;
                    string constr = @"Data Source=DESKTOP-J8N4H7L;Initial Catalog=MMABooks;Integrated Security=True";
                    SqlCommand cmd;
                    SqlDataAdapter adap = new SqlDataAdapter();

                    string sql;

                    conn = new SqlConnection(constr);

                    conn.Open();
                    sql = "Update Products SET Description = '" + description + "', UnitPrice = '" + unit_price + "', OnHandQuantity = '" + on_hand + "' Where ProductCode = '" + p_code + "' ";
                    cmd = new SqlCommand(sql, conn);
                    adap.UpdateCommand = new SqlCommand(sql, conn);
                    adap.UpdateCommand.ExecuteNonQuery();
                    MessageBox.Show("Updated");
                    cmd.Dispose();
                    conn.Close();
                }
                catch(SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                string p_code;
                p_code = txtProductCode.Text;
                SqlConnection conn;
                string constr = @"Data Source=DESKTOP-J8N4H7L;Initial Catalog=MMABooks;Integrated Security=True";
                SqlCommand cmd;
                SqlDataAdapter adap = new SqlDataAdapter();

                string sql;


                if(txtProductCode.Text != "")
                {
                    var confirmResult = MessageBox.Show("Delete " + txtProductCode.Text + " ?",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        conn = new SqlConnection(constr);

                        conn.Open();
                        sql = "Delete From Products Where ProductCode = '" + p_code + "' ";
                        cmd = new SqlCommand(sql, conn);
                        adap.DeleteCommand = new SqlCommand(sql, conn);
                        adap.DeleteCommand.ExecuteNonQuery();
                        MessageBox.Show("Deleted");
                        cmd.Dispose();
                        conn.Close();
                    }
                }
            }
            catch (SqlException ex)
            { 
                MessageBox.Show(ex.Message);
            }
            this.txtClear();
        }
    

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtClear()
        {
            
            txtProductCode.Clear();
            
        }

        private void txtProductCode_TextChanged(object sender, EventArgs e)
        {
            txtDescription.Clear();
            txtOnHand.Clear();
            txtUnitPrice.Clear();
        }
    }
}

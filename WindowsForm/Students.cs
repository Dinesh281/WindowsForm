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
using System.Configuration;

namespace WindowsForm
{
    public partial class Students : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader dr;
        public Students()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStdRollNo.Clear();
            txtStdName.Clear();
            txtStream.Clear();
            txtPercentage.Clear();
            txtGender.Clear();
            txtAge.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "Insert into tblStudent values (@name,@stream,@percentage,@age,@gender)";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@name", txtStdName.Text);
                cmd.Parameters.AddWithValue("@stream", txtStream.Text);
                cmd.Parameters.AddWithValue("@gender", txtGender.Text);
                cmd.Parameters.AddWithValue("@percentage", Convert.ToDouble(txtPercentage.Text));
                cmd.Parameters.AddWithValue("@age", Convert.ToInt32(txtAge.Text));
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Record Inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "Update  tblStudent set stdname=@name,stream=@stream,percentage=@percentage,age=@age,gender=@gender where rollno=@rollno";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@name", txtStdName.Text);
                cmd.Parameters.AddWithValue("@stream", txtStream.Text);
                cmd.Parameters.AddWithValue("@gender", txtGender.Text);
                cmd.Parameters.AddWithValue("@percentage", Convert.ToDouble(txtPercentage.Text));
                cmd.Parameters.AddWithValue("@age", Convert.ToInt32(txtAge.Text));
                cmd.Parameters.AddWithValue("@rollno", Convert.ToInt32(txtStdRollNo.Text));
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Record Updated");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "delete from tblStudent where rollno=@rollno";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@rollno", Convert.ToInt32(txtStdRollNo.Text));
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Record Deleted");
                }
                else
                {
                    MessageBox.Show("Record not Found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select * from tblStudent where rollno=@rollno";
                cmd = new SqlCommand(qry, con);

                cmd.Parameters.AddWithValue("@rollno", Convert.ToInt32(txtStdRollNo.Text));
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        txtStdName.Text = dr["stdname"].ToString();
                        txtStream.Text = dr["stream"].ToString();
                        txtPercentage.Text = dr["percentage"].ToString();
                        txtAge.Text = dr["age"].ToString();
                        txtGender.Text = dr["gender"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Records not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select * from tblStudent ";
                cmd = new SqlCommand(qry, con);

                
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {


                    DataTable table = new DataTable();
                    table.Load(dr);
                    dataGridView1.DataSource = table;

                }
                else
                {
                    MessageBox.Show("Records not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}

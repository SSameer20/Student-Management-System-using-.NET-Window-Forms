using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class Form1 : Form
    {
        int selectedRowId = 0;
        SqlConnection con = new SqlConnection(@"Data Source=ZENX\SQLEXPRESS04;Initial Catalog=EmployeeDB;Integrated Security=true;");
        SqlCommand cmd;

        public Form1()
        {
            InitializeComponent();
            fillGrid();
            validateForm();
            fillGender();

        }


        private void fillGrid()
        {
            cmd = new SqlCommand("select * from Employee order by id DESC", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGV.DataSource = dt;
            con.Close();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            cmd = new SqlCommand("sp_addUpdateData", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@Id",)
            cmd.Parameters.AddWithValue("@firstName", txtFirstName.Text);
            cmd.Parameters.AddWithValue("@secondName", txtSecondName.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@mobile", txtNumber.Text);
            cmd.Parameters.AddWithValue("@eid", txtEid.Text);
            cmd.Parameters.AddWithValue("@dob", txtDate.Value);
            cmd.Parameters.AddWithValue("@gender", ddlGender.SelectedValue);
            cmd.Parameters.AddWithValue("@address", txtAddress.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Details Updated Successfully ", "Record Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();

        }

        private void clear()
        {
            txtFirstName.Clear();
            txtSecondName.Clear();
            txtEmail.Clear();
            txtNumber.Clear();
            txtEid.Clear();
            txtDate.MinDate = new DateTime(1950, 1, 1);
            txtDate.Value = txtDate.MinDate;
            ddlGender.SelectedIndex = -1;
            txtAddress.Clear();
            validateForm();
        }
        private void dataGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGV.Rows[e.RowIndex];
            selectedRowId = Convert.ToInt32(row.Cells[0].Value);
            txtFirstName.Text = row.Cells[1].Value.ToString();
            txtSecondName.Text = row.Cells[2].Value.ToString();
            txtEmail.Text = row.Cells[3].Value.ToString();
            txtNumber.Text = row.Cells[4].Value.ToString();
            txtEid.Text = row.Cells[5].Value.ToString();
            txtDate.Value = (DateTime)row.Cells[6].Value;
            ddlGender.SelectedValue = row.Cells[7].Value;
            txtAddress.Text = row.Cells[8].Value.ToString();

        }

        private void validateForm()
        {
         if(!string.IsNullOrEmpty(txtFirstName.Text) && !string.IsNullOrEmpty(txtEmail.Text) && !string.IsNullOrEmpty(txtEid.Text) 
                && !string.IsNullOrEmpty(txtNumber.Text))
            {
                if(selectedRowId > 0)
                {
                   
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnSave.Enabled = false;
                }
                else
                {
                    btnSave.Enabled = true;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;


                }
         }
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("insert into Employee (first_name,second_name,email,mobile,eid,dob,gender,address_details) values (@firstName, @secondName, @email, @mobile, @eid, @dob, @gender, @address)", con);
                cmd.Parameters.AddWithValue("@firstName", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@secondName", txtSecondName.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@mobile", txtNumber.Text);
                cmd.Parameters.AddWithValue("@eid", txtEid.Text);
                cmd.Parameters.AddWithValue("@dob", txtDate.Value);
               /* string? g = (ddlGender.SelectedItem.ToString() != null) ? ddlGender.SelectedItem.ToString() : "O" ;
                cmd.Parameters.AddWithValue("@gender", g);*/

                if (ddlGender.SelectedItem != null)
                {
                    string? g = ddlGender.SelectedItem.ToString();
                    cmd.Parameters.AddWithValue("@gender", g);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@gender", "O");
                  
                }
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("DetailsSaved Successfully ", "Record Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not A Proper way to Save", "Process Canceled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void fillGender()
        {
            cmd = new SqlCommand("Select * from gender", con);
            con.Open();
            SqlDataAdapter sdaGender = new SqlDataAdapter(cmd);
            DataTable dtGender = new DataTable();
            sdaGender.Fill(dtGender);

            ddlGender.DataSource = dtGender;
            ddlGender.DisplayMember = "gender";
            ddlGender.ValueMember = "gender";

            con.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Employee order by id DESC", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            dataGV.DataSource = dt;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGV.DataSource = null;
            dataGV.Rows.Clear();


            cmd = new SqlCommand("select * from Employee where first_name like '%' +@search+ '%' or second_name like '%' +@search+ '%' or id like '%' +@search+ '%'", con);
            cmd.Parameters.AddWithValue("@search", txtSearch.Text);
            con.Open();
            SqlDataAdapter sda1 = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda1.Fill(dt);
            dataGV.DataSource = dt;
            con.Close();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("delete from Employee where id =" + selectedRowId, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            fillGrid();
        }
    }
}

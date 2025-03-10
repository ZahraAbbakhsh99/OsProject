using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Abbakhsh_SMS
{
    public partial class AddDepartment : Form
    {
        private System.Windows.Forms.Label Status;
        private String ConSt = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\TetaSoft\\source\\repos\\Abbakhsh-SMS\\Abbakhsh-SMS\\SMSdb.mdf;Integrated Security=True";

        public AddDepartment()
        {
            InitializeComponent();
        }
        private void AddDepartment_Load(object sender, EventArgs e)
        {
            LoadDep();
        }

        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }

        private void DepID_TextChanged(object sender, EventArgs e) { }
        private void DepName_TextChanged(object sender, EventArgs e) { }
        private void BasicSalary_TextChanged(object sender, EventArgs e) { }
        private void BasicWHoures_TextChanged(object sender, EventArgs e) { }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void AssociateWithEmployee_Click(object sender, EventArgs e)
        {

            int depId;
            decimal bSalary;
            TimeSpan bWH;

            if (!int.TryParse(DepID.Text, out depId))
            {
                Status.Text = "Invalid Department ID.";
                return;
            }
            if (String.IsNullOrEmpty(DepName.Text))
            {
                Status.Text = "Department Name is required.";
                return;
            }
            if (!decimal.TryParse(BasicSalary.Text, out bSalary))
            {
                Status.Text = "Invalid Base Salary.";
                return;
            }
            if (!TimeSpan.TryParse(BasicWHoures.Text, out bWH))
            {
                Status.Text = "Invalid Base WorkingHours.";
                return;
            }

            using (SqlConnection con = new SqlConnection(ConSt))
            {
                try
                {
                    con.Open();

                    string insertQ = "INSERT INTO Department (ID, Name,BasicSalary,BasicWH) VALUES (@depId, @depName, @bSalary, @bWH)";
                    using (SqlCommand cmd = new SqlCommand(insertQ, con))
                    {
                        cmd.Parameters.AddWithValue("@depId", depId);
                        cmd.Parameters.AddWithValue("@depName", DepName.Text);
                        cmd.Parameters.AddWithValue("@bSalary", bSalary);
                        cmd.Parameters.AddWithValue("@bWH", bWH);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            Status.Text = "Department added successfully.";
                            LoadDep();
                        }
                        else
                        {
                            Status.Text = "Error adding department.";
                        }
                    }
                }
                catch (Exception ex)
                {
                    Status.Text = "Error: " + ex.Message;
                }

            }

        }
        private void LoadDep()
        {
            using (SqlConnection con = new SqlConnection(ConSt))
            {
                try
                {
                    con.Open();
                    string selectQ = "SELECT DepartmentID, DepartmentName, BaseSalary, BaseHours FROM Department";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(selectQ, con))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    Status.Text = "Error: " + ex.Message;
                }
            }
        }

        private void Main_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

       
    }
}


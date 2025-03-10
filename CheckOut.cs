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

namespace Abbakhsh_SMS
{
    public partial class CheckOut : Form
    {
        private System.Windows.Forms.Label Status;
        private String ConSt = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\TetaSoft\\source\\repos\\Abbakhsh-SMS\\Abbakhsh-SMS\\SMSdb.mdf;Integrated Security=True";

        public CheckOut()
        {
            InitializeComponent();
        }

        private void CheckOut_Load(object sender, EventArgs e)
        {

            label3.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void DepID_TextChanged(object sender, EventArgs e) { }

        private void buttonCheckIn_Click(object sender, EventArgs e) 
        {
            int empId, depId;
            if (!int.TryParse(textBox1.Text, out empId))
            {
                Status.Text = "Invalid Employee ID.";
                return;
            }
            if (!int.TryParse(DepID.Text, out depId))
            {
                Status.Text = "Invalid Department ID.";
                return;
            }
            DateTime currentTime = DateTime.Now;
            using (SqlConnection con = new SqlConnection(ConSt))
            {
                try
                {
                    con.Open();

                    DateTime startTime;

                    String CheckAssQ = "SELECT COUNT(*) FROM AssociateED WHERE EmpID = @empId AND " +
                        "DepID = @depId ";
                    using (SqlCommand CheckAssCmd = new SqlCommand(CheckAssQ , con))
                    {
                        CheckAssCmd.Parameters.AddWithValue("@empId", empId);
                        CheckAssCmd.Parameters.AddWithValue("@depId", depId);

                        int count = (int)CheckAssCmd.ExecuteScalar();
                        if (count == 0) 
                        {
                            Status.Text = "Employee isn't associated whit this department.";
                            return;
                        }
                    }

                    String CheckHoursQ = "SELECT TOP 1 StartTime FROM Hours WHERE EmpID = @empId " +
                        "AND DepID = @depId AND EndTime = NULL AND StartTime >= DATEADD( HOUR , -15 , @cuTime )" +
                        "ORDER BY StartTime DESC ";
                    using (SqlCommand CheckHoursCmd = new SqlCommand(CheckHoursQ , con))
                    {
                        CheckHoursCmd.Parameters.AddWithValue("@empId" , empId);
                        CheckHoursCmd.Parameters.AddWithValue("@depId", depId);
                        CheckHoursCmd.Parameters.AddWithValue("@cuTime", currentTime);

                        var result = CheckHoursCmd.ExecuteScalar();
                        if (result == null)
                        {
                            Status.Text = "No valid checkIn record found.";
                            return;
                        }
                        startTime = (DateTime)result;
                    }

                    String updateQ = "UPDATE Hours SET EndTime = @endTime , Duration = DATEDIFF(HOUER ,StartTime , @endTime" +
                        "WHERE EmpID = @empId and DepID = @depId and EndTime IS NULL AND StartTime = @startTime ";
                    using (SqlCommand updateCmd = new SqlCommand(updateQ , con)) 
                    {
                        updateCmd.Parameters.AddWithValue("@endTime", currentTime);
                        updateCmd.Parameters.AddWithValue("@empId", empId);
                        updateCmd.Parameters.AddWithValue("@depId", depId);
                        updateCmd.Parameters.AddWithValue("@startTime", startTime);

                        int rowAffected = updateCmd.ExecuteNonQuery();
                        if (rowAffected > 0) 
                        {
                            Status.Text = "Check Out successful.";
                            return;
                        }else
                        {
                            Status.Text = "Check Out failed.";
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Status.Text = "Error: " + ex.Message;
                }
            }
        }
        private void Home_Click(object sender, EventArgs e) 
        {
            Home HomeForm = new Home();
            HomeForm.Show();
            this.Hide();
        }
    }
}

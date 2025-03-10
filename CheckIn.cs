using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Abbakhsh_SMS
{
    public partial class CheckIn : Form
    {
        private System.Windows.Forms.Label Status;
        private String ConSt = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\TetaSoft\\source\\repos\\Abbakhsh-SMS\\Abbakhsh-SMS\\SMSdb.mdf;Integrated Security=True";
        public CheckIn()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString("HH:mm:ss");
        }


        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void DepID_TextChanged(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void buttonCheckIn_Click(object sender, EventArgs e)
        {
            int empId, depId;
            if (!int.TryParse(textBox1.Text , out empId))
            {
                Status.Text = "Invalid Employee ID.";
                return;
            }
            if(!int.TryParse(DepID.Text , out depId))
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
                    String CheckQ = "SELECT COUNT(*) FROM AssociateED WHERE EmpID = @empId and DepID = @depId";
                    using (SqlCommand CheckCmd = new SqlCommand (CheckQ , con))
                    {
                        CheckCmd.Parameters.AddWithValue("@empId", empId);
                        CheckCmd.Parameters.AddWithValue("@depId", depId);
                        int count = (int)CheckCmd.ExecuteScalar();
                        if (count == 0)
                        {
                            Status.Text = "Employee isn't associated whit this department.";
                            return;
                        }
                    }
                    String LastCheckInQ = "SELECT COUNT(*) FROM Hours WHERE EmpID = @empId AND " +
                        "DepID = @depId AND StartTime >= DATEADD (HOUR , -30 ,@curTime) AND EndTime IS NULL";
                    using (SqlCommand LastCheckInCmd = new SqlCommand(LastCheckInQ , con))
                    {
                        LastCheckInCmd.Parameters.AddWithValue("@empId" , empId);
                        LastCheckInCmd.Parameters.AddWithValue("@depId", depId);
                        LastCheckInCmd.Parameters.AddWithValue("@curTime", currentTime);

                        int recentChIn = (int)LastCheckInCmd.ExecuteScalar();
                        if (recentChIn > 0) 
                        {
                            Status.Text = "Employee has already checked In within the last 24 hours.";
                            return;
                        }
                       
                    }
                    String InsertQ = "INSERT INTO Hours (EmpID,StartTime,EndTime,Duration,DepID)" +
                                        "VALUES (@empId , @startT , NULL , NULL ,@depId) ";
                    using (SqlCommand InsertCmd = new SqlCommand(InsertQ , con))
                    {
                        InsertCmd.Parameters.AddWithValue("@empId" , empId);
                        InsertCmd.Parameters.AddWithValue("@startT", currentTime);
                        InsertCmd.Parameters.AddWithValue("@depId", depId);

                        int rowsAffected = InsertCmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                            Status.Text = "Check In Successful.";
                        else
                            Status.Text = "Check In Failled.";

                    }
                }catch(Exception ex)
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

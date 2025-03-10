using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Abbakhsh_SMS
{
    public partial class LoginPage : Form
    {

        private System.Windows.Forms.Label Status;
        private String userName = "Arezoo";
        private String password = "arezo9296";

        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void User_TextChanged(object sender, EventArgs e) { }
        private void Password_TextChanged(object sender, EventArgs e) { }

        private void Login_Click(object sender, EventArgs e)
        {
            String userN = User.Text;   
            String passw = Password.Text;

            if (userN == userName && passw == password)
            {
                Status.Text = "Login Successful.";
                Status.ForeColor = Color.Green ;
                
                Main main = new Main();
                main.Show ();
                this.Hide ();
            }else
            {
                Status.Text = "Invalid User Name or Password.";
                Status.ForeColor = Color.Red;
            }
        }
        private void Home_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}


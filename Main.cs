using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abbakhsh_SMS
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee addEmp = new AddEmployee();
            addEmp.Show();
            this.Hide();
        }

        private void AddDepartment_Click(object sender, EventArgs e)
        {
            AddDepartment addDep = new AddDepartment();
            addDep.Show();  
            this.Hide();
        }

        private void AddJobPosition_Click(object sender, EventArgs e)
        {
            AddJobPosition addJPO = new AddJobPosition();
            addJPO.Show();
            this.Hide();
        }

        private void Associate_Click(object sender, EventArgs e)
        {
            AssociateED asso = new AssociateED();
            asso.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PaySlip payS = new PaySlip();
            payS.Show();
            this.Hide();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

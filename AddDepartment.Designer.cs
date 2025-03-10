namespace Abbakhsh_SMS
{
    partial class AddDepartment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DepName = new System.Windows.Forms.TextBox();
            this.DepID = new System.Windows.Forms.TextBox();
            this.BasicSalary = new System.Windows.Forms.TextBox();
            this.BasicWHoures = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Home = new System.Windows.Forms.Button();
            this.Main = new System.Windows.Forms.Button();
            this.AssociateWithEmployee = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please complete the form below.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(28, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Department ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(28, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "     Name        ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(28, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = " Basic Salary ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(28, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Basic working hours";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // DepName
            // 
            this.DepName.Location = new System.Drawing.Point(237, 177);
            this.DepName.Name = "DepName";
            this.DepName.Size = new System.Drawing.Size(220, 22);
            this.DepName.TabIndex = 8;
            this.DepName.TextChanged += new System.EventHandler(this.DepName_TextChanged);
            // 
            // DepID
            // 
            this.DepID.Location = new System.Drawing.Point(237, 101);
            this.DepID.Name = "DepID";
            this.DepID.Size = new System.Drawing.Size(220, 22);
            this.DepID.TabIndex = 9;
            this.DepID.TextChanged += new System.EventHandler(this.DepID_TextChanged);
            // 
            // BasicSalary
            // 
            this.BasicSalary.Location = new System.Drawing.Point(237, 253);
            this.BasicSalary.Name = "BasicSalary";
            this.BasicSalary.Size = new System.Drawing.Size(220, 22);
            this.BasicSalary.TabIndex = 10;
            this.BasicSalary.TextChanged += new System.EventHandler(this.BasicSalary_TextChanged);
            // 
            // BasicWHoures
            // 
            this.BasicWHoures.Location = new System.Drawing.Point(237, 333);
            this.BasicWHoures.Name = "BasicWHoures";
            this.BasicWHoures.Size = new System.Drawing.Size(220, 22);
            this.BasicWHoures.TabIndex = 11;
            this.BasicWHoures.TextChanged += new System.EventHandler(this.BasicWHoures_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Abbakhsh_SMS.Properties.Resources.dep;
            this.pictureBox1.Location = new System.Drawing.Point(487, -102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(506, 554);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.LightSlateGray;
            this.Home.Location = new System.Drawing.Point(372, 397);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(76, 28);
            this.Home.TabIndex = 15;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.Color.LightSlateGray;
            this.Main.Location = new System.Drawing.Point(18, 397);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(76, 28);
            this.Main.TabIndex = 16;
            this.Main.Text = "Main";
            this.Main.UseVisualStyleBackColor = false;
            this.Main.Click += new System.EventHandler(this.Main_Click);
            // 
            // AssociateWithEmployee
            // 
            this.AssociateWithEmployee.BackColor = System.Drawing.Color.LightSlateGray;
            this.AssociateWithEmployee.Location = new System.Drawing.Point(124, 397);
            this.AssociateWithEmployee.Name = "AssociateWithEmployee";
            this.AssociateWithEmployee.Size = new System.Drawing.Size(220, 28);
            this.AssociateWithEmployee.TabIndex = 17;
            this.AssociateWithEmployee.Text = "Associate With Employee";
            this.AssociateWithEmployee.UseVisualStyleBackColor = false;
            this.AssociateWithEmployee.Click += new System.EventHandler(this.AssociateWithEmployee_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 479);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(714, 141);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AddDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 632);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AssociateWithEmployee);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BasicWHoures);
            this.Controls.Add(this.BasicSalary);
            this.Controls.Add(this.DepID);
            this.Controls.Add(this.DepName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddDepartment";
            this.Text = "Add Department";
            this.Load += new System.EventHandler(this.AddDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DepName;
        private System.Windows.Forms.TextBox DepID;
        private System.Windows.Forms.TextBox BasicSalary;
        private System.Windows.Forms.TextBox BasicWHoures;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button Main;
        private System.Windows.Forms.Button AssociateWithEmployee;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
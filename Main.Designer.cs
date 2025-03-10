namespace Abbakhsh_SMS
{
    partial class Main
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
            this.AddEmployee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddDepartment = new System.Windows.Forms.Button();
            this.Associate = new System.Windows.Forms.Button();
            this.AddJobPosition = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddEmployee
            // 
            this.AddEmployee.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployee.Location = new System.Drawing.Point(187, 177);
            this.AddEmployee.Name = "AddEmployee";
            this.AddEmployee.Size = new System.Drawing.Size(162, 62);
            this.AddEmployee.TabIndex = 0;
            this.AddEmployee.Text = "Add Employee";
            this.AddEmployee.UseVisualStyleBackColor = true;
            this.AddEmployee.Click += new System.EventHandler(this.AddEmployee_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hello boss.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(84, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(388, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please select the desired option.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // AddDepartment
            // 
            this.AddDepartment.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDepartment.Location = new System.Drawing.Point(496, 177);
            this.AddDepartment.Name = "AddDepartment";
            this.AddDepartment.Size = new System.Drawing.Size(162, 62);
            this.AddDepartment.TabIndex = 3;
            this.AddDepartment.Text = "Add Department";
            this.AddDepartment.UseVisualStyleBackColor = true;
            this.AddDepartment.Click += new System.EventHandler(this.AddDepartment_Click);
            // 
            // Associate
            // 
            this.Associate.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Associate.Location = new System.Drawing.Point(331, 288);
            this.Associate.Name = "Associate";
            this.Associate.Size = new System.Drawing.Size(167, 74);
            this.Associate.TabIndex = 4;
            this.Associate.Text = "Associate Employee With Department";
            this.Associate.UseVisualStyleBackColor = true;
            this.Associate.Click += new System.EventHandler(this.Associate_Click);
            // 
            // AddJobPosition
            // 
            this.AddJobPosition.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddJobPosition.Location = new System.Drawing.Point(90, 288);
            this.AddJobPosition.Name = "AddJobPosition";
            this.AddJobPosition.Size = new System.Drawing.Size(167, 74);
            this.AddJobPosition.TabIndex = 5;
            this.AddJobPosition.Text = "Add Job Position";
            this.AddJobPosition.UseVisualStyleBackColor = true;
            this.AddJobPosition.Click += new System.EventHandler(this.AddJobPosition_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(574, 288);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(182, 74);
            this.button5.TabIndex = 6;
            this.button5.Text = "View the pay slip";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.LightSlateGray;
            this.Home.Location = new System.Drawing.Point(101, 401);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(76, 28);
            this.Home.TabIndex = 12;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.LightSlateGray;
            this.Exit.Location = new System.Drawing.Point(637, 401);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(76, 28);
            this.Exit.TabIndex = 13;
            this.Exit.Text = "Exit  ";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.AddJobPosition);
            this.Controls.Add(this.Associate);
            this.Controls.Add(this.AddDepartment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddEmployee);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddDepartment;
        private System.Windows.Forms.Button Associate;
        private System.Windows.Forms.Button AddJobPosition;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button Exit;
    }
}
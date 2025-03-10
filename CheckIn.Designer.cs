namespace Abbakhsh_SMS
{
    partial class CheckIn
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCheckIn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Home = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.DepID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter the following information.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Your ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkCyan;
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(220, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 40);
            this.label3.TabIndex = 4;
            this.label3.Text = "Current Time";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 27);
            this.label4.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label5.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 27);
            this.label5.TabIndex = 6;
            this.label5.Text = "Current Time";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // buttonCheckIn
            // 
            this.buttonCheckIn.Font = new System.Drawing.Font("Lotus", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonCheckIn.Location = new System.Drawing.Point(37, 294);
            this.buttonCheckIn.Name = "buttonCheckIn";
            this.buttonCheckIn.Size = new System.Drawing.Size(373, 81);
            this.buttonCheckIn.TabIndex = 9;
            this.buttonCheckIn.Text = "Check In ";
            this.buttonCheckIn.UseVisualStyleBackColor = true;
            this.buttonCheckIn.Click += new System.EventHandler(this.buttonCheckIn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Abbakhsh_SMS.Properties.Resources.emp2;
            this.pictureBox1.Location = new System.Drawing.Point(474, -38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 530);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.LightSlateGray;
            this.Home.Location = new System.Drawing.Point(364, 398);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(76, 28);
            this.Home.TabIndex = 11;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label6.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 27);
            this.label6.TabIndex = 12;
            this.label6.Text = "Dep ID";
            // 
            // DepID
            // 
            this.DepID.Location = new System.Drawing.Point(150, 172);
            this.DepID.Name = "DepID";
            this.DepID.Size = new System.Drawing.Size(243, 22);
            this.DepID.TabIndex = 13;
            this.DepID.TextChanged += new System.EventHandler(this.DepID_TextChanged);
            // 
            // CheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(798, 450);
            this.Controls.Add(this.DepID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonCheckIn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "CheckIn";
            this.Text = "Check In";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonCheckIn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DepID;
    }
}
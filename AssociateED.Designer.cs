namespace Abbakhsh_SMS
{
    partial class AssociateED
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
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Main = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.EmpID = new System.Windows.Forms.ComboBox();
            this.DepID = new System.Windows.Forms.ComboBox();
            this.PosID = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(25, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please complete the form below.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(47, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Department ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(47, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = " Employee ID  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(47, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "   Position ID   ";
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.Color.LightSlateGray;
            this.Main.Location = new System.Drawing.Point(68, 382);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(76, 28);
            this.Main.TabIndex = 16;
            this.Main.Text = "Main";
            this.Main.UseVisualStyleBackColor = false;
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.LightSlateGray;
            this.Home.Location = new System.Drawing.Point(273, 382);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(76, 28);
            this.Home.TabIndex = 17;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = false;
            // 
            // EmpID
            // 
            this.EmpID.FormattingEnabled = true;
            this.EmpID.Location = new System.Drawing.Point(223, 96);
            this.EmpID.Name = "EmpID";
            this.EmpID.Size = new System.Drawing.Size(192, 24);
            this.EmpID.TabIndex = 18;
            // 
            // DepID
            // 
            this.DepID.FormattingEnabled = true;
            this.DepID.Location = new System.Drawing.Point(223, 186);
            this.DepID.Name = "DepID";
            this.DepID.Size = new System.Drawing.Size(192, 24);
            this.DepID.TabIndex = 19;
            // 
            // PosID
            // 
            this.PosID.FormattingEnabled = true;
            this.PosID.Location = new System.Drawing.Point(223, 289);
            this.PosID.Name = "PosID";
            this.PosID.Size = new System.Drawing.Size(192, 24);
            this.PosID.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Abbakhsh_SMS.Properties.Resources.emp3_1;
            this.pictureBox1.Location = new System.Drawing.Point(467, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 382);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // AssociateED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PosID);
            this.Controls.Add(this.DepID);
            this.Controls.Add(this.EmpID);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AssociateED";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Main;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.ComboBox EmpID;
        private System.Windows.Forms.ComboBox DepID;
        private System.Windows.Forms.ComboBox PosID;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
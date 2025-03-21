namespace Patients_registration_form
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PatName = new System.Windows.Forms.TextBox();
            this.PatPhone = new System.Windows.Forms.TextBox();
            this.PatContact = new System.Windows.Forms.TextBox();
            this.PatHistory = new System.Windows.Forms.TextBox();
            this.PatId = new System.Windows.Forms.TextBox();
            this.PatPhysician = new System.Windows.Forms.TextBox();
            this.PatGender = new System.Windows.Forms.ComboBox();
            this.PatBloodGrp = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PatDob = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.PatEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.PatAddress = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.PatAge = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1237, 103);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(271, 28);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(645, 39);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "PATIENT REGISTRATION FORM\r\n";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PatName
            // 
            this.PatName.Location = new System.Drawing.Point(168, 123);
            this.PatName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PatName.Name = "PatName";
            this.PatName.Size = new System.Drawing.Size(258, 31);
            this.PatName.TabIndex = 1;
            this.PatName.Text = "\r\n";
            // 
            // PatPhone
            // 
            this.PatPhone.Location = new System.Drawing.Point(834, 123);
            this.PatPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PatPhone.Name = "PatPhone";
            this.PatPhone.Size = new System.Drawing.Size(258, 31);
            this.PatPhone.TabIndex = 5;
            // 
            // PatContact
            // 
            this.PatContact.Location = new System.Drawing.Point(834, 361);
            this.PatContact.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PatContact.Name = "PatContact";
            this.PatContact.Size = new System.Drawing.Size(258, 31);
            this.PatContact.TabIndex = 6;
            this.PatContact.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // PatHistory
            // 
            this.PatHistory.Location = new System.Drawing.Point(834, 300);
            this.PatHistory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PatHistory.Name = "PatHistory";
            this.PatHistory.Size = new System.Drawing.Size(258, 31);
            this.PatHistory.TabIndex = 8;
            // 
            // PatId
            // 
            this.PatId.Location = new System.Drawing.Point(168, 243);
            this.PatId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PatId.Name = "PatId";
            this.PatId.Size = new System.Drawing.Size(258, 31);
            this.PatId.TabIndex = 9;
            // 
            // PatPhysician
            // 
            this.PatPhysician.Location = new System.Drawing.Point(834, 422);
            this.PatPhysician.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PatPhysician.Name = "PatPhysician";
            this.PatPhysician.Size = new System.Drawing.Size(258, 31);
            this.PatPhysician.TabIndex = 11;
            this.PatPhysician.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // PatGender
            // 
            this.PatGender.FormattingEnabled = true;
            this.PatGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.PatGender.Location = new System.Drawing.Point(168, 367);
            this.PatGender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PatGender.Name = "PatGender";
            this.PatGender.Size = new System.Drawing.Size(258, 33);
            this.PatGender.TabIndex = 12;
            // 
            // PatBloodGrp
            // 
            this.PatBloodGrp.FormattingEnabled = true;
            this.PatBloodGrp.Items.AddRange(new object[] {
            "A+",
            "O+",
            "B+",
            "AB+",
            "A-",
            "O-",
            "B-",
            "AB-"});
            this.PatBloodGrp.Location = new System.Drawing.Point(168, 428);
            this.PatBloodGrp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PatBloodGrp.Name = "PatBloodGrp";
            this.PatBloodGrp.Size = new System.Drawing.Size(258, 33);
            this.PatBloodGrp.TabIndex = 13;
            this.PatBloodGrp.SelectedIndexChanged += new System.EventHandler(this.PatBloodGrp_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(442, 509);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 46);
            this.button1.TabIndex = 14;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(590, 509);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 46);
            this.button2.TabIndex = 15;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(493, 577);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 37);
            this.button4.TabIndex = 17;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Full Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Date of Birth :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "ID Number :";
            // 
            // PatDob
            // 
            this.PatDob.Location = new System.Drawing.Point(168, 182);
            this.PatDob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PatDob.Name = "PatDob";
            this.PatDob.Size = new System.Drawing.Size(258, 31);
            this.PatDob.TabIndex = 21;
            this.PatDob.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Gender :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 428);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "BloodGroup :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(618, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = "PhoneNumber :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(618, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 25);
            this.label7.TabIndex = 25;
            this.label7.Text = "EmergencyContact :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(618, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 25);
            this.label8.TabIndex = 26;
            this.label8.Text = "MedicalHistory :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(618, 428);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(201, 25);
            this.label9.TabIndex = 27;
            this.label9.Text = "PrimaryCorePhysician :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(618, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 25);
            this.label10.TabIndex = 28;
            this.label10.Text = "EmailAddress :";
            // 
            // PatEmail
            // 
            this.PatEmail.Location = new System.Drawing.Point(834, 185);
            this.PatEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PatEmail.Name = "PatEmail";
            this.PatEmail.Size = new System.Drawing.Size(258, 31);
            this.PatEmail.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(618, 246);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 25);
            this.label11.TabIndex = 30;
            this.label11.Text = "PhysicalAddress :";
            // 
            // PatAddress
            // 
            this.PatAddress.Location = new System.Drawing.Point(834, 243);
            this.PatAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PatAddress.Name = "PatAddress";
            this.PatAddress.Size = new System.Drawing.Size(258, 31);
            this.PatAddress.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 297);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 25);
            this.label12.TabIndex = 32;
            this.label12.Text = "Age :";
            // 
            // PatAge
            // 
            this.PatAge.Location = new System.Drawing.Point(168, 297);
            this.PatAge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PatAge.Name = "PatAge";
            this.PatAge.Size = new System.Drawing.Size(258, 31);
            this.PatAge.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1237, 684);
            this.Controls.Add(this.PatAge);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.PatAddress);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.PatEmail);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PatDob);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PatBloodGrp);
            this.Controls.Add(this.PatGender);
            this.Controls.Add(this.PatPhysician);
            this.Controls.Add(this.PatId);
            this.Controls.Add(this.PatHistory);
            this.Controls.Add(this.PatContact);
            this.Controls.Add(this.PatPhone);
            this.Controls.Add(this.PatName);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Full name";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox PatName;
        private System.Windows.Forms.TextBox PatPhone;
        private System.Windows.Forms.TextBox PatContact;
        private System.Windows.Forms.TextBox PatHistory;
        private System.Windows.Forms.TextBox PatId;
        private System.Windows.Forms.TextBox PatPhysician;
        private System.Windows.Forms.ComboBox PatGender;
        private System.Windows.Forms.ComboBox PatBloodGrp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PatDob;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox PatEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox PatAddress;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox PatAge;
    }
}


namespace HMSLogin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            patientname = new TextBox();
            patientpasswd = new TextBox();
            button1 = new Button();
            label2 = new Label();
            patientsid = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(448, 125);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(56, 25);
            label1.Name = "label1";
            label1.Size = new Size(334, 60);
            label1.TabIndex = 1;
            label1.Text = "Patient's Login";
            label1.Click += label1_Click;
            // 
            // patientname
            // 
            patientname.BorderStyle = BorderStyle.FixedSingle;
            patientname.ForeColor = SystemColors.ControlDark;
            patientname.Location = new Point(106, 211);
            patientname.Name = "patientname";
            patientname.Size = new Size(181, 27);
            patientname.TabIndex = 2;
            patientname.Text = "patient's name";
            // 
            // patientpasswd
            // 
            patientpasswd.BorderStyle = BorderStyle.FixedSingle;
            patientpasswd.ForeColor = SystemColors.ControlDark;
            patientpasswd.Location = new Point(108, 259);
            patientpasswd.Name = "patientpasswd";
            patientpasswd.Size = new Size(181, 27);
            patientpasswd.TabIndex = 3;
            patientpasswd.Text = "enter password";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(108, 363);
            button1.Name = "button1";
            button1.Size = new Size(199, 56);
            button1.TabIndex = 1;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(108, 444);
            label2.Name = "label2";
            label2.Size = new Size(179, 20);
            label2.TabIndex = 4;
            label2.Text = "dont have an account?";
            label2.Click += label2_Click;
            // 
            // patientsid
            // 
            patientsid.BorderStyle = BorderStyle.FixedSingle;
            patientsid.ForeColor = SystemColors.ControlDark;
            patientsid.Location = new Point(106, 163);
            patientsid.Name = "patientsid";
            patientsid.Size = new Size(181, 27);
            patientsid.TabIndex = 5;
            patientsid.Text = "patient's ID";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(448, 508);
            Controls.Add(patientsid);
            Controls.Add(label2);
            Controls.Add(patientpasswd);
            Controls.Add(patientname);
            Controls.Add(button1);
            Controls.Add(panel1);
            ForeColor = SystemColors.InfoText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox patientname;
        private TextBox patientpasswd;
        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox patientsid;
    }
}

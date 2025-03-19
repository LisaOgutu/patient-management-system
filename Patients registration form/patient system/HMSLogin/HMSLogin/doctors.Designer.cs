namespace HMSLogin
{
    partial class Doctors
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
            panel1 = new Panel();
            label1 = new Label();
            button1 = new Button();
            docname = new TextBox();
            docpasswcd = new TextBox();
            label2 = new Label();
            docid = new TextBox();
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
            panel1.Size = new Size(439, 125);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(50, 29);
            label1.Name = "label1";
            label1.Size = new Size(321, 60);
            label1.TabIndex = 0;
            label1.Text = "Doctor's Login";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(127, 319);
            button1.Name = "button1";
            button1.Size = new Size(181, 55);
            button1.TabIndex = 1;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // docname
            // 
            docname.BackColor = SystemColors.Window;
            docname.ForeColor = SystemColors.ControlDark;
            docname.Location = new Point(131, 219);
            docname.Name = "docname";
            docname.Size = new Size(181, 27);
            docname.TabIndex = 2;
            docname.Text = "Doc's name";
            // 
            // docpasswcd
            // 
            docpasswcd.BackColor = SystemColors.Window;
            docpasswcd.ForeColor = SystemColors.ControlDark;
            docpasswcd.Location = new Point(131, 268);
            docpasswcd.Name = "docpasswcd";
            docpasswcd.Size = new Size(181, 27);
            docpasswcd.TabIndex = 3;
            docpasswcd.Text = "enter password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(131, 432);
            label2.Name = "label2";
            label2.Size = new Size(179, 20);
            label2.TabIndex = 5;
            label2.Text = "dont have an account?";
            label2.Click += label2_Click;
            // 
            // docid
            // 
            docid.BackColor = SystemColors.Window;
            docid.ForeColor = SystemColors.ControlDark;
            docid.Location = new Point(131, 169);
            docid.Name = "docid";
            docid.Size = new Size(181, 27);
            docid.TabIndex = 6;
            docid.Text = "Doc's ID";
            // 
            // Doctors
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(439, 515);
            Controls.Add(docid);
            Controls.Add(label2);
            Controls.Add(docpasswcd);
            Controls.Add(docname);
            Controls.Add(button1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Doctors";
            Text = "enter password";
            Load += doctors_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private TextBox docname;
        private TextBox docpasswcd;
        private Label label2;
        private TextBox docid;
    }
}
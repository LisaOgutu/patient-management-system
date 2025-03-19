namespace Doctor_s_Panel
{
    partial class Surgeries
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
            this.label1 = new System.Windows.Forms.Label();
            this.ptid = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.purpose = new System.Windows.Forms.ComboBox();
            this.method = new System.Windows.Forms.ComboBox();
            this.specialty = new System.Windows.Forms.ComboBox();
            this.urgency = new System.Windows.Forms.ComboBox();
            this.theatre = new System.Windows.Forms.ComboBox();
            this.details = new System.Windows.Forms.RichTextBox();
            this.SurgeriesGV = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SurgeriesGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1150, 110);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label1.Location = new System.Drawing.Point(378, 21);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(1);
            this.label1.Size = new System.Drawing.Size(401, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mandated Surgeries";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ptid
            // 
            this.ptid.BackColor = System.Drawing.SystemColors.Control;
            this.ptid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptid.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptid.Location = new System.Drawing.Point(40, 168);
            this.ptid.Name = "ptid";
            this.ptid.Size = new System.Drawing.Size(139, 31);
            this.ptid.TabIndex = 10;
            this.ptid.Text = "Patient ID";
            this.ptid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ptid.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(40, 508);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(249, 31);
            this.date.TabIndex = 13;
            this.date.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // purpose
            // 
            this.purpose.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purpose.FormattingEnabled = true;
            this.purpose.Items.AddRange(new object[] {
            "Diagnostic Surgery",
            "Curative Surgery",
            "Palliative Surgery",
            "Exploratory Surgery",
            "Cosmetic Surgery",
            "Reconstructive Surgery"});
            this.purpose.Location = new System.Drawing.Point(40, 221);
            this.purpose.Name = "purpose";
            this.purpose.Size = new System.Drawing.Size(168, 33);
            this.purpose.TabIndex = 14;
            this.purpose.Text = "Surgery Purpose";
            this.purpose.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // method
            // 
            this.method.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.method.FormattingEnabled = true;
            this.method.Items.AddRange(new object[] {
            "Open Surgery",
            "Minimally Invasive Surgery",
            "Laser Surgery"});
            this.method.Location = new System.Drawing.Point(40, 274);
            this.method.Name = "method";
            this.method.Size = new System.Drawing.Size(168, 33);
            this.method.TabIndex = 15;
            this.method.Text = "Surgery Method";
            this.method.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // specialty
            // 
            this.specialty.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialty.FormattingEnabled = true;
            this.specialty.Items.AddRange(new object[] {
            "Cardiovascular",
            "Neurosurgery",
            "Orthopedic",
            "Gastrointestinal",
            "Urological",
            "Otolaryngology",
            "Opthalmic",
            "Plastic Surgery",
            "Thoracic"});
            this.specialty.Location = new System.Drawing.Point(40, 332);
            this.specialty.Name = "specialty";
            this.specialty.Size = new System.Drawing.Size(168, 33);
            this.specialty.TabIndex = 16;
            this.specialty.Text = "Specialty";
            this.specialty.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // urgency
            // 
            this.urgency.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urgency.FormattingEnabled = true;
            this.urgency.Items.AddRange(new object[] {
            "Emergency Surgery",
            "Urgent Surgery",
            "Elective Surgery"});
            this.urgency.Location = new System.Drawing.Point(40, 393);
            this.urgency.Name = "urgency";
            this.urgency.Size = new System.Drawing.Size(168, 33);
            this.urgency.TabIndex = 17;
            this.urgency.Text = "Urgency";
            this.urgency.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // theatre
            // 
            this.theatre.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theatre.FormattingEnabled = true;
            this.theatre.Items.AddRange(new object[] {
            "T001",
            "T002",
            "T003",
            "T004",
            "T005"});
            this.theatre.Location = new System.Drawing.Point(40, 453);
            this.theatre.Name = "theatre";
            this.theatre.Size = new System.Drawing.Size(168, 33);
            this.theatre.TabIndex = 18;
            this.theatre.Text = "Theatre No.";
            // 
            // details
            // 
            this.details.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.details.Location = new System.Drawing.Point(40, 568);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(320, 98);
            this.details.TabIndex = 19;
            this.details.Text = "Details";
            // 
            // SurgeriesGV
            // 
            this.SurgeriesGV.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.SurgeriesGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SurgeriesGV.Location = new System.Drawing.Point(450, 148);
            this.SurgeriesGV.Name = "SurgeriesGV";
            this.SurgeriesGV.RowHeadersWidth = 62;
            this.SurgeriesGV.RowTemplate.Height = 28;
            this.SurgeriesGV.Size = new System.Drawing.Size(670, 499);
            this.SurgeriesGV.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(39, 699);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 37);
            this.button1.TabIndex = 21;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(194, 699);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 37);
            this.button2.TabIndex = 22;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(344, 699);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 37);
            this.button3.TabIndex = 23;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(1007, 699);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 37);
            this.button4.TabIndex = 24;
            this.button4.Text = "DONE";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Surgeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 761);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SurgeriesGV);
            this.Controls.Add(this.details);
            this.Controls.Add(this.theatre);
            this.Controls.Add(this.urgency);
            this.Controls.Add(this.specialty);
            this.Controls.Add(this.method);
            this.Controls.Add(this.purpose);
            this.Controls.Add(this.date);
            this.Controls.Add(this.ptid);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Surgeries";
            this.Text = "Surgeries";
            this.Load += new System.EventHandler(this.Surgeries_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SurgeriesGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ptid;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.ComboBox purpose;
        private System.Windows.Forms.ComboBox method;
        private System.Windows.Forms.ComboBox specialty;
        private System.Windows.Forms.ComboBox urgency;
        private System.Windows.Forms.ComboBox theatre;
        private System.Windows.Forms.RichTextBox details;
        private System.Windows.Forms.DataGridView SurgeriesGV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}
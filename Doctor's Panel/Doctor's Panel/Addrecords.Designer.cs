namespace Doctor_s_Panel
{
    partial class Addrecords
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
            this.pid = new System.Windows.Forms.TextBox();
            this.pname = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.present = new System.Windows.Forms.ComboBox();
            this.history = new System.Windows.Forms.ComboBox();
            this.past = new System.Windows.Forms.ComboBox();
            this.allergies = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.summ = new System.Windows.Forms.RichTextBox();
            this.medicine = new System.Windows.Forms.RichTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1150, 110);
            this.panel1.TabIndex = 4;
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
            this.label1.Location = new System.Drawing.Point(472, 20);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(1);
            this.label1.Size = new System.Drawing.Size(171, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Records";
            // 
            // pid
            // 
            this.pid.BackColor = System.Drawing.SystemColors.Control;
            this.pid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pid.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pid.Location = new System.Drawing.Point(41, 158);
            this.pid.Name = "pid";
            this.pid.Size = new System.Drawing.Size(157, 31);
            this.pid.TabIndex = 11;
            this.pid.Text = "Patient ID";
            this.pid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pname
            // 
            this.pname.BackColor = System.Drawing.SystemColors.Control;
            this.pname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pname.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pname.Location = new System.Drawing.Point(41, 208);
            this.pname.Name = "pname";
            this.pname.Size = new System.Drawing.Size(157, 31);
            this.pname.TabIndex = 12;
            this.pname.Text = "Patient Name";
            this.pname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(24, 145);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 105);
            this.panel2.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(20, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 28);
            this.label2.TabIndex = 14;
            this.label2.Text = "Credentials";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(20, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 28);
            this.label3.TabIndex = 18;
            this.label3.Text = "Medical History";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.present);
            this.panel3.Controls.Add(this.history);
            this.panel3.Controls.Add(this.past);
            this.panel3.Controls.Add(this.allergies);
            this.panel3.Location = new System.Drawing.Point(24, 370);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(318, 250);
            this.panel3.TabIndex = 17;
            // 
            // present
            // 
            this.present.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.present.FormattingEnabled = true;
            this.present.Items.AddRange(new object[] {
            "None",
            "Cardiovascular",
            "Respiratory",
            "Gastrointestinal",
            "Neurological",
            "Musculoskeletal",
            "Endocrine",
            "Dermatological",
            "Renal/Urinary",
            "Reproductive"});
            this.present.Location = new System.Drawing.Point(17, 187);
            this.present.Name = "present";
            this.present.Size = new System.Drawing.Size(235, 33);
            this.present.TabIndex = 21;
            this.present.Text = "Present Illness & Condition";
            // 
            // history
            // 
            this.history.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.history.FormattingEnabled = true;
            this.history.Items.AddRange(new object[] {
            "None",
            "Cardiovascular",
            "Neurosurgery",
            "Orthopedic",
            "Gastrointestinal",
            "Urological",
            "Otolaryngology",
            "Opthalmic",
            "Plastic Surgery",
            "Thoracic"});
            this.history.Location = new System.Drawing.Point(17, 78);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(196, 33);
            this.history.TabIndex = 19;
            this.history.Text = "Surgical History";
            // 
            // past
            // 
            this.past.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.past.FormattingEnabled = true;
            this.past.Items.AddRange(new object[] {
            "None",
            "Cardiovascular",
            "Respiratory",
            "Gastrointestinal",
            "Neurological",
            "Musculoskeletal",
            "Endocrine",
            "Dermatological",
            "Renal/Urinary",
            "Reproductive"});
            this.past.Location = new System.Drawing.Point(17, 127);
            this.past.Name = "past";
            this.past.Size = new System.Drawing.Size(235, 33);
            this.past.TabIndex = 20;
            this.past.Text = "Past Illness & Condition";
            // 
            // allergies
            // 
            this.allergies.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.allergies.FormattingEnabled = true;
            this.allergies.Items.AddRange(new object[] {
            "None",
            "Drug Allergies",
            "Environmental Allergies",
            "Food Allergies",
            "Insect Sting Allergies",
            "Skin Allergies"});
            this.allergies.Location = new System.Drawing.Point(17, 26);
            this.allergies.Name = "allergies";
            this.allergies.Size = new System.Drawing.Size(157, 33);
            this.allergies.TabIndex = 19;
            this.allergies.Text = "Allergies";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(476, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 28);
            this.label4.TabIndex = 22;
            this.label4.Text = "Currently";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.summ);
            this.panel4.Controls.Add(this.medicine);
            this.panel4.Location = new System.Drawing.Point(481, 145);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(622, 474);
            this.panel4.TabIndex = 21;
            // 
            // summ
            // 
            this.summ.BackColor = System.Drawing.SystemColors.Control;
            this.summ.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.summ.Location = new System.Drawing.Point(17, 232);
            this.summ.Name = "summ";
            this.summ.Size = new System.Drawing.Size(583, 203);
            this.summ.TabIndex = 1;
            this.summ.Text = "Summary:";
            // 
            // medicine
            // 
            this.medicine.BackColor = System.Drawing.SystemColors.Control;
            this.medicine.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.medicine.Location = new System.Drawing.Point(17, 26);
            this.medicine.Name = "medicine";
            this.medicine.Size = new System.Drawing.Size(408, 154);
            this.medicine.TabIndex = 0;
            this.medicine.Text = "Medication:";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(24, 683);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(113, 37);
            this.button5.TabIndex = 34;
            this.button5.Text = "ADD";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.button6.Location = new System.Drawing.Point(188, 683);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(113, 37);
            this.button6.TabIndex = 35;
            this.button6.Text = "UPDATE";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.button7.Location = new System.Drawing.Point(338, 683);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(113, 37);
            this.button7.TabIndex = 36;
            this.button7.Text = "DELETE";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.button8.Location = new System.Drawing.Point(989, 683);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(113, 37);
            this.button8.TabIndex = 37;
            this.button8.Text = "DONE";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button4_Click);
            // 
            // Addrecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 761);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pname);
            this.Controls.Add(this.pid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Addrecords";
            this.Text = "Addrecords";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pid;
        private System.Windows.Forms.TextBox pname;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox allergies;
        private System.Windows.Forms.ComboBox past;
        private System.Windows.Forms.ComboBox history;
        private System.Windows.Forms.ComboBox present;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RichTextBox summ;
        private System.Windows.Forms.RichTextBox medicine;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}
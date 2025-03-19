namespace Doctor_s_Panel
{
    partial class Timeslots
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
            this.date = new System.Windows.Forms.DateTimePicker();
            this.TimeslotsGV = new System.Windows.Forms.DataGridView();
            this.time = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.available = new System.Windows.Forms.RadioButton();
            this.unavailable = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeslotsGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1150, 110);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.label1.Location = new System.Drawing.Point(440, 20);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(1);
            this.label1.Size = new System.Drawing.Size(219, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time Slots";
            // 
            // date
            // 
            this.date.CustomFormat = "MM/dd/yyyy";
            this.date.Location = new System.Drawing.Point(32, 171);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(277, 26);
            this.date.TabIndex = 4;
            // 
            // TimeslotsGV
            // 
            this.TimeslotsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TimeslotsGV.Location = new System.Drawing.Point(536, 162);
            this.TimeslotsGV.Name = "TimeslotsGV";
            this.TimeslotsGV.RowHeadersWidth = 62;
            this.TimeslotsGV.RowTemplate.Height = 28;
            this.TimeslotsGV.Size = new System.Drawing.Size(563, 465);
            this.TimeslotsGV.TabIndex = 5;
            this.TimeslotsGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // time
            // 
            this.time.FormattingEnabled = true;
            this.time.Items.AddRange(new object[] {
            "8:00 - 10:00",
            "10:00 - 12:00",
            "2:00 - 4:00"});
            this.time.Location = new System.Drawing.Point(32, 234);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(202, 28);
            this.time.TabIndex = 6;
            this.time.Text = "Time";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(986, 702);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 37);
            this.button4.TabIndex = 33;
            this.button4.Text = "DONE";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(196, 702);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 37);
            this.button2.TabIndex = 31;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(32, 702);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 37);
            this.button1.TabIndex = 30;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // available
            // 
            this.available.AutoSize = true;
            this.available.Location = new System.Drawing.Point(32, 303);
            this.available.Name = "available";
            this.available.Size = new System.Drawing.Size(97, 24);
            this.available.TabIndex = 34;
            this.available.TabStop = true;
            this.available.Text = "Available";
            this.available.UseVisualStyleBackColor = true;
            this.available.CheckedChanged += new System.EventHandler(this.available_CheckedChanged);
            // 
            // unavailable
            // 
            this.unavailable.AutoSize = true;
            this.unavailable.Location = new System.Drawing.Point(214, 303);
            this.unavailable.Name = "unavailable";
            this.unavailable.Size = new System.Drawing.Size(126, 24);
            this.unavailable.TabIndex = 35;
            this.unavailable.TabStop = true;
            this.unavailable.Text = "Not Available";
            this.unavailable.UseVisualStyleBackColor = true;
            this.unavailable.CheckedChanged += new System.EventHandler(this.unavailable_CheckedChanged);
            // 
            // Timeslots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 761);
            this.Controls.Add(this.unavailable);
            this.Controls.Add(this.available);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.time);
            this.Controls.Add(this.TimeslotsGV);
            this.Controls.Add(this.date);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Timeslots";
            this.Text = "Timeslots";
            this.Load += new System.EventHandler(this.Timeslots_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeslotsGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.DataGridView TimeslotsGV;
        private System.Windows.Forms.ComboBox time;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton available;
        private System.Windows.Forms.RadioButton unavailable;
    }
}
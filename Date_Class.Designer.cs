namespace Date_Class
{
    partial class Date_Class
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
            this.dateEntry = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nextBtn = new System.Windows.Forms.Button();
            this.errorMessageLbl = new System.Windows.Forms.Label();
            this.timeEntry = new System.Windows.Forms.DateTimePicker();
            this.returnBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateEntry
            // 
            this.dateEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEntry.Location = new System.Drawing.Point(78, 113);
            this.dateEntry.Name = "dateEntry";
            this.dateEntry.TabIndex = 0;
            this.dateEntry.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.dateEntry_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date of Entry";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(493, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time of Entry";
            // 
            // nextBtn
            // 
            this.nextBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBtn.Location = new System.Drawing.Point(512, 223);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(115, 52);
            this.nextBtn.TabIndex = 4;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // errorMessageLbl
            // 
            this.errorMessageLbl.AutoSize = true;
            this.errorMessageLbl.Location = new System.Drawing.Point(306, 328);
            this.errorMessageLbl.Name = "errorMessageLbl";
            this.errorMessageLbl.Size = new System.Drawing.Size(17, 13);
            this.errorMessageLbl.TabIndex = 6;
            this.errorMessageLbl.Text = "lbl";
            this.errorMessageLbl.Visible = false;
            // 
            // timeEntry
            // 
            this.timeEntry.CustomFormat = "h:mm tt";
            this.timeEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeEntry.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeEntry.Location = new System.Drawing.Point(521, 140);
            this.timeEntry.Name = "timeEntry";
            this.timeEntry.ShowUpDown = true;
            this.timeEntry.Size = new System.Drawing.Size(100, 26);
            this.timeEntry.TabIndex = 7;
            this.timeEntry.ValueChanged += new System.EventHandler(this.timeEntry_ValueChanged);
            // 
            // returnBtn
            // 
            this.returnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBtn.Location = new System.Drawing.Point(279, 367);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(196, 52);
            this.returnBtn.TabIndex = 8;
            this.returnBtn.Text = "Return to Main Page";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // Date_Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.timeEntry);
            this.Controls.Add(this.errorMessageLbl);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateEntry);
            this.Name = "Date_Class";
            this.Text = "Please enter date and time of entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar dateEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Label errorMessageLbl;
        private System.Windows.Forms.DateTimePicker timeEntry;
        private System.Windows.Forms.Button returnBtn;
    }
}


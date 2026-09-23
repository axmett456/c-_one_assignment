namespace home_work1_ca242
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
            this.txt_day_of_week = new System.Windows.Forms.TextBox();
            this.txt_name_of_month = new System.Windows.Forms.TextBox();
            this.txt_number_of_day = new System.Windows.Forms.TextBox();
            this.txt_year = new System.Windows.Forms.TextBox();
            this.lbldayofweek = new System.Windows.Forms.Label();
            this.lblnameofmonth = new System.Windows.Forms.Label();
            this.lblnumberofday = new System.Windows.Forms.Label();
            this.lblyear = new System.Windows.Forms.Label();
            this.lbl_output = new System.Windows.Forms.Label();
            this.btn_show_data = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_day_of_week
            // 
            this.txt_day_of_week.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_day_of_week.Location = new System.Drawing.Point(423, 29);
            this.txt_day_of_week.Name = "txt_day_of_week";
            this.txt_day_of_week.Size = new System.Drawing.Size(381, 26);
            this.txt_day_of_week.TabIndex = 0;
            // 
            // txt_name_of_month
            // 
            this.txt_name_of_month.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_name_of_month.Location = new System.Drawing.Point(423, 72);
            this.txt_name_of_month.Name = "txt_name_of_month";
            this.txt_name_of_month.Size = new System.Drawing.Size(381, 26);
            this.txt_name_of_month.TabIndex = 0;
            // 
            // txt_number_of_day
            // 
            this.txt_number_of_day.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_number_of_day.Location = new System.Drawing.Point(423, 121);
            this.txt_number_of_day.Name = "txt_number_of_day";
            this.txt_number_of_day.Size = new System.Drawing.Size(381, 26);
            this.txt_number_of_day.TabIndex = 0;
            this.txt_number_of_day.TextChanged += new System.EventHandler(this.txt_number_of_day_TextChanged);
            // 
            // txt_year
            // 
            this.txt_year.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_year.Location = new System.Drawing.Point(423, 165);
            this.txt_year.Name = "txt_year";
            this.txt_year.Size = new System.Drawing.Size(381, 26);
            this.txt_year.TabIndex = 0;
            // 
            // lbldayofweek
            // 
            this.lbldayofweek.AutoSize = true;
            this.lbldayofweek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldayofweek.Location = new System.Drawing.Point(124, 30);
            this.lbldayofweek.Name = "lbldayofweek";
            this.lbldayofweek.Size = new System.Drawing.Size(220, 25);
            this.lbldayofweek.TabIndex = 1;
            this.lbldayofweek.Text = "Enter day of the week";
            // 
            // lblnameofmonth
            // 
            this.lblnameofmonth.AutoSize = true;
            this.lblnameofmonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnameofmonth.Location = new System.Drawing.Point(77, 73);
            this.lblnameofmonth.Name = "lblnameofmonth";
            this.lblnameofmonth.Size = new System.Drawing.Size(283, 25);
            this.lblnameofmonth.TabIndex = 1;
            this.lblnameofmonth.Text = "Enter the name of the month";
            // 
            // lblnumberofday
            // 
            this.lblnumberofday.AutoSize = true;
            this.lblnumberofday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumberofday.Location = new System.Drawing.Point(63, 122);
            this.lblnumberofday.Name = "lblnumberofday";
            this.lblnumberofday.Size = new System.Drawing.Size(311, 25);
            this.lblnumberofday.TabIndex = 1;
            this.lblnumberofday.Text = "Enter the numeric day of month";
            // 
            // lblyear
            // 
            this.lblyear.AutoSize = true;
            this.lblyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyear.Location = new System.Drawing.Point(197, 164);
            this.lblyear.Name = "lblyear";
            this.lblyear.Size = new System.Drawing.Size(147, 25);
            this.lblyear.TabIndex = 1;
            this.lblyear.Text = "Enter the year";
            // 
            // lbl_output
            // 
            this.lbl_output.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_output.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_output.Location = new System.Drawing.Point(82, 261);
            this.lbl_output.Name = "lbl_output";
            this.lbl_output.Size = new System.Drawing.Size(722, 66);
            this.lbl_output.TabIndex = 2;
            this.lbl_output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_show_data
            // 
            this.btn_show_data.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_show_data.Location = new System.Drawing.Point(82, 385);
            this.btn_show_data.Name = "btn_show_data";
            this.btn_show_data.Size = new System.Drawing.Size(179, 81);
            this.btn_show_data.TabIndex = 3;
            this.btn_show_data.Text = "show data";
            this.btn_show_data.UseVisualStyleBackColor = false;
            this.btn_show_data.Click += new System.EventHandler(this.btn_show_data_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_clear.Location = new System.Drawing.Point(366, 385);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(179, 81);
            this.btn_clear.TabIndex = 3;
            this.btn_clear.Text = "claer";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_close.Location = new System.Drawing.Point(639, 385);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(179, 81);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 530);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_show_data);
            this.Controls.Add(this.lbl_output);
            this.Controls.Add(this.lblyear);
            this.Controls.Add(this.lblnumberofday);
            this.Controls.Add(this.lblnameofmonth);
            this.Controls.Add(this.lbldayofweek);
            this.Controls.Add(this.txt_year);
            this.Controls.Add(this.txt_number_of_day);
            this.Controls.Add(this.txt_name_of_month);
            this.Controls.Add(this.txt_day_of_week);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_day_of_week;
        private System.Windows.Forms.TextBox txt_name_of_month;
        private System.Windows.Forms.TextBox txt_number_of_day;
        private System.Windows.Forms.TextBox txt_year;
        private System.Windows.Forms.Label lbldayofweek;
        private System.Windows.Forms.Label lblnameofmonth;
        private System.Windows.Forms.Label lblnumberofday;
        private System.Windows.Forms.Label lblyear;
        private System.Windows.Forms.Label lbl_output;
        private System.Windows.Forms.Button btn_show_data;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_close;
    }
}


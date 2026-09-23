using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace home_work1_ca242
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_show_data_Click(object sender, EventArgs e)
        {
            //stage1 of input
            //creating variables
            String day_of_the_week, name_of_the_month, full_date;
            int numeric_day, year;
            //initial values
            day_of_the_week = txt_day_of_week.Text;
            name_of_the_month = txt_name_of_month.Text;
            //type casting using parse
            numeric_day = int.Parse(txt_number_of_day.Text);
            year = int.Parse(txt_year.Text);
            //stage2 process concatination of full date
            full_date = day_of_the_week + "," + name_of_the_month + "," + numeric_day + "," + year;
            //stage3 the output using label
            lbl_output.Text = full_date;
        }

        private void txt_number_of_day_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            //clear textbox and label
            txt_day_of_week.Clear();
            txt_name_of_month.Text = "";
            txt_number_of_day.Text = string.Empty;
            txt_year.Clear();
            //clearing the output
            lbl_output.Text = "";

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            //form close using this keyword and close functinon
            this.Close();
        }
    }
}

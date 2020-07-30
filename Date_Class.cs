using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Date_Class
{
    public partial class Date_Class : Form
    {
        //decalring variables
        string date = null;
        string time = null;
        string dateTime = null;
        public Date_Class()
        {
            InitializeComponent();
        }

        private void dateEntry_DateChanged(object sender, DateRangeEventArgs e)
        {
            date = dateEntry.SelectionStart.ToShortDateString();
        }

        private void timeEntry_ValueChanged(object sender, EventArgs e)
        {
            time = timeEntry.Value.ToString("h:mm tt");
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (date == null && time == null)
            {
                errorMessageLbl.Visible = true;
                errorMessageLbl.Text = "Please select a date and time.";
            }
            else if (date == null)
            {
                errorMessageLbl.Visible = true;
                errorMessageLbl.Text = "Please select a date.";
            }
            else if (time == null)
            {
                errorMessageLbl.Visible = true;
                errorMessageLbl.Text = "Please select a time.";
            }
            else
            {
                errorMessageLbl.Visible = false;
                dateTime = $"{date} {time}";
            }
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            //WelcomePage wp = new WelcomePage();
            //wp.ShowDialog;
            this.Close();
        }
    }
}

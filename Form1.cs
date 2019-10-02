using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignSoftware
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            maskedTextBox1.Text = Convert.ToString(monthCalendar1.SelectionEnd);
        }

        

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void batata4(object sender, EventArgs e)
        {
            monthCalendar1.Hide();
        }

        private void batata3(object sender, EventArgs e)
        {
            monthCalendar1.Show();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            DateTime data;
            int month = 0, days = 0;

            data = Convert.ToDateTime(maskedTextBox1.Text);

            month = data.Month;
            days = data.Day;


            if ((month == 12) && (days >= 22) || (month == 1) && (days <= 20)) 
            {
                PictureBox1.Image = Properties.Resources.capricorn;

            }
            if ((month == 3) && (days >= 21) || (month == 4) && (days <= 20))
            {
                PictureBox1.Image = Properties.Resources.aries;

            }
            if ((month == 4) && (days >= 21) || (month == 5) && (days <= 20))
            {
                PictureBox1.Image = Properties.Resources.taurus;

            }
            if ((month == 5) && (days >= 21) || (month == 6) && (days <= 20))
            {
                PictureBox1.Image = Properties.Resources.gemini;

            }
            if ((month == 6) && (days >= 21) || (month == 7) && (days <= 22))
            {
                PictureBox1.Image = Properties.Resources.cancer;

            }
            if ((month == 7) && (days >= 23) || (month == 8) && (days <= 22))
            {
                PictureBox1.Image = Properties.Resources.lion;

            }
            if ((month == 8) && (days >= 23) || (month == 9) && (days <= 22))
            {
                PictureBox1.Image = Properties.Resources.virgo;

            }
            if ((month == 9) && (days >= 23) || (month == 10) && (days <= 22))
            {
                PictureBox1.Image = Properties.Resources.libra;

            }
            if ((month == 10) && (days >= 23) || (month == 11) && (days <= 21))
            {
                PictureBox1.Image = Properties.Resources.scorpio;

            }
            if ((month == 1) && (days >= 21) || (month == 2) && (days <= 18))
            {
                PictureBox1.Image = Properties.Resources.aquarius;

            }
            if ((month == 2) && (days >= 19) || (month == 3) && (days <= 20))
            {
                PictureBox1.Image = Properties.Resources.peixes;

            }
            if ((month == 11) && (days >= 22) || (month == 12) && (days <= 21))
            {
                PictureBox1.Image = Properties.Resources.sagittarius;

            }
        }
    }
}

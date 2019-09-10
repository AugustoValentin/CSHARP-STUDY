using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula_6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ProgressBar1_Click(object sender, EventArgs e)
        {
            
            
          }

        private void Form2_Load(object sender, EventArgs e)
        {
           



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
 
                if (ProgressBar1.Value < 99)
                {
                    ProgressBar1.Value += 1;
                }
            if (ProgressBar1.Value >= 100)
            {
                    FormPrincipal FormPrincipal = new FormPrincipal();
                    FormPrincipal.Show();
                    this.Hide();
                }
            }
    }
}

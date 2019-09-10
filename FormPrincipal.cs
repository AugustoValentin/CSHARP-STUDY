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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TelaLog Loguin = new TelaLog();
            Loguin.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolstbtWord_Click(object sender, EventArgs e)
        {
            processo.StartInfo.FileName = @"C:\Program Files\Microsoft Office\Office16\\WINWORD.Exe";
            processo.Start();
        }

        private void toolStripbtexcel_Click(object sender, EventArgs e)
        {
            processo.StartInfo.FileName = @"C:\Program Files\Microsoft Office\Office16\\EXCEL.Exe";
            processo.Start();
        }

        private void toolStripBtCalculadora_Click(object sender, EventArgs e)
        {
            processo.StartInfo.FileName = "calc.exe";
            processo.Start();
        }

        private void toolStripBtExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 formAbout = new AboutBox1();
            formAbout.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form1 novo = new Form1();
            novo.Show();
        }

        internal class Show
        {
        }
    }
}

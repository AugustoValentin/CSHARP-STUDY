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
    public partial class TelaLog : Form
    {
        public TelaLog()
        {
            InitializeComponent();
        }

        private void TelaLog_Load(object sender, EventArgs e)
        {
            FormPrincipal Menu = new FormPrincipal();
            Menu.Show();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if ((txtLog.Text == "ETEC" && txtSenha.Text == "123"))
            {
                Form2 Form2 = new Form2();
                Form2.Show();
                this.Close();
            }

            else
            {
                MessageBox.Show("Errou");
            }
            }
        }
    }


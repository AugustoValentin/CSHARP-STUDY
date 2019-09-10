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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdAdicionar_Click(object sender, EventArgs e)
        {
            lstBox.Items.Add(txtTexto.Text);
            txtTexto.Clear();
            txtTexto.Focus();
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
           if(lstBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Não tem item selecionado");
                }
            else
            {
                lstBox.Items.Remove(lstBox.SelectedItem);
            }
        }

        private void cmdLimparTodos_Click(object sender, EventArgs e)
        {
            lstBox.Items.Clear();
        }

        private void cmdLimpar_Click(object sender, EventArgs e)
        {
            txtTexto.Clear();
            lstBox.Items.Clear();
            lblPosLista.Text = "";
            lblTotal.Text = "";
            txtTexto.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstBox.SelectedIndex !=-1)
            {
                lblPosLista.Text = lstBox.SelectedIndex.ToString();
                lblTextoSel.Text = lstBox.SelectedItem.ToString();
                lblTotal.Text = lstBox.Items.Count.ToString();

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoMultForm
{
    public partial class Form3 : Form
    {

        Form4 cad_cliente = new Form4();  //Instaciamento a objeto 
        public Form3()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Sair do Programa
            if (MessageBox.Show("Deseja sair??", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cad_cliente.Show();
        }
    }
}

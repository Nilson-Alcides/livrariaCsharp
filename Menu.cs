using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livraria
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void AbrirFormNoPanel<Forms>() where Forms : Form, new()
        {
            Form formulario;
            formulario = pnl_conteudo.Controls.OfType<Forms>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new Forms();
                formulario.TopLevel = false;
                //formulario.FormBorderStyle = FormBorderStyle.None;
                //formulario.Dock = DockStyle.Fill;
                pnl_conteudo.Controls.Add(formulario);
                pnl_conteudo.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                if (formulario.WindowState == FormWindowState.Minimized)
                    formulario.WindowState = FormWindowState.Normal;
                formulario.BringToFront();
            }
        }




        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            DialogResult Resposta = MessageBox.Show("Deseja Sair", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resposta == DialogResult.Yes) { Application.Exit(); }

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Cliente>();
        }

        private void btn_maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btn_Livros_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Livros>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Produto>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Vendas>();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Pagamento>();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Relatorio>();
        }
    }
}

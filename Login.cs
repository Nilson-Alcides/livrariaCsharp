using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livraria
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_logar_Click(object sender, EventArgs e)
        {
            SqlConnection Con = Conexao.GetConexao();
            Con.Open();

            DataTable DT_login = new DataTable();
            SqlDataAdapter DA_login = new SqlDataAdapter("SELECT * FROM FUNCIONARIOS " +
                "where login_Func = @Funcionario and senha = @Senha ",Con);
            DA_login.SelectCommand.Parameters.AddWithValue("@Funcionario",txt_login.Text);
            DA_login.SelectCommand.Parameters.AddWithValue("@Senha",txt_senha.Text);
            DA_login.Fill(DT_login);

            if(DT_login.Rows.Count == 0)
            {
                MessageBox.Show("Usuário/Senha Inválidos");
            }
            else
            {
                Menu menu = new Menu();
                menu.Show();
                this.Hide();

                MessageBox.Show("Bem vindo a Livraria BG!!!!");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult Resposta = MessageBox.Show("Deseja Sair", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resposta == DialogResult.Yes) { Application.Exit(); }
        }
    }
}

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
    public partial class Produto : Form
    {
        SqlConnection Con = Conexao.GetConexao();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader rdr;
        public Produto()
        {
            InitializeComponent();
            cmd.Connection = Con;
            PreencheGrid();

        }
        public void PreencheGrid()
        {
            Con.Open();
            SqlDataAdapter Da = new SqlDataAdapter("", Con);

            Da.SelectCommand.CommandText = "SELECT PRODUTOS.cod_produto As Código, nome_produto as Nome, marca as Marca, valor as Valor, quantidade As Quantidade from PRODUTOS" +
                    " INNER JOIN ESTOQUE on PRODUTOS.cod_produto = ESTOQUE.cod_item_estoque";
            DataTable Dt = new DataTable();
            Da.Fill(Dt);
            dgvProduto.DataSource = Dt;
            Con.Close();
        }

        public void limpaCamposProduto()
        {
            txt_NomeProduto.Text = "";
            txt_MarcaProduto.Text = "";
            txt_ValorUnitarioProduto.Text = "";
            txtQuatidade.Text = "";
            txtCodigo.Text = "";
            txt_Pesquisa.Text = "";
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {

            Con.Open();
            SqlDataAdapter Da = new SqlDataAdapter("", Con);
            //Pesquisa Produto sem passar nenhum parametro
            if (txt_Pesquisa.Text == "")
            {
                Da.SelectCommand.CommandText = "SELECT PRODUTOS.cod_produto As Código, nome_produto as Nome, marca as Marca, valor as Valor, quantidade As Quantidade from PRODUTOS" +
                     " INNER JOIN ESTOQUE  on PRODUTOS.cod_produto = ESTOQUE.cod_item_estoque";
                DataTable Dt = new DataTable();
                Da.Fill(Dt);
                dgvProduto.DataSource = Dt;
                Con.Close();

            }
            //Pesquisa Produto pelo nome
            else
            {
                Da.SelectCommand.CommandText = "SELECT PRODUTOS.cod_produto as Código, PRODUTOS.nome_produto as Nome, marca as Marca, " +
                    "valor as Valor, quantidade as Quantidade from PRODUTOS INNER JOIN ESTOQUE on PRODUTOS.cod_produto = ESTOQUE.cod_item_estoque" +
                    " WHERE PRODUTOS.nome_produto like '%" + txt_Pesquisa.Text + "%' or PRODUTOS.cod_produto like '%" + txt_Pesquisa.Text + "%' ";
                DataTable Dt = new DataTable();
                Da.Fill(Dt);
                dgvProduto.DataSource = Dt;
                Con.Close();
                btn_Cadastrar.Enabled = false;
            }
             
        }
               
        private void dgvProduto_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string strRowNumber = (e.RowIndex + 1).ToString();
            SizeF size = e.Graphics.MeasureString(strRowNumber, this.Font);
            if (dgvProduto.RowHeadersWidth < Convert.ToInt32((size.Width + 20)))
            {
                dgvProduto.RowHeadersWidth = Convert.ToInt32((size.Width + 20));
            }
            Brush b = SystemBrushes.ControlText;
            e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
        }

        private void dgvProduto_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dr = dgvProduto.SelectedRows[0];
            txtCodigo.Text = dr.Cells[0].Value.ToString();
            txt_NomeProduto.Text = dr.Cells[1].Value.ToString();
            txt_MarcaProduto.Text = dr.Cells[2].Value.ToString();
            txt_ValorUnitarioProduto.Text = dr.Cells[3].Value.ToString();
            txtQuatidade.Text = dr.Cells[4].Value.ToString();
            txt_NomeProduto.Focus();
            btn_Cadastrar.Enabled = false;
            btn_Atualizar.Enabled = true;
        }

        private void txt_ValorUnitarioProduto_Leave(object sender, EventArgs e)
        {
            if (txt_ValorUnitarioProduto.Text != "")
            {
                txt_ValorUnitarioProduto.Text = Convert.ToDouble(txt_ValorUnitarioProduto.Text).ToString("F");
            }
            else
            {
                MessageBox.Show("Favor informar um valor!");
                return;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpaCamposProduto();
            btn_Cadastrar.Enabled = true;
            btn_Atualizar.Enabled = false;
            btn_Deletar.Enabled = false;
        }

        private void btn_Deletar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                // Initializes the variables to pass to the MessageBox.Show method.

                string message = "Deseja realmente deletar o Produto " + txt_NomeProduto.Text + "?";
                string caption = "Deleta Produto";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.

                result = MessageBox.Show(this, message, caption, buttons,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign);

                if (result == DialogResult.No)
                {
                    //retorna a tela caso desista de deletar
                    return;
                }

                if (result == DialogResult.Yes)
                {

                    //Deleta produto consultados por CPF
                    SqlConnection Con = Conexao.GetConexao();
                    Con.Open();

                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = Con;
                        command.CommandText = "delete from ESTOQUE " +
                                              "where cod_item_estoque = @cod_produto";

                        command.Parameters.AddWithValue("@cod_produto", txtCodigo.Text);

                        command.ExecuteNonQuery();

                        MessageBox.Show("produto deletado com Sucesso!");
                    }

                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = Con;
                        command.CommandText = "delete from produtos " +
                                              "where cod_produto = @cod_produto";

                        command.Parameters.AddWithValue("@cod_produto", txtCodigo.Text);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Produto deletado com Sucesso!");
                    }

                    Con.Close();

                }


            }
            else
            {
                MessageBox.Show("Consulte produto antes de deletar");
            }
        }

        private void btn_Cadastrar_Click_1(object sender, EventArgs e)
        {
            string cod_produto;
            //Validando os campos vazio

            if (txt_NomeProduto.Text == "")
            {
                MessageBox.Show("Por favor informe o Nome");
                txt_NomeProduto.Focus();
                return;
            }
            if (txt_MarcaProduto.Text == "")
            {
                MessageBox.Show("Por favor informe a marca");
                txt_MarcaProduto.Focus();
                return;
            }
            if (txt_ValorUnitarioProduto.Text == "")
            {
                MessageBox.Show("Pro favor informe o valor do produto");
                txt_ValorUnitarioProduto.Focus();
                return;
            }
            if (txtQuatidade.Text == "")
            {
                MessageBox.Show("Pro favor informe a quantidae do produto");
                txtQuatidade.Focus();
                return;
            }
            // Insere o produto
            Con.Open();

            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = Con;
                command.CommandText = "INSERT INTO PRODUTOS(nome_produto, marca,valor) " +
                    "output  INSERTED.cod_produto " +
                    "values(@nome_produto, @marca, @valor); ";

                command.Parameters.AddWithValue("@nome_produto", txt_NomeProduto.Text);
                command.Parameters.AddWithValue("@marca", txt_MarcaProduto.Text);
                command.Parameters.AddWithValue("@valor", txt_ValorUnitarioProduto.Text.Replace(",", "."));

                cod_produto = Convert.ToString(command.ExecuteScalar());
            }

            using (SqlCommand command = new SqlCommand())
            {

                command.Connection = Con;
                command.CommandText = "INSERT INTO ESTOQUE(cod_item_estoque, quantidade) " +
                    "values(@cod_produto, @Qtd_estoque);";

                command.Parameters.AddWithValue("@cod_produto", cod_produto);
                command.Parameters.AddWithValue("@Qtd_estoque", txtQuatidade.Text);

                command.ExecuteNonQuery();
            }
            Con.Close();

            //limpar campos
            limpaCamposProduto();

            MessageBox.Show("Produto Cadastrado com Sucesso");
            return;
        }

        private void btn_Atualizar_Click_1(object sender, EventArgs e)
        {
            string cod_produto;
            //Validando os campos vazio
            if (txt_NomeProduto.Text == "")
            {
                MessageBox.Show("Por favor informe o Nome");
                txt_NomeProduto.Focus();
                return;
            }
            if (txt_MarcaProduto.Text == "")
            {
                MessageBox.Show("Por favor informe a marca");
                txt_MarcaProduto.Focus();
                return;
            }
            if (txt_ValorUnitarioProduto.Text == "")
            {
                MessageBox.Show("Pro favor informe o valor do produto");
                txt_ValorUnitarioProduto.Focus();
                return;
            }
            Con.Open();
            // Atualiza produto
            using (SqlCommand command = new SqlCommand())
            {
               
                command.Connection = Con;
                command.CommandText = "UPDATE PRODUTOS SET nome_produto = @nome_produto, " +
                    "marca = @marca, valor = @valor " +
                    "where cod_produto = @cod_produto; ";

                command.Parameters.AddWithValue("@cod_produto", txtCodigo.Text);
                command.Parameters.AddWithValue("@nome_produto", txt_NomeProduto.Text);
                command.Parameters.AddWithValue("@marca", txt_MarcaProduto.Text);
                command.Parameters.AddWithValue("@valor", txt_ValorUnitarioProduto.Text.Replace(",", "."));


                cod_produto = Convert.ToString(command.ExecuteScalar());
            }
            using (SqlCommand command = new SqlCommand())
            {
            command.Connection = Con;
            command.CommandText = "UPDATE ESTOQUE SET quantidade = @quantidade " +
                "where cod_item_estoque = @cod_item_estoque; ";

            command.Parameters.AddWithValue("@cod_item_estoque", txtCodigo.Text);
            command.Parameters.AddWithValue("@quantidade", txtQuatidade.Text);
            command.ExecuteNonQuery();
            }
            Con.Close();
            //limpar campos
            limpaCamposProduto();
            MessageBox.Show("Produto atualizado com Sucesso");
            return;
        }

        private void txt_ValorUnitarioProduto_Enter_1(object sender, EventArgs e)
        {
            String x = "";
            for (int i = 0; i <= txt_ValorUnitarioProduto.Text.Length - 1; i++)
            {
                if ((txt_ValorUnitarioProduto.Text[i] >= '0' &&
                    txt_ValorUnitarioProduto.Text[i] <= '9') ||
                    txt_ValorUnitarioProduto.Text[i] == ',')
                {
                    x += txt_ValorUnitarioProduto.Text[i];
                }
            }
            txt_ValorUnitarioProduto.Text = x;
            txt_ValorUnitarioProduto.SelectAll();
        }

        private void txt_ValorUnitarioProduto_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
                       (e.KeyChar != ',' && e.KeyChar != '.' &&
                        e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txt_ValorUnitarioProduto.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }
    }
}

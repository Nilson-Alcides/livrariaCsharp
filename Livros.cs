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
    public partial class Livros : Form
    {
        SqlConnection Con = Conexao.GetConexao();
        SqlCommand cmd = new SqlCommand();

        public Livros()
        {
            InitializeComponent();
            cmd.Connection = Con;
            PreencheGrid();
            Carrega_categorias();
        }
        public void LimpaCapos()
        {
            txt_Titulo.Text = "";
            txt_Autor.Text = "";
            txt_Editora.Text = "";
            txt_ISBN.Text = "";
            cmb_Categoria.Text = "";
            txt_qtd_estoque.Value = 0;
            txtValor.Text = "";
        }
        public void validaCampos()
        {
            

        }
        private void Carrega_categorias()
        {
            using (SqlCommand command = new SqlCommand())
            {
                Con.Open();
                command.Connection = Con;
                command.CommandText = "select * from categoria";
                

                SqlDataReader sqlDataReader = null;
                sqlDataReader = command.ExecuteReader();

                DataTable tb_categoria = new DataTable();

                tb_categoria.Load(sqlDataReader);

                cmb_Categoria.DisplayMember = "nome_categoria";
                cmb_Categoria.ValueMember = "cod_categoria";
                cmb_Categoria.DataSource = tb_categoria;
                Con.Close();
            }
        }


        public void PreencheGrid()
        {
            Con.Open();
            SqlDataAdapter Da = new SqlDataAdapter("", Con);

            Da.SelectCommand.CommandText = "SELECT LIVRO.cod_livro as Código,LIVRO.nome_livro as Nome,LIVRO.autor as Autor," +
                "LIVRO.editora as Editora,LIVRO.ISBN,CATEGORIA.nome_categoria as Categoria," +
                "ESTOQUE.quantidade as Quantidade,LIVRO.valor as Valor from LIVRO " +
                "inner JOIN ESTOQUE ON LIVRO.cod_livro = ESTOQUE.cod_item_estoque " +
                "inner JOIN CATEGORIA ON LIVRO.cod_categoria = CATEGORIA.cod_categoria";
            DataTable Dt = new DataTable();
            Da.Fill(Dt);
            dgvLivro.DataSource = Dt;
            Con.Close();
        }


        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            if (txt_Titulo.Text == "")
            {
                MessageBox.Show("por favor informe o Titulo");
                txt_Titulo.Focus();
                return;
            }
            if (txt_Autor.Text == "")
            {
                MessageBox.Show("por favor informe o autor");
                txt_Autor.Focus();
                return;
            }
            if (txt_Editora.Text == "")
            {
                MessageBox.Show("por favor informe a editora");
                txt_Editora.Focus();
                return;
            }
            if (txt_ISBN.Text == "")
            {
                MessageBox.Show("por favor informe o ISBN");
                txt_ISBN.Focus();
                return;
            }
            if (cmb_Categoria.Text == "")
            {
                MessageBox.Show("por favor informe uma Categoria");
                cmb_Categoria.Focus();
                return;
            }
            if (txt_qtd_estoque.Value == 0)
            {
                MessageBox.Show("por favor informe um numero maior que zero");
                txt_qtd_estoque.Focus();
                return;
            }

            if (txtValor.Text == "")
            {
                MessageBox.Show("por favor informe o valor");
                txtValor.Focus();
                return;
            }
            try
            {
                
                Con.Open();
                string cod_livro;

                using (SqlCommand command = new SqlCommand())
                {

                    command.Connection = Con;
                    command.CommandText = "Insert into Livro(nome_livro, autor,editora,valor,cod_categoria, ISBN) " +
                        "output INSERTED.cod_livro " +
                        "values(@nome_livro, @autor,@editora,@valor,@cod_categoria,@ISBN);";

                    command.Parameters.AddWithValue("@nome_livro", txt_Titulo.Text);
                    command.Parameters.AddWithValue("@autor", txt_Autor.Text);
                    command.Parameters.AddWithValue("@editora", txt_Editora.Text);
                    command.Parameters.AddWithValue("@valor", txtValor.Text.Replace(',','.'));
                    command.Parameters.AddWithValue("@cod_categoria", cmb_Categoria.SelectedValue);
                    command.Parameters.AddWithValue("@ISBN", txt_ISBN.Text);
                   

                    cod_livro = Convert.ToString(command.ExecuteScalar());

                }

                using ( SqlCommand command = new SqlCommand())
                {

                    command.Connection = Con;
                    command.CommandText = "INSERT INTO ESTOQUE(cod_item_estoque, quantidade) " +
                        "values(@cod_livro, @Qtd_estoque);";

                    command.Parameters.AddWithValue("@cod_livro", cod_livro);
                    command.Parameters.AddWithValue("@Qtd_estoque", txt_qtd_estoque.Text);
                    command.ExecuteNonQuery();
                    LimpaCapos();
                }
                Con.Close();
                MessageBox.Show("Livro Cadastrado com Sucesso");
                PreencheGrid();
                return;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cmb_Categoria_SelectedIndexChanged_1(object sender, EventArgs e)
        {

  

            
            
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {

            Con.Open();
            SqlDataAdapter Da = new SqlDataAdapter("", Con);
            //Pesquisa Produto sem passar nenhum parametro
            if (txtPesquisa.Text == "")
            {
                Da.SelectCommand.CommandText = "SELECT LIVRO.cod_livro as Código,LIVRO.nome_livro as Nome,LIVRO.autor as Autor," +
                 "LIVRO.editora as Editora,LIVRO.ISBN,CATEGORIA.nome_categoria as Categoria," +
                 "ESTOQUE.quantidade as Quantidade,LIVRO.valor as Valor from LIVRO " +
                 "inner JOIN ESTOQUE ON LIVRO.cod_livro = ESTOQUE.cod_item_estoque " +
                 "inner JOIN CATEGORIA ON LIVRO.cod_categoria = CATEGORIA.cod_categoria";
                DataTable Dt = new DataTable();
                Da.Fill(Dt);
                dgvLivro.DataSource = Dt;
                Con.Close();

            }
            //Pesquisa Produto pelo nome
            else
            {
                Da.SelectCommand.CommandText = "SELECT LIVRO.cod_livro as Código,LIVRO.nome_livro as Nome,LIVRO.autor as Autor," +
                 "LIVRO.editora as Editora,LIVRO.ISBN,CATEGORIA.nome_categoria as Categoria," +
                 "ESTOQUE.quantidade as Quantidade,LIVRO.valor as Valor from LIVRO " +
                 "inner JOIN ESTOQUE ON LIVRO.cod_livro = ESTOQUE.cod_item_estoque " +
                 "inner JOIN CATEGORIA ON LIVRO.cod_categoria = CATEGORIA.cod_categoria " +
                 "WHERE LIVRO.nome_livro like '%" + txtPesquisa.Text + "%' or LIVRO.cod_livro like '%" + txtPesquisa.Text + "%' ";

                DataTable Dt = new DataTable();
                Da.Fill(Dt);
                dgvLivro.DataSource = Dt;
                Con.Close();
            }
           
        }

        private void dgvLivro_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string strRowNumber = (e.RowIndex + 1).ToString();
            SizeF size = e.Graphics.MeasureString(strRowNumber, this.Font);
            if (dgvLivro.RowHeadersWidth < Convert.ToInt32((size.Width + 20)))
            {
                dgvLivro.RowHeadersWidth = Convert.ToInt32((size.Width + 20));
            }
            Brush b = SystemBrushes.ControlText;
            e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
        }

        private void dgvLivro_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dr = dgvLivro.SelectedRows[0];
            lblCodigo.Text = dr.Cells[0].Value.ToString();
            txt_Titulo.Text = dr.Cells[1].Value.ToString();
            txt_Autor.Text = dr.Cells[2].Value.ToString();
            txt_Editora.Text = dr.Cells[3].Value.ToString();
            txt_ISBN.Text = dr.Cells[4].Value.ToString();
            cmb_Categoria.Text = dr.Cells[5].Value.ToString();
            txt_qtd_estoque.Text = dr.Cells[6].Value.ToString();
            txtValor.Text = dr.Cells[7].Value.ToString();
            btn_Cadastrar.Enabled = false;
            btn_Atualizar.Enabled = true;
            btn_Deletar.Enabled = true;
            //cmb_Categoria.Enabled = false;
        }

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            string cod_livro;
            Con.Open();

            using (SqlCommand command = new SqlCommand())
            {
                
                command.Connection = Con;
                command.CommandText = "UPDATE LIVRO SET nome_livro = @nome_livro, " +
                    "autor = @autor, editora = @editora, ISBN = @ISBN, valor = @valor, cod_categoria = @cod_categoria " +
                    "where cod_livro = @cod_livro; ";

                command.Parameters.AddWithValue("@cod_livro", lblCodigo.Text);
                command.Parameters.AddWithValue("@nome_livro", txt_Titulo.Text);
                command.Parameters.AddWithValue("@autor", txt_Autor.Text);
                command.Parameters.AddWithValue("@editora", txt_Editora.Text);
                command.Parameters.AddWithValue("@ISBN", txt_ISBN.Text);
                command.Parameters.AddWithValue("@valor", txtValor.Text.Replace(',', '.'));
                command.Parameters.AddWithValue("@cod_categoria", cmb_Categoria.SelectedValue);
                
                cod_livro = Convert.ToString(command.ExecuteScalar());
            }
            
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = Con;
                command.CommandText = "UPDATE ESTOQUE SET quantidade = @quantidade " +
                    "where cod_item_estoque = @cod_item_estoque; ";

                command.Parameters.AddWithValue("@cod_item_estoque", lblCodigo.Text);
                command.Parameters.AddWithValue("@quantidade", txt_qtd_estoque.Text);
                command.ExecuteNonQuery();
            }
            Con.Close();
            //limpar campos
            LimpaCapos();
            MessageBox.Show("Livro atualizado com Sucesso");
            return;

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaCapos();
            txtPesquisa.Text = "";
            btn_Cadastrar.Enabled = true;
            btn_Atualizar.Enabled = false;
            btn_Deletar.Enabled = false;
        }

        private void btn_Deletar_Click(object sender, EventArgs e)
        {
            if (lblCodigo.Text != "")
            {
                // Initializes the variables to pass to the MessageBox.Show method.

                string message = "Deseja realmente deletar o Livro " + txt_Titulo.Text + "?";
                string caption = "Deleta Livro";
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
                                              "where cod_item_estoque = @cod_livro";

                        command.Parameters.AddWithValue("@cod_livro", lblCodigo.Text);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Livro deletado com Sucesso!");
                    }

                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = Con;
                        command.CommandText = "delete from livro " +
                                              "where cod_livro = @cod_livro";

                        command.Parameters.AddWithValue("@cod_livro", lblCodigo.Text);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Livro deletado com Sucesso!");
                        LimpaCapos();
                        PreencheGrid();
                    }

                    Con.Close();

                }


            }
            else
            {
                MessageBox.Show("Consulte Livro antes de deletar");
            }
        }
    }
}

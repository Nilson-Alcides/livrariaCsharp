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
    public partial class Vendas : Form
    {
        public Vendas()
        {
            InitializeComponent();


        }
        SqlConnection Con = Conexao.GetConexao();

        private void btn_consulta_Click(object sender, EventArgs e)
        {
            if (rb_produtos.Checked)
            {
                //faz a busca de produtos
                Con.Open();
                SqlDataAdapter Da = new SqlDataAdapter("select cod_produto as 'Código',nome_produto as Nome,marca,Valor," +
                    "Quantidade from PRODUTOS P inner join ESTOQUE E on E.cod_item_estoque = P.cod_produto " +
                    "where P.nome_produto like '%" + txt_busca_item.Text + "%' or P.cod_produto like '%" + txt_busca_item.Text + "%'", Con);


                DataTable Dt = new DataTable();
                Da.Fill(Dt);
                gv_seleciona_items.DataSource = Dt;
                Con.Close();
            }

            if (rb_livros.Checked)
            {
                //faz a busca de livros
                Con.Open();
                SqlDataAdapter Da = new SqlDataAdapter("SELECT l.cod_livro as Código,l.nome_livro as Nome,l.autor as Autor, " +
                    "l.editora as Editora,l.ISBN,c.nome_categoria as Categoria,e.quantidade as Quantidade, " +
                    "l.valor as Valor from LIVRO l inner JOIN ESTOQUE e ON l.cod_livro = e.cod_item_estoque " +
                    "inner JOIN CATEGORIA c ON l.cod_categoria = c.cod_categoria " +
                    "where l.nome_livro like '%" + txt_busca_item.Text + "%' or l.cod_livro like '%" + txt_busca_item.Text + "%'", Con);


                DataTable Dt = new DataTable();
                Da.Fill(Dt);
                gv_seleciona_items.DataSource = Dt;
                Con.Close();
            }
        }

        private void gv_visualiza_items_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void cod_item_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gv_seleciona_items.SelectedCells.Count > 0)
            {
                int selectedrowindex = gv_seleciona_items.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = gv_seleciona_items.Rows[selectedrowindex];
                lbl_cod_item.Text = Convert.ToString(selectedRow.Cells["Código"].Value);
                txt_item.Text = Convert.ToString(selectedRow.Cells["Nome"].Value);
                txt_preco_unit.Text = Convert.ToString(selectedRow.Cells["Valor"].Value);
                txt_qtd_disponivel.Text = Convert.ToString(selectedRow.Cells["Quantidade"].Value);
                txt_qtd_item.Text = "0";
                txt_valor_total.Text = "0";

            }
        }

        private void txt_qtd_item_TextChanged(object sender, EventArgs e)
        {
            if (txt_qtd_item.Text != "")
            {
                
                int selectedrowindex = gv_seleciona_items.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = gv_seleciona_items.Rows[selectedrowindex];

                txt_qtd_disponivel.Text = Convert.ToString(selectedRow.Cells["Quantidade"].Value);

                int qtd = Convert.ToInt32(txt_qtd_disponivel.Text) - Convert.ToInt32(txt_qtd_item.Text);
                double valor_total = Convert.ToInt32(txt_qtd_item.Text) * Convert.ToDouble(txt_preco_unit.Text);

                txt_qtd_disponivel.Text = Convert.ToString(qtd);
                txt_valor_total.Text = Convert.ToString(valor_total);
            }
            else
            {
                int selectedrowindex = gv_seleciona_items.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = gv_seleciona_items.Rows[selectedrowindex];

                txt_qtd_disponivel.Text = Convert.ToString(selectedRow.Cells["Quantidade"].Value);
                txt_valor_total.Text = "";
            }


        }

        private void valida_inclui_pedido()
        {
            if (txt_qtd_item.Text == "" || txt_qtd_item.Text == "0")
            {
                MessageBox.Show("Selecione a Qtde de items a serem comprados");
            }


            
        }

        private void btn_incluir_Click(object sender, EventArgs e)
        {
            valida_inclui_pedido();

            if (Convert.ToInt32(txt_qtd_disponivel.Text) < 0)
            {
                MessageBox.Show("Quantidade selecionada maior que o estoque");
                return;
            }


            foreach (DataGridViewRow row2 in gv_carrinho.Rows)
            {
                if (row2.Cells["Id_Item"].Value != null)
                {
                    if (row2.Cells["Id_Item"].Value.ToString() == lbl_cod_item.Text)
                    {
                        MessageBox.Show("Ja existe esse item no carrinho!");
                        return;
                    }
                }
            }


            int rowId = gv_carrinho.Rows.Add();


            DataGridViewRow row = gv_carrinho.Rows[rowId];


            row.Cells["Id_Item"].Value = lbl_cod_item.Text;
            row.Cells["Nome"].Value = txt_item.Text;
            row.Cells["Qtde"].Value = txt_qtd_item.Text;
            row.Cells["Valor_Unitario"].Value = txt_preco_unit.Text;
            row.Cells["Valor_Total"].Value = txt_valor_total.Text;
            row.Cells["delete_item"].Value = "X";



        }

        private void gv_carrinho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == gv_carrinho.Columns["delete_item"].Index)
            {
                int row = gv_carrinho.CurrentCell.RowIndex;
                gv_carrinho.Rows.RemoveAt(row);

            }
        }

        private void validacampos()
        {
            if (lbl_id_cliente_venda.Text == "")
            {
                MessageBox.Show("Selecione o Cliente antes de finalizar o pedido!");
                return;
            }

            if (gv_carrinho.Rows.Count == 0)
            {
                MessageBox.Show("Selecione os produtos antes finaliza o pedido");
                return;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            validacampos();
            int id_venda;

            Con.Open();

            DataTable Dt_id_venda = new DataTable();
            SqlDataAdapter DA_id_venda = new SqlDataAdapter("select isnull(max(id_venda),0) id_venda from VENDA", Con);


            DA_id_venda.Fill(Dt_id_venda);
            id_venda = Convert.ToInt32(Dt_id_venda.Rows[0]["id_venda"].ToString());

            for (int i = 0; i < gv_carrinho.Rows.Count; i++)
            {
                if (gv_carrinho.Rows[i].Cells["Id_Item"].Value != null)
                {
                    using (SqlCommand command = new SqlCommand())
                    {

                        command.Connection = Con;
                        command.CommandText = "Insert into venda(id_venda, id_item_venda,cod_cliente,data_venda,quantidade,valor_unitario,valor_total) " +
                            "values(@id_venda, @id_item_venda,@cod_cliente,getdate(),@quantidade,@valor_unitario,@valor_total);";

                        command.Parameters.AddWithValue("@id_venda", id_venda + 1);
                        command.Parameters.AddWithValue("@id_item_venda", gv_carrinho.Rows[i].Cells["Id_Item"].Value);
                        command.Parameters.AddWithValue("@cod_cliente", lbl_id_cliente_venda.Text);
                        command.Parameters.AddWithValue("@valor_unitario", gv_carrinho.Rows[i].Cells["Valor_Unitario"].Value);
                        command.Parameters.AddWithValue("@valor_total", gv_carrinho.Rows[i].Cells["Valor_Total"].Value);
                        command.Parameters.AddWithValue("@quantidade", gv_carrinho.Rows[i].Cells["Qtde"].Value);
                        command.ExecuteNonQuery();

                    }

                    using (SqlCommand command = new SqlCommand())
                    {

                        command.Connection = Con;
                        command.CommandText = "update ESTOQUE set quantidade = quantidade - @quantidade where cod_item_estoque = @id_item_venda";
                        command.Parameters.AddWithValue("@id_item_venda", gv_carrinho.Rows[i].Cells["Id_Item"].Value);
                        command.Parameters.AddWithValue("@quantidade", gv_carrinho.Rows[i].Cells["Qtde"].Value);
                        command.ExecuteNonQuery();

                    }




                }


            }
            using (SqlCommand command = new SqlCommand())
            {

                command.Connection = Con;
                command.CommandText = "Insert into pagamento(id_venda, pago) " +
                    "values(@id_venda, @pago);";

                command.Parameters.AddWithValue("@id_venda", id_venda + 1);

                command.Parameters.AddWithValue("@pago", "N");
                command.ExecuteNonQuery();

            }

            Con.Close();
            MessageBox.Show("Pedido Realizado com sucesso!");

        }


        private void txt_busca_cliente_venda_TextChanged(object sender, EventArgs e)
        {
            SqlConnection Con = Conexao.GetConexao();
            Con.Open();


            DataTable Dt_Cliente = new DataTable();
            SqlDataAdapter DA_Cliente = new SqlDataAdapter("SELECT c.cod_cliente,cpf_cliente as CPF,nome_cliente as Nome_cliente,email " +
                                                           "FROM CLIENTE c where c.CPF_Cliente like '%" + txt_busca_cliente_venda.Text + "%' " +
                                                           "or nome_cliente like '%" + txt_busca_cliente_venda.Text + "%'", Con);

            DA_Cliente.Fill(Dt_Cliente);
            Con.Close();

            gv_cliente_venda.DataSource = Dt_Cliente;

        }

        private void gv_cliente_venda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gv_cliente_venda.SelectedCells.Count > 0)
            {
                int selectedrowindex = gv_cliente_venda.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = gv_cliente_venda.Rows[selectedrowindex];
                lbl_id_cliente_venda.Text = Convert.ToString(selectedRow.Cells["cod_cliente"].Value);


            }
        }
    }
}

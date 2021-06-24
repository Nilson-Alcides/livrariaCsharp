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
    
    public partial class Relatorio : Form
    {
        SqlConnection Con = Conexao.GetConexao();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader rdr;
        public Relatorio()
        {
            InitializeComponent();
            cmd.Connection = Con;
            
        }
        public void PreencheGridProduto()
        {
            Con.Open();
            SqlDataAdapter Da = new SqlDataAdapter("", Con);

            Da.SelectCommand.CommandText = "select VENDA.id_item_venda as Código,PRODUTOS.nome_produto as Produto," +
                "VENDA.quantidade as Quatidade,VENDA.valor_unitario as Valor,VENDA.valor_total as Total," +
                "PAGAMENTO.tipo_pagamento as Pagamento,PAGAMENTO.valor_pago as ValorPago," +
                "PAGAMENTO.parcelas as Parcelas,PAGAMENTO.Pago,CLIENTE.nome_cliente as Nome," +
                "CLIENTE.cpf_cliente as CPF, VENDA.data_venda as Data from CLIENTE " +
                "inner join VENDA on CLIENTE.cod_cliente = VENDA.cod_cliente " +
                "inner join PRODUTOS on PRODUTOS.cod_produto = VENDA.id_item_venda " +
                "inner join PAGAMENTO on PAGAMENTO.id_venda = VENDA.id_venda where Pago = 's'";
            DataTable Dt = new DataTable();
            Da.Fill(Dt);
            dgvClientes.DataSource = Dt;
            Con.Close();
        }
        public void PreencheGridLivro()
        {
            Con.Open();
            SqlDataAdapter Da = new SqlDataAdapter("", Con);

            Da.SelectCommand.CommandText = "select VENDA.id_item_venda as Código,LIVRO.nome_livro as Livro," +
                "LIVRO.editora as Editora,VENDA.quantidade as Quatidade,VENDA.valor_unitario as Valor," +
                "VENDA.valor_total as Total,PAGAMENTO.tipo_pagamento as Pagamento," +
                "PAGAMENTO.valor_pago as ValorPago,PAGAMENTO.parcelas as Parcelas,PAGAMENTO.Pago," +
                "CLIENTE.nome_cliente as Nome,CLIENTE.cpf_cliente as CPF,VENDA.data_venda from CLIENTE" +
                " inner join VENDA on CLIENTE.cod_cliente = VENDA.cod_cliente " +
                "inner join LIVRO on LIVRO.cod_livro = VENDA.id_item_venda " +
                "inner join PAGAMENTO on PAGAMENTO.id_venda = VENDA.id_venda where Pago = 's'";
            DataTable Dt = new DataTable();
            Da.Fill(Dt);
            dgvClientes.DataSource = Dt;
            Con.Close();
        }

        private void btn_consulta_Click(object sender, EventArgs e)
        {
            if(rb_produtos.Checked == true)
            {
                dgvClientes.DataSource = null;
                dgvClientes.Rows.Clear();
                PreencheGridProduto();
            }
            if (rb_livros.Checked == true)
            {
                dgvClientes.DataSource = null;
                dgvClientes.Rows.Clear();
                PreencheGridLivro();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime DataInicial;
            DateTime DataFinal;

            DataInicial = Convert.ToDateTime(txt_data_Inicio.Text);
            DataFinal = Convert.ToDateTime(txt_data_Final.Text);

            Con.Open();
            SqlDataAdapter Da = new SqlDataAdapter("", Con);

            Da.SelectCommand.CommandText = "select VENDA.id_item_venda as Código,LIVRO.nome_livro as Livro," +
                "LIVRO.editora as Editora,VENDA.quantidade as Quatidade,VENDA.valor_unitario as Valor," +
                "VENDA.valor_total as Total,PAGAMENTO.tipo_pagamento as Pagamento," +
                "PAGAMENTO.valor_pago as ValorPago,PAGAMENTO.parcelas as Parcelas,PAGAMENTO.Pago," +
                "CLIENTE.nome_cliente as Nome,CLIENTE.cpf_cliente as CPF,VENDA.data_venda from CLIENTE" +
                " inner join VENDA on CLIENTE.cod_cliente = VENDA.cod_cliente " +
                "inner join LIVRO on LIVRO.cod_livro = VENDA.id_item_venda " +
                "inner join PAGAMENTO on PAGAMENTO.id_venda = VENDA.id_venda where Pago = 's' and " +
                //"VENDA.data_venda = '" + DataInicial + "' AND VENDA.data_venda = '" + DataFinal + "' ";
               "convert(date,VENDA.data_venda) >= convert(date,'" + DataInicial + "',103) and convert(date,VENDA.data_venda) <= convert(date,'" + DataFinal + "',103)";

            DataTable Dt = new DataTable();
            Da.Fill(Dt);
            dgvClientes.DataSource = Dt;
            Con.Close();

        }
    }
}

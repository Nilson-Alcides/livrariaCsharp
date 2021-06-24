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
    public partial class Pagamento : Form
    {
        public Pagamento()
        {
            InitializeComponent();
            SqlConnection Con = Conexao.GetConexao();

            Con.Open();
            SqlDataAdapter Da = new SqlDataAdapter("select p.cod_pagamento,sum(v.valor_total) as Valor_Total_Produtos,c.cod_cliente,c.cpf_cliente, " +
                                                   "ce.id_endereco,c.nome_cliente as Cliente from PAGAMENTO p " +
                                                   "inner join VENDA v on v.id_venda = p.id_venda " +
                                                   "inner join CLIENTE c on c.cod_cliente = v.cod_cliente " +
                                                   "inner join cliente_endereco ce on ce.cod_cliente = c.cod_cliente" +
                                                   " where p.Pago = 'N'" +
                                                   " group by cod_pagamento,cpf_cliente,nome_cliente,c.cod_cliente, ce.id_endereco ", Con);


            DataTable Dt = new DataTable();
            Da.Fill(Dt);
            gv_pedidos_pgto.DataSource = Dt;
            Con.Close();
            gv_pedidos_pgto.Columns["cod_cliente"].Visible = false;
            gv_pedidos_pgto.Columns["id_endereco"].Visible = false;
        }
        SqlConnection Con = Conexao.GetConexao();


        private void recarrega_grid_pgto_pendente()
        {

            SqlConnection Con = Conexao.GetConexao();

            Con.Open();
            SqlDataAdapter Da = new SqlDataAdapter("select p.cod_pagamento,sum(v.valor_total) as Valor_Total_Produtos,c.cod_cliente,c.cpf_cliente, " +
                                                   "ce.id_endereco,c.nome_cliente as nome_cliente from PAGAMENTO p " +
                                                   "inner join VENDA v on v.id_venda = p.id_venda " +
                                                   "inner join CLIENTE c on c.cod_cliente = v.cod_cliente " +
                                                   "inner join cliente_endereco ce on ce.cod_cliente = c.cod_cliente" +
                                                   " where p.Pago = 'N'" +
                                                   " group by cod_pagamento,cpf_cliente,nome_cliente,c.cod_cliente, ce.id_endereco ", Con);


            DataTable Dt = new DataTable();
            Da.Fill(Dt);
            gv_pedidos_pgto.DataSource = Dt;
            Con.Close();
            gv_pedidos_pgto.Columns["cod_cliente"].Visible = false;
            gv_pedidos_pgto.Columns["id_endereco"].Visible = false;
        }

        private void btn_finaliza_pgto_Click(object sender, EventArgs e)
        {
            string cod_delivery;
            if (rd_delivery_S.Checked == true)
            {
                Con.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = Con;
                    command.CommandText = "INSERT INTO DELIVERY(nome_motoboy, id_endereco, valor_entrega, data_entrega, placa_moto) " +
                        "output  INSERTED.id_entrega " +
                        "values(@nome_motoboy, @id_endereco, @valor_entrega,@data_entrega,@placa_moto); ";

                    command.Parameters.AddWithValue("@nome_motoboy", txt_entregador.Text);
                    command.Parameters.AddWithValue("@id_endereco", lbl_id_endereco.Text);
                    command.Parameters.AddWithValue("@valor_entrega", txt_valor_parcela.Text.Replace(",", "."));
                    command.Parameters.AddWithValue("@data_entrega", txt_dt_entrega.Text);
                    command.Parameters.AddWithValue("@placa_moto", txt_placa_moto.Text);


                    cod_delivery = Convert.ToString(command.ExecuteScalar());
                }

                using (SqlCommand command = new SqlCommand())
                {

                    command.Connection = Con;
                    command.CommandText = "update pagamento set id_entrega = @entrega,data_pagamento = getdate(), tipo_pagamento = @tipo_pagamento, " +
                        "valor_total = @valor_total, valor_pago = @valor_pago, valor_troco = @valor_troco, parcelas = @parcelas, " +
                        "valor_parcelas = @valor_parcelas, Pago = 'S' where cod_pagamento = @cod_pagamento";
                    command.Parameters.AddWithValue("@tipo_pagamento", cb_tipo_pagamento.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@valor_total", txt_valor_venda.Text.Replace(",", ".").Replace("R$ ", ""));
                    command.Parameters.AddWithValue("@valor_pago", txt_valor_frete.Text.Replace(",", ".").Replace("R$ ", ""));
                    command.Parameters.AddWithValue("@valor_troco", txt_troco.Text.Replace(",", ".").Replace("R$ ", ""));
                    command.Parameters.AddWithValue("@parcelas", txt_n_parcelas.Text);
                    command.Parameters.AddWithValue("@valor_parcelas", txt_valor_parcela.Text.Replace(",", "."));
                    command.Parameters.AddWithValue("@entrega", cod_delivery );                    
                    command.Parameters.AddWithValue("@cod_pagamento", lbl_id_venda.Text);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Pedido pago com sucesso!");
                    txt_valor_pago.Text = "";
                    txt_valor_parcela.Text = "";
                    txt_n_parcelas.Text = "";
                    txt_troco.Text = "";
                    txt_valor_venda.Text = "";
                    txt_valor_frete.Text = "";
                    gv_pedidos_pgto.DataSource = null;
                    gv_pedidos_pgto.Rows.Clear();
                    recarrega_grid_pgto_pendente();

                }


                Con.Close();
            }
            if (rd_delivery_N.Checked == true)
            {
                if (cb_tipo_pagamento.Text == "Selecione")
                {
                    MessageBox.Show("Selecione uma forma de pagamento");
                    return;
                }
                if (txt_valor_pago.Text == "")
                {
                    MessageBox.Show("Informe o valor do pagamento");
                    return;
                }

                Con.Open();
                using (SqlCommand command = new SqlCommand())
                {

                    try
                    {
                        command.Connection = Con;
                        command.CommandText = "update pagamento set data_pagamento = getdate(), tipo_pagamento = @tipo_pagamento, " +
                            "valor_total = @valor_total, valor_pago = @valor_pago, valor_troco = @valor_troco, parcelas = @parcelas, " +
                            "valor_parcelas = @valor_parcelas, Pago = 'S' where cod_pagamento = @cod_pagamento ";
                        command.Parameters.AddWithValue("@tipo_pagamento", cb_tipo_pagamento.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@valor_total", txt_valor_venda.Text.Replace(",", "."));
                        command.Parameters.AddWithValue("@valor_pago", txt_valor_venda.Text.Replace(",", "."));
                        command.Parameters.AddWithValue("@valor_troco", txt_troco.Text.Replace(",", ".").Replace("R$ ", ""));
                        command.Parameters.AddWithValue("@parcelas", txt_n_parcelas.Text);
                        command.Parameters.AddWithValue("@valor_parcelas", txt_valor_parcela.Text.Replace(",", ".").Replace("R$ ", ""));
                        command.Parameters.AddWithValue("@cod_pagamento", lbl_id_venda.Text);
                        command.ExecuteNonQuery();

                        MessageBox.Show("Pedido pago com sucesso!");


                        txt_valor_pago.Text = "";
                        txt_valor_parcela.Text = "";
                        txt_n_parcelas.Text = "";
                        txt_troco.Text = "";
                        txt_valor_venda.Text = "";
                        txt_valor_frete.Text = "";
                        gv_pedidos_pgto.DataSource = null;
                        gv_pedidos_pgto.Rows.Clear();
                        recarrega_grid_pgto_pendente();
                    }
                    catch (Exception)
                    {

                        throw;
                    }


                }
                Con.Close();


            }


        }

        private void txt_valor_frete_TextChanged(object sender, EventArgs e)
        {
            if (txt_valor_frete.Text != "" && txt_valor_venda.Text != "")
            {

                txt_valor_venda.Text = (Convert.ToDouble(lbl_valor_venda.Text) + Convert.ToDouble(txt_valor_frete.Text)).ToString();
            }


            
        }

        private void gv_pedidos_pgto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gv_pedidos_pgto.SelectedCells.Count > 0)
            {
                int selectedrowindex = gv_pedidos_pgto.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = gv_pedidos_pgto.Rows[selectedrowindex];

                lbl_id_venda.Text = Convert.ToString(selectedRow.Cells["cod_pagamento"].Value);
                lbl_id_cliente.Text = Convert.ToString(selectedRow.Cells["cod_cliente"].Value);
                lbl_id_endereco.Text = Convert.ToString(selectedRow.Cells["id_endereco"].Value);
                txt_valor_venda.Text = Convert.ToString(selectedRow.Cells["Valor_Total_Produtos"].Value);
                lbl_valor_venda.Text = Convert.ToString(selectedRow.Cells["Valor_Total_Produtos"].Value);

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_tipo_pagamento.SelectedItem.ToString() == "Dinheiro" || cb_tipo_pagamento.SelectedItem.ToString() == "Débito")
            {
                txt_n_parcelas.Enabled = false;
                txt_valor_parcela.Enabled = false;
                txt_valor_pago.Enabled = true;
            }

            if (cb_tipo_pagamento.SelectedItem.ToString() == "Crédito")
            {
                txt_n_parcelas.Enabled = true;
                txt_valor_parcela.Enabled = true;
                txt_valor_pago.Enabled = false;
                txt_troco.Text = "0";
                txt_valor_pago.Text = txt_valor_venda.Text;
            }

        }

        private void txt_valor_pago_TextChanged(object sender, EventArgs e)
        {
            if (txt_valor_pago.Text != "")
            {
                txt_troco.Text = (Convert.ToDouble(txt_valor_pago.Text) - Convert.ToDouble(txt_valor_venda.Text)).ToString("C2");
            }
            else
            {
                txt_troco.Text = "0";
            }
        }

        private void txt_n_parcelas_ValueChanged(object sender, EventArgs e)
        {
            txt_valor_parcela.Text = (Convert.ToDouble(txt_valor_venda.Text) / Convert.ToInt32(txt_n_parcelas.Value)).ToString("C2");
        }

        private void rd_delivery_S_CheckedChanged(object sender, EventArgs e)
        {
            txt_valor_frete.Enabled = true;
        }

        private void rd_delivery_N_CheckedChanged(object sender, EventArgs e)
        {
            txt_valor_frete.Enabled = false;
        }
    }
}

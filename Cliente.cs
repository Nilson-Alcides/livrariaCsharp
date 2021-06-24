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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
            
        }
              
        private void limpa_dados()
        {
            txt_Nome.Text = "";
            txt_CPF.Text = "";
            txt_Endereco.Text = "";
            txt_Numero.Text = "";
            txt_Complemento.Text = "";
            txt_Bairro.Text = "";            
            cbo_Tipo_tels.Text = "";            
            txt_Email.Text = "";
            lbl_ID_Cliente.Text = "";
            cbo_sexo.Text = "";
            txt_data_nascimento.Text = "";
            txt_ddd.Text = "";
            txt_telefone.Text = "";
            cbo_Tipo_tels.Text = "";

        }

        public static bool ValidaCPF(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(",", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }


        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            //Cadastro Cliente

            //Verifica se o CPF ja existe


            //valida os campos
            if (txt_Nome.Text == "")
            {
                MessageBox.Show("Preencha o nome!");
                txt_Nome.Focus();
                return;
            }

            if (txt_CPF.Text == "")
            {
                MessageBox.Show("Preencha o CPF!");
                txt_CPF.Focus();
                return;
            }

            if (ValidaCPF(txt_CPF.Text) == false)
            {
                MessageBox.Show("CPF inválido!");
                txt_CPF.Focus();
                return;
            }

            if (cbo_sexo.Text == "Selecione:")
            {
                MessageBox.Show("Preencha o sexo!");
                cbo_sexo.Focus();
                return;
            }

            if (txt_data_nascimento.Text == "  /  /")
            {
                MessageBox.Show("Preencha o Data de Nascimento!");
                txt_data_nascimento.Focus();
                return;
            }

            if (txt_Email.Text == "")
            {
                MessageBox.Show("Preencha o Email!");
                txt_Email.Focus();
                return;
            }

            if (txt_Endereco.Text == "")
            {
                MessageBox.Show("Preencha o Endereço!");
                txt_Endereco.Focus();
                return;
            }
            if (txt_Numero.Text == "")
            {
                MessageBox.Show("Preencha o Número!");
                txt_Numero.Focus();
                return;
            }
            if (txt_Complemento.Text == "")
            {
                MessageBox.Show("Preencha o Complemento!");
                txt_Complemento.Focus();
                return;
            }
            if (txt_Bairro.Text == "")
            {
                MessageBox.Show("Preencha o Bairro!");
                txt_Bairro.Focus();
                return;
            }
          


            if (txt_ddd.Text == "")
            {
                MessageBox.Show("Preencha o DDD!");
                txt_ddd.Focus();
                return;
            }

            if (txt_telefone.Text == "")
            {
                MessageBox.Show("Preencha o Telefone!");
                txt_telefone.Focus();
                return;
            }

            if (cbo_Tipo_tels.Text == "Selecione:")
            {
                MessageBox.Show("Preencha o tipo de Telefone!");
                cbo_Tipo_tels.Focus();
                return;
            }
            //fim valida campos



            SqlConnection Con = Conexao.GetConexao();
            Con.Open();

            DataTable Dt_Cliente = new DataTable();
            SqlDataAdapter DA_Cliente = new SqlDataAdapter("SELECT * FROM CLIENTE " +
                                                           "where CPF_Cliente = @CPF ", Con);
            DA_Cliente.SelectCommand.Parameters.AddWithValue("@CPF", txt_CPF.Text.Replace(",", ".").Replace("-", ""));
            DA_Cliente.Fill(Dt_Cliente);

            if (Dt_Cliente.Rows.Count != 0)
            {
                MessageBox.Show("CPF já existe clique em consultar e Atualize os dados");
                Con.Close();
                return;
            }
            else
            {                                
                int cod_cliente;

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = Con;
                    command.CommandText = "Insert into Cliente(Nome_Cliente, CPF_Cliente,email,sexo,data_nascimento) " +
                        "values(@nome, @CPF,@Email,@sexo,@data_nascimento);SELECT SCOPE_IDENTITY();";

                    command.Parameters.AddWithValue("@nome", txt_Nome.Text);
                    command.Parameters.AddWithValue("@CPF", txt_CPF.Text.Replace(",", "").Replace("-", ""));
                    command.Parameters.AddWithValue("@Email", txt_Email.Text);
                    command.Parameters.AddWithValue("@sexo", cbo_sexo.Text);
                    command.Parameters.AddWithValue("@data_nascimento", txt_data_nascimento.Text);


                    cod_cliente = Convert.ToInt32(command.ExecuteScalar());

                }

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = Con;
                    command.CommandText = "Insert into Cliente_endereco(cod_cliente,logradouro,numero,complemento,bairro) " +
                        "values(@cod_cliente, @logradouro,@numero,@complemento,@bairro);";

                    command.Parameters.AddWithValue("@cod_cliente", cod_cliente);
                    command.Parameters.AddWithValue("@logradouro", txt_Endereco.Text);
                    command.Parameters.AddWithValue("@numero", txt_Numero.Text);
                    command.Parameters.AddWithValue("@complemento", txt_Complemento.Text);
                    command.Parameters.AddWithValue("@bairro", txt_Bairro.Text);


                    command.ExecuteNonQuery();

                }

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = Con;
                    command.CommandText = "Insert into CLIENTE_TELEFONE(cod_cliente,ddd,numero,tipo) " +
                        "values(@cod_cliente, @ddd,@telefone,@tipo);";

                    command.Parameters.AddWithValue("@cod_cliente", cod_cliente);
                    command.Parameters.AddWithValue("@ddd", txt_ddd.Text);
                    command.Parameters.AddWithValue("@telefone", txt_telefone.Text);
                    command.Parameters.AddWithValue("@tipo", cbo_Tipo_tels.Text);

                    command.ExecuteNonQuery();

                }
                MessageBox.Show("Cliente cadastrado com sucesso!");

                Con.Close();
                limpa_dados();
            }
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {

            //Consulta Cliente cadastrados por CPF
            SqlConnection Con = Conexao.GetConexao();
            Con.Open();

            DataTable Dt_Cliente = new DataTable();
            SqlDataAdapter DA_Cliente = new SqlDataAdapter("SELECT c.cod_cliente,cpf_cliente as CPF,nome_cliente as Nome,email,sexo," +
                                                           "data_nascimento as 'Dt.Nasc',logradouro,numero as 'Nº', complemento as'compl.'," +
                                                           " bairro FROM CLIENTE c inner join CLIENTE_ENDERECO e on e.cod_cliente = c.cod_cliente " +
                                                           "where c.CPF_Cliente = @CPF or nome_cliente like '%" + txt_consulta.Text + "%'", Con);
            DA_Cliente.SelectCommand.Parameters.AddWithValue("@CPF", txt_consulta.Text.Replace(",", "."));

            DA_Cliente.Fill(Dt_Cliente);

            if (Dt_Cliente.Rows.Count == 0)
            {
                MessageBox.Show("CPF de cliente não encontrado, cadastrar o cliente!");
                
            }
            else
            {
                DataTable Dt_Cliente_Tel = new DataTable();
                SqlDataAdapter DA_Cliente_Tel = new SqlDataAdapter("select ddd,numero as telefone, tipo from Cliente_telefone " +
                    "where cod_cliente = @COD_CLI ", Con);
                DA_Cliente_Tel.SelectCommand.Parameters.AddWithValue("@COD_CLI", Dt_Cliente.Rows[0]["cod_Cliente"].ToString());
                DA_Cliente_Tel.Fill(Dt_Cliente_Tel);

                dgvClientes.DataSource = Dt_Cliente;
                dgvTelefone.DataSource = Dt_Cliente_Tel;
                
                lbl_ID_Cliente.Text = Dt_Cliente.Rows[0]["cod_Cliente"].ToString();


            }
            Con.Close();
            btn_Cadastrar.Enabled = true;
        }

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {

            if (lbl_ID_Cliente.Text != "")
            {
                //Atualiza Cliente consultados por CPF
                SqlConnection Con = Conexao.GetConexao();
                Con.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = Con;
                    command.CommandText = "Update Cliente set Nome_Cliente = @nome, sexo = @sexo, " +
                                          "data_nascimento = @dt_nascimento, Email = @Email " +
                                          "where cod_cliente = @cod_cliente";

                    command.Parameters.AddWithValue("@cod_cliente", lbl_ID_Cliente.Text);
                    command.Parameters.AddWithValue("@nome", txt_Nome.Text);
                    command.Parameters.AddWithValue("@sexo", cbo_sexo.SelectedItem);
                    command.Parameters.AddWithValue("@dt_nascimento", txt_data_nascimento.Text);
                    command.Parameters.AddWithValue("@Email", txt_Email.Text);
                    command.ExecuteNonQuery();
                }

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = Con;
                    command.CommandText = "Update Cliente_endereco set logradouro = @endereco, numero = @numero, " +
                                          "complemento = @complemento, bairro = @bairro " +
                                          "where cod_cliente = @cod_cliente";

                    command.Parameters.AddWithValue("@cod_cliente", lbl_ID_Cliente.Text);
                    command.Parameters.AddWithValue("@endereco", txt_Endereco.Text);
                    command.Parameters.AddWithValue("@numero", txt_Numero.Text);
                    command.Parameters.AddWithValue("@complemento", txt_Complemento.Text);
                    command.Parameters.AddWithValue("@bairro", txt_Bairro.Text);


                    command.ExecuteNonQuery();
                }
                if (txt_ddd.Text == "") 
                {
                    MessageBox.Show("Favor selecionar un ddd");
                    txt_ddd.Focus();
                    return;
                }
                if (txt_telefone.Text == "")
                {
                    MessageBox.Show("Favor selecionar un tefefone");
                    txt_telefone.Focus();
                    return;
                }
                if (cbo_Tipo_tels.Text == "")
                {
                    MessageBox.Show("Favor selecionar un tipo de telefone");
                    cbo_Tipo_tels.Focus();
                    return;
                }

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = Con;
                    command.CommandText = "Update Cliente_telefone set ddd = @ddd, numero = @telefone, " +
                                          "tipo = @tipo " +
                                          "where cod_cliente = @cod_cliente and id_telefone = @id_telefone";

                    command.Parameters.AddWithValue("@cod_cliente", lbl_ID_Cliente.Text);
                    command.Parameters.AddWithValue("@id_telefone", lbl_ID_Cliente.Text);
                    command.Parameters.AddWithValue("@ddd", txt_ddd.Text);
                    command.Parameters.AddWithValue("@telefone", txt_telefone.Text);
                    command.Parameters.AddWithValue("@tipo", cbo_Tipo_tels.Text);
                    


                    command.ExecuteNonQuery();
                }

                Con.Close();
                MessageBox.Show("Cliente atualizado com successo!");
            }
            else
            {
                MessageBox.Show("Consulte CPF antes de atualizar");
            }
        }

        private void btn_Deletar_Click(object sender, EventArgs e)
        {

            if (lbl_ID_Cliente.Text != "")
            {
                // Initializes the variables to pass to the MessageBox.Show method.

                string message = "Deseja realmente deletar o Cliente " + txt_Nome.Text + "?";
                string caption = "Deleta Cliente";
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

                    //Deleta Cliente consultados por CPF
                    SqlConnection Con = Conexao.GetConexao();
                    Con.Open();

                    try
                    {
                        using (SqlCommand command = new SqlCommand())
                        {
                            command.Connection = Con;
                            command.CommandText = "delete from Cliente_endereco " +
                                                  "where cod_cliente = @Id_cliente";

                            command.Parameters.AddWithValue("@Id_cliente", lbl_ID_Cliente.Text);

                            command.ExecuteNonQuery();


                        }

                        using (SqlCommand command = new SqlCommand())
                        {
                            command.Connection = Con;
                            command.CommandText = "delete from Cliente_telefone " +
                                                  "where cod_cliente = @Id_cliente";

                            command.Parameters.AddWithValue("@Id_cliente", lbl_ID_Cliente.Text);

                            command.ExecuteNonQuery();


                        }

                        using (SqlCommand command = new SqlCommand())
                        {
                            command.Connection = Con;
                            command.CommandText = "delete from Cliente " +
                                                  "where cod_cliente = @Id_cliente";

                            command.Parameters.AddWithValue("@Id_cliente", lbl_ID_Cliente.Text);

                            command.ExecuteNonQuery();

                            MessageBox.Show("Cliente deletado com Sucesso!");
                            limpa_dados();
                        }

                    }
                    catch (Exception)
                    {

                        throw;
                    }



                    Con.Close();


                }


            }
            else
            {
                MessageBox.Show("Consulte CPF antes de deletar");
            }
        }

        private void dgvClientes_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string strRowNumber = (e.RowIndex + 1).ToString();
            SizeF size = e.Graphics.MeasureString(strRowNumber, this.Font);
            if (dgvClientes.RowHeadersWidth < Convert.ToInt32((size.Width + 20)))
            {
                dgvClientes.RowHeadersWidth = Convert.ToInt32((size.Width + 20));
            }
            Brush b = SystemBrushes.ControlText;
            e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));

        }

        private void dgvClientes_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dr = dgvClientes.SelectedRows[0];
            lbl_ID_Cliente.Text = dr.Cells[0].Value.ToString();
            txt_Nome.Text = dr.Cells[2].Value.ToString();
            txt_CPF.Text = dr.Cells[1].Value.ToString();
            cbo_sexo.Text = dr.Cells[4].Value.ToString();
            txt_data_nascimento.Text = dr.Cells[5].Value.ToString();
            txt_Endereco.Text = dr.Cells[6].Value.ToString();
            txt_Numero.Text = dr.Cells[7].Value.ToString();
            txt_Complemento.Text = dr.Cells[8].Value.ToString();
            txt_Bairro.Text = dr.Cells[9].Value.ToString();
            txt_Email.Text = dr.Cells[3].Value.ToString();

            btn_Cadastrar.Enabled = false;
            btn_Atualizar.Enabled = true;
        }

        private void dgvTelefone_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string strRowNumber = (e.RowIndex + 1).ToString();
            SizeF size = e.Graphics.MeasureString(strRowNumber, this.Font);
            if (dgvTelefone.RowHeadersWidth < Convert.ToInt32((size.Width + 20)))
            {
                dgvTelefone.RowHeadersWidth = Convert.ToInt32((size.Width + 20));
            }
            Brush b = SystemBrushes.ControlText;
            e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));


        }

        private void dgvTelefone_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dr = dgvTelefone.SelectedRows[0];
            txt_ddd.Text = dr.Cells[0].Value.ToString();
            txt_telefone.Text = dr.Cells[1].Value.ToString();
            cbo_Tipo_tels.Text = dr.Cells[2].Value.ToString();
            

            btn_Cadastrar.Enabled = false;
            btn_Atualizar.Enabled = true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpa_dados();
            btn_Cadastrar.Enabled = true;
        }
    }
}

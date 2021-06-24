namespace Livraria
{
    partial class Cliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_consulta = new System.Windows.Forms.TextBox();
            this.dgvTelefone = new System.Windows.Forms.DataGridView();
            this.gpb_dados_pessoais = new System.Windows.Forms.GroupBox();
            this.txt_data_nascimento = new System.Windows.Forms.MaskedTextBox();
            this.lbl_nascimento = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.lbl_sexo = new System.Windows.Forms.Label();
            this.txt_CPF = new System.Windows.Forms.MaskedTextBox();
            this.cbo_sexo = new System.Windows.Forms.ComboBox();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.gpb_endereco = new System.Windows.Forms.GroupBox();
            this.lbl_Endereco = new System.Windows.Forms.Label();
            this.lbl_Bairro = new System.Windows.Forms.Label();
            this.lbl_Numero = new System.Windows.Forms.Label();
            this.lbl_Complemento = new System.Windows.Forms.Label();
            this.txt_Numero = new System.Windows.Forms.TextBox();
            this.txt_Bairro = new System.Windows.Forms.TextBox();
            this.txt_Complemento = new System.Windows.Forms.TextBox();
            this.txt_Endereco = new System.Windows.Forms.TextBox();
            this.gpb_contato = new System.Windows.Forms.GroupBox();
            this.txt_ddd = new System.Windows.Forms.MaskedTextBox();
            this.txt_telefone = new System.Windows.Forms.MaskedTextBox();
            this.cbo_Tipo_tels = new System.Windows.Forms.ComboBox();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.lbl_ddd = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lbl_Estado = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.lbl_ID_Cliente = new System.Windows.Forms.Label();
            this.btn_Deletar = new System.Windows.Forms.Button();
            this.btn_Consultar = new System.Windows.Forms.Button();
            this.btn_Atualizar = new System.Windows.Forms.Button();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.gbCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefone)).BeginInit();
            this.gpb_dados_pessoais.SuspendLayout();
            this.gpb_endereco.SuspendLayout();
            this.gpb_contato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.btnLimpar);
            this.gbCliente.Controls.Add(this.label2);
            this.gbCliente.Controls.Add(this.txt_consulta);
            this.gbCliente.Controls.Add(this.dgvTelefone);
            this.gbCliente.Controls.Add(this.gpb_dados_pessoais);
            this.gbCliente.Controls.Add(this.gpb_endereco);
            this.gbCliente.Controls.Add(this.gpb_contato);
            this.gbCliente.Controls.Add(this.dgvClientes);
            this.gbCliente.Controls.Add(this.lbl_ID_Cliente);
            this.gbCliente.Controls.Add(this.btn_Deletar);
            this.gbCliente.Controls.Add(this.btn_Consultar);
            this.gbCliente.Controls.Add(this.btn_Atualizar);
            this.gbCliente.Controls.Add(this.btn_Cadastrar);
            this.gbCliente.ForeColor = System.Drawing.Color.SeaShell;
            this.gbCliente.Location = new System.Drawing.Point(12, 12);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(1022, 494);
            this.gbCliente.TabIndex = 0;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cadastro Cliente";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLimpar.Location = new System.Drawing.Point(193, 284);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 52;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(457, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Digite o Nome ou CPF do cliente para consultar:";
            // 
            // txt_consulta
            // 
            this.txt_consulta.Location = new System.Drawing.Point(460, 286);
            this.txt_consulta.Name = "txt_consulta";
            this.txt_consulta.Size = new System.Drawing.Size(313, 20);
            this.txt_consulta.TabIndex = 50;
            this.txt_consulta.Tag = "teste";
            // 
            // dgvTelefone
            // 
            this.dgvTelefone.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTelefone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelefone.Location = new System.Drawing.Point(488, 178);
            this.dgvTelefone.MultiSelect = false;
            this.dgvTelefone.Name = "dgvTelefone";
            this.dgvTelefone.ReadOnly = true;
            this.dgvTelefone.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTelefone.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTelefone.Size = new System.Drawing.Size(285, 80);
            this.dgvTelefone.TabIndex = 49;
            this.dgvTelefone.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTelefone_RowHeaderMouseClick);
            this.dgvTelefone.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvTelefone_RowPostPaint);
            // 
            // gpb_dados_pessoais
            // 
            this.gpb_dados_pessoais.Controls.Add(this.txt_data_nascimento);
            this.gpb_dados_pessoais.Controls.Add(this.lbl_nascimento);
            this.gpb_dados_pessoais.Controls.Add(this.txt_Nome);
            this.gpb_dados_pessoais.Controls.Add(this.lbl_sexo);
            this.gpb_dados_pessoais.Controls.Add(this.txt_CPF);
            this.gpb_dados_pessoais.Controls.Add(this.cbo_sexo);
            this.gpb_dados_pessoais.Controls.Add(this.lbl_Nome);
            this.gpb_dados_pessoais.Controls.Add(this.lbl_cpf);
            this.gpb_dados_pessoais.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.gpb_dados_pessoais.Location = new System.Drawing.Point(16, 26);
            this.gpb_dados_pessoais.Name = "gpb_dados_pessoais";
            this.gpb_dados_pessoais.Size = new System.Drawing.Size(757, 68);
            this.gpb_dados_pessoais.TabIndex = 40;
            this.gpb_dados_pessoais.TabStop = false;
            this.gpb_dados_pessoais.Text = "Dados Pessoais";
            // 
            // txt_data_nascimento
            // 
            this.txt_data_nascimento.Location = new System.Drawing.Point(532, 37);
            this.txt_data_nascimento.Mask = "00/00/0000";
            this.txt_data_nascimento.Name = "txt_data_nascimento";
            this.txt_data_nascimento.Size = new System.Drawing.Size(100, 20);
            this.txt_data_nascimento.TabIndex = 3;
            this.txt_data_nascimento.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_nascimento
            // 
            this.lbl_nascimento.AutoSize = true;
            this.lbl_nascimento.Location = new System.Drawing.Point(529, 19);
            this.lbl_nascimento.Name = "lbl_nascimento";
            this.lbl_nascimento.Size = new System.Drawing.Size(89, 13);
            this.lbl_nascimento.TabIndex = 41;
            this.lbl_nascimento.Text = "Data Nascimento";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(12, 35);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(317, 20);
            this.txt_Nome.TabIndex = 0;
            // 
            // lbl_sexo
            // 
            this.lbl_sexo.AutoSize = true;
            this.lbl_sexo.Location = new System.Drawing.Point(423, 20);
            this.lbl_sexo.Name = "lbl_sexo";
            this.lbl_sexo.Size = new System.Drawing.Size(31, 13);
            this.lbl_sexo.TabIndex = 39;
            this.lbl_sexo.Text = "Sexo";
            // 
            // txt_CPF
            // 
            this.txt_CPF.Location = new System.Drawing.Point(335, 36);
            this.txt_CPF.Mask = "999.999.999-99";
            this.txt_CPF.Name = "txt_CPF";
            this.txt_CPF.Size = new System.Drawing.Size(85, 20);
            this.txt_CPF.TabIndex = 1;
            // 
            // cbo_sexo
            // 
            this.cbo_sexo.FormattingEnabled = true;
            this.cbo_sexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbo_sexo.Location = new System.Drawing.Point(426, 36);
            this.cbo_sexo.Name = "cbo_sexo";
            this.cbo_sexo.Size = new System.Drawing.Size(100, 21);
            this.cbo_sexo.TabIndex = 2;
            this.cbo_sexo.Text = "Selecione:";
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Location = new System.Drawing.Point(12, 19);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_Nome.TabIndex = 10;
            this.lbl_Nome.Text = "Nome";
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Location = new System.Drawing.Point(335, 20);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(27, 13);
            this.lbl_cpf.TabIndex = 14;
            this.lbl_cpf.Text = "CPF";
            // 
            // gpb_endereco
            // 
            this.gpb_endereco.Controls.Add(this.lbl_Endereco);
            this.gpb_endereco.Controls.Add(this.lbl_Bairro);
            this.gpb_endereco.Controls.Add(this.lbl_Numero);
            this.gpb_endereco.Controls.Add(this.lbl_Complemento);
            this.gpb_endereco.Controls.Add(this.txt_Numero);
            this.gpb_endereco.Controls.Add(this.txt_Bairro);
            this.gpb_endereco.Controls.Add(this.txt_Complemento);
            this.gpb_endereco.Controls.Add(this.txt_Endereco);
            this.gpb_endereco.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.gpb_endereco.Location = new System.Drawing.Point(16, 100);
            this.gpb_endereco.Name = "gpb_endereco";
            this.gpb_endereco.Size = new System.Drawing.Size(757, 71);
            this.gpb_endereco.TabIndex = 41;
            this.gpb_endereco.TabStop = false;
            this.gpb_endereco.Text = "Endereço";
            // 
            // lbl_Endereco
            // 
            this.lbl_Endereco.AutoSize = true;
            this.lbl_Endereco.Location = new System.Drawing.Point(7, 20);
            this.lbl_Endereco.Name = "lbl_Endereco";
            this.lbl_Endereco.Size = new System.Drawing.Size(53, 13);
            this.lbl_Endereco.TabIndex = 33;
            this.lbl_Endereco.Text = "Endereço";
            // 
            // lbl_Bairro
            // 
            this.lbl_Bairro.AutoSize = true;
            this.lbl_Bairro.Location = new System.Drawing.Point(529, 20);
            this.lbl_Bairro.Name = "lbl_Bairro";
            this.lbl_Bairro.Size = new System.Drawing.Size(34, 13);
            this.lbl_Bairro.TabIndex = 32;
            this.lbl_Bairro.Text = "Bairro";
            // 
            // lbl_Numero
            // 
            this.lbl_Numero.AutoSize = true;
            this.lbl_Numero.Location = new System.Drawing.Point(332, 20);
            this.lbl_Numero.Name = "lbl_Numero";
            this.lbl_Numero.Size = new System.Drawing.Size(44, 13);
            this.lbl_Numero.TabIndex = 28;
            this.lbl_Numero.Text = "Numero";
            // 
            // lbl_Complemento
            // 
            this.lbl_Complemento.AutoSize = true;
            this.lbl_Complemento.Location = new System.Drawing.Point(428, 20);
            this.lbl_Complemento.Name = "lbl_Complemento";
            this.lbl_Complemento.Size = new System.Drawing.Size(71, 13);
            this.lbl_Complemento.TabIndex = 27;
            this.lbl_Complemento.Text = "Complemento";
            // 
            // txt_Numero
            // 
            this.txt_Numero.Location = new System.Drawing.Point(335, 36);
            this.txt_Numero.Name = "txt_Numero";
            this.txt_Numero.Size = new System.Drawing.Size(85, 20);
            this.txt_Numero.TabIndex = 1;
            // 
            // txt_Bairro
            // 
            this.txt_Bairro.Location = new System.Drawing.Point(532, 36);
            this.txt_Bairro.Name = "txt_Bairro";
            this.txt_Bairro.Size = new System.Drawing.Size(100, 20);
            this.txt_Bairro.TabIndex = 3;
            // 
            // txt_Complemento
            // 
            this.txt_Complemento.Location = new System.Drawing.Point(426, 36);
            this.txt_Complemento.Name = "txt_Complemento";
            this.txt_Complemento.Size = new System.Drawing.Size(100, 20);
            this.txt_Complemento.TabIndex = 2;
            // 
            // txt_Endereco
            // 
            this.txt_Endereco.Location = new System.Drawing.Point(10, 36);
            this.txt_Endereco.Name = "txt_Endereco";
            this.txt_Endereco.Size = new System.Drawing.Size(319, 20);
            this.txt_Endereco.TabIndex = 0;
            // 
            // gpb_contato
            // 
            this.gpb_contato.Controls.Add(this.txt_ddd);
            this.gpb_contato.Controls.Add(this.txt_telefone);
            this.gpb_contato.Controls.Add(this.cbo_Tipo_tels);
            this.gpb_contato.Controls.Add(this.lbl_telefone);
            this.gpb_contato.Controls.Add(this.lbl_ddd);
            this.gpb_contato.Controls.Add(this.txt_Email);
            this.gpb_contato.Controls.Add(this.lbl_Estado);
            this.gpb_contato.Controls.Add(this.lbl_Email);
            this.gpb_contato.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.gpb_contato.Location = new System.Drawing.Point(16, 178);
            this.gpb_contato.Name = "gpb_contato";
            this.gpb_contato.Size = new System.Drawing.Size(466, 80);
            this.gpb_contato.TabIndex = 42;
            this.gpb_contato.TabStop = false;
            this.gpb_contato.Text = "Contato";
            // 
            // txt_ddd
            // 
            this.txt_ddd.Location = new System.Drawing.Point(9, 44);
            this.txt_ddd.Mask = "99";
            this.txt_ddd.Name = "txt_ddd";
            this.txt_ddd.Size = new System.Drawing.Size(29, 20);
            this.txt_ddd.TabIndex = 0;
            // 
            // txt_telefone
            // 
            this.txt_telefone.Location = new System.Drawing.Point(47, 45);
            this.txt_telefone.Mask = "000000000";
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(64, 20);
            this.txt_telefone.TabIndex = 1;
            // 
            // cbo_Tipo_tels
            // 
            this.cbo_Tipo_tels.FormattingEnabled = true;
            this.cbo_Tipo_tels.Items.AddRange(new object[] {
            "Fixo",
            "Celular",
            "Comercial"});
            this.cbo_Tipo_tels.Location = new System.Drawing.Point(117, 44);
            this.cbo_Tipo_tels.Name = "cbo_Tipo_tels";
            this.cbo_Tipo_tels.Size = new System.Drawing.Size(81, 21);
            this.cbo_Tipo_tels.TabIndex = 2;
            this.cbo_Tipo_tels.Text = "Selecione:";
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Location = new System.Drawing.Point(44, 25);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(49, 13);
            this.lbl_telefone.TabIndex = 34;
            this.lbl_telefone.Text = "Telefone";
            // 
            // lbl_ddd
            // 
            this.lbl_ddd.AutoSize = true;
            this.lbl_ddd.Location = new System.Drawing.Point(7, 25);
            this.lbl_ddd.Name = "lbl_ddd";
            this.lbl_ddd.Size = new System.Drawing.Size(31, 13);
            this.lbl_ddd.TabIndex = 33;
            this.lbl_ddd.Text = "DDD";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(204, 45);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(243, 20);
            this.txt_Email.TabIndex = 3;
            // 
            // lbl_Estado
            // 
            this.lbl_Estado.AutoSize = true;
            this.lbl_Estado.Location = new System.Drawing.Point(114, 25);
            this.lbl_Estado.Name = "lbl_Estado";
            this.lbl_Estado.Size = new System.Drawing.Size(28, 13);
            this.lbl_Estado.TabIndex = 30;
            this.lbl_Estado.Text = "Tipo";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(204, 29);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(32, 13);
            this.lbl_Email.TabIndex = 25;
            this.lbl_Email.Text = "Email";
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToOrderColumns = true;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.GridColor = System.Drawing.Color.DarkGreen;
            this.dgvClientes.Location = new System.Drawing.Point(13, 325);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgvClientes.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClientes.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial Narrow", 7.25F);
            this.dgvClientes.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(1003, 129);
            this.dgvClientes.TabIndex = 48;
            this.dgvClientes.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvClientes_RowHeaderMouseClick);
            this.dgvClientes.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvClientes_RowPostPaint);
            // 
            // lbl_ID_Cliente
            // 
            this.lbl_ID_Cliente.AutoSize = true;
            this.lbl_ID_Cliente.Location = new System.Drawing.Point(716, 25);
            this.lbl_ID_Cliente.Name = "lbl_ID_Cliente";
            this.lbl_ID_Cliente.Size = new System.Drawing.Size(0, 13);
            this.lbl_ID_Cliente.TabIndex = 47;
            // 
            // btn_Deletar
            // 
            this.btn_Deletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Deletar.Location = new System.Drawing.Point(282, 284);
            this.btn_Deletar.Name = "btn_Deletar";
            this.btn_Deletar.Size = new System.Drawing.Size(75, 23);
            this.btn_Deletar.TabIndex = 45;
            this.btn_Deletar.Text = "Deletar";
            this.btn_Deletar.UseVisualStyleBackColor = false;
            this.btn_Deletar.Click += new System.EventHandler(this.btn_Deletar_Click);
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Consultar.Location = new System.Drawing.Point(372, 284);
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(75, 23);
            this.btn_Consultar.TabIndex = 46;
            this.btn_Consultar.Text = "Consultar";
            this.btn_Consultar.UseVisualStyleBackColor = false;
            this.btn_Consultar.Click += new System.EventHandler(this.btn_Consultar_Click);
            // 
            // btn_Atualizar
            // 
            this.btn_Atualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Atualizar.Location = new System.Drawing.Point(103, 284);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(75, 23);
            this.btn_Atualizar.TabIndex = 44;
            this.btn_Atualizar.Text = "Atualizar";
            this.btn_Atualizar.UseVisualStyleBackColor = false;
            this.btn_Atualizar.Click += new System.EventHandler(this.btn_Atualizar_Click);
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Cadastrar.Location = new System.Drawing.Point(16, 284);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cadastrar.TabIndex = 43;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = false;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1046, 667);
            this.ControlBox = false;
            this.Controls.Add(this.gbCliente);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cliente";
            this.Text = "Data Nascimento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefone)).EndInit();
            this.gpb_dados_pessoais.ResumeLayout(false);
            this.gpb_dados_pessoais.PerformLayout();
            this.gpb_endereco.ResumeLayout(false);
            this.gpb_endereco.PerformLayout();
            this.gpb_contato.ResumeLayout(false);
            this.gpb_contato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_consulta;
        private System.Windows.Forms.DataGridView dgvTelefone;
        private System.Windows.Forms.GroupBox gpb_dados_pessoais;
        private System.Windows.Forms.MaskedTextBox txt_data_nascimento;
        private System.Windows.Forms.Label lbl_nascimento;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label lbl_sexo;
        private System.Windows.Forms.MaskedTextBox txt_CPF;
        private System.Windows.Forms.ComboBox cbo_sexo;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.GroupBox gpb_endereco;
        private System.Windows.Forms.Label lbl_Endereco;
        private System.Windows.Forms.Label lbl_Bairro;
        private System.Windows.Forms.Label lbl_Numero;
        private System.Windows.Forms.Label lbl_Complemento;
        private System.Windows.Forms.TextBox txt_Numero;
        private System.Windows.Forms.TextBox txt_Bairro;
        private System.Windows.Forms.TextBox txt_Complemento;
        private System.Windows.Forms.TextBox txt_Endereco;
        private System.Windows.Forms.GroupBox gpb_contato;
        private System.Windows.Forms.MaskedTextBox txt_ddd;
        private System.Windows.Forms.MaskedTextBox txt_telefone;
        private System.Windows.Forms.ComboBox cbo_Tipo_tels;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.Label lbl_ddd;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lbl_Estado;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label lbl_ID_Cliente;
        private System.Windows.Forms.Button btn_Deletar;
        private System.Windows.Forms.Button btn_Consultar;
        private System.Windows.Forms.Button btn_Atualizar;
        private System.Windows.Forms.Button btn_Cadastrar;
    }
}
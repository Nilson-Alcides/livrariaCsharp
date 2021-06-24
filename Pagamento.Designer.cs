namespace Livraria
{
    partial class Pagamento
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gv_pedidos_pgto = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_id_cliente = new System.Windows.Forms.Label();
            this.lbl_id_venda = new System.Windows.Forms.Label();
            this.txt_valor_pago = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_finaliza_pgto = new System.Windows.Forms.Button();
            this.txt_valor_parcela = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_n_parcelas = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_troco = new System.Windows.Forms.TextBox();
            this.txt_valor_venda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_tipo_pagamento = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_valor_frete = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_placa_moto = new System.Windows.Forms.TextBox();
            this.lbl_placa_moto = new System.Windows.Forms.Label();
            this.txt_dt_entrega = new System.Windows.Forms.MaskedTextBox();
            this.lbl_dt_entrega = new System.Windows.Forms.Label();
            this.lbl_id_endereco = new System.Windows.Forms.Label();
            this.txt_entregador = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rd_delivery_N = new System.Windows.Forms.RadioButton();
            this.rd_delivery_S = new System.Windows.Forms.RadioButton();
            this.lbl_valor_venda = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_pedidos_pgto)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_n_parcelas)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gv_pedidos_pgto);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 165);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pedidos em aberto";
            // 
            // gv_pedidos_pgto
            // 
            this.gv_pedidos_pgto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_pedidos_pgto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_pedidos_pgto.Location = new System.Drawing.Point(6, 19);
            this.gv_pedidos_pgto.MultiSelect = false;
            this.gv_pedidos_pgto.Name = "gv_pedidos_pgto";
            this.gv_pedidos_pgto.ReadOnly = true;
            this.gv_pedidos_pgto.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.gv_pedidos_pgto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_pedidos_pgto.Size = new System.Drawing.Size(418, 124);
            this.gv_pedidos_pgto.TabIndex = 0;
            this.gv_pedidos_pgto.VirtualMode = true;
            this.gv_pedidos_pgto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_pedidos_pgto_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_id_cliente);
            this.groupBox2.Controls.Add(this.lbl_id_venda);
            this.groupBox2.Controls.Add(this.txt_valor_pago);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btn_finaliza_pgto);
            this.groupBox2.Controls.Add(this.txt_valor_parcela);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_n_parcelas);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_troco);
            this.groupBox2.Controls.Add(this.txt_valor_venda);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cb_tipo_pagamento);
            this.groupBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Location = new System.Drawing.Point(12, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(848, 84);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pagamento";
            // 
            // lbl_id_cliente
            // 
            this.lbl_id_cliente.AutoSize = true;
            this.lbl_id_cliente.Location = new System.Drawing.Point(651, 45);
            this.lbl_id_cliente.Name = "lbl_id_cliente";
            this.lbl_id_cliente.Size = new System.Drawing.Size(0, 13);
            this.lbl_id_cliente.TabIndex = 21;
            this.lbl_id_cliente.Visible = false;
            // 
            // lbl_id_venda
            // 
            this.lbl_id_venda.AutoSize = true;
            this.lbl_id_venda.Location = new System.Drawing.Point(309, 23);
            this.lbl_id_venda.Name = "lbl_id_venda";
            this.lbl_id_venda.Size = new System.Drawing.Size(0, 13);
            this.lbl_id_venda.TabIndex = 20;
            this.lbl_id_venda.Visible = false;
            // 
            // txt_valor_pago
            // 
            this.txt_valor_pago.Location = new System.Drawing.Point(266, 41);
            this.txt_valor_pago.Name = "txt_valor_pago";
            this.txt_valor_pago.Size = new System.Drawing.Size(100, 20);
            this.txt_valor_pago.TabIndex = 17;
            this.txt_valor_pago.TextChanged += new System.EventHandler(this.txt_valor_pago_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(268, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Valor Pago";
            // 
            // btn_finaliza_pgto
            // 
            this.btn_finaliza_pgto.BackColor = System.Drawing.Color.Black;
            this.btn_finaliza_pgto.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_finaliza_pgto.Location = new System.Drawing.Point(685, 32);
            this.btn_finaliza_pgto.Name = "btn_finaliza_pgto";
            this.btn_finaliza_pgto.Size = new System.Drawing.Size(130, 30);
            this.btn_finaliza_pgto.TabIndex = 14;
            this.btn_finaliza_pgto.Text = "Finalizar Pagamento";
            this.btn_finaliza_pgto.UseVisualStyleBackColor = false;
            this.btn_finaliza_pgto.Click += new System.EventHandler(this.btn_finaliza_pgto_Click);
            // 
            // txt_valor_parcela
            // 
            this.txt_valor_parcela.Enabled = false;
            this.txt_valor_parcela.Location = new System.Drawing.Point(558, 38);
            this.txt_valor_parcela.Name = "txt_valor_parcela";
            this.txt_valor_parcela.Size = new System.Drawing.Size(67, 20);
            this.txt_valor_parcela.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(555, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Valor Parcela";
            // 
            // txt_n_parcelas
            // 
            this.txt_n_parcelas.Location = new System.Drawing.Point(490, 39);
            this.txt_n_parcelas.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.txt_n_parcelas.Name = "txt_n_parcelas";
            this.txt_n_parcelas.Size = new System.Drawing.Size(47, 20);
            this.txt_n_parcelas.TabIndex = 8;
            this.txt_n_parcelas.ValueChanged += new System.EventHandler(this.txt_n_parcelas_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(489, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Parcelas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Troco";
            // 
            // txt_troco
            // 
            this.txt_troco.Enabled = false;
            this.txt_troco.Location = new System.Drawing.Point(383, 39);
            this.txt_troco.Name = "txt_troco";
            this.txt_troco.Size = new System.Drawing.Size(100, 20);
            this.txt_troco.TabIndex = 4;
            // 
            // txt_valor_venda
            // 
            this.txt_valor_venda.Enabled = false;
            this.txt_valor_venda.Location = new System.Drawing.Point(148, 39);
            this.txt_valor_venda.Name = "txt_valor_venda";
            this.txt_valor_venda.Size = new System.Drawing.Size(100, 20);
            this.txt_valor_venda.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor Total a Pagar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de Pagamento";
            // 
            // cb_tipo_pagamento
            // 
            this.cb_tipo_pagamento.FormattingEnabled = true;
            this.cb_tipo_pagamento.Items.AddRange(new object[] {
            "Dinheiro",
            "Débito",
            "Crédito"});
            this.cb_tipo_pagamento.Location = new System.Drawing.Point(19, 39);
            this.cb_tipo_pagamento.Name = "cb_tipo_pagamento";
            this.cb_tipo_pagamento.Size = new System.Drawing.Size(102, 21);
            this.cb_tipo_pagamento.TabIndex = 0;
            this.cb_tipo_pagamento.Text = "Selecione";
            this.cb_tipo_pagamento.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Valor Frete";
            // 
            // txt_valor_frete
            // 
            this.txt_valor_frete.Enabled = false;
            this.txt_valor_frete.Location = new System.Drawing.Point(6, 72);
            this.txt_valor_frete.Name = "txt_valor_frete";
            this.txt_valor_frete.Size = new System.Drawing.Size(100, 20);
            this.txt_valor_frete.TabIndex = 18;
            this.txt_valor_frete.TextChanged += new System.EventHandler(this.txt_valor_frete_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_placa_moto);
            this.groupBox3.Controls.Add(this.lbl_placa_moto);
            this.groupBox3.Controls.Add(this.txt_dt_entrega);
            this.groupBox3.Controls.Add(this.lbl_dt_entrega);
            this.groupBox3.Controls.Add(this.lbl_id_endereco);
            this.groupBox3.Controls.Add(this.txt_entregador);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.rd_delivery_N);
            this.groupBox3.Controls.Add(this.rd_delivery_S);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txt_valor_frete);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox3.Location = new System.Drawing.Point(478, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(382, 165);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delivery";
            // 
            // txt_placa_moto
            // 
            this.txt_placa_moto.Location = new System.Drawing.Point(201, 72);
            this.txt_placa_moto.Name = "txt_placa_moto";
            this.txt_placa_moto.Size = new System.Drawing.Size(100, 20);
            this.txt_placa_moto.TabIndex = 26;
            // 
            // lbl_placa_moto
            // 
            this.lbl_placa_moto.AutoSize = true;
            this.lbl_placa_moto.Location = new System.Drawing.Point(203, 56);
            this.lbl_placa_moto.Name = "lbl_placa_moto";
            this.lbl_placa_moto.Size = new System.Drawing.Size(61, 13);
            this.lbl_placa_moto.TabIndex = 25;
            this.lbl_placa_moto.Text = "Placa Moto";
            // 
            // txt_dt_entrega
            // 
            this.txt_dt_entrega.Location = new System.Drawing.Point(112, 72);
            this.txt_dt_entrega.Mask = "00/00/0000";
            this.txt_dt_entrega.Name = "txt_dt_entrega";
            this.txt_dt_entrega.Size = new System.Drawing.Size(73, 20);
            this.txt_dt_entrega.TabIndex = 24;
            this.txt_dt_entrega.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_dt_entrega
            // 
            this.lbl_dt_entrega.AutoSize = true;
            this.lbl_dt_entrega.Location = new System.Drawing.Point(109, 56);
            this.lbl_dt_entrega.Name = "lbl_dt_entrega";
            this.lbl_dt_entrega.Size = new System.Drawing.Size(70, 13);
            this.lbl_dt_entrega.TabIndex = 23;
            this.lbl_dt_entrega.Text = "Data Entrega";
            // 
            // lbl_id_endereco
            // 
            this.lbl_id_endereco.AutoSize = true;
            this.lbl_id_endereco.Location = new System.Drawing.Point(203, 23);
            this.lbl_id_endereco.Name = "lbl_id_endereco";
            this.lbl_id_endereco.Size = new System.Drawing.Size(0, 13);
            this.lbl_id_endereco.TabIndex = 22;
            // 
            // txt_entregador
            // 
            this.txt_entregador.Location = new System.Drawing.Point(6, 121);
            this.txt_entregador.Name = "txt_entregador";
            this.txt_entregador.Size = new System.Drawing.Size(200, 20);
            this.txt_entregador.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Nome Entregador";
            // 
            // rd_delivery_N
            // 
            this.rd_delivery_N.AutoSize = true;
            this.rd_delivery_N.Checked = true;
            this.rd_delivery_N.Location = new System.Drawing.Point(68, 20);
            this.rd_delivery_N.Name = "rd_delivery_N";
            this.rd_delivery_N.Size = new System.Drawing.Size(45, 17);
            this.rd_delivery_N.TabIndex = 12;
            this.rd_delivery_N.TabStop = true;
            this.rd_delivery_N.Text = "Não";
            this.rd_delivery_N.UseVisualStyleBackColor = true;
            this.rd_delivery_N.CheckedChanged += new System.EventHandler(this.rd_delivery_N_CheckedChanged);
            // 
            // rd_delivery_S
            // 
            this.rd_delivery_S.AutoSize = true;
            this.rd_delivery_S.Location = new System.Drawing.Point(6, 20);
            this.rd_delivery_S.Name = "rd_delivery_S";
            this.rd_delivery_S.Size = new System.Drawing.Size(42, 17);
            this.rd_delivery_S.TabIndex = 11;
            this.rd_delivery_S.Text = "Sim";
            this.rd_delivery_S.UseVisualStyleBackColor = true;
            this.rd_delivery_S.CheckedChanged += new System.EventHandler(this.rd_delivery_S_CheckedChanged);
            // 
            // lbl_valor_venda
            // 
            this.lbl_valor_venda.AutoSize = true;
            this.lbl_valor_venda.Location = new System.Drawing.Point(31, 289);
            this.lbl_valor_venda.Name = "lbl_valor_venda";
            this.lbl_valor_venda.Size = new System.Drawing.Size(35, 13);
            this.lbl_valor_venda.TabIndex = 14;
            this.lbl_valor_venda.Text = "label9";
            this.lbl_valor_venda.Visible = false;
            // 
            // Pagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(885, 509);
            this.Controls.Add(this.lbl_valor_venda);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pagamento";
            this.Text = "Pagamento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_pedidos_pgto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_n_parcelas)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rd_delivery_N;
        private System.Windows.Forms.RadioButton rd_delivery_S;
        private System.Windows.Forms.TextBox txt_valor_parcela;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown txt_n_parcelas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_troco;
        private System.Windows.Forms.TextBox txt_valor_venda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_tipo_pagamento;
        private System.Windows.Forms.Button btn_finaliza_pgto;
        private System.Windows.Forms.TextBox txt_valor_pago;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_valor_frete;
        private System.Windows.Forms.Label lbl_id_venda;
        private System.Windows.Forms.Label lbl_id_cliente;
        private System.Windows.Forms.DataGridView gv_pedidos_pgto;
        private System.Windows.Forms.TextBox txt_entregador;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_id_endereco;
        private System.Windows.Forms.MaskedTextBox txt_dt_entrega;
        private System.Windows.Forms.Label lbl_dt_entrega;
        private System.Windows.Forms.TextBox txt_placa_moto;
        private System.Windows.Forms.Label lbl_placa_moto;
        private System.Windows.Forms.Label lbl_valor_venda;
    }
}
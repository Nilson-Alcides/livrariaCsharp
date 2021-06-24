namespace Livraria
{
    partial class Vendas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_item = new System.Windows.Forms.Label();
            this.lbl_qtd_item = new System.Windows.Forms.Label();
            this.lbl_preco_unitario = new System.Windows.Forms.Label();
            this.btn_consulta_produto = new System.Windows.Forms.Label();
            this.lbl_qtd_disponivel = new System.Windows.Forms.Label();
            this.txt_item = new System.Windows.Forms.TextBox();
            this.txt_preco_unit = new System.Windows.Forms.TextBox();
            this.txt_qtd_item = new System.Windows.Forms.TextBox();
            this.txt_qtd_disponivel = new System.Windows.Forms.TextBox();
            this.txt_valor_total = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_id_cliente_venda = new System.Windows.Forms.Label();
            this.gv_cliente_venda = new System.Windows.Forms.DataGridView();
            this.txt_busca_cliente_venda = new System.Windows.Forms.TextBox();
            this.lbl_cliente_venda = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_cod_item = new System.Windows.Forms.Label();
            this.btn_incluir = new System.Windows.Forms.Button();
            this.gv_carrinho = new System.Windows.Forms.DataGridView();
            this.Id_Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete_item = new System.Windows.Forms.DataGridViewLinkColumn();
            this.gv_seleciona_items = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_texto_ajuda1 = new System.Windows.Forms.Label();
            this.rb_produtos = new System.Windows.Forms.RadioButton();
            this.rb_livros = new System.Windows.Forms.RadioButton();
            this.btn_consulta = new System.Windows.Forms.Button();
            this.txt_busca_item = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_cliente_venda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_carrinho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_seleciona_items)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_item
            // 
            this.lbl_item.AutoSize = true;
            this.lbl_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.lbl_item.Location = new System.Drawing.Point(6, 21);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(31, 13);
            this.lbl_item.TabIndex = 1;
            this.lbl_item.Text = "Item";
            // 
            // lbl_qtd_item
            // 
            this.lbl_qtd_item.AutoSize = true;
            this.lbl_qtd_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qtd_item.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.lbl_qtd_item.Location = new System.Drawing.Point(6, 73);
            this.lbl_qtd_item.Name = "lbl_qtd_item";
            this.lbl_qtd_item.Size = new System.Drawing.Size(62, 13);
            this.lbl_qtd_item.TabIndex = 2;
            this.lbl_qtd_item.Text = "Qtde Item";
            // 
            // lbl_preco_unitario
            // 
            this.lbl_preco_unitario.AutoSize = true;
            this.lbl_preco_unitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_preco_unitario.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.lbl_preco_unitario.Location = new System.Drawing.Point(6, 47);
            this.lbl_preco_unitario.Name = "lbl_preco_unitario";
            this.lbl_preco_unitario.Size = new System.Drawing.Size(108, 13);
            this.lbl_preco_unitario.TabIndex = 3;
            this.lbl_preco_unitario.Text = "Preço Unitário R$";
            // 
            // btn_consulta_produto
            // 
            this.btn_consulta_produto.AutoSize = true;
            this.btn_consulta_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consulta_produto.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btn_consulta_produto.Location = new System.Drawing.Point(184, 73);
            this.btn_consulta_produto.Name = "btn_consulta_produto";
            this.btn_consulta_produto.Size = new System.Drawing.Size(158, 13);
            this.btn_consulta_produto.TabIndex = 4;
            this.btn_consulta_produto.Text = "Total Item Selecionado R$";
            // 
            // lbl_qtd_disponivel
            // 
            this.lbl_qtd_disponivel.AutoSize = true;
            this.lbl_qtd_disponivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qtd_disponivel.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.lbl_qtd_disponivel.Location = new System.Drawing.Point(245, 47);
            this.lbl_qtd_disponivel.Name = "lbl_qtd_disponivel";
            this.lbl_qtd_disponivel.Size = new System.Drawing.Size(97, 13);
            this.lbl_qtd_disponivel.TabIndex = 9;
            this.lbl_qtd_disponivel.Text = "Qtde Disponivel";
            // 
            // txt_item
            // 
            this.txt_item.Location = new System.Drawing.Point(118, 18);
            this.txt_item.Name = "txt_item";
            this.txt_item.Size = new System.Drawing.Size(305, 20);
            this.txt_item.TabIndex = 16;
            // 
            // txt_preco_unit
            // 
            this.txt_preco_unit.Enabled = false;
            this.txt_preco_unit.Location = new System.Drawing.Point(118, 44);
            this.txt_preco_unit.Name = "txt_preco_unit";
            this.txt_preco_unit.Size = new System.Drawing.Size(60, 20);
            this.txt_preco_unit.TabIndex = 17;
            // 
            // txt_qtd_item
            // 
            this.txt_qtd_item.Location = new System.Drawing.Point(118, 70);
            this.txt_qtd_item.Name = "txt_qtd_item";
            this.txt_qtd_item.Size = new System.Drawing.Size(60, 20);
            this.txt_qtd_item.TabIndex = 18;
            this.txt_qtd_item.TextChanged += new System.EventHandler(this.txt_qtd_item_TextChanged);
            // 
            // txt_qtd_disponivel
            // 
            this.txt_qtd_disponivel.Enabled = false;
            this.txt_qtd_disponivel.Location = new System.Drawing.Point(348, 44);
            this.txt_qtd_disponivel.Name = "txt_qtd_disponivel";
            this.txt_qtd_disponivel.Size = new System.Drawing.Size(60, 20);
            this.txt_qtd_disponivel.TabIndex = 19;
            // 
            // txt_valor_total
            // 
            this.txt_valor_total.Enabled = false;
            this.txt_valor_total.Location = new System.Drawing.Point(348, 69);
            this.txt_valor_total.Name = "txt_valor_total";
            this.txt_valor_total.Size = new System.Drawing.Size(94, 20);
            this.txt_valor_total.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lbl_cod_item);
            this.groupBox1.Controls.Add(this.btn_incluir);
            this.groupBox1.Controls.Add(this.gv_carrinho);
            this.groupBox1.Controls.Add(this.txt_valor_total);
            this.groupBox1.Controls.Add(this.txt_qtd_disponivel);
            this.groupBox1.Controls.Add(this.txt_qtd_item);
            this.groupBox1.Controls.Add(this.txt_preco_unit);
            this.groupBox1.Controls.Add(this.txt_item);
            this.groupBox1.Controls.Add(this.lbl_qtd_disponivel);
            this.groupBox1.Controls.Add(this.btn_consulta_produto);
            this.groupBox1.Controls.Add(this.lbl_preco_unitario);
            this.groupBox1.Controls.Add(this.lbl_qtd_item);
            this.groupBox1.Controls.Add(this.lbl_item);
            this.groupBox1.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.groupBox1.Location = new System.Drawing.Point(23, 273);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(989, 301);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalhe do Item";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_id_cliente_venda);
            this.groupBox3.Controls.Add(this.gv_cliente_venda);
            this.groupBox3.Controls.Add(this.txt_busca_cliente_venda);
            this.groupBox3.Controls.Add(this.lbl_cliente_venda);
            this.groupBox3.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.groupBox3.Location = new System.Drawing.Point(582, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(400, 222);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cliente";
            // 
            // lbl_id_cliente_venda
            // 
            this.lbl_id_cliente_venda.AutoSize = true;
            this.lbl_id_cliente_venda.Location = new System.Drawing.Point(311, 20);
            this.lbl_id_cliente_venda.Name = "lbl_id_cliente_venda";
            this.lbl_id_cliente_venda.Size = new System.Drawing.Size(0, 13);
            this.lbl_id_cliente_venda.TabIndex = 3;
            // 
            // gv_cliente_venda
            // 
            this.gv_cliente_venda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_cliente_venda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_cliente_venda.Location = new System.Drawing.Point(6, 74);
            this.gv_cliente_venda.Name = "gv_cliente_venda";
            this.gv_cliente_venda.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.gv_cliente_venda.Size = new System.Drawing.Size(388, 142);
            this.gv_cliente_venda.TabIndex = 2;
            this.gv_cliente_venda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_cliente_venda_CellClick);
            // 
            // txt_busca_cliente_venda
            // 
            this.txt_busca_cliente_venda.Location = new System.Drawing.Point(6, 43);
            this.txt_busca_cliente_venda.Name = "txt_busca_cliente_venda";
            this.txt_busca_cliente_venda.Size = new System.Drawing.Size(388, 20);
            this.txt_busca_cliente_venda.TabIndex = 1;
            this.txt_busca_cliente_venda.TextChanged += new System.EventHandler(this.txt_busca_cliente_venda_TextChanged);
            // 
            // lbl_cliente_venda
            // 
            this.lbl_cliente_venda.AutoSize = true;
            this.lbl_cliente_venda.Location = new System.Drawing.Point(6, 27);
            this.lbl_cliente_venda.Name = "lbl_cliente_venda";
            this.lbl_cliente_venda.Size = new System.Drawing.Size(172, 13);
            this.lbl_cliente_venda.TabIndex = 0;
            this.lbl_cliente_venda.Text = "Busque o Cliente por nome ou CPF";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(863, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 39);
            this.button1.TabIndex = 24;
            this.button1.Text = "Fechar Pedido";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_cod_item
            // 
            this.lbl_cod_item.AutoSize = true;
            this.lbl_cod_item.Location = new System.Drawing.Point(450, 21);
            this.lbl_cod_item.Name = "lbl_cod_item";
            this.lbl_cod_item.Size = new System.Drawing.Size(0, 13);
            this.lbl_cod_item.TabIndex = 23;
            // 
            // btn_incluir
            // 
            this.btn_incluir.BackColor = System.Drawing.Color.Black;
            this.btn_incluir.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btn_incluir.Location = new System.Drawing.Point(480, 69);
            this.btn_incluir.Name = "btn_incluir";
            this.btn_incluir.Size = new System.Drawing.Size(80, 21);
            this.btn_incluir.TabIndex = 21;
            this.btn_incluir.Text = "Incluir ";
            this.btn_incluir.UseVisualStyleBackColor = false;
            this.btn_incluir.Click += new System.EventHandler(this.btn_incluir_Click);
            // 
            // gv_carrinho
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gv_carrinho.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gv_carrinho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_carrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_carrinho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Item,
            this.Nome,
            this.Qtde,
            this.Valor_Total,
            this.Valor_Unitario,
            this.delete_item});
            this.gv_carrinho.Location = new System.Drawing.Point(9, 96);
            this.gv_carrinho.Name = "gv_carrinho";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.gv_carrinho.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gv_carrinho.Size = new System.Drawing.Size(560, 190);
            this.gv_carrinho.TabIndex = 22;
            this.gv_carrinho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_carrinho_CellClick);
            // 
            // Id_Item
            // 
            this.Id_Item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Id_Item.FillWeight = 101.7259F;
            this.Id_Item.HeaderText = "Cod_Item";
            this.Id_Item.Name = "Id_Item";
            this.Id_Item.Width = 77;
            // 
            // Nome
            // 
            this.Nome.FillWeight = 101.7259F;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Qtde
            // 
            this.Qtde.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Qtde.FillWeight = 101.7259F;
            this.Qtde.HeaderText = "Qtde";
            this.Qtde.Name = "Qtde";
            this.Qtde.Width = 55;
            // 
            // Valor_Total
            // 
            this.Valor_Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Valor_Total.FillWeight = 101.7259F;
            this.Valor_Total.HeaderText = "Valor Total R$";
            this.Valor_Total.Name = "Valor_Total";
            // 
            // Valor_Unitario
            // 
            this.Valor_Unitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Valor_Unitario.FillWeight = 101.7259F;
            this.Valor_Unitario.HeaderText = "Valor Unit. R$";
            this.Valor_Unitario.Name = "Valor_Unitario";
            this.Valor_Unitario.Width = 98;
            // 
            // delete_item
            // 
            this.delete_item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.delete_item.DefaultCellStyle = dataGridViewCellStyle2;
            this.delete_item.FillWeight = 91.37056F;
            this.delete_item.HeaderText = "Remover";
            this.delete_item.LinkColor = System.Drawing.Color.Red;
            this.delete_item.Name = "delete_item";
            this.delete_item.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delete_item.Text = "X";
            this.delete_item.VisitedLinkColor = System.Drawing.Color.Red;
            this.delete_item.Width = 56;
            // 
            // gv_seleciona_items
            // 
            this.gv_seleciona_items.AllowUserToAddRows = false;
            this.gv_seleciona_items.AllowUserToDeleteRows = false;
            this.gv_seleciona_items.AllowUserToOrderColumns = true;
            this.gv_seleciona_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_seleciona_items.Location = new System.Drawing.Point(6, 96);
            this.gv_seleciona_items.MultiSelect = false;
            this.gv_seleciona_items.Name = "gv_seleciona_items";
            this.gv_seleciona_items.ReadOnly = true;
            this.gv_seleciona_items.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.gv_seleciona_items.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_seleciona_items.Size = new System.Drawing.Size(977, 150);
            this.gv_seleciona_items.TabIndex = 29;
            this.gv_seleciona_items.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cod_item_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_texto_ajuda1);
            this.groupBox2.Controls.Add(this.rb_produtos);
            this.groupBox2.Controls.Add(this.rb_livros);
            this.groupBox2.Controls.Add(this.btn_consulta);
            this.groupBox2.Controls.Add(this.txt_busca_item);
            this.groupBox2.Controls.Add(this.gv_seleciona_items);
            this.groupBox2.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.groupBox2.Location = new System.Drawing.Point(23, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(989, 255);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pedido Livros ou Produtos";
            // 
            // lbl_texto_ajuda1
            // 
            this.lbl_texto_ajuda1.AutoSize = true;
            this.lbl_texto_ajuda1.Location = new System.Drawing.Point(3, 25);
            this.lbl_texto_ajuda1.Name = "lbl_texto_ajuda1";
            this.lbl_texto_ajuda1.Size = new System.Drawing.Size(133, 13);
            this.lbl_texto_ajuda1.TabIndex = 33;
            this.lbl_texto_ajuda1.Text = "Selecione o tipo de busca:";
            // 
            // rb_produtos
            // 
            this.rb_produtos.AutoSize = true;
            this.rb_produtos.Location = new System.Drawing.Point(201, 25);
            this.rb_produtos.Name = "rb_produtos";
            this.rb_produtos.Size = new System.Drawing.Size(67, 17);
            this.rb_produtos.TabIndex = 32;
            this.rb_produtos.TabStop = true;
            this.rb_produtos.Text = "Produtos";
            this.rb_produtos.UseVisualStyleBackColor = true;
            // 
            // rb_livros
            // 
            this.rb_livros.AutoSize = true;
            this.rb_livros.Location = new System.Drawing.Point(142, 25);
            this.rb_livros.Name = "rb_livros";
            this.rb_livros.Size = new System.Drawing.Size(53, 17);
            this.rb_livros.TabIndex = 31;
            this.rb_livros.TabStop = true;
            this.rb_livros.Text = "Livros";
            this.rb_livros.UseVisualStyleBackColor = true;
            // 
            // btn_consulta
            // 
            this.btn_consulta.BackColor = System.Drawing.Color.Black;
            this.btn_consulta.Location = new System.Drawing.Point(295, 44);
            this.btn_consulta.Name = "btn_consulta";
            this.btn_consulta.Size = new System.Drawing.Size(126, 23);
            this.btn_consulta.TabIndex = 30;
            this.btn_consulta.Text = "Buscar";
            this.btn_consulta.UseVisualStyleBackColor = false;
            this.btn_consulta.Click += new System.EventHandler(this.btn_consulta_Click);
            // 
            // txt_busca_item
            // 
            this.txt_busca_item.Location = new System.Drawing.Point(6, 47);
            this.txt_busca_item.Name = "txt_busca_item";
            this.txt_busca_item.Size = new System.Drawing.Size(262, 20);
            this.txt_busca_item.TabIndex = 0;
            // 
            // Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1065, 587);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vendas";
            this.Text = "Vendas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_cliente_venda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_carrinho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_seleciona_items)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_item;
        private System.Windows.Forms.Label lbl_qtd_item;
        private System.Windows.Forms.Label lbl_preco_unitario;
        private System.Windows.Forms.Label btn_consulta_produto;
        private System.Windows.Forms.Label lbl_qtd_disponivel;
        private System.Windows.Forms.TextBox txt_item;
        private System.Windows.Forms.TextBox txt_preco_unit;
        private System.Windows.Forms.TextBox txt_qtd_item;
        private System.Windows.Forms.TextBox txt_qtd_disponivel;
        private System.Windows.Forms.TextBox txt_valor_total;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_incluir;
        private System.Windows.Forms.DataGridView gv_carrinho;
        private System.Windows.Forms.DataGridView gv_seleciona_items;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_busca_item;
        private System.Windows.Forms.Button btn_consulta;
        private System.Windows.Forms.RadioButton rb_produtos;
        private System.Windows.Forms.RadioButton rb_livros;
        private System.Windows.Forms.Label lbl_texto_ajuda1;
        private System.Windows.Forms.Label lbl_cod_item;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView gv_cliente_venda;
        private System.Windows.Forms.TextBox txt_busca_cliente_venda;
        private System.Windows.Forms.Label lbl_cliente_venda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Unitario;
        private System.Windows.Forms.DataGridViewLinkColumn delete_item;
        private System.Windows.Forms.Label lbl_id_cliente_venda;
    }
}
namespace Livraria
{
    partial class Produto
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
            this.lbl_ID_Cliente = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblQuantidae = new System.Windows.Forms.Label();
            this.txtQuatidade = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.txt_Pesquisa = new System.Windows.Forms.TextBox();
            this.btn_Deletar = new System.Windows.Forms.Button();
            this.btn_Consultar = new System.Windows.Forms.Button();
            this.btn_Atualizar = new System.Windows.Forms.Button();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.lbl_Numero = new System.Windows.Forms.Label();
            this.lbl_Complemento = new System.Windows.Forms.Label();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.txt_MarcaProduto = new System.Windows.Forms.TextBox();
            this.txt_ValorUnitarioProduto = new System.Windows.Forms.TextBox();
            this.txt_NomeProduto = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ID_Cliente
            // 
            this.lbl_ID_Cliente.AutoSize = true;
            this.lbl_ID_Cliente.Location = new System.Drawing.Point(657, 393);
            this.lbl_ID_Cliente.Name = "lbl_ID_Cliente";
            this.lbl_ID_Cliente.Size = new System.Drawing.Size(0, 13);
            this.lbl_ID_Cliente.TabIndex = 64;
            this.lbl_ID_Cliente.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimpar);
            this.groupBox1.Controls.Add(this.lblQuantidae);
            this.groupBox1.Controls.Add(this.txtQuatidade);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.dgvProduto);
            this.groupBox1.Controls.Add(this.txt_Pesquisa);
            this.groupBox1.Controls.Add(this.btn_Deletar);
            this.groupBox1.Controls.Add(this.btn_Consultar);
            this.groupBox1.Controls.Add(this.btn_Atualizar);
            this.groupBox1.Controls.Add(this.btn_Cadastrar);
            this.groupBox1.Controls.Add(this.lbl_Numero);
            this.groupBox1.Controls.Add(this.lbl_Complemento);
            this.groupBox1.Controls.Add(this.lbl_Nome);
            this.groupBox1.Controls.Add(this.txt_MarcaProduto);
            this.groupBox1.Controls.Add(this.txt_ValorUnitarioProduto);
            this.groupBox1.Controls.Add(this.txt_NomeProduto);
            this.groupBox1.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 368);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro Produtos";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLimpar.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnLimpar.Location = new System.Drawing.Point(279, 81);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 89;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblQuantidae
            // 
            this.lblQuantidae.AutoSize = true;
            this.lblQuantidae.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.lblQuantidae.Location = new System.Drawing.Point(591, 22);
            this.lblQuantidae.Name = "lblQuantidae";
            this.lblQuantidae.Size = new System.Drawing.Size(62, 13);
            this.lblQuantidae.TabIndex = 88;
            this.lblQuantidae.Text = "Quantidade";
            // 
            // txtQuatidade
            // 
            this.txtQuatidade.Location = new System.Drawing.Point(594, 38);
            this.txtQuatidade.Name = "txtQuatidade";
            this.txtQuatidade.Size = new System.Drawing.Size(82, 20);
            this.txtQuatidade.TabIndex = 3;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(112, 12);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 86;
            this.txtCodigo.Visible = false;
            // 
            // dgvProduto
            // 
            this.dgvProduto.AllowUserToOrderColumns = true;
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.AntiqueWhite;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduto.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProduto.Location = new System.Drawing.Point(5, 122);
            this.dgvProduto.MultiSelect = false;
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.ReadOnly = true;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgvProduto.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduto.Size = new System.Drawing.Size(671, 221);
            this.dgvProduto.TabIndex = 85;
            this.dgvProduto.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProduto_RowHeaderMouseClick);
            this.dgvProduto.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvProduto_RowPostPaint);
            // 
            // txt_Pesquisa
            // 
            this.txt_Pesquisa.Location = new System.Drawing.Point(452, 83);
            this.txt_Pesquisa.Name = "txt_Pesquisa";
            this.txt_Pesquisa.Size = new System.Drawing.Size(224, 20);
            this.txt_Pesquisa.TabIndex = 4;
            // 
            // btn_Deletar
            // 
            this.btn_Deletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Deletar.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btn_Deletar.Location = new System.Drawing.Point(194, 81);
            this.btn_Deletar.Name = "btn_Deletar";
            this.btn_Deletar.Size = new System.Drawing.Size(75, 23);
            this.btn_Deletar.TabIndex = 83;
            this.btn_Deletar.Text = "Deletar";
            this.btn_Deletar.UseVisualStyleBackColor = false;
            this.btn_Deletar.Click += new System.EventHandler(this.btn_Deletar_Click);
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Consultar.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btn_Consultar.Location = new System.Drawing.Point(365, 81);
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(75, 23);
            this.btn_Consultar.TabIndex = 84;
            this.btn_Consultar.Text = "Consultar";
            this.btn_Consultar.UseVisualStyleBackColor = false;
            this.btn_Consultar.Click += new System.EventHandler(this.btn_Consultar_Click);
            // 
            // btn_Atualizar
            // 
            this.btn_Atualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Atualizar.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btn_Atualizar.Location = new System.Drawing.Point(103, 81);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(75, 23);
            this.btn_Atualizar.TabIndex = 81;
            this.btn_Atualizar.Text = "Atualizar";
            this.btn_Atualizar.UseVisualStyleBackColor = false;
            this.btn_Atualizar.Click += new System.EventHandler(this.btn_Atualizar_Click_1);
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Cadastrar.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btn_Cadastrar.Location = new System.Drawing.Point(9, 81);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cadastrar.TabIndex = 80;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = false;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click_1);
            // 
            // lbl_Numero
            // 
            this.lbl_Numero.AutoSize = true;
            this.lbl_Numero.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.lbl_Numero.Location = new System.Drawing.Point(302, 22);
            this.lbl_Numero.Name = "lbl_Numero";
            this.lbl_Numero.Size = new System.Drawing.Size(37, 13);
            this.lbl_Numero.TabIndex = 82;
            this.lbl_Numero.Text = "Marca";
            // 
            // lbl_Complemento
            // 
            this.lbl_Complemento.AutoSize = true;
            this.lbl_Complemento.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.lbl_Complemento.Location = new System.Drawing.Point(474, 22);
            this.lbl_Complemento.Name = "lbl_Complemento";
            this.lbl_Complemento.Size = new System.Drawing.Size(31, 13);
            this.lbl_Complemento.TabIndex = 79;
            this.lbl_Complemento.Text = "Valor";
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.lbl_Nome.Location = new System.Drawing.Point(7, 22);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_Nome.TabIndex = 77;
            this.lbl_Nome.Text = "Nome";
            // 
            // txt_MarcaProduto
            // 
            this.txt_MarcaProduto.Location = new System.Drawing.Point(305, 38);
            this.txt_MarcaProduto.Name = "txt_MarcaProduto";
            this.txt_MarcaProduto.Size = new System.Drawing.Size(155, 20);
            this.txt_MarcaProduto.TabIndex = 1;
            // 
            // txt_ValorUnitarioProduto
            // 
            this.txt_ValorUnitarioProduto.Location = new System.Drawing.Point(477, 38);
            this.txt_ValorUnitarioProduto.Name = "txt_ValorUnitarioProduto";
            this.txt_ValorUnitarioProduto.Size = new System.Drawing.Size(100, 20);
            this.txt_ValorUnitarioProduto.TabIndex = 2;
            this.txt_ValorUnitarioProduto.Enter += new System.EventHandler(this.txt_ValorUnitarioProduto_Enter_1);
            this.txt_ValorUnitarioProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ValorUnitarioProduto_KeyPress_1);
            this.txt_ValorUnitarioProduto.Leave += new System.EventHandler(this.txt_ValorUnitarioProduto_Leave);
            // 
            // txt_NomeProduto
            // 
            this.txt_NomeProduto.Location = new System.Drawing.Point(7, 38);
            this.txt_NomeProduto.Name = "txt_NomeProduto";
            this.txt_NomeProduto.Size = new System.Drawing.Size(279, 20);
            this.txt_NomeProduto.TabIndex = 0;
            // 
            // Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(718, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_ID_Cliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "Produto";
            this.Text = "Produto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_ID_Cliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblQuantidae;
        private System.Windows.Forms.TextBox txtQuatidade;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.TextBox txt_Pesquisa;
        private System.Windows.Forms.Button btn_Deletar;
        private System.Windows.Forms.Button btn_Consultar;
        private System.Windows.Forms.Button btn_Atualizar;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.Label lbl_Numero;
        private System.Windows.Forms.Label lbl_Complemento;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.TextBox txt_MarcaProduto;
        private System.Windows.Forms.TextBox txt_ValorUnitarioProduto;
        private System.Windows.Forms.TextBox txt_NomeProduto;
    }
}
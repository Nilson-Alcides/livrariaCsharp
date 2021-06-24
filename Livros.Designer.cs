namespace Livraria
{
    partial class Livros
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
            this.gpb_cadastro_livros = new System.Windows.Forms.GroupBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.dgvLivro = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_qtd_estoque = new System.Windows.Forms.NumericUpDown();
            this.lbl_Categoria = new System.Windows.Forms.Label();
            this.cmb_Categoria = new System.Windows.Forms.ComboBox();
            this.txt_Autor = new System.Windows.Forms.TextBox();
            this.lbl_Autor = new System.Windows.Forms.Label();
            this.btn_Deletar = new System.Windows.Forms.Button();
            this.btn_Consultar = new System.Windows.Forms.Button();
            this.btn_Atualizar = new System.Windows.Forms.Button();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.lbl_ISBN = new System.Windows.Forms.Label();
            this.lbl_Editora = new System.Windows.Forms.Label();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.txt_Editora = new System.Windows.Forms.TextBox();
            this.txt_ISBN = new System.Windows.Forms.TextBox();
            this.txt_Titulo = new System.Windows.Forms.TextBox();
            this.lbl_livros = new System.Windows.Forms.Label();
            this.gpb_cadastro_livros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_qtd_estoque)).BeginInit();
            this.SuspendLayout();
            // 
            // gpb_cadastro_livros
            // 
            this.gpb_cadastro_livros.Controls.Add(this.lblCodigo);
            this.gpb_cadastro_livros.Controls.Add(this.btnLimpar);
            this.gpb_cadastro_livros.Controls.Add(this.lblValor);
            this.gpb_cadastro_livros.Controls.Add(this.txtPesquisa);
            this.gpb_cadastro_livros.Controls.Add(this.txtValor);
            this.gpb_cadastro_livros.Controls.Add(this.dgvLivro);
            this.gpb_cadastro_livros.Controls.Add(this.label1);
            this.gpb_cadastro_livros.Controls.Add(this.txt_qtd_estoque);
            this.gpb_cadastro_livros.Controls.Add(this.lbl_Categoria);
            this.gpb_cadastro_livros.Controls.Add(this.cmb_Categoria);
            this.gpb_cadastro_livros.Controls.Add(this.txt_Autor);
            this.gpb_cadastro_livros.Controls.Add(this.lbl_Autor);
            this.gpb_cadastro_livros.Controls.Add(this.btn_Deletar);
            this.gpb_cadastro_livros.Controls.Add(this.btn_Consultar);
            this.gpb_cadastro_livros.Controls.Add(this.btn_Atualizar);
            this.gpb_cadastro_livros.Controls.Add(this.btn_Cadastrar);
            this.gpb_cadastro_livros.Controls.Add(this.lbl_ISBN);
            this.gpb_cadastro_livros.Controls.Add(this.lbl_Editora);
            this.gpb_cadastro_livros.Controls.Add(this.lbl_Titulo);
            this.gpb_cadastro_livros.Controls.Add(this.txt_Editora);
            this.gpb_cadastro_livros.Controls.Add(this.txt_ISBN);
            this.gpb_cadastro_livros.Controls.Add(this.txt_Titulo);
            this.gpb_cadastro_livros.Controls.Add(this.lbl_livros);
            this.gpb_cadastro_livros.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.gpb_cadastro_livros.Location = new System.Drawing.Point(12, 12);
            this.gpb_cadastro_livros.Name = "gpb_cadastro_livros";
            this.gpb_cadastro_livros.Size = new System.Drawing.Size(859, 395);
            this.gpb_cadastro_livros.TabIndex = 0;
            this.gpb_cadastro_livros.TabStop = false;
            this.gpb_cadastro_livros.Text = "Cadastro de Livros ";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.lblCodigo.Location = new System.Drawing.Point(702, 38);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(0, 13);
            this.lblCodigo.TabIndex = 96;
            this.lblCodigo.Visible = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLimpar.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnLimpar.Location = new System.Drawing.Point(279, 129);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.lblValor.Location = new System.Drawing.Point(425, 68);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 95;
            this.lblValor.Text = "Valor";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(443, 131);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(114, 20);
            this.txtPesquisa.TabIndex = 94;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(425, 84);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(132, 20);
            this.txtValor.TabIndex = 7;
            // 
            // dgvLivro
            // 
            this.dgvLivro.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            this.dgvLivro.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLivro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.AntiqueWhite;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLivro.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLivro.Location = new System.Drawing.Point(10, 178);
            this.dgvLivro.MultiSelect = false;
            this.dgvLivro.Name = "dgvLivro";
            this.dgvLivro.ReadOnly = true;
            this.dgvLivro.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvLivro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLivro.Size = new System.Drawing.Size(834, 203);
            this.dgvLivro.TabIndex = 15;
            this.dgvLivro.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvLivro_RowHeaderMouseClick);
            this.dgvLivro.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvLivro_RowPostPaint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label1.Location = new System.Drawing.Point(350, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 91;
            this.label1.Text = "Qtd. Estoque";
            // 
            // txt_qtd_estoque
            // 
            this.txt_qtd_estoque.Location = new System.Drawing.Point(349, 83);
            this.txt_qtd_estoque.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txt_qtd_estoque.Name = "txt_qtd_estoque";
            this.txt_qtd_estoque.Size = new System.Drawing.Size(69, 20);
            this.txt_qtd_estoque.TabIndex = 6;
            // 
            // lbl_Categoria
            // 
            this.lbl_Categoria.AutoSize = true;
            this.lbl_Categoria.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.lbl_Categoria.Location = new System.Drawing.Point(221, 66);
            this.lbl_Categoria.Name = "lbl_Categoria";
            this.lbl_Categoria.Size = new System.Drawing.Size(52, 13);
            this.lbl_Categoria.TabIndex = 88;
            this.lbl_Categoria.Text = "Categoria";
            // 
            // cmb_Categoria
            // 
            this.cmb_Categoria.FormattingEnabled = true;
            this.cmb_Categoria.Location = new System.Drawing.Point(224, 83);
            this.cmb_Categoria.Name = "cmb_Categoria";
            this.cmb_Categoria.Size = new System.Drawing.Size(115, 21);
            this.cmb_Categoria.TabIndex = 5;
            this.cmb_Categoria.SelectedIndexChanged += new System.EventHandler(this.cmb_Categoria_SelectedIndexChanged_1);
            // 
            // txt_Autor
            // 
            this.txt_Autor.Location = new System.Drawing.Point(224, 35);
            this.txt_Autor.Name = "txt_Autor";
            this.txt_Autor.Size = new System.Drawing.Size(115, 20);
            this.txt_Autor.TabIndex = 1;
            // 
            // lbl_Autor
            // 
            this.lbl_Autor.AutoSize = true;
            this.lbl_Autor.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.lbl_Autor.Location = new System.Drawing.Point(221, 19);
            this.lbl_Autor.Name = "lbl_Autor";
            this.lbl_Autor.Size = new System.Drawing.Size(32, 13);
            this.lbl_Autor.TabIndex = 86;
            this.lbl_Autor.Text = "Autor";
            // 
            // btn_Deletar
            // 
            this.btn_Deletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Deletar.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btn_Deletar.Location = new System.Drawing.Point(195, 129);
            this.btn_Deletar.Name = "btn_Deletar";
            this.btn_Deletar.Size = new System.Drawing.Size(75, 23);
            this.btn_Deletar.TabIndex = 10;
            this.btn_Deletar.Text = "Deletar";
            this.btn_Deletar.UseVisualStyleBackColor = false;
            this.btn_Deletar.Click += new System.EventHandler(this.btn_Deletar_Click);
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Consultar.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btn_Consultar.Location = new System.Drawing.Point(362, 129);
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(75, 23);
            this.btn_Consultar.TabIndex = 13;
            this.btn_Consultar.Text = "Consultar";
            this.btn_Consultar.UseVisualStyleBackColor = false;
            this.btn_Consultar.Click += new System.EventHandler(this.btn_Consultar_Click);
            // 
            // btn_Atualizar
            // 
            this.btn_Atualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Atualizar.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btn_Atualizar.Location = new System.Drawing.Point(104, 129);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(75, 23);
            this.btn_Atualizar.TabIndex = 9;
            this.btn_Atualizar.Text = "Atualizar";
            this.btn_Atualizar.UseVisualStyleBackColor = false;
            this.btn_Atualizar.Click += new System.EventHandler(this.btn_Atualizar_Click);
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Cadastrar.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btn_Cadastrar.Location = new System.Drawing.Point(10, 129);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cadastrar.TabIndex = 8;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = false;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // lbl_ISBN
            // 
            this.lbl_ISBN.AutoSize = true;
            this.lbl_ISBN.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.lbl_ISBN.Location = new System.Drawing.Point(10, 67);
            this.lbl_ISBN.Name = "lbl_ISBN";
            this.lbl_ISBN.Size = new System.Drawing.Size(32, 13);
            this.lbl_ISBN.TabIndex = 85;
            this.lbl_ISBN.Text = "ISBN";
            // 
            // lbl_Editora
            // 
            this.lbl_Editora.AutoSize = true;
            this.lbl_Editora.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.lbl_Editora.Location = new System.Drawing.Point(345, 19);
            this.lbl_Editora.Name = "lbl_Editora";
            this.lbl_Editora.Size = new System.Drawing.Size(40, 13);
            this.lbl_Editora.TabIndex = 84;
            this.lbl_Editora.Text = "Editora";
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.lbl_Titulo.Location = new System.Drawing.Point(10, 19);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(33, 13);
            this.lbl_Titulo.TabIndex = 77;
            this.lbl_Titulo.Text = "Titulo";
            // 
            // txt_Editora
            // 
            this.txt_Editora.Location = new System.Drawing.Point(348, 35);
            this.txt_Editora.Name = "txt_Editora";
            this.txt_Editora.Size = new System.Drawing.Size(209, 20);
            this.txt_Editora.TabIndex = 2;
            // 
            // txt_ISBN
            // 
            this.txt_ISBN.Location = new System.Drawing.Point(10, 83);
            this.txt_ISBN.Name = "txt_ISBN";
            this.txt_ISBN.Size = new System.Drawing.Size(202, 20);
            this.txt_ISBN.TabIndex = 3;
            // 
            // txt_Titulo
            // 
            this.txt_Titulo.Location = new System.Drawing.Point(10, 35);
            this.txt_Titulo.Name = "txt_Titulo";
            this.txt_Titulo.Size = new System.Drawing.Size(202, 20);
            this.txt_Titulo.TabIndex = 0;
            // 
            // lbl_livros
            // 
            this.lbl_livros.AutoSize = true;
            this.lbl_livros.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.lbl_livros.Location = new System.Drawing.Point(362, 113);
            this.lbl_livros.Name = "lbl_livros";
            this.lbl_livros.Size = new System.Drawing.Size(35, 13);
            this.lbl_livros.TabIndex = 73;
            this.lbl_livros.Text = "Livros";
            // 
            // Livros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(907, 450);
            this.Controls.Add(this.gpb_cadastro_livros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Livros";
            this.Text = " Livros";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gpb_cadastro_livros.ResumeLayout(false);
            this.gpb_cadastro_livros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_qtd_estoque)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_cadastro_livros;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.DataGridView dgvLivro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txt_qtd_estoque;
        private System.Windows.Forms.Label lbl_Categoria;
        private System.Windows.Forms.ComboBox cmb_Categoria;
        private System.Windows.Forms.TextBox txt_Autor;
        private System.Windows.Forms.Label lbl_Autor;
        private System.Windows.Forms.Button btn_Deletar;
        private System.Windows.Forms.Button btn_Consultar;
        private System.Windows.Forms.Button btn_Atualizar;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.Label lbl_ISBN;
        private System.Windows.Forms.Label lbl_Editora;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.TextBox txt_Editora;
        private System.Windows.Forms.TextBox txt_ISBN;
        private System.Windows.Forms.TextBox txt_Titulo;
        private System.Windows.Forms.Label lbl_livros;
        private System.Windows.Forms.Label lblCodigo;
    }
}
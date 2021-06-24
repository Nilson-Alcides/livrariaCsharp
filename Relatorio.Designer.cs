namespace Livraria
{
    partial class Relatorio
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
            this.gbRelatori = new System.Windows.Forms.GroupBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.txt_data_Final = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_data_Inicio = new System.Windows.Forms.MaskedTextBox();
            this.lbl_nascimento = new System.Windows.Forms.Label();
            this.lbl_texto_ajuda1 = new System.Windows.Forms.Label();
            this.rb_produtos = new System.Windows.Forms.RadioButton();
            this.rb_livros = new System.Windows.Forms.RadioButton();
            this.btn_consulta = new System.Windows.Forms.Button();
            this.txt_busca_item = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gbRelatori.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // gbRelatori
            // 
            this.gbRelatori.Controls.Add(this.button1);
            this.gbRelatori.Controls.Add(this.dgvClientes);
            this.gbRelatori.Controls.Add(this.txt_data_Final);
            this.gbRelatori.Controls.Add(this.label1);
            this.gbRelatori.Controls.Add(this.txt_data_Inicio);
            this.gbRelatori.Controls.Add(this.lbl_nascimento);
            this.gbRelatori.Controls.Add(this.lbl_texto_ajuda1);
            this.gbRelatori.Controls.Add(this.rb_produtos);
            this.gbRelatori.Controls.Add(this.rb_livros);
            this.gbRelatori.Controls.Add(this.btn_consulta);
            this.gbRelatori.Controls.Add(this.txt_busca_item);
            this.gbRelatori.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.gbRelatori.Location = new System.Drawing.Point(12, 12);
            this.gbRelatori.Name = "gbRelatori";
            this.gbRelatori.Size = new System.Drawing.Size(902, 437);
            this.gbRelatori.TabIndex = 0;
            this.gbRelatori.TabStop = false;
            this.gbRelatori.Text = "Relatorios";
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
            this.dgvClientes.Location = new System.Drawing.Point(19, 110);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgvClientes.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClientes.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial Narrow", 7.25F);
            this.dgvClientes.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(866, 250);
            this.dgvClientes.TabIndex = 49;
            // 
            // txt_data_Final
            // 
            this.txt_data_Final.Location = new System.Drawing.Point(155, 71);
            this.txt_data_Final.Mask = "00/00/0000";
            this.txt_data_Final.Name = "txt_data_Final";
            this.txt_data_Final.Size = new System.Drawing.Size(100, 20);
            this.txt_data_Final.TabIndex = 44;
            this.txt_data_Final.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Data Final";
            // 
            // txt_data_Inicio
            // 
            this.txt_data_Inicio.Location = new System.Drawing.Point(19, 71);
            this.txt_data_Inicio.Mask = "00/00/0000";
            this.txt_data_Inicio.Name = "txt_data_Inicio";
            this.txt_data_Inicio.Size = new System.Drawing.Size(100, 20);
            this.txt_data_Inicio.TabIndex = 42;
            this.txt_data_Inicio.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_nascimento
            // 
            this.lbl_nascimento.AutoSize = true;
            this.lbl_nascimento.Location = new System.Drawing.Point(16, 53);
            this.lbl_nascimento.Name = "lbl_nascimento";
            this.lbl_nascimento.Size = new System.Drawing.Size(60, 13);
            this.lbl_nascimento.TabIndex = 43;
            this.lbl_nascimento.Text = "Data Inicial";
            // 
            // lbl_texto_ajuda1
            // 
            this.lbl_texto_ajuda1.AutoSize = true;
            this.lbl_texto_ajuda1.Location = new System.Drawing.Point(16, 28);
            this.lbl_texto_ajuda1.Name = "lbl_texto_ajuda1";
            this.lbl_texto_ajuda1.Size = new System.Drawing.Size(133, 13);
            this.lbl_texto_ajuda1.TabIndex = 38;
            this.lbl_texto_ajuda1.Text = "Selecione o tipo de busca:";
            // 
            // rb_produtos
            // 
            this.rb_produtos.AutoSize = true;
            this.rb_produtos.Location = new System.Drawing.Point(258, 28);
            this.rb_produtos.Name = "rb_produtos";
            this.rb_produtos.Size = new System.Drawing.Size(114, 17);
            this.rb_produtos.TabIndex = 37;
            this.rb_produtos.TabStop = true;
            this.rb_produtos.Text = "Produtos Vendidos";
            this.rb_produtos.UseVisualStyleBackColor = true;
            // 
            // rb_livros
            // 
            this.rb_livros.AutoSize = true;
            this.rb_livros.Location = new System.Drawing.Point(155, 28);
            this.rb_livros.Name = "rb_livros";
            this.rb_livros.Size = new System.Drawing.Size(100, 17);
            this.rb_livros.TabIndex = 36;
            this.rb_livros.TabStop = true;
            this.rb_livros.Text = "Livros Vendidos";
            this.rb_livros.UseVisualStyleBackColor = true;
            // 
            // btn_consulta
            // 
            this.btn_consulta.BackColor = System.Drawing.Color.Black;
            this.btn_consulta.Location = new System.Drawing.Point(711, 71);
            this.btn_consulta.Name = "btn_consulta";
            this.btn_consulta.Size = new System.Drawing.Size(126, 23);
            this.btn_consulta.TabIndex = 35;
            this.btn_consulta.Text = "Buscar";
            this.btn_consulta.UseVisualStyleBackColor = false;
            this.btn_consulta.Click += new System.EventHandler(this.btn_consulta_Click);
            // 
            // txt_busca_item
            // 
            this.txt_busca_item.Location = new System.Drawing.Point(428, 71);
            this.txt_busca_item.Name = "txt_busca_item";
            this.txt_busca_item.Size = new System.Drawing.Size(262, 20);
            this.txt_busca_item.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(273, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 50;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(944, 461);
            this.Controls.Add(this.gbRelatori);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Relatorio";
            this.Text = "Relatorio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gbRelatori.ResumeLayout(false);
            this.gbRelatori.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRelatori;
        private System.Windows.Forms.Label lbl_texto_ajuda1;
        private System.Windows.Forms.RadioButton rb_produtos;
        private System.Windows.Forms.RadioButton rb_livros;
        private System.Windows.Forms.Button btn_consulta;
        private System.Windows.Forms.TextBox txt_busca_item;
        private System.Windows.Forms.MaskedTextBox txt_data_Inicio;
        private System.Windows.Forms.Label lbl_nascimento;
        private System.Windows.Forms.MaskedTextBox txt_data_Final;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button button1;
    }
}
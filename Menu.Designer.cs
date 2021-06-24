namespace Livraria
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btn_Livros = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnl_conteudo = new System.Windows.Forms.Panel();
            this.pnl_titulo = new System.Windows.Forms.Panel();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_maximizar = new System.Windows.Forms.Button();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.lbl_rodape = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_menu
            // 
            this.pnl_menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnl_menu.BackColor = System.Drawing.Color.DarkCyan;
            this.pnl_menu.Controls.Add(this.pictureBox2);
            this.pnl_menu.Controls.Add(this.button8);
            this.pnl_menu.Controls.Add(this.button7);
            this.pnl_menu.Controls.Add(this.button6);
            this.pnl_menu.Controls.Add(this.btn_Livros);
            this.pnl_menu.Controls.Add(this.btnClientes);
            this.pnl_menu.Controls.Add(this.button1);
            this.pnl_menu.Location = new System.Drawing.Point(1, 31);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(204, 509);
            this.pnl_menu.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Livraria.Properties.Resources.Logo_Livraria;
            this.pictureBox2.Location = new System.Drawing.Point(15, 235);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(171, 148);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = global::Livraria.Properties.Resources.relatorio;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(0, 173);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(205, 39);
            this.button8.TabIndex = 5;
            this.button8.Text = "           Relatórios";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Image = global::Livraria.Properties.Resources.pay2;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(-1, 137);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(205, 39);
            this.button7.TabIndex = 4;
            this.button7.Text = "           Vendas";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = global::Livraria.Properties.Resources.produtos;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(-1, 67);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(205, 39);
            this.button6.TabIndex = 3;
            this.button6.Text = "           Produtos";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn_Livros
            // 
            this.btn_Livros.FlatAppearance.BorderSize = 0;
            this.btn_Livros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btn_Livros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Livros.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Livros.ForeColor = System.Drawing.Color.White;
            this.btn_Livros.Image = global::Livraria.Properties.Resources.books3;
            this.btn_Livros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Livros.Location = new System.Drawing.Point(0, 32);
            this.btn_Livros.Name = "btn_Livros";
            this.btn_Livros.Size = new System.Drawing.Size(204, 39);
            this.btn_Livros.TabIndex = 2;
            this.btn_Livros.Text = "           Livros";
            this.btn_Livros.UseVisualStyleBackColor = true;
            this.btn_Livros.Click += new System.EventHandler(this.btn_Livros_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(-1, 0);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(204, 39);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "           Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-1, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "           Pedidos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnl_conteudo
            // 
            this.pnl_conteudo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_conteudo.BackColor = System.Drawing.Color.SlateGray;
            this.pnl_conteudo.Location = new System.Drawing.Point(203, 31);
            this.pnl_conteudo.Name = "pnl_conteudo";
            this.pnl_conteudo.Size = new System.Drawing.Size(1074, 452);
            this.pnl_conteudo.TabIndex = 2;
            // 
            // pnl_titulo
            // 
            this.pnl_titulo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnl_titulo.Controls.Add(this.lbl_titulo);
            this.pnl_titulo.Controls.Add(this.button2);
            this.pnl_titulo.Controls.Add(this.btn_maximizar);
            this.pnl_titulo.Controls.Add(this.btn_Fechar);
            this.pnl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_titulo.Location = new System.Drawing.Point(0, 0);
            this.pnl_titulo.Name = "pnl_titulo";
            this.pnl_titulo.Size = new System.Drawing.Size(1277, 33);
            this.pnl_titulo.TabIndex = 0;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_titulo.Location = new System.Drawing.Point(12, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(176, 20);
            this.lbl_titulo.TabIndex = 4;
            this.lbl_titulo.Text = "SISTEMA LIVRARIA";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(1147, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 30);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_maximizar.FlatAppearance.BorderSize = 0;
            this.btn_maximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_maximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_maximizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_maximizar.Image")));
            this.btn_maximizar.Location = new System.Drawing.Point(1193, 0);
            this.btn_maximizar.Name = "btn_maximizar";
            this.btn_maximizar.Size = new System.Drawing.Size(38, 30);
            this.btn_maximizar.TabIndex = 2;
            this.btn_maximizar.UseVisualStyleBackColor = true;
            this.btn_maximizar.Click += new System.EventHandler(this.btn_maximizar_Click);
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Fechar.FlatAppearance.BorderSize = 0;
            this.btn_Fechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Fechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Fechar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Fechar.Image")));
            this.btn_Fechar.Location = new System.Drawing.Point(1239, 0);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(38, 30);
            this.btn_Fechar.TabIndex = 3;
            this.btn_Fechar.UseVisualStyleBackColor = true;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // lbl_rodape
            // 
            this.lbl_rodape.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_rodape.AutoSize = true;
            this.lbl_rodape.Location = new System.Drawing.Point(1066, 520);
            this.lbl_rodape.Name = "lbl_rodape";
            this.lbl_rodape.Size = new System.Drawing.Size(93, 13);
            this.lbl_rodape.TabIndex = 32;
            this.lbl_rodape.Text = "Desenvolvido por:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Livraria.Properties.Resources.novo_logo;
            this.pictureBox1.Location = new System.Drawing.Point(1165, 501);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1277, 542);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_rodape);
            this.Controls.Add(this.pnl_conteudo);
            this.Controls.Add(this.pnl_menu);
            this.Controls.Add(this.pnl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnl_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnl_titulo.ResumeLayout(false);
            this.pnl_titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnl_menu;
        private System.Windows.Forms.Panel pnl_conteudo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnl_titulo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_maximizar;
        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.Button btn_Livros;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_rodape;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
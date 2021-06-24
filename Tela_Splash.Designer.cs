namespace Livraria
{
    partial class Tela_Splash
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_porcentagem = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Imagem_Logo = new System.Windows.Forms.PictureBox();
            this.Barra_Progresso = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imagem_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_porcentagem
            // 
            this.lbl_porcentagem.AutoSize = true;
            this.lbl_porcentagem.BackColor = System.Drawing.Color.Transparent;
            this.lbl_porcentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_porcentagem.Location = new System.Drawing.Point(523, 213);
            this.lbl_porcentagem.Name = "lbl_porcentagem";
            this.lbl_porcentagem.Size = new System.Drawing.Size(0, 20);
            this.lbl_porcentagem.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Livraria.Properties.Resources.Gifs_animados_livro_2;
            this.pictureBox1.Location = new System.Drawing.Point(177, 199);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Imagem_Logo
            // 
            this.Imagem_Logo.Image = global::Livraria.Properties.Resources.Logo_Livraria;
            this.Imagem_Logo.Location = new System.Drawing.Point(0, 1);
            this.Imagem_Logo.Name = "Imagem_Logo";
            this.Imagem_Logo.Size = new System.Drawing.Size(611, 198);
            this.Imagem_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imagem_Logo.TabIndex = 0;
            this.Imagem_Logo.TabStop = false;
            // 
            // Barra_Progresso
            // 
            this.Barra_Progresso.Location = new System.Drawing.Point(0, 199);
            this.Barra_Progresso.Name = "Barra_Progresso";
            this.Barra_Progresso.Size = new System.Drawing.Size(434, 41);
            this.Barra_Progresso.TabIndex = 1;
            this.Barra_Progresso.Visible = false;
            // 
            // Tela_Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 242);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_porcentagem);
            this.Controls.Add(this.Barra_Progresso);
            this.Controls.Add(this.Imagem_Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tela_Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imagem_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Imagem_Logo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_porcentagem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar Barra_Progresso;
    }
}


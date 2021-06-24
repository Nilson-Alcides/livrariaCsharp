namespace Livraria
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txt_login = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.btn_logar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.lbl_rodape = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(201, 186);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(160, 20);
            this.txt_login.TabIndex = 0;
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(201, 225);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(160, 20);
            this.txt_senha.TabIndex = 1;
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Location = new System.Drawing.Point(139, 189);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(33, 13);
            this.lbl_login.TabIndex = 2;
            this.lbl_login.Text = "Login";
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Location = new System.Drawing.Point(134, 228);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(38, 13);
            this.lbl_senha.TabIndex = 3;
            this.lbl_senha.Text = "Senha";
            // 
            // btn_logar
            // 
            this.btn_logar.Location = new System.Drawing.Point(201, 264);
            this.btn_logar.Name = "btn_logar";
            this.btn_logar.Size = new System.Drawing.Size(75, 23);
            this.btn_logar.TabIndex = 4;
            this.btn_logar.Text = "OK";
            this.btn_logar.UseVisualStyleBackColor = true;
            this.btn_logar.Click += new System.EventHandler(this.btn_logar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(286, 264);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 5;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // lbl_rodape
            // 
            this.lbl_rodape.AutoSize = true;
            this.lbl_rodape.Location = new System.Drawing.Point(73, 331);
            this.lbl_rodape.Name = "lbl_rodape";
            this.lbl_rodape.Size = new System.Drawing.Size(93, 13);
            this.lbl_rodape.TabIndex = 7;
            this.lbl_rodape.Text = "Desenvolvido por:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Livraria.Properties.Resources.Logo_Livraria;
            this.pictureBox2.Location = new System.Drawing.Point(142, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(287, 152);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Livraria.Properties.Resources.novo_logo;
            this.pictureBox1.Location = new System.Drawing.Point(184, 293);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AcceptButton = this.btn_logar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(567, 371);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbl_rodape);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_logar);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.txt_login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.Button btn_logar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_rodape;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
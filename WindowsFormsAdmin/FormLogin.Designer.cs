namespace WindowsFormsAdmin
{
    partial class FormLogin
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
            this.llblRegistrar = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.pbxSenha = new System.Windows.Forms.PictureBox();
            this.pbxUsuario = new System.Windows.Forms.PictureBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.tbxSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pnlAzul = new System.Windows.Forms.Panel();
            this.lblBiblioteca = new System.Windows.Forms.Label();
            this.lblSistema = new System.Windows.Forms.Label();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUsuario)).BeginInit();
            this.pnlAzul.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // llblRegistrar
            // 
            this.llblRegistrar.AutoSize = true;
            this.llblRegistrar.Location = new System.Drawing.Point(351, 476);
            this.llblRegistrar.Name = "llblRegistrar";
            this.llblRegistrar.Size = new System.Drawing.Size(132, 13);
            this.llblRegistrar.TabIndex = 21;
            this.llblRegistrar.TabStop = true;
            this.llblRegistrar.Text = "Não tem usuario , Registre";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(367, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Teste";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pbxSenha
            // 
            this.pbxSenha.Location = new System.Drawing.Point(256, 240);
            this.pbxSenha.Name = "pbxSenha";
            this.pbxSenha.Size = new System.Drawing.Size(40, 40);
            this.pbxSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSenha.TabIndex = 19;
            this.pbxSenha.TabStop = false;
            // 
            // pbxUsuario
            // 
            this.pbxUsuario.Location = new System.Drawing.Point(256, 151);
            this.pbxUsuario.Name = "pbxUsuario";
            this.pbxUsuario.Size = new System.Drawing.Size(40, 40);
            this.pbxUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxUsuario.TabIndex = 18;
            this.pbxUsuario.TabStop = false;
            // 
            // btnEntrar
            // 
            this.btnEntrar.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnEntrar.FlatAppearance.BorderSize = 2;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnEntrar.Location = new System.Drawing.Point(351, 314);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(78, 48);
            this.btnEntrar.TabIndex = 17;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // tbxSenha
            // 
            this.tbxSenha.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSenha.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbxSenha.Location = new System.Drawing.Point(307, 249);
            this.tbxSenha.MaxLength = 12;
            this.tbxSenha.Multiline = true;
            this.tbxSenha.Name = "tbxSenha";
            this.tbxSenha.PasswordChar = '*';
            this.tbxSenha.Size = new System.Drawing.Size(189, 31);
            this.tbxSenha.TabIndex = 16;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSenha.Location = new System.Drawing.Point(302, 224);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(69, 25);
            this.lblSenha.TabIndex = 15;
            this.lblSenha.Text = "Senha:";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmail.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbxEmail.Location = new System.Drawing.Point(307, 159);
            this.tbxEmail.Multiline = true;
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(189, 32);
            this.tbxEmail.TabIndex = 14;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblEmail.Location = new System.Drawing.Point(302, 131);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(72, 25);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "E-mail:";
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnFechar.Location = new System.Drawing.Point(572, -125);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(40, 40);
            this.btnFechar.TabIndex = 12;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // pnlAzul
            // 
            this.pnlAzul.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pnlAzul.Controls.Add(this.lblBiblioteca);
            this.pnlAzul.Controls.Add(this.lblSistema);
            this.pnlAzul.Controls.Add(this.lblBemVindo);
            this.pnlAzul.Controls.Add(this.pbxLogo);
            this.pnlAzul.Location = new System.Drawing.Point(-288, -125);
            this.pnlAzul.Name = "pnlAzul";
            this.pnlAzul.Size = new System.Drawing.Size(400, 700);
            this.pnlAzul.TabIndex = 11;
            // 
            // lblBiblioteca
            // 
            this.lblBiblioteca.AutoSize = true;
            this.lblBiblioteca.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBiblioteca.ForeColor = System.Drawing.SystemColors.Window;
            this.lblBiblioteca.Location = new System.Drawing.Point(98, 442);
            this.lblBiblioteca.Name = "lblBiblioteca";
            this.lblBiblioteca.Size = new System.Drawing.Size(197, 45);
            this.lblBiblioteca.TabIndex = 3;
            this.lblBiblioteca.Text = "Bibliotecário";
            // 
            // lblSistema
            // 
            this.lblSistema.AutoSize = true;
            this.lblSistema.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSistema.ForeColor = System.Drawing.SystemColors.Window;
            this.lblSistema.Location = new System.Drawing.Point(42, 397);
            this.lblSistema.Name = "lblSistema";
            this.lblSistema.Size = new System.Drawing.Size(321, 45);
            this.lblSistema.TabIndex = 2;
            this.lblSistema.Text = "Sistema de Controle";
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindo.ForeColor = System.Drawing.SystemColors.Window;
            this.lblBemVindo.Location = new System.Drawing.Point(56, 352);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(287, 45);
            this.lblBemVindo.TabIndex = 1;
            this.lblBemVindo.Text = "Seja bem-vindo ao";
            // 
            // pbxLogo
            // 
            this.pbxLogo.Location = new System.Drawing.Point(135, 200);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(130, 130);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 0;
            this.pbxLogo.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 618);
            this.Controls.Add(this.llblRegistrar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbxSenha);
            this.Controls.Add(this.pbxUsuario);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.tbxSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.pnlAzul);
            this.Name = "FormLogin";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUsuario)).EndInit();
            this.pnlAzul.ResumeLayout(false);
            this.pnlAzul.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llblRegistrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbxSenha;
        private System.Windows.Forms.PictureBox pbxUsuario;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.TextBox tbxSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel pnlAzul;
        private System.Windows.Forms.Label lblBiblioteca;
        private System.Windows.Forms.Label lblSistema;
        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.PictureBox pbxLogo;
    }
}


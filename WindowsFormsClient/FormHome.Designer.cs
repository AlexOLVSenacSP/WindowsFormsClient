namespace WindowsFormsClient
{
    partial class FormHome
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
            this.pnlAzul = new System.Windows.Forms.Panel();
            this.btnInicio = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.btnSobre = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnFaq = new System.Windows.Forms.Button();
            this.btnLivros = new System.Windows.Forms.Button();
            this.pnlAzul.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAzul
            // 
            this.pnlAzul.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pnlAzul.Controls.Add(this.btnLivros);
            this.pnlAzul.Controls.Add(this.btnFaq);
            this.pnlAzul.Controls.Add(this.btnSair);
            this.pnlAzul.Controls.Add(this.btnSobre);
            this.pnlAzul.Controls.Add(this.pbxLogo);
            this.pnlAzul.Controls.Add(this.btnInicio);
            this.pnlAzul.Location = new System.Drawing.Point(0, 0);
            this.pnlAzul.Name = "pnlAzul";
            this.pnlAzul.Size = new System.Drawing.Size(300, 700);
            this.pnlAzul.TabIndex = 9;
            // 
            // btnInicio
            // 
            this.btnInicio.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnInicio.FlatAppearance.BorderSize = 2;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Location = new System.Drawing.Point(74, 171);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(122, 36);
            this.btnInicio.TabIndex = 10;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::WindowsFormsClient.Properties.Resources.online_library;
            this.pbxLogo.Location = new System.Drawing.Point(74, 12);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(146, 131);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 11;
            this.pbxLogo.TabStop = false;
            // 
            // btnSobre
            // 
            this.btnSobre.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSobre.FlatAppearance.BorderSize = 2;
            this.btnSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSobre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSobre.ForeColor = System.Drawing.Color.White;
            this.btnSobre.Location = new System.Drawing.Point(74, 332);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(122, 36);
            this.btnSobre.TabIndex = 12;
            this.btnSobre.Text = "Sobre";
            this.btnSobre.UseVisualStyleBackColor = true;
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.BorderSize = 2;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(74, 567);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(122, 36);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnFaq
            // 
            this.btnFaq.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFaq.FlatAppearance.BorderSize = 2;
            this.btnFaq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFaq.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFaq.ForeColor = System.Drawing.Color.White;
            this.btnFaq.Location = new System.Drawing.Point(74, 278);
            this.btnFaq.Name = "btnFaq";
            this.btnFaq.Size = new System.Drawing.Size(122, 36);
            this.btnFaq.TabIndex = 14;
            this.btnFaq.Text = "FAQ";
            this.btnFaq.UseVisualStyleBackColor = true;
            this.btnFaq.Click += new System.EventHandler(this.btnFaq_Click);
            // 
            // btnLivros
            // 
            this.btnLivros.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLivros.FlatAppearance.BorderSize = 2;
            this.btnLivros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLivros.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLivros.ForeColor = System.Drawing.Color.White;
            this.btnLivros.Location = new System.Drawing.Point(74, 226);
            this.btnLivros.Name = "btnLivros";
            this.btnLivros.Size = new System.Drawing.Size(122, 36);
            this.btnLivros.TabIndex = 15;
            this.btnLivros.Text = "Lista de Livros";
            this.btnLivros.UseVisualStyleBackColor = true;
            this.btnLivros.Click += new System.EventHandler(this.btnLivros_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.pnlAzul);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHome";
            this.Text = "FormHome";
            this.pnlAzul.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlAzul;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Button btnLivros;
        private System.Windows.Forms.Button btnFaq;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSobre;
    }
}
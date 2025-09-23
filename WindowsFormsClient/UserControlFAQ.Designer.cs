namespace WindowsFormsClient
{
    partial class UserControlFAQ
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFaq = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFaq
            // 
            this.lblFaq.AutoSize = true;
            this.lblFaq.Location = new System.Drawing.Point(274, 313);
            this.lblFaq.Name = "lblFaq";
            this.lblFaq.Size = new System.Drawing.Size(28, 13);
            this.lblFaq.TabIndex = 0;
            this.lblFaq.Text = "FAQ";
            // 
            // UserControlFAQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblFaq);
            this.Name = "UserControlFAQ";
            this.Size = new System.Drawing.Size(600, 700);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFaq;
    }
}

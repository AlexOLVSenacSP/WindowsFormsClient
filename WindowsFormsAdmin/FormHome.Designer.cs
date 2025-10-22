namespace WindowsFormsAdmin
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
            this.tbxPesquisa = new System.Windows.Forms.TextBox();
            this.lblpesquisa = new System.Windows.Forms.Label();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.tbxDescricao = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.btnList = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.rbtnStored = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxPesquisa
            // 
            this.tbxPesquisa.Location = new System.Drawing.Point(116, 98);
            this.tbxPesquisa.Name = "tbxPesquisa";
            this.tbxPesquisa.Size = new System.Drawing.Size(100, 20);
            this.tbxPesquisa.TabIndex = 0;
            this.tbxPesquisa.TextChanged += new System.EventHandler(this.tbxPesquisa_TextChanged);
            // 
            // lblpesquisa
            // 
            this.lblpesquisa.AutoSize = true;
            this.lblpesquisa.Location = new System.Drawing.Point(116, 59);
            this.lblpesquisa.Name = "lblpesquisa";
            this.lblpesquisa.Size = new System.Drawing.Size(81, 13);
            this.lblpesquisa.TabIndex = 1;
            this.lblpesquisa.Text = "Pesquisa Nome";
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(87, 204);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.Size = new System.Drawing.Size(701, 158);
            this.dgvProduct.TabIndex = 2;
            this.dgvProduct.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvProduct_MouseDoubleClick);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(415, 59);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(50, 13);
            this.lblDescricao.TabIndex = 3;
            this.lblDescricao.Text = "Decrição";
            // 
            // tbxDescricao
            // 
            this.tbxDescricao.Location = new System.Drawing.Point(418, 98);
            this.tbxDescricao.Name = "tbxDescricao";
            this.tbxDescricao.Size = new System.Drawing.Size(138, 20);
            this.tbxDescricao.TabIndex = 4;
            this.tbxDescricao.TextChanged += new System.EventHandler(this.tbxDescricao_TextChanged);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(76, 37);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(40, 13);
            this.lblCode.TabIndex = 5;
            this.lblCode.Text = "Codigo";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(147, 37);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 6;
            this.lblId.Text = "ID";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(268, 136);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(35, 13);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "Preço";
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(271, 164);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(100, 20);
            this.tbxPrice.TabIndex = 8;
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(259, 384);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 23);
            this.btnList.TabIndex = 9;
            this.btnList.Text = "Listar";
            this.btnList.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(388, 384);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 10;
            this.btnCreate.Text = "Cadastrar";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(513, 383);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(643, 382);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Remover";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(49, 382);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "Status";
            // 
            // rbtnStored
            // 
            this.rbtnStored.AutoSize = true;
            this.rbtnStored.Location = new System.Drawing.Point(52, 410);
            this.rbtnStored.Name = "rbtnStored";
            this.rbtnStored.Size = new System.Drawing.Size(82, 17);
            this.rbtnStored.TabIndex = 14;
            this.rbtnStored.TabStop = true;
            this.rbtnStored.Text = "Em Estoque";
            this.rbtnStored.UseVisualStyleBackColor = true;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbtnStored);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.tbxPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.tbxDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.lblpesquisa);
            this.Controls.Add(this.tbxPesquisa);
            this.Name = "FormHome";
            this.Text = "FormHome";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxPesquisa;
        private System.Windows.Forms.Label lblpesquisa;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox tbxDescricao;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.RadioButton rbtnStored;
    }
}
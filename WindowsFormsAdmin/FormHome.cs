using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryUser;

namespace WindowsFormsAdmin
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void tbxPesquisa_TextChanged(object sender, EventArgs e)
        {

            //incialização
            string name = tbxPesquisa.Text;
            string description = tbxDescricao.Text;


            // instanciacao da classe
            ClassProd _product = new ClassProd(0, name, description, 0, true);

            // Pesquisa na tabela
            DataTable dt = _product.ProductSearch(name, description);
            //MessageBox.Show(_product.ProductSearch(name, description).ToString());
            //Atualizar DataGridView
            dgvProduct.DataSource = dt;

        }

        private void tbxDescricao_TextChanged(object sender, EventArgs e)
        {
            //incialização
            string name = tbxPesquisa.Text;
            string description = tbxDescricao.Text;


            // instanciacao da classe
            ClassProd _product = new ClassProd(0, name, description, 0, true);

            // Pesquisa na tabela
            DataTable dt = _product.ProductSearch(name, description);

            //Atualizar DataGridView
            dgvProduct.DataSource = dt;
        }

        private void btnUpdate_Click(object sender, EventArgs e)


        {
            // incialização
            int id_Product = 0;
            string Name = "";
            string Description = "";
            double Price = 0.0;
            bool Status = true;

            //entrada de dados 
            id_Product = Convert.ToInt16(lblId.Text);
            Name = tbxPesquisa.Text;
            Description = tbxDescricao.Text;
            Price = Convert.ToDouble(tbxPrice.Text);
            Status = rbtnStored.Checked;

            //Processamento
            ClassProd _product = new ClassProd(id_Product, Name, Description, Price, Status);

            if (_product.Atualizar())
            {
                MessageBox.Show("Sucesso"); //saida

            }
            else
            {
                MessageBox.Show("Erro"); //Saida
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //inicialização
            int id_product = 0;

            id_product = Convert.ToInt16(lblId.Text);

            //processamento
            ClassProd _product = new ClassProd(id_product, "", "", 0.0, true);

            if (_product.Remover())
            {
                MessageBox.Show("Sucesso"); //Saida

            }
            else
            {
                MessageBox.Show("Erro");    //Saida 

            }


        }

        private void dgvProduct_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var hit = dgvProduct.HitTest(e.X, e.Y);

            if (hit.RowIndex >= 0)

            {
                dgvProduct.Rows[hit.RowIndex].Selected = true;

                lblId.Text = dgvProduct.Rows[hit.RowIndex].Cells["id_product"].Value.ToString();
                lblpesquisa.Text = dgvProduct.Rows[hit.RowIndex].Cells["name"].Value.ToString();
                lblDescricao.Text = dgvProduct.Rows[hit.RowIndex].Cells["description"].Value.ToString();
                lblPrice.Text = dgvProduct.Rows[hit.RowIndex].Cells["price"].Value.ToString();
                bool ativo = Convert.ToBoolean(dgvProduct.Rows[hit.RowIndex].Cells["status"].Value);
                if (ativo)
                {
                    rbtnStored.Checked = ativo;
                }
                else
                {
                    rbtnStored.Checked = !ativo; 
                }
            }

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ClassProd _product = new ClassProd(0, tbxPesquisa.Text, tbxDescricao.Text, Convert.ToDouble(tbxPrice.Text), true);
            if (_product.Registrar())
            {
                MessageBox.Show("Sucesso"); //Saída
            }
            else
            {
                MessageBox.Show("Erro"); //Saída
            }
        }
    }
}

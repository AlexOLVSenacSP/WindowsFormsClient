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
            int id_product = 0;
            string name = "";
            string description = "";
            Double price = 0.0;
            bool status = true;

            //entrada de dados 
            id_product = Convert.ToInt16(lblId.TabIndex);
            name = tbxPesquisa.Text;
            description = tbxDescricao.Text;
            price = Convert.ToDouble(tbxPrice.Text);
            status = rbtnStored.Checked;

            //Processamento
            ClassProd _product = new ClassProd(id_product, name, description, price, status);

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
    

        //private void dgvProduct_MouseDoubleClick(object sender, MouseEventArgs e)

        //var hit = dvgproduct.hittest(e.x, e.y);
        //  {
        //    if (hit.rowindex >= 0)

        //    { 
        //          dvg.product.rows[hit.rowindex].select = true;

        //          lblcode.text = dvgproduct.rows[hit.rowindex].cells["id_product"].value.tostring();
        //          lblsearch.text = dvgproduct.rows[hit.rowindex].cells["name"].value.tostring();
        //          lbldecription.text = dvgproduct.rows[hit.rowindex].cells["description"].value.tostring();
        //          lblprice.text = dvgproduct.rows[hit.rowindex].cells["price"].value.tostring();
        //          bool ativo = convert.toboolean(dvgproduct.rows[hit.rowindex].cells["status"].value.tostring();
        //          if (ativo)
        //          {
        //          rbtnstored.checked = ativo;
        //          }
        //          else { rbtnstored.checked = !ativo; }
        //    }
        //}
    }
}

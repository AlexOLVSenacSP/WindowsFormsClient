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
            ClassProd _product = new ClassProd (0, name, description, 0, true); 

            // Pesquisa na tabela
            DataTable dt = _product.ProductSearch(name,description);
            MessageBox.Show(_product.ProductSearch(name, description).ToString());
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
    }
}

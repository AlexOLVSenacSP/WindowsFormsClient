using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsClient
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {

        }

        private void btnLivros_Click(object sender, EventArgs e)
        {

        }

        private void btnFaq_Click(object sender, EventArgs e)
        {

        }

        private void btnSobre_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            FormLogin _formLogin = new FormLogin();
            _formLogin.Show();
            this.Hide();

        }
    }
}

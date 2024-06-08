using PrjDispensacao.Models;
using PrjDispensacao.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjDispensacao
{
    public partial class frmLinhaProducao : Form
    {
        public frmLinhaProducao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "" && txtNome.Text != "")
            {
                LinhaProducao linhaProducao = new LinhaProducao();
                linhaProducao.Codigo = int.Parse(txtCodigo.Text);
                linhaProducao.Nome = txtNome.Text;
                LinhaProducaoRepository.Linha.Add(linhaProducao);

                txtCodigo.Text = null;
                txtNome.Text = null;
                txtCodigo.Focus();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }

        }
    }
}

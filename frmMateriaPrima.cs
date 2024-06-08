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
    public partial class frmMateriaPrima : Form
    {
        public frmMateriaPrima()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(txtCodigo.Text != null && txtNome.Text != "")
            {
                //Cria objeto de matéria prima e salva na lista de repositório do mesmo
                MateriaPrima materiaPrima = new MateriaPrima();
                materiaPrima.Codigo = int.Parse(txtCodigo.Text);
                materiaPrima.Nome = txtNome.Text;
                MateriaPrimaRepository.Materias.Add(materiaPrima);

                //Limpa tela e coloca o foco no campo código
                txtCodigo.Text = null;
                txtNome.Text = null;
                txtCodigo.Focus();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos");
            }
           
        }
    }
}

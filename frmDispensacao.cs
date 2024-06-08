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
    public partial class frmDispensacao : Form
    {
        public frmDispensacao()
        {
            InitializeComponent();
        }

        private void frmDispensacao_Load(object sender, EventArgs e)
        {
            AtualizaForm();
        }
        private void AtualizaForm()
        {
            //Carregar os dados do combobox e o listbox
            cmbMateriaPrima.DataSource = MateriaPrimaRepository.Materias;
            cmbMateriaPrima.DisplayMember = "Nome";
            cmbMateriaPrima.ValueMember = "Nome";
            ltbLinhaProducao.DataSource = LinhaProducaoRepository.Linha;
            ltbLinhaProducao.DisplayMember = "Nome";
            ltbLinhaProducao.ValueMember = "Nome";

            //Carregar DataView Grid
            dtvDispensacao.DataSource = null;
            dtvDispensacao.DataSource = DispensacaoRepository.Dispensacoes;
        }

        private void btnDispensar_Click(object sender, EventArgs e)
        {
            if(txtNumero.Text !="" && txtQuantidade.Text != "" && cmbMateriaPrima.Text != "" && ltbLinhaProducao.Text != "")
            {
                Dispensacao dispensacao = new Dispensacao();
                dispensacao.Numero = int.Parse(txtNumero.Text);
                dispensacao.Quantidade = double.Parse(txtQuantidade.Text);
                dispensacao.NomeLin = ltbLinhaProducao.SelectedValue.ToString();
                dispensacao.NomeMat = cmbMateriaPrima.SelectedValue.ToString();
                DispensacaoRepository.Dispensacoes.Add(dispensacao);

                AtualizaForm();
            }
        }
    }
}

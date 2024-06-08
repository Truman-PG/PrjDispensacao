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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMateriaPrima formMateriaprima = new frmMateriaPrima();
            formMateriaprima.ShowDialog();
        }

        private void btnLinProducao_Click(object sender, EventArgs e)
        {
            frmLinhaProducao formLinhaProducao = new frmLinhaProducao();
            formLinhaProducao.ShowDialog();
        }

        private void btnDispensacao_Click(object sender, EventArgs e)
        {
            frmDispensacao formDispensacao = new frmDispensacao();
            formDispensacao.ShowDialog();
        }
    }
}

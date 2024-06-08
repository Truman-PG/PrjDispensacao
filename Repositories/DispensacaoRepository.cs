using PrjDispensacao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjDispensacao.Repositories
{
    public static class DispensacaoRepository
    {
        public static List<Dispensacao> Dispensacoes { get; set; } = new List<Dispensacao>();
    }
}
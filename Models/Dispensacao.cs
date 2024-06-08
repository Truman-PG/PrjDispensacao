using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjDispensacao.Models
{
    public class Dispensacao
    {
        public int Numero {  get; set; }
        public string NomeMat { get; set; }
        public string NomeLin{  get; set; }
        public double Quantidade {  get; set; }
    }
}

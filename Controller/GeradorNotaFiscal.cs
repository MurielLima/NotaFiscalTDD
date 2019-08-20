using NotaFiscalTDD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotaFiscalTDD.Controller
{
    public class GeradorNotaFiscal
    {
        private Fatura _fatura;
        private static bool ValidaFatura()
        {
            return true;
        }
        public static NotaFiscal GeraNotaFiscal(Fatura fatura)
        {
            return new NotaFiscal();
        }
    }
}

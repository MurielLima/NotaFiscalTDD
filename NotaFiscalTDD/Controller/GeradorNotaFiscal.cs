using NotaFiscalTDD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NotaFiscalTDD.Model.Fatura;

namespace NotaFiscalTDD.Controller
{
    public static class GeradorNotaFiscal
    {
        public static NotaFiscal GeraNotaFiscal(Fatura fat)
        {
            return new NotaFiscal(fat.Nome,fat.Valor,fat.Servico, CalculaImposto(fat));
        }
        public static double CalculaImposto(Fatura fat)
        {
            switch (fat.Servico)
            {
                case TipoServico.Consultoria:
                    return fat.Valor * 0.75;
                case TipoServico.Treinamento:
                    return fat.Valor * 0.85;
                default:
                    return fat.Valor * 0.94;
            }
        }
        public static string EnviaPorEmail(NotaFiscal notaF)
        {
            return "Email enviado com sucesso!";
        }
        public static string EnviaParaSistema(NotaFiscal notaF)
        {
            return "Enviado com sucesso!";
        }
        public static string Salvar(NotaFiscal notaF)
        {
            return "Salvo com sucesso!";
        }
    }
}

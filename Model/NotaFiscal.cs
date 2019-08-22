using static NotaFiscalTDD.Model.Fatura;

namespace NotaFiscalTDD.Model
{
    public class NotaFiscal
    {
        public NotaFiscal(string nome, double valor, TipoServico servico,double imposto)
        {
            Nome = nome;
            Valor = valor;
            Servico = servico;
            Imposto = imposto;
        }

        public string Nome { get; set; }
        public double Valor { get; set; }
        public double Imposto{ get; set; }
        public TipoServico Servico { get; set; }
    }
}

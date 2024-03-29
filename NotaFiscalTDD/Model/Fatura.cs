﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotaFiscalTDD.Model
{
    public class Fatura
    {
        public Fatura(string nome, string endereco, double valor,TipoServico servico)
        {
            Nome = nome;
            Endereco = endereco;
            Valor = valor;
            Servico = servico;
        }

        public Fatura()
        {
        }

        public enum TipoServico
        {
            Consultoria,
            Treinamento,
            Outros
        };

        public string Nome { get; set; }
        public string Endereco { get; set; }
        public double Valor { get; set; }
        public TipoServico Servico { get; set; }
    }
}

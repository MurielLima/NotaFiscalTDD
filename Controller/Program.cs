using NotaFiscalTDD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotaFiscalTDD
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
        }
    }
}
Implementar um sistema de gerac¸ao de nota fiscal a partir de uma fatura..O gerador de nota ´
fiscal devera gerar uma nota fiscal que cont ´ em nome do cliente, valor da nota e valor do ´
imposto a ser pago
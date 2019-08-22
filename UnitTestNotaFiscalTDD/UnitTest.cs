using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NotaFiscalTDD.Controller;
using NotaFiscalTDD.Model;

namespace UnitTestNotaFiscalTDD
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestGeradorNotaFiscal1()
        {
            Fatura fat = new Fatura("Muriel josé Lima","Rua dos bobos nº0",1,Fatura.TipoServico.Consultoria);
            NotaFiscal nF = GeradorNotaFiscal.GeraNotaFiscal(fat);
            Assert.AreNotEqual(1,nF.Imposto);
        }
        [TestMethod]
        public void TestGeradorNotaFiscal2()
        {
            Fatura fat = new Fatura("Muriel josé Lima", "Rua dos bobos nº0", 1000, Fatura.TipoServico.Consultoria);
            NotaFiscal nF = GeradorNotaFiscal.GeraNotaFiscal(fat);
            Assert.AreEqual(750, nF.Imposto);
        }
        [TestMethod]
        public void TestGeradorNotaFiscal3()
        {
            Fatura fat = new Fatura("Muriel josé Lima", "Rua dos bobos nº0", 1000, Fatura.TipoServico.Treinamento);
            NotaFiscal nF = GeradorNotaFiscal.GeraNotaFiscal(fat);
            Assert.AreEqual(850, nF.Imposto);
        }
        [TestMethod]
        public void TestGeradorNotaFiscal4()
        {
            Fatura fat = new Fatura("Muriel josé Lima", "Rua dos bobos nº0", 1000, Fatura.TipoServico.Outros);
            NotaFiscal nF = GeradorNotaFiscal.GeraNotaFiscal(fat);
            Assert.AreEqual(940, nF.Imposto);
        }
        [TestMethod]
        public void TestGeradorNotaFiscal5()
        {
            Fatura fat = new Fatura("Muriel josé Lima", "Rua dos bobos nº0", 1000, Fatura.TipoServico.Outros);
            NotaFiscal nF = GeradorNotaFiscal.GeraNotaFiscal(fat);
            Assert.AreEqual(940, nF.Imposto);
            Assert.AreEqual("Email enviado com sucesso!", GeradorNotaFiscal.EnviaPorEmail(nF));
        }
        [TestMethod]
        public void TestGeradorNotaFiscal6()
        {
            Fatura fat = new Fatura("Muriel josé Lima", "Rua dos bobos nº0", 1000, Fatura.TipoServico.Outros);
            NotaFiscal nF = GeradorNotaFiscal.GeraNotaFiscal(fat);
            Assert.AreEqual(940, nF.Imposto);
            Assert.AreEqual("Salvo com sucesso!", GeradorNotaFiscal.Salvar(nF));
        }
        [TestMethod]
        public void TestGeradorNotaFiscal7()
        {
            Fatura fat = new Fatura("Muriel josé Lima", "Rua dos bobos nº0", 1000, Fatura.TipoServico.Outros);
            NotaFiscal nF = GeradorNotaFiscal.GeraNotaFiscal(fat);
            Assert.AreEqual(940, nF.Imposto);
            Assert.AreEqual("Enviado com sucesso!", GeradorNotaFiscal.EnviaParaSistema(nF));
        }
    }
}

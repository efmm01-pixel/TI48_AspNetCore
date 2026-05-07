using NUnit.Framework;
using System.Collections.Generic;
using TI48_AspNetCore.Services;
using TI48_AspNetCore.Models;

namespace TI48.Tests
{
    [TestFixture]
    public class ProdutoServiceTests
    {
        private ProdutoService _service;

        [SetUp]
        public void Setup()
        {
            _service = new ProdutoService();
        }

        [Test]
        public void DeveRetornarListaDeProdutos()
        {
            var resultado = _service.ObterProdutos();

            Assert.That(resultado, Is.Not.Null);
            Assert.That(resultado, Is.InstanceOf<List<Produto>>());
        }

        [Test]
        public void ListaNaoDeveEstarVazia()
        {
            var resultado = _service.ObterProdutos();

            Assert.That(resultado.Count, Is.GreaterThan(0));
        }
    }
}
using System.Collections.Generic;
using TI48_AspNetCore.Models;

namespace TI48_AspNetCore.Services
{
    public class ProdutoService
    {
        public List<Produto> ObterProdutos()
        {
            return new List<Produto>
            {
                new Produto { Id = 1, Nome = "Notebook", Preco = 3500 },
                new Produto { Id = 2, Nome = "Mouse", Preco = 150 },
                new Produto { Id = 3, Nome = "Teclado", Preco = 300 }
            };
        }
    }
}
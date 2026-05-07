using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TI48_AspNetCore.Models;
using TI48_AspNetCore.Services;

namespace TI48_AspNetCore.Pages
{
    public class CatalogoModel : PageModel
    {
        private readonly ProdutoService _service;

        public List<Produto> Produtos { get; set; } = new List<Produto>();

        public CatalogoModel()
        {
            _service = new ProdutoService();
        }

        public void OnGet()
        {
            Produtos = _service.ObterProdutos();
        }
    }
}

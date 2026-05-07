namespace TI48_AspNetCore.Models
{
    public class Produto
    {
        public int Id { get; set; }

        public string Nome { get; set; } = string.Empty;

        public decimal Preco { get; set; }
    }
}
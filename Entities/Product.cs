// Representa um produto disponível para compra
namespace ShopOnline.Api.Entities
{
    public class Product
    {
        // Identificador único do produto
        public int Id { get; set; }

        // Nome do produto
        public string Name { get; set; }

        // Preço do produto
        public decimal Price { get; set; }

        // ID da categoria à qual o produto pertence
        public int CategoryId { get; set; }
    }
}

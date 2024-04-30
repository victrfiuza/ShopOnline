// Representa um item dentro do carrinho de compras
namespace ShopOnline.Api.Entities
{
    public class CartItem
    {
        // Identificador único do item
        public int Id { get; set; }

        // ID do carrinho ao qual o item pertence
        public int CartId { get; set; }

        // ID do produto associado ao item
        public int ProductId { get; set; }

        // Quantidade do produto no carrinho
        public int Qty { get; set; }
    }
}

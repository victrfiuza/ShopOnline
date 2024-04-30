// Representa um carrinho de compras
namespace ShopOnline.Api.Entities
{
    public class Cart
    {
        // Identificador único do carrinho
        public int Id { get; set; }

        // ID do usuário ao qual o carrinho pertence
        public int UserId { get; set; }
    }
}

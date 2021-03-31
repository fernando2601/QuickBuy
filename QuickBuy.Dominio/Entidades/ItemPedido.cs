using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class ItemPedido
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        
        public ICollection<Pedido> Pedidos { get; set; } // O usuário pode ter um ou mais pedidos
    }
}

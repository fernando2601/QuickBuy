using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        
        public virtual ICollection<Pedido> Pedidos { get; set; } // O usuário pode ter um ou mais pedidos

        public override void Validate()
        {
            if (ProdutoId == 0)
                AdicionarCritica("Não foi identificado qual a referencia do produto");

            if (Quantidade == 0)
                AdicionarCritica("Quantidade não informada");
        }
    }
}

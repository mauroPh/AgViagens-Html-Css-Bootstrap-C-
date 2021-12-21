using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgenciaDeViagens.Models
{
    [Table("CarrinhoCompraItens") ]
    public class CarrinhoCompraItem
    {
        public int CarrinhoCompraItemId { get; set; }

        public Pacote Pacote { get; set; }

        public int Quantidade { get; set; }

        [StringLength(200)]

        public String CarrinhoCompraId { get; set; }
    }
}

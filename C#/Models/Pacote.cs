using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgenciaDeViagens.Models
{
    [Table ("Pacotes")]
    public class Pacote
    {
       [Key]
        public int PacoteId { get; set; }

        [Required(ErrorMessage = "Informe um nome para o pacote de viagens")]
        [Display(Name = "Nome do Pacote")]
        [StringLength(80, MinimumLength = 5, ErrorMessage = "O{0} deve ter no mínimo {1} e no máximo {2} caracteres.")]
        public string PacoteNome { get; set; }
        [Required(ErrorMessage = "Você deve informar uma breve descrição.")]
        [Display(Name = "Descrição do Pacote")]
        
        public string DescricaoCurta { get; set; }
        [Required(ErrorMessage = "A descrição detalhada deve ser informada.")]
        [Display(Name = "Detalhes do Pacote")]
        
        public string DescricaoDetalhada { get; set; }
        [Required(ErrorMessage = "Informe o preço a ser cobrado.")]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)clear")]
        [Range(300, 49999.99, ErrorMessage = "O preço deve estar entre 300 e 49.999,99")]
        public decimal Preco { get; set; }
        
        [Display(Name = "Favorito?")]
        public bool IsPacoteFavorito{ get; set; }
        [Display(Name = "Disponível")]
        public bool Disponivel { get; set; }


        public int DestinoId { get; set; }

        public virtual Destino Destino { get; set; }


    }
}

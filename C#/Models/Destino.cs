using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgenciaDeViagens.Models
{
    [Table("Destinos")]
    public class Destino
    {
        [Key]
        public int DestinoId{ get; set; }
        [StringLength(100,ErrorMessage ="O tamanho máximo é de 100 caracteres.")]
        [Required(ErrorMessage ="Informe o destino:")]
        [Display (Name="Destino")]
        public string DestinoNome { get; set; }
        
        [Required(ErrorMessage = "Informe uma breve descrição sobre o destino:")]
        [Display(Name = "Destino")]
        public string Descricao { get; set; }

        public List<Pacote> Pacotes { get; set ; }

    }
}

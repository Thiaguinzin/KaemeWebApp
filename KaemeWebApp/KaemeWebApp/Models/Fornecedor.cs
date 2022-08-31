using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KaemeWebApp.Models
{
    public class Fornecedor
    {

        [Key]
        public int Id { get; set; }
        [Required]            
        public string RazaoSocial { get; set; }
        [Column(TypeName = "money")]
        public decimal minPedidoAtacado { get; set; }
        [Required]
        public int FreteStatusID { get; set; }
        public decimal percDescAVista { get; set; }
        public string Endereco { get; set; }
        public string Instagram { get; set; }
        public string Contato { get; set; }
    }
}

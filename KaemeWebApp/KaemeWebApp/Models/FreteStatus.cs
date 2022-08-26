using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KaemeWebApp.Models
{
    public class FreteStatus
    {

        [Key]
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    [Table("Cliente")]
    public class Cliente
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string CPF { get; set; }

        [Required]
        public DateTime DataNascimento { get; set; }

        [Required]
        public string Sexo { get; set; }

        [Required]
        public string Telefone { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public int CidadeId { get; set; }

        //[ForeignKey("CidadeId")]
        public virtual Cidade Cidade { get; set; }

        [NotMapped]
        public int EstadoId { get; set; }
    }
}

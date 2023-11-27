using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet._6.WF.SqLite
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nome { get; set; }

        [Required]
        [StringLength(11)]
        public string Cpf { get; set; }
        public bool Ativo { get; set; }

    }
}

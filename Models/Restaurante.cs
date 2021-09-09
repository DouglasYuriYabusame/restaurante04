using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace restaurante04.Models
{
    [Table("restaurante")]
    public class Restaurante
    {

        [Key]
        [Column("idrestaurante")]
        public Int32 IdRestaurante { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace restaurante04.Models
{
    [Table("prato")]
    public class Prato
    {
        [Key]
        [Column("idprato")]
        public Int32 IdPrato { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("valor")]
        public decimal Valor { get; set; }

        [Column("idvenda")]
        public Int32 IdVenda { get; set; }

    }
}

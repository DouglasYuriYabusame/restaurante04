using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace restaurante04.Models
{
    [Table("prato_ingrediente")]
    public class PratoIngrediente
    {
        [Key]
        [Column("idprato_ingrediente")]
        public Int32 IdPratoIngrediente { get; set; }

        [Column("idprato")]
        public Int32 IdPrato { get; set; }

        [Column("idingrediente")]
        public Int32 IdIngrediente { get; set; }

    }
}

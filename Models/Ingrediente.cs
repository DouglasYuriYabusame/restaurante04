using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace restaurante04.Models
{
    [Table("ingrediente")]
    public class Ingrediente
    {

        [Key]
        [Column("idingrediente")]
        public Int32 IdIngrediente { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("validade")]
        public DateTime Validade { get; set; }

        [Column("quantidade")]
        public Int32 Quantidade { get; set; }

    }
}

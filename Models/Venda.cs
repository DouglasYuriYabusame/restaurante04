using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace restaurante04.Models
{
    [Table("venda")]
    public class Venda
    {

        [Key]
        [Column("idvenda")]
        public Int32 IdVenda { get; set; }

        [Column("idfuncionario")]
        public Int32 IdFuncionario { get; set; }

        [Column("idcliente")]
        public Int32 IdCliente { get; set; }

    }
}

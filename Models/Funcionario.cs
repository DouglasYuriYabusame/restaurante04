using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace restaurante04.Models
{
    [Table("funcionario")]
    public class Funcionario
    {

        [Key]
        [Column("idfuncionario")]
        public Int32 IdFuncionario { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("cpf")]
        public string Cpf { get; set; }

        [Column("salario")]
        public Decimal Salario { get; set; }

        [Column("idrestaurante")]
        public Int32 IdRestaurante { get; set; }

    }
}

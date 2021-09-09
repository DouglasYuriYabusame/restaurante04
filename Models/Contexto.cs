using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restaurante04.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Restaurante> Restaurantes { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<Prato> Pratos { get; set; }
        public DbSet<Ingrediente> Ingredientes { get; set; }
        public DbSet<PratoIngrediente> PratosIngredientes { get; set; }

        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes)
        {

        }

    }
}

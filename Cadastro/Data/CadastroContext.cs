using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cadastro.Models;

namespace Cadastro.Data
{
    public class CadastroContext : DbContext
    {
        public CadastroContext (DbContextOptions<CadastroContext> options)
            : base(options)
        {
        }

        public DbSet<Cadastro.Models.Pessoa> Pessoa { get; set; }

      
    }
}

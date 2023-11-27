using Microsoft.EntityFrameworkCore;

namespace Dotnet._6.WF.SqLite
{
    public class BancoDadosContexto : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder opt)
        {
            opt.UseSqlite("Data Source=cliente.db");
        }
    }
}

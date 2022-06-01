using Microsoft.EntityFrameworkCore;
using static TemplateBootstrap.Models.TemplateBootstrap;

namespace TemplateBootstrap.Data
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {

        }

        public DbSet<funcionario> Funcionarios { get; set; }
    }
}

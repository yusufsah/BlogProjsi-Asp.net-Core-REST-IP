using Microsoft.EntityFrameworkCore;

namespace BlogApidemo.dataAccsesslayer
{
    public class context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.\\SQLEXPRESS;database=CoreBlogApıDb;integrated security=true;TrustServerCertificate=True;");
        }

        public DbSet<çalışan> çalışans { get; set; }
    }
}

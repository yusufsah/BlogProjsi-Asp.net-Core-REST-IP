using entity;
using entity.conti;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataacseslayer.concreat
{
    public class context : IdentityDbContext<userapp,apprpol,int>                            //  DbContext     ESKİ HALİ
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.\\SQLEXPRESS;database=CoreBlogDb;integrated security=true;TrustServerCertificate=True;");
        }




        public DbSet<about> abouts { get; set; }  // about sınıfını işlem yapma

        public DbSet<blog> blogs { get; set; }

        public DbSet<comment> comments { get; set; }

        public DbSet<cotact> cotacts { get; set; }

        public DbSet<katagori> katagoris { get; set; }

        public DbSet<writer> writers { get; set; }

        public DbSet<Newsletter> Newsletter { get; set; }

        public DbSet<bildirimler> bildirimlers { get; set; }
    }
}

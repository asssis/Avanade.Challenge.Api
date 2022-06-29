using Avanade.Challenge.Api.Infra.Database.Domain; 
using Microsoft.EntityFrameworkCore; 

namespace Avanade.Challenge.Infra.Database
{
    public class AppContexto : DbContext
    {
        public AppContexto()
        {
        }

        public AppContexto(DbContextOptions<AppContexto> options) : base(options)
        { }
        public DbSet<Phrase> Phrases { get; set; }
        public DbSet<Topic> Topics { get; set; }  
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source='127.0.0.1,1433';User Id=sa;Password=aaabbbccc1234;Initial Catalog=LearningEnglish;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {  
            modelBuilder.Entity<Phrase>().HasIndex(b => b.Expression).IsUnique();
            modelBuilder.Entity<Topic>().HasIndex(b => b.Descricao).IsUnique();
        }
    }
}

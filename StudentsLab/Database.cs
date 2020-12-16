using Microsoft.EntityFrameworkCore;
using System;

namespace StudentsLab
{
   public class Database : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           if (optionsBuilder.IsConfigured == false)
           {
                String connectionString = "Server=localhost;Port=5433;Username=postgres;Password=yfcnz157;Database=Students;";                              
                optionsBuilder.UseNpgsql(@connectionString);

               // optionsBuilder.UseSqlServer(@connectionString);               
               //"Data Source= DESKTOP-KTBF1RR\SQLEXPRESS;Initial Catalog=Students;Integrated Security=True;MultipleActiveResultSets=True;"
           }
            base.OnConfiguring(optionsBuilder);
        }
        public virtual DbSet<Student> Students { set; get; }
    }
}

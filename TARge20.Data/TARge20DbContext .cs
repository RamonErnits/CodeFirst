using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TARge20.Core.Domain;

namespace TARge20.Data
{
    public class TARge20DbContext : DbContext
    {

        public TARge20DbContext(DbContextOptions<TARge20DbContext> options)
            : base(options) { }
        public DbSet<Töötaja> Worker { get; set; }
        public DbSet<Puhkus> Vacation { get; set; }
        public DbSet<Lapsed> Children { get; set; }
        public DbSet<Laenutamine> Borrow { get; set; }
        public DbSet<Ametinimetus> Agencyname { get; set; }


        // näide, kuidas teha, kui lisate domaini alla ühe objekti
        // migratsioonid peavad tulema siia libary-sse e TARge20.Data alla.
        public DbSet<Employee> Employee { get; set; }
    }
}
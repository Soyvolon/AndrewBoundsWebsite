using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using CardGameData;

using Microsoft.EntityFrameworkCore;

namespace WebsiteMain.Database
{
    public class AndrewBoundsDatabaseModel : DbContext
    {
        public DbSet<CardGame> CardGames { get; set; }

        public AndrewBoundsDatabaseModel(DbContextOptions<AndrewBoundsDatabaseModel> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}

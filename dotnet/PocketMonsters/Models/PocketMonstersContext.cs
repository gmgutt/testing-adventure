using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace PocketMonsters.Models
{
    public class PocketMonstersContext : DbContext
    {
        public PocketMonstersContext(DbContextOptions<PocketMonstersContext> options)
            : base(options)
        {
        }

        public DbSet<Species> Species { get; set; } = null!;
    }
}
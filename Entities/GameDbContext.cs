using Microsoft.EntityFrameworkCore;

namespace MillionaireWeb.Entities;

public class GameDbContext : DbContext
{
    public GameDbContext(DbContextOptions<GameDbContext> options)
        : base(options)
    {
    }

    public DbSet<Question> Questions { get; set; }
    public DbSet<Answer> Answers { get; set; }
    public DbSet<PrizeLevel> PrizeLevel { get; set; }
}

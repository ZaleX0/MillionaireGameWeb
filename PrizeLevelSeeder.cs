using MillionaireWeb.Entities;

namespace MillionaireWeb;

public class PrizeLevelSeeder
{
    private readonly GameDbContext _context;

    public PrizeLevelSeeder(GameDbContext context)
    {
        _context = context;
    }

    public void Seed()
    {
        if (!_context.Database.CanConnect())
            return;

        if (!_context.PrizeLevel.Any())
        {
            var questionsAndAnswers = GetPrizeLevels();
            _context.AddRange(questionsAndAnswers);
            _context.SaveChanges();
        }
    }

    private IEnumerable<PrizeLevel> GetPrizeLevels()
    {
        return new List<PrizeLevel>()
        {
            new PrizeLevel() { PrizeAmount = 500 },
            new PrizeLevel() { PrizeAmount = 1000 },
            new PrizeLevel() { PrizeAmount = 2000 },
            new PrizeLevel() { PrizeAmount = 3000 },
            new PrizeLevel() { PrizeAmount = 5000 },
            new PrizeLevel() { PrizeAmount = 7000 },
            new PrizeLevel() { PrizeAmount = 10000 },
            new PrizeLevel() { PrizeAmount = 20000 },
            new PrizeLevel() { PrizeAmount = 30000 },
            new PrizeLevel() { PrizeAmount = 50000 },
            new PrizeLevel() { PrizeAmount = 100000 },
            new PrizeLevel() { PrizeAmount = 250000 },
            new PrizeLevel() { PrizeAmount = 500000 },
            new PrizeLevel() { PrizeAmount = 1000000 },
        };
    }
}

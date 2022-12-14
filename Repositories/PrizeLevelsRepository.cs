using MillionaireWeb.Entities;

namespace MillionaireWeb.Repositories;

public class PrizeLevelsRepository : IPrizeLevelsRepository
{
	private readonly GameDbContext _context;

	public PrizeLevelsRepository(GameDbContext context)
	{
		_context = context;
	}

	public PrizeLevel? GetPrizeLevel(int id)
	{
		return _context.PrizeLevel
			.FirstOrDefault(l => l.Id == id);
	}

	public PrizeLevel? GetGuaranteedPrizeLevel(int id)
	{
		return _context.PrizeLevel
			.Where(l => l.IsGuaranteed == true)
			.OrderBy(l => l.Id)
			.LastOrDefault(l => l.Id <= id);
	}

	public PrizeLevel? GetLastPrizeLevel()
	{
		return _context.PrizeLevel
			.OrderBy(l => l.Id)
			.LastOrDefault();
	}

	public int Count()
	{
		return _context.PrizeLevel.Count();
	}
}

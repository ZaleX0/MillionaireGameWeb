using MillionaireWeb.Entities;

namespace MillionaireWeb.Repositories;

public class PrizeLevelsRepository
{
	private readonly GameDbContext _context;

	public PrizeLevelsRepository(GameDbContext context)
	{
		_context = context;
	}

	public PrizeLevel GetPrizeLevel(int id)
	{
		return _context.PrizeLevel.FirstOrDefault(l => l.Id == id);
	}
}

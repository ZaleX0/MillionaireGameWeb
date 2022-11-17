using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using MillionaireWeb.Entities;

namespace MillionaireWeb.Repositories;

public class QuestionsRepository : IQuestionsRepository
{
	private readonly GameDbContext _context;

	public QuestionsRepository(GameDbContext context)
	{
		_context = context;
	}

	public IEnumerable<Question> GetAllByLevel(int prizeLevel)
	{
		return _context.Questions
			.Where(q => q.PrizeLevelId == prizeLevel)
			.ToList();
	}

	public void Add(Question question)
	{
		_context.Questions.Add(question);
		_context.SaveChanges();
	}
}

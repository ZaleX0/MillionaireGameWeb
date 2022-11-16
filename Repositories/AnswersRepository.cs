using MillionaireWeb.Entities;

namespace MillionaireWeb.Repositories;

public class AnswersRepository
{
    private readonly GameDbContext _context;

    public AnswersRepository(GameDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Answer> GetByQuestionId(int id)
    {
        return _context.Answers
            .Where(a => a.QuestionId == id)
            .ToList();
    }

    public bool CheckIfAnswerCorrect(int answerId)
    {
        return _context.Answers
            .First(a => a.Id == answerId)
            .IsCorrect;
    }

    public Answer GetCorrectAnswer(int questionId)
    {
        return _context.Answers
            .Where(a => a.QuestionId == questionId)
            .First(a => a.IsCorrect);
    }
}

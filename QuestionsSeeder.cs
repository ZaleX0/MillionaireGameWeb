using MillionaireWeb.Entities;
using System.Diagnostics;

namespace MillionaireWeb;

public class QuestionsSeeder
{
    private readonly GameDbContext _context;

    public QuestionsSeeder(GameDbContext context)
    {
        _context = context;
    }

    public void Seed()
    {
        if (!_context.Database.CanConnect())
            return;

        if (!_context.Questions.Any())
        {
            var questionsAndAnswers = GetQuestionsAndAnswers();
            _context.AddRange(questionsAndAnswers);
            _context.SaveChanges();
        }
    }

    private IEnumerable<Question> GetQuestionsAndAnswers()
    {
        // TODO seed from file
        return new List<Question>()
        {
            new Question()
            {
                Content = "Test 1?",
                PrizeLevelId = 1,
                Answers = new List<Answer>()
                {
                    new Answer() { IsCorrect = true, Content = "TestCorrect" },
                    new Answer() { IsCorrect = false, Content = "TestWrong1" },
                    new Answer() { IsCorrect = false, Content = "TestWrong2" },
                    new Answer() { IsCorrect = false, Content = "TestWrong3" }
                }
            },
            new Question()
            {
                Content = "Test 2?",
                PrizeLevelId = 1,
                Answers = new List<Answer>()
                {
                    new Answer() { IsCorrect = false, Content = "TestWrong1" },
                    new Answer() { IsCorrect = true, Content = "TestCorrect" },
                    new Answer() { IsCorrect = false, Content = "TestWrong2" },
                    new Answer() { IsCorrect = false, Content = "TestWrong3" }
                }
            },
            new Question()
            {
                Content = "Test 3?",
                PrizeLevelId = 1,
                Answers = new List<Answer>()
                {
                    new Answer() { IsCorrect = false, Content = "TestWrong1" },
                    new Answer() { IsCorrect = false, Content = "TestWrong2" },
                    new Answer() { IsCorrect = true, Content = "TestCorrect" },
                    new Answer() { IsCorrect = false, Content = "TestWrong3" }
                }
            },
            new Question()
            {
                Content = "Test 4?",
                PrizeLevelId = 2,
                Answers = new List<Answer>()
                {
                    new Answer() { IsCorrect = false, Content = "TestWrong1" },
                    new Answer() { IsCorrect = false, Content = "TestWrong2" },
                    new Answer() { IsCorrect = false, Content = "TestWrong3" },
                    new Answer() { IsCorrect = true, Content = "TestCorrect" }
                }
            }
        };
    }
}

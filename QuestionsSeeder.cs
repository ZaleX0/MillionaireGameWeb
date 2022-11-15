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
                    new Answer() { IsCorrect = true, Content = "Correct" },
                    new Answer() { IsCorrect = false, Content = "Wrong1" },
                    new Answer() { IsCorrect = false, Content = "Wrong2" },
                    new Answer() { IsCorrect = false, Content = "Wrong3" }
                }
            },
            new Question()
            {
                Content = "Test 2?",
                PrizeLevelId = 2,
                Answers = new List<Answer>()
                {
                    new Answer() { IsCorrect = false, Content = "Wrong1" },
                    new Answer() { IsCorrect = true, Content = "Correct" },
                    new Answer() { IsCorrect = false, Content = "Wrong2" },
                    new Answer() { IsCorrect = false, Content = "Wrong3" }
                }
            },
            new Question()
            {
                Content = "Test 3?",
                PrizeLevelId = 3,
                Answers = new List<Answer>()
                {
                    new Answer() { IsCorrect = false, Content = "Wrong1" },
                    new Answer() { IsCorrect = false, Content = "Wrong2" },
                    new Answer() { IsCorrect = true, Content = "Correct" },
                    new Answer() { IsCorrect = false, Content = "Wrong3" }
                }
            },
            new Question()
            {
                Content = "Test 4?",
                PrizeLevelId = 4,
                Answers = new List<Answer>()
                {
                    new Answer() { IsCorrect = false, Content = "Wrong1" },
                    new Answer() { IsCorrect = false, Content = "Wrong2" },
                    new Answer() { IsCorrect = false, Content = "Wrong3" },
                    new Answer() { IsCorrect = true, Content = "Correct" }
                }
            },
            new Question()
            {
                Content = "Test 5?",
                PrizeLevelId = 5,
                Answers = new List<Answer>()
                {
                    new Answer() { IsCorrect = false, Content = "Wrong1" },
                    new Answer() { IsCorrect = false, Content = "Wrong2" },
                    new Answer() { IsCorrect = false, Content = "Wrong3" },
                    new Answer() { IsCorrect = true, Content = "Correct" }
                }
            },
            new Question()
            {
                Content = "Test 6?",
                PrizeLevelId = 6,
                Answers = new List<Answer>()
                {
                    new Answer() { IsCorrect = false, Content = "Wrong1" },
                    new Answer() { IsCorrect = false, Content = "Wrong2" },
                    new Answer() { IsCorrect = false, Content = "Wrong3" },
                    new Answer() { IsCorrect = true, Content = "Correct" }
                }
            },
            new Question()
            {
                Content = "Test 7?",
                PrizeLevelId = 7,
                Answers = new List<Answer>()
                {
                    new Answer() { IsCorrect = false, Content = "Wrong1" },
                    new Answer() { IsCorrect = false, Content = "Wrong2" },
                    new Answer() { IsCorrect = false, Content = "Wrong3" },
                    new Answer() { IsCorrect = true, Content = "Correct" }
                }
            },
            new Question()
            {
                Content = "Test 8?",
                PrizeLevelId = 8,
                Answers = new List<Answer>()
                {
                    new Answer() { IsCorrect = false, Content = "Wrong1" },
                    new Answer() { IsCorrect = false, Content = "Wrong2" },
                    new Answer() { IsCorrect = false, Content = "Wrong3" },
                    new Answer() { IsCorrect = true, Content = "Correct" }
                }
            },
            new Question()
            {
                Content = "Test 9?",
                PrizeLevelId = 9,
                Answers = new List<Answer>()
                {
                    new Answer() { IsCorrect = false, Content = "Wrong1" },
                    new Answer() { IsCorrect = false, Content = "Wrong2" },
                    new Answer() { IsCorrect = false, Content = "Wrong3" },
                    new Answer() { IsCorrect = true, Content = "Correct" }
                }
            },
            new Question()
            {
                Content = "Test 10?",
                PrizeLevelId = 10,
                Answers = new List<Answer>()
                {
                    new Answer() { IsCorrect = false, Content = "Wrong1" },
                    new Answer() { IsCorrect = false, Content = "Wrong2" },
                    new Answer() { IsCorrect = false, Content = "Wrong3" },
                    new Answer() { IsCorrect = true, Content = "Correct" }
                }
            },
            new Question()
            {
                Content = "Test 11?",
                PrizeLevelId = 11,
                Answers = new List<Answer>()
                {
                    new Answer() { IsCorrect = false, Content = "Wrong1" },
                    new Answer() { IsCorrect = false, Content = "Wrong2" },
                    new Answer() { IsCorrect = false, Content = "Wrong3" },
                    new Answer() { IsCorrect = true, Content = "Correct" }
                }
            },
            new Question()
            {
                Content = "Test 12?",
                PrizeLevelId = 12,
                Answers = new List<Answer>()
                {
                    new Answer() { IsCorrect = false, Content = "Wrong1" },
                    new Answer() { IsCorrect = false, Content = "Wrong2" },
                    new Answer() { IsCorrect = false, Content = "Wrong3" },
                    new Answer() { IsCorrect = true, Content = "Correct" }
                }
            },
            new Question()
            {
                Content = "Test 13?",
                PrizeLevelId = 13,
                Answers = new List<Answer>()
                {
                    new Answer() { IsCorrect = false, Content = "Wrong1" },
                    new Answer() { IsCorrect = false, Content = "Wrong2" },
                    new Answer() { IsCorrect = false, Content = "Wrong3" },
                    new Answer() { IsCorrect = true, Content = "Correct" }
                }
            },
            new Question()
            {
                Content = "Test 14?",
                PrizeLevelId = 14,
                Answers = new List<Answer>()
                {
                    new Answer() { IsCorrect = false, Content = "Wrong1" },
                    new Answer() { IsCorrect = false, Content = "Wrong2" },
                    new Answer() { IsCorrect = false, Content = "Wrong3" },
                    new Answer() { IsCorrect = true, Content = "Correct" }
                }
            }
        };
    }
}

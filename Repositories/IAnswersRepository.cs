using MillionaireWeb.Entities;

namespace MillionaireWeb.Repositories;
public interface IAnswersRepository
{
    bool CheckIfAnswerCorrect(int answerId);
    IEnumerable<Answer> GetByQuestionId(int id);
    Answer GetCorrectAnswer(int questionId);
}
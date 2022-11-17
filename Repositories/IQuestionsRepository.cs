using MillionaireWeb.Entities;

namespace MillionaireWeb.Repositories;
public interface IQuestionsRepository
{
    void Add(Question question);
    IEnumerable<Question> GetAllByLevel(int prizeLevel);
}
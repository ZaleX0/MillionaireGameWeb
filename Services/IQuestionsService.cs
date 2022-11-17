using MillionaireWeb.Models;

namespace MillionaireWeb.Services;
public interface IQuestionsService
{
    void AddQuestion(CreateQuestionDto dto);
    int GetPrizeLevelCount();
}
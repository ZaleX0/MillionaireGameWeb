namespace MillionaireWeb.Models;

public class CreateQuestionDto
{
    public int PrizeLevel { get; set; }
    public string Question { get; set; }
    public string CorrectAnswer { get; set; }
    public string WrongAnswer1 { get; set; }
    public string WrongAnswer2 { get; set; }
    public string WrongAnswer3 { get; set; }
}

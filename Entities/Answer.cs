namespace MillionaireWeb.Entities;

public class Answer
{
    public int Id { get; set; }
    public int QuestionId { get; set; }
    public string Content { get; set; }
    public bool IsCorrect { get; set; }

    public virtual Question Question { get; set; }
}

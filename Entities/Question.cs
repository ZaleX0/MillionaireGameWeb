namespace MillionaireWeb.Entities;

public class Question
{
    public int Id { get; set; }
    public string Content { get; set; }
    public int PrizeLevelId { get; set; }

    public virtual List<Answer> Answers { get; set; }
    public virtual PrizeLevel PrizeLevel { get; set; }
}

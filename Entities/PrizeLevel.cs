namespace MillionaireWeb.Entities;

public class PrizeLevel
{
    public int Id { get; set; }
    public int PrizeAmount { get; set; }
    public bool IsGuaranteed { get; set; } = false;
}

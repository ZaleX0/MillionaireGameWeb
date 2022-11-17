using MillionaireWeb.Entities;

namespace MillionaireWeb.Repositories;
public interface IPrizeLevelsRepository
{
    int Count();
    PrizeLevel? GetGuaranteedPrizeLevel(int id);
    PrizeLevel? GetLastPrizeLevel();
    PrizeLevel? GetPrizeLevel(int id);
}
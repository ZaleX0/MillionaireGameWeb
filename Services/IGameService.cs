using MillionaireWeb.Models;

namespace MillionaireWeb.Services;
public interface IGameService
{
    int GetPreviousGuaranteedPrizeLevelAmount(int prizeLevel);
    int GetPreviousPrizeLevelAmount(int prizeLevel);
    int GetWinningPrizeAmount();
    GameViewModel NextGameViewModel(int prizeLevel);
    GameViewModel ResultGameViewModel(GameViewModel model);
}
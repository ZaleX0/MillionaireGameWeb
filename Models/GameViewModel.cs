﻿using MillionaireWeb.Entities;

namespace MillionaireWeb.Models;

public class GameViewModel
{
    public int PrizeLevel { get; set; }
    public int PrizeLevelAmount { get; set; }
    public QuestionDto Question { get; set; }
    public AnswerDto AnswerA { get; set; }
    public AnswerDto AnswerB { get; set; }
    public AnswerDto AnswerC { get; set; }
    public AnswerDto AnswerD { get; set; }

    public int LastAnswerId { get; set; }

    public bool? IsAnswerCorrect { get; set; }
}

using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using MillionaireWeb.Entities;
using MillionaireWeb.Models;
using MillionaireWeb.Repositories;

namespace MillionaireWeb.Services;

public class GameService
{
	private readonly PrizeLevelsRepository _prizeLevelsRepository;
	private readonly QuestionsRepository _questionRepository;
	private readonly AnswersRepository _answerRepository;
	private readonly IMapper _mapper;

	public GameService(
		PrizeLevelsRepository prizeLevelsRepository,
		QuestionsRepository questionRepository,
		AnswersRepository answerRepository,
		IMapper mapper)
	{
		_prizeLevelsRepository = prizeLevelsRepository;
		_questionRepository = questionRepository;
		_answerRepository = answerRepository;
		_mapper = mapper;
	}

	public GameViewModel ResultGameViewModel(GameViewModel model)
	{
		model.IsAnswerCorrect = _answerRepository.CheckIfAnswerCorrect(model.LastAnswerId);

        if (model.PrizeLevel >= _prizeLevelsRepository.GetLastPrizeLevel().Id)
			if (model.IsAnswerCorrect == true)
				model.IsGameWon = true;

        return model;
	}

    public GameViewModel NextGameViewModel(int prizeLevel)
	{
		var model = new GameViewModel();
		model.PrizeLevel = prizeLevel + 1;
		model.PrizeLevelAmount = GetPrizeAmount(model.PrizeLevel);

        var question = GetRandomQuestionDto(model.PrizeLevel);
		var answers = GetAnswersDto(question.Id);

		// TODO: randomize answer order
		model.Question = question;
		model.AnswerA = answers[0];
		model.AnswerB = answers[1];
		model.AnswerC = answers[2];
		model.AnswerD = answers[3];

		model.IsAnswerCorrect = null;
		return model;
    }

	public int GetPreviousPrizeLevelAmount(int prizeLevel)
	{
		if (prizeLevel == 1)
			return 0;
		return _prizeLevelsRepository.GetPrizeLevel(prizeLevel - 1).PrizeAmount;
	}

    public int GetPreviousGuaranteedPrizeLevelAmount(int prizeLevel)
    {
        if (prizeLevel == 1)
            return 0;
        return _prizeLevelsRepository.GetGuaranteedPrizeLevel(prizeLevel - 1).PrizeAmount;
    }

	public int GetWinningPrizeAmount()
	{
		return _prizeLevelsRepository.GetLastPrizeLevel().PrizeAmount;
	}



    private QuestionDto GetRandomQuestionDto(int prizeLevel)
    {
        var questions = _questionRepository.GetAllByLevel(prizeLevel);

        int skip = new Random().Next(questions.Count());
        var question = questions
            .Skip(skip)
            .Take(1)
            .FirstOrDefault();

        return _mapper.Map<QuestionDto>(question);
    }

	private List<AnswerDto> GetAnswersDto(int questionId)
	{
        var answers = _answerRepository.GetByQuestionId(questionId);
        return _mapper.Map<List<AnswerDto>>(answers);
	}

	private int GetPrizeAmount(int prizeLevelId)
	{
		var prizeLevel = _prizeLevelsRepository.GetPrizeLevel(prizeLevelId);
		return prizeLevel.PrizeAmount;
	}
}

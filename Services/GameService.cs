using AutoMapper;
using MillionaireWeb.Models;
using MillionaireWeb.Repositories;

namespace MillionaireWeb.Services;

public class GameService : IGameService
{
	private readonly IPrizeLevelsRepository _prizeLevelsRepository;
	private readonly IQuestionsRepository _questionRepository;
	private readonly IAnswersRepository _answerRepository;
	private readonly IMapper _mapper;

	public GameService(
		IPrizeLevelsRepository prizeLevelsRepository,
		IQuestionsRepository questionRepository,
		IAnswersRepository answerRepository,
		IMapper mapper)
	{
		_prizeLevelsRepository = prizeLevelsRepository;
		_questionRepository = questionRepository;
		_answerRepository = answerRepository;
		_mapper = mapper;
	}

	public GameViewModel ResultGameViewModel(GameViewModel model)
	{
		var answer = _answerRepository.GetCorrectAnswer(model.Question.Id);
		model.CorrectAnswer = answer.Content;

		model.IsAnswerCorrect = _answerRepository.CheckIfAnswerCorrect(model.LastAnswerId);

		var prizeLevel = _prizeLevelsRepository.GetLastPrizeLevel();
		if (model.PrizeLevel >= prizeLevel?.Id)
			if (model.IsAnswerCorrect == true)
				model.IsGameWon = true;

		return model;
	}

	public GameViewModel NextGameViewModel(int prizeLevel)
	{
		var model = new GameViewModel();
		model.QuestionsCount = GetQuestionsCount();

		model.PrizeLevel = prizeLevel + 1;
		model.PrizeLevelAmount = GetPrizeAmount(model.PrizeLevel);
		model.PreviousPrizeLevelAmount = GetPreviousPrizeLevelAmount(model.PrizeLevel);

		var question = GetRandomQuestionDto(model.PrizeLevel);
		var answers = GetAnswersDto(question.Id);

		model.Question = question;
		model.AnswerA = PullRandomAnswer(answers);
		model.AnswerB = PullRandomAnswer(answers);
		model.AnswerC = PullRandomAnswer(answers);
		model.AnswerD = PullRandomAnswer(answers);

		model.IsAnswerCorrect = null;
		model.IsGameWon = false;
		return model;
	}

	public int GetPreviousPrizeLevelAmount(int prizeLevel)
	{
		if (prizeLevel == 1)
			return 0;

		var prize = _prizeLevelsRepository.GetPrizeLevel(prizeLevel - 1);
		if (prize == null)
			return 0;

		return prize.PrizeAmount;
	}

	public int GetPreviousGuaranteedPrizeLevelAmount(int prizeLevel)
	{
		if (prizeLevel == 1)
			return 0;

		var prize = _prizeLevelsRepository.GetGuaranteedPrizeLevel(prizeLevel - 1);
		if (prize == null)
			return 0;

		return prize.PrizeAmount;

	}

	public int GetWinningPrizeAmount()
	{
		var prize = _prizeLevelsRepository.GetLastPrizeLevel();
		if (prize == null)
			return 0;

		return prize.PrizeAmount;
	}

	private int GetQuestionsCount()
	{
		var prize = _prizeLevelsRepository.GetLastPrizeLevel();
		if (prize == null)
			return 0;

		return prize.Id;
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
		if (prizeLevel == null)
			return 0;

		return prizeLevel.PrizeAmount;
	}

	private AnswerDto PullRandomAnswer(List<AnswerDto> list)
	{
		var element = list[new Random().Next(list.Count)];
		list.Remove(element);
		return element;
	}
}

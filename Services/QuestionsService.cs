using AutoMapper;
using MillionaireWeb.Entities;
using MillionaireWeb.MappingProfiles;
using MillionaireWeb.Models;
using MillionaireWeb.Repositories;

namespace MillionaireWeb.Services;

public class QuestionsService : IQuestionsService
{
	private readonly IPrizeLevelsRepository _prizeLevelsRepository;
	private readonly IQuestionsRepository _questionsRepository;
	private readonly IMapper _mapper;

	public QuestionsService(
		IPrizeLevelsRepository prizeLevelsRepository,
		IQuestionsRepository questionsRepository,
		IMapper mapper)
	{
		_prizeLevelsRepository = prizeLevelsRepository;
		_questionsRepository = questionsRepository;
		_mapper = mapper;
	}

	public int GetPrizeLevelCount()
	{
		return _prizeLevelsRepository.Count();
	}

	public void AddQuestion(CreateQuestionDto dto)
	{
		var question = _mapper.Map(dto, new Question());
		RandomizeAnswerOrder(question.Answers);
        _questionsRepository.Add(question);
	}

    private void RandomizeAnswerOrder(List<Answer> list)
    {
		var rng = new Random();
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            var answer = list[k];
            list[k] = list[n];
            list[n] = answer;
        }
    }
}

using AutoMapper;
using MillionaireWeb.Entities;
using MillionaireWeb.Models;

namespace MillionaireWeb.MappingProfiles;

public class QuestionsAndAnswersMappingProfile : Profile
{
	public QuestionsAndAnswersMappingProfile()
	{
		CreateMap<Question, QuestionDto>();
		CreateMap<Answer, AnswerDto>();
	}
}

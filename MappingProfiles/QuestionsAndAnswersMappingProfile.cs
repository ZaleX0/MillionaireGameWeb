using AutoMapper;
using AutoMapper.Execution;
using Microsoft.EntityFrameworkCore.Infrastructure;
using MillionaireWeb.Entities;
using MillionaireWeb.Models;
using System.Collections.Generic;

namespace MillionaireWeb.MappingProfiles;

public class QuestionsAndAnswersMappingProfile : Profile
{
    public QuestionsAndAnswersMappingProfile()
    {
        CreateMap<Question, QuestionDto>();
        CreateMap<Answer, AnswerDto>();
        CreateMap<CreateQuestionDto, Question>().ConvertUsing<CustomTypeConverter>();
    }
}

class CustomTypeConverter : ITypeConverter<CreateQuestionDto, Question>
{
    public Question Convert(CreateQuestionDto source, Question destination, ResolutionContext context)
    {
        destination.Content = source.Question;
        destination.PrizeLevelId = source.PrizeLevel;
        destination.Answers = new List<Answer>
        {
            new Answer { Content = source.CorrectAnswer, IsCorrect = true },
            new Answer { Content = source.WrongAnswer1 },
            new Answer { Content = source.WrongAnswer2 },
            new Answer { Content = source.WrongAnswer3 }
        };
        return destination;
    }
}

using MillionaireWeb.Entities;
using System.Diagnostics;
using System.Diagnostics.Metrics;

namespace MillionaireWeb;

public class QuestionsSeeder
{
    private readonly GameDbContext _context;

    public QuestionsSeeder(GameDbContext context)
    {
        _context = context;
    }

    public void Seed()
    {
        if (!_context.Database.CanConnect())
            return;

        if (!_context.Questions.Any())
        {
            var questionsAndAnswers = GetQuestionsAndAnswers();
            _context.AddRange(questionsAndAnswers);
            _context.SaveChanges();
        }
    }

    private IEnumerable<Question> GetQuestionsAndAnswers()
    {
        var level1 = new List<Question>
        {
            new Question()
            {
                Content = "A flashing red traffic light signifies that a driver should do what?",
                PrizeLevelId = 1,
                Answers = new List<Answer>()
                {
                    new Answer() { Content = "Stop", IsCorrect = true },
                    new Answer() { Content = "Speed up" },
                    new Answer() { Content = "Honk the horn" },
                    new Answer() { Content = "Proceed with caution" }
                }
            },
            new Question()
            {
                Content = "Whats the capital city of Poland",
                PrizeLevelId = 1,
                Answers = new List<Answer>()
                {
                    new Answer() { Content = "Cracow" },
                    new Answer() { Content = "Poznan" },
                    new Answer() { Content = "Bydgoszcz" },
                    new Answer() { Content = "Warsaw", IsCorrect = true }
                }
            },
            new Question()
            {
                Content = "How do you express 3/4 as a decimal?",
                PrizeLevelId = 1,
                Answers = new List<Answer>()
                {
                    new Answer() { Content = "0.25" },
                    new Answer() { Content = "0.50" },
                    new Answer() { Content = "0.75", IsCorrect = true },
                    new Answer() { Content = "0.90" }
                }
            }
        };
        var level2 = new List<Question>
        {
            new Question()
            {
                Content = "How is the Arabic numeral for '2' written?",
                PrizeLevelId = 2,
                Answers = new List<Answer>()
                {
                    new Answer() { Content = "II" },
                    new Answer() { Content = "I" },
                    new Answer() { Content = "ii" },
                    new Answer() { Content = "2", IsCorrect = true }
                }
            },
            new Question()
            {
                Content = "How is 4:00 pm expressed in military time?",
                PrizeLevelId = 2,
                Answers = new List<Answer>()
                {
                    new Answer() { Content = "0400" },
                    new Answer() { Content = "16:00" },
                    new Answer() { Content = "1600", IsCorrect = true },
                    new Answer() { Content = "4:00" }
                }
            },
            new Question()
            {
                Content = "Including the bottom, how many sides are on a square-based pyramid?",
                PrizeLevelId = 2,
                Answers = new List<Answer>()
                {
                    new Answer() { Content = "Five", IsCorrect = true },
                    new Answer() { Content = "Three" },
                    new Answer() { Content = "Four" },
                    new Answer() { Content = "Six" }
                }
            }
        };
        var level3 = new List<Question>
        {
            new Question()
            {
                Content = "What is the last letter of the Greek alphabet?",
                PrizeLevelId = 3,
                Answers = new List<Answer>()
                {
                    new Answer() { Content = "Omicron" },
                    new Answer() { Content = "Omega", IsCorrect = true },
                    new Answer() { Content = "Upsilon" },
                    new Answer() { Content = "Zeta" }
                }
            },
            new Question()
            {
                Content = "An airplane's black box is usually what color?",
                PrizeLevelId = 3,
                Answers = new List<Answer>()
                {
                    new Answer() { Content = "Black" },
                    new Answer() { Content = "White" },
                    new Answer() { Content = "Orange", IsCorrect = true },
                    new Answer() { Content = "Purple" }
                }
            },
            new Question()
            {
                Content = "How is the word 'ambulance' normally written on the front of American ambulances?",
                PrizeLevelId = 3,
                Answers = new List<Answer>()
                {
                    new Answer() { Content = "In French" },
                    new Answer() { Content = "In reverse", IsCorrect = true },
                    new Answer() { Content = "In braille" },
                    new Answer() { Content = "In gibberish" }
                }
            }
        };
        var level4 = new List<Question>
        {
            new Question()
            {
                Content = "Backgammon is a how many player game?",
                PrizeLevelId = 4,
                Answers = new List<Answer>()
                {
                    new Answer() { Content = "Three" },
                    new Answer() { Content = "Two", IsCorrect = true },
                    new Answer() { Content = "Four" },
                    new Answer() { Content = "Six" }
                }
            },
            new Question()
            {
                Content = "How many stars are on the American flag?",
                PrizeLevelId = 4,
                Answers = new List<Answer>()
                {
                    new Answer() { Content = "50", IsCorrect = true },
                    new Answer() { Content = "51" },
                    new Answer() { Content = "13" },
                    new Answer() { Content = "48" }
                }
            },
            new Question()
            {
                Content = "In what country did Pokemon originate?",
                PrizeLevelId = 4,
                Answers = new List<Answer>()
                {
                    new Answer() { Content = "Japan", IsCorrect = true },
                    new Answer() { Content = "France" },
                    new Answer() { Content = "Hungary" },
                    new Answer() { Content = "Canada" }
                }
            }
        };
        var level5 = new List<Question>
        {
            new Question()
            {
                Content = "In computer terminology, what does the acronym 'FTP' stand for?",
                PrizeLevelId = 5,
                Answers = new List<Answer>()
                {
                    new Answer() { Content = "Full time portal" },
                    new Answer() { Content = "Full text processor" },
                    new Answer() { Content = "Free to print" },
                    new Answer() { Content = "File transfer protocol", IsCorrect = true }
                }
            },
            new Question()
            {
                Content = "What animal is considered sacred in India?",
                PrizeLevelId = 5,
                Answers = new List<Answer>()
                {
                    new Answer() { Content = "Sheep" },
                    new Answer() { Content = "Dog" },
                    new Answer() { Content = "Cow", IsCorrect = true },
                    new Answer() { Content = "Chicken" }
                }
            },
            new Question()
            {
                Content = "What does a pH level measure?",
                PrizeLevelId = 5,
                Answers = new List<Answer>()
                {
                    new Answer() { Content = "Acidity", IsCorrect = true },
                    new Answer() { Content = "Density" },
                    new Answer() { Content = "Wave length" },
                    new Answer() { Content = "Humidity" }
                }
            }
        };
        var level6 = new List<Question>
        {
            new Question()
            {
                Content = "What color is cartoon character Marge Simpson's hair?",
                PrizeLevelId = 6,
                Answers = new List<Answer>()
                {
                    new Answer() { Content = "Yellow" },
                    new Answer() { Content = "Blue", IsCorrect = true },
                    new Answer() { Content = "Brown" },
                    new Answer() { Content = "Purple" }
                }
            },
            new Question()
            {
                Content = "What does the 'ROM' in CD-ROM stand for?",
                PrizeLevelId = 6,
                Answers = new List<Answer>()
                {
                    new Answer() { Content = "Really Obscure Memory" },
                    new Answer() { Content = "Run-Other Memory" },
                    new Answer() { Content = "Read-Only Memory", IsCorrect = true },
                    new Answer() { Content = "Random Object Memory" }
                }
            },
            new Question()
            {
                Content = "In the 1992 animated film 'Aladdin' what device does the hero use to travel from place to place?",
                PrizeLevelId = 6,
                Answers = new List<Answer>()
                {
                    new Answer() { Content = "Talking car" },
                    new Answer() { Content = "Winged horse" },
                    new Answer() { Content = "Magic carpet", IsCorrect = true },
                    new Answer() { Content = "Hot air baloon" }
                }
            }
        };
        var level7 = new List<Question>
        {
            new Question()
            {
                Content = "In what forest did Robin Hood live?",
                PrizeLevelId = 7,
                Answers = new List<Answer>()
                {
                    new Answer() { Content = "Sherwood Forest", IsCorrect = true },
                    new Answer() { Content = "Black Forest" },
                    new Answer() { Content = "Petrified Forest" },
                    new Answer() { Content = "Nottingham Forest" }
                }
            },
            new Question()
            {
                Content = "A pita is a type of what?",
                PrizeLevelId = 7,
                Answers = new List<Answer>()
                {
                    new Answer() { Content = "Fresh fruit" },
                    new Answer() { Content = "French tart" },
                    new Answer() { Content = "Flat bread", IsCorrect = true },
                    new Answer() { Content = "Bean dip" }
                }
            },
            new Question()
            {
                Content = "According to legend, if you give someone the 'evil eye' what are you doing?",
                PrizeLevelId = 7,
                Answers = new List<Answer>()
                {
                    new Answer() { Content = "Cursing them", IsCorrect = true },
                    new Answer() { Content = "Blessing a child" },
                    new Answer() { Content = "Counting money" },
                    new Answer() { Content = "Passing time" }
                }
            }
        };
        var level8 = new List<Question>
        {
            new Question()
            {
                Content = "In bowling, how many pins must you knock down to get a strike?",
                PrizeLevelId = 8,
                Answers = new List<Answer>()
                {
                    new Answer() { Content = "8" },
                    new Answer() { Content = "12" },
                    new Answer() { Content = "0" },
                    new Answer() { Content = "10", IsCorrect = true }
                }
            },
            new Question()
            {
                Content = "In computer terminology, what does the acronym 'ISP' stand for?",
                PrizeLevelId = 8,
                Answers = new List<Answer>()
                {
                    new Answer() { Content = "Individual Site Privacy" },
                    new Answer() { Content = "Investment Stability Plan" },
                    new Answer() { Content = "Internet Service Provider", IsCorrect = true },
                    new Answer() { Content = "Internal Security Position" }
                }
            },
            new Question()
            {
                Content = "The majority of calcium in the human body is found where?",
                PrizeLevelId = 8,
                Answers = new List<Answer>()
                {
                    new Answer() { Content = "Blood" },
                    new Answer() { Content = "Bones", IsCorrect = true },
                    new Answer() { Content = "Hair" },
                    new Answer() { Content = "Digestive tract" }
                }
            }
        };
        var level9 = new List<Question>
        {
            new Question()
            {
                Content = "If you are truly afraid of the dark, what do you suffer from?",
                PrizeLevelId = 9,
                Answers = new List<Answer>()
                {
                    new Answer() { Content = "Hypnophobia" },
                    new Answer() { Content = "Cryptophobia" },
                    new Answer() { Content = "Nyctophobia", IsCorrect = true },
                    new Answer() { Content = "Hadephobia" }
                }
            },
            new Question()
            {
                Content = "Modern computer microchips are primarily composed of what element?",
                PrizeLevelId = 9,
                Answers = new List<Answer>()
                {
                    new Answer() { Content = "Sodium" },
                    new Answer() { Content = "Silicon", IsCorrect = true },
                    new Answer() { Content = "Aluminum" },
                    new Answer() { Content = "Silver" }
                }
            },
            new Question()
            {
                Content = "In the movie 'Star Wars' what kind of creature is Chewbacca?",
                PrizeLevelId = 9,
                Answers = new List<Answer>()
                {
                    new Answer() { Content = "Boobie" },
                    new Answer() { Content = "Woolie" },
                    new Answer() { Content = "Klingon" },
                    new Answer() { Content = "Wookie", IsCorrect = true }
                }
            }
        };
        var level10 = new List<Question>
        {
            new Question()
            {
                Content = "If a piece of music is in 'common time' how many quarter notes are there per measure?",
                PrizeLevelId = 10,
                Answers = new List<Answer>()
                {
                    new Answer() { Content = "Four", IsCorrect = true },
                    new Answer() { Content = "Eight" },
                    new Answer() { Content = "Five" },
                    new Answer() { Content = "One" }
                }
            },
            new Question()
            {
                Content = "What is a balalaika?",
                PrizeLevelId = 10,
                Answers = new List<Answer>()
                {
                    new Answer() { Content = "Russian peasant" },
                    new Answer() { Content = "Type of hat" },
                    new Answer() { Content = "Musical instrument", IsCorrect = true },
                    new Answer() { Content = "Breed of shark" }
                }
            },
            new Question()
            {
                Content = "What is produced during photosynthesis?",
                PrizeLevelId = 10,
                Answers = new List<Answer>()
                {
                    new Answer() { Content = "Hydrogen" },
                    new Answer() { Content = "Nylon" },
                    new Answer() { Content = "Light" },
                    new Answer() { Content = "Oxygen", IsCorrect = true }
                }
            }
        };
        var level11 = new List<Question>
        {
            new Question()
            {
                Content = "What is the art of elegant handwriting called?",
                PrizeLevelId = 11,
                Answers = new List<Answer>()
                {
                    new Answer() { Content = "Lithography" },
                    new Answer() { Content = "Decoupage" },
                    new Answer() { Content = "Engraving" },
                    new Answer() { Content = "Calligraphy", IsCorrect = true }
                }
            },
            new Question()
            {
                Content = "What is the colored part of the eye called?",
                PrizeLevelId = 11,
                Answers = new List<Answer>()
                {
                    new Answer() { Content = "Pupil" },
                    new Answer() { Content = "Retina" },
                    new Answer() { Content = "Iris", IsCorrect = true },
                    new Answer() { Content = "Cochlea" }
                }
            },
            new Question()
            {
                Content = "What is the largest animal ever to live on Earth?",
                PrizeLevelId = 11,
                Answers = new List<Answer>()
                {
                    new Answer() { Content = "Giant squid" },
                    new Answer() { Content = "Woolly mammoth" },
                    new Answer() { Content = "Blue whale", IsCorrect = true },
                    new Answer() { Content = "Tyrannosaurus" }
                }
            }
        };
        var level12 = new List<Question>
        {
            new Question()
            {
                Content = "What are the names of the two primary M&M's spokes-candies?",
                PrizeLevelId = 12,
                Answers = new List<Answer>()
                {
                    new Answer() { Content = "Peanut and Plain" },
                    new Answer() { Content = "Red and Yellow", IsCorrect = true },
                    new Answer() { Content = "Mort and Marty" },
                    new Answer() { Content = "They don't have names" }
                }
            },
            new Question()
            {
                Content = "What country was once ruled by shoguns?",
                PrizeLevelId = 12,
                Answers = new List<Answer>()
                {
                    new Answer() { Content = "Taiwan" },
                    new Answer() { Content = "China" },
                    new Answer() { Content = "Japan", IsCorrect = true },
                    new Answer() { Content = "North Korea" }
                }
            },
            new Question()
            {
                Content = "What are the names of Donald Duck's three nephews?",
                PrizeLevelId = 12,
                Answers = new List<Answer>()
                {
                    new Answer() { Content = "Huey, Dewey, Louie", IsCorrect = true },
                    new Answer() { Content = "Quick, Quack, Quock" },
                    new Answer() { Content = "Robbie, Chip, Ernie" },
                    new Answer() { Content = "Alvin, Simon, Theodore" }
                }
            }
        };
        var level13 = new List<Question>
        {
            new Question()
            {
                Content = "What is the intergral of e^x?",
                PrizeLevelId = 13,
                Answers = new List<Answer>()
                {
                    new Answer() { Content = "1/x + C" },
                    new Answer() { Content = "ln(x) + C" },
                    new Answer() { Content = "-x + C" },
                    new Answer() { Content = "e^x + C", IsCorrect = true }
                }
            },
            new Question()
            {
                Content = "What biological process replicates DNA?",
                PrizeLevelId = 13,
                Answers = new List<Answer>()
                {
                    new Answer() { Content = "Mitosis", IsCorrect = true },
                    new Answer() { Content = "Molting" },
                    new Answer() { Content = "Diffusion" },
                    new Answer() { Content = "Peristalsis" }
                }
            },
            new Question()
            {
                Content = "How many keys are on a standard piano?",
                PrizeLevelId = 13,
                Answers = new List<Answer>()
                {
                    new Answer() { Content = "54" },
                    new Answer() { Content = "88", IsCorrect = true },
                    new Answer() { Content = "20" },
                    new Answer() { Content = "100" }
                }
            }
        };
        var level14 = new List<Question>
        {
            new Question()
            {
                Content = "What is your hallux?",
                PrizeLevelId = 14,
                Answers = new List<Answer>()
                {
                    new Answer() { Content = "Earlobe" },
                    new Answer() { Content = "Big toe", IsCorrect = true },
                    new Answer() { Content = "Tongue" },
                    new Answer() { Content = "Eyelid" }
                }
            },
            new Question()
            {
                Content = "What type of substance is 'terra-cotta'?",
                PrizeLevelId = 14,
                Answers = new List<Answer>()
                {
                    new Answer() { Content = "Metal" },
                    new Answer() { Content = "Wood" },
                    new Answer() { Content = "Ceramic", IsCorrect = true },
                    new Answer() { Content = "Glass" }
                }
            },
            new Question()
            {
                Content = "What was the name of the first nuclear-powered submarine?",
                PrizeLevelId = 14,
                Answers = new List<Answer>()
                {
                    new Answer() { Content = "Nautilus", IsCorrect = true },
                    new Answer() { Content = "Neptune" },
                    new Answer() { Content = "Nordenfelt III" },
                    new Answer() { Content = "Nicholas" }
                }
            }
        };

        var questions = new List<Question>();
        questions.AddRange(level1);
        questions.AddRange(level2);
        questions.AddRange(level3);
        questions.AddRange(level4);
        questions.AddRange(level5);
        questions.AddRange(level6);
        questions.AddRange(level7);
        questions.AddRange(level8);
        questions.AddRange(level9);
        questions.AddRange(level10);
        questions.AddRange(level11);
        questions.AddRange(level12);
        questions.AddRange(level13);
        questions.AddRange(level14);
        return questions;
    }
}

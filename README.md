# Who Wants To Be A Millionaire?
This is a simple implementation of popular TV Show

## Configuration
#### 1. Change your connection string in [appsettings.json](appsettings.json)
```json
"ConnectionStrings": {
    "Default": "Server=(localdb)\\mssqllocaldb;Database=WebMillionaire;Trusted_Connection=True;"
  }
```

#### 2. Initiate database
You need to run `update-database` command in Package Manager Console.

The data would be inserted into database automatically by using the PrizeLevelSeeder and QuestionsSeeder

## Architecture
- My project uses EntityFrameworkCore as the tool to communicate with the database
- **PrizeLevelSeeder** and **QuestionsSeeder** imports sample data into database if the tables are empty
- **GameController** is used to communicate between the view and GameService
- **GameService** does all the logic like updating the GameViewModel, Calling for data from repositories, calling the mapper to map entities into Dto models or randomizing the order of answers to choose
- **Repositories** job is to get or input data into the GameDbContext (each table has its own repository class)
- **QuestionsController** returns the view with "Add question" form and calls QuestionsService to add a new question
- **QuestionsService** uses mapper and a repository to add a new question with randomly ordered answers
- **QuestionsAndAnswersMappingProfile** is a mapping profile that I used to easily map different models in one place

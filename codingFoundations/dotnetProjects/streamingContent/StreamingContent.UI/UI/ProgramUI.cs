public class ProgramUI
{
    private readonly StreamingContentRepository _scRepo = new StreamingContentRepository();
    //entry point to app
    public void Run()
    {
        RunMenu();
    }

    private void RunMenu()
    {
        bool continueToRun = true;

        while (continueToRun)
        {
            Console.Clear();
            Console.WriteLine("Please make a selection: \n" +
            "1. Show ALL Streaming Content\n" +
            "2. Find Streaming Content by Title\n" +
            "3. Add New Streaming Content\n" +
            "4. Update Existing Content\n" +
            "5. Remove Streaming Content\n" +
            "6. Exit Application\n"
            );

            string userInput = Console.ReadLine()!;

            switch (userInput)
            {
                case "1":
                case "one":
                    ShowAllContent();
                    break;

                case "2":
                case "two":
                    ShowContentByTitle();
                    break;

                case "3":
                case "three":
                    CreateNewStreamingContent();
                    break;

                case "4":
                case "four":
                    UpdateExistingContent();
                    break;

                case "5":
                case "five":
                    RemoveContentFromList();
                    break;

                case "6":
                case "six":
                    continueToRun = false;
                    System.Console.WriteLine("Thanks for using Streaming Content!");
                    PauseUntilKeyPress();
                    Console.Clear();
                    break;

                default:
                    System.Console.WriteLine("Please enter a valid number between 1-6");
                    PauseUntilKeyPress();
                    break;
            }
        }
    }

    private void RemoveContentFromList()
    {
        throw new NotImplementedException();
    }

    private void UpdateExistingContent()
    {
        try
        {
            //Find the content by title for update
            System.Console.WriteLine("Please input a Title.");

            var userInput = Console.ReadLine();

            var content = _scRepo.GetContent(userInput!);

            if (content != null)
            {
                Console.Clear();

                StreamingContentEntity scContent

                System.Console.WriteLine("Please enter a Title: ");
                content.Title = Console.ReadLine()!;

                System.Console.WriteLine("Please enter a Description: ");
                content.Title = Console.ReadLine()!;

                System.Console.WriteLine("Please enter a Star Rating (1-10): ");
                content.StarRating = double.Parse(Console.ReadLine()!);

                content.MaturityRating = GiveMeAMaturityRating(content);

                System.Console.WriteLine("Select a Genre: \n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. SciFi\n" +
                "4. Documentary\n" +
                "5. Bromance\n" +
                "6. Drama\n" +
                "7. Action\n");

                string genreInput = Console.ReadLine()!;
                int genreValue = int.Parse(genreInput);

                content.TypeOfGenre = (GenreType)genreValue;

                System.Console.WriteLine("Is this a:\n" +
                "1. Movie\n" +
                "2. Show\n");

                var streamingContentValue = ConvertMe(content);
                System.Console.WriteLine($"Streaming content is now of type: {streamingContentValue.GetType().Name}");

                //See if EVERYTHING IS GOING TO WORK
                bool isSuccessful = _scRepo.AddContentToDirectory(streamingContentValue);
                if (isSuccessful)
                {
                    System.Console.WriteLine($"The content named: {streamingContentValue.Title} WAS ADDED to the database.");
                }
                else
                {
                    System.Console.WriteLine($"The content named: {streamingContentValue.Title} WAS NOT ADDED to the database.");
                }
            }
            else
            {
                System.Console.WriteLine($"Sorry, No available content: {userInput}");
            }
        }
        catch (Exception ex)
        {
            System.Console.WriteLine(ex.Message);
        }
        PauseUntilKeyPress();
    }

    private void CreateNewStreamingContent()
    {
        Console.Clear();

        //Empty Form
        StreamingContentEntity content = new StreamingContentEntity();

        System.Console.WriteLine("Please enter a Title: ");
        content.Title = Console.ReadLine()!;

        System.Console.WriteLine("Please enter a Description: ");
        content.Title = Console.ReadLine()!;

        System.Console.WriteLine("Please enter a Star Rating (1-10): ");
        content.StarRating = double.Parse(Console.ReadLine()!);

        content.MaturityRating = GiveMeAMaturityRating(content);

        System.Console.WriteLine("Select a Genre: \n" +
        "1. Horror\n" +
        "2. RomCom\n" +
        "3. SciFi\n" +
        "4. Documentary\n" +
        "5. Bromance\n" +
        "6. Drama\n" +
        "7. Action\n");

        string genreInput = Console.ReadLine()!;
        int genreValue = int.Parse(genreInput);

        content.TypeOfGenre = (GenreType)genreValue;

        System.Console.WriteLine("Is this a:\n" +
        "1. Movie\n" +
        "2. Show\n");

        var streamingContentValue = ConvertMe(content);
        System.Console.WriteLine($"Streaming content is now of type: {streamingContentValue.GetType().Name}");

        //See if EVERYTHING IS GOING TO WORK
        bool isSuccessful = _scRepo.AddContentToDirectory(streamingContentValue);
        if (isSuccessful)
        {
            System.Console.WriteLine($"The content named: {streamingContentValue.Title} WAS ADDED to the database.");
        }
        else
        {
            System.Console.WriteLine($"The content named: {streamingContentValue.Title} WAS NOT ADDED to the database.");
        }

        PauseUntilKeyPress();
    }

    private StreamingContentEntity ConvertMe(StreamingContentEntity content)
    {
        string userInputSC_contentType = Console.ReadLine()!;
        switch (userInputSC_contentType)
        {
            case "1":
            case "Movie":
                System.Console.WriteLine("-- Movie Creation Menu --");
                System.Console.WriteLine("Please enter this movie's runtime.");
                double movieRuntime = double.Parse(Console.ReadLine()!);
                var movie = new Movie(content.Title, content.Description, content.StarRating, content.MaturityRating, content.TypeOfGenre, movieRuntime);
                return movie;

            case "2":
            case "Show":
                System.Console.WriteLine("-- Show Creation Menu --");

                System.Console.WriteLine("Please enter the Season Count.");
                int seasonCount = int.Parse(Console.ReadLine()!);

                System.Console.WriteLine("Please enter the Episode Count.");
                int episodeCount = int.Parse(Console.ReadLine()!);

                System.Console.WriteLine("Please enter the Episode RunTime.");
                double showRunTime = double.Parse(Console.ReadLine()!);
                var show = new Show(seasonCount, episodeCount, showRunTime, content.Title, content.Description, content.MaturityRating, content.TypeOfGenre);

                return show;

            default:
                System.Console.WriteLine("Sorry, Invalid selection. Returning Default Type (Streaming Content Entity). ");
                return content;

        }
    }

    private MaturityRating GiveMeAMaturityRating(StreamingContentEntity content)
    {
        System.Console.WriteLine("Select a Maturity Rating:\n" +
        "1. G\n" +
        "2. PG\n" +
        "3. PG-13\n" +
        "4. R\n" +
        "5. NC-17\n" +
        "6. TV-Y\n" +
        "7. TV-G\n" +
        "8. TV-PG\n" +
        "9. TV-14\n" +
        "10. TV-MA\n"
        );

        string maturityRating = Console.ReadLine()!;

        switch (maturityRating)
        {
            case "1":
                return MaturityRating.G;
            case "2":
                return MaturityRating.PG;
            case "3":
                return MaturityRating.PG_13;
            case "4":
                return MaturityRating.R;
            case "5":
                return MaturityRating.NC_17;
            case "6":
                return MaturityRating.TV_Y;
            case "7":
                return MaturityRating.TV_G;
            case "8":
                return MaturityRating.TV_PG;
            case "9":
                return MaturityRating.TV_14;
            case "10":
                return MaturityRating.TV_MA;
            default:
                System.Console.WriteLine("Invalid Operation");
                return MaturityRating.UNDEFINED;
        }
    }

    private void ShowContentByTitle()
    {
        Console.Clear();
        System.Console.WriteLine("Enter a Title: ");
        string title = Console.ReadLine()!;

        StreamingContentEntity content = _scRepo.GetContent(title);
        if (content != null)
        {
            DisplayContent(content);
        }
        else
        {
            System.Console.WriteLine("Invalid Title...Could not find results!");
        }

        PauseUntilKeyPress();
    }

    private void ShowAllContent()
    {
        Console.Clear();

        List<StreamingContentEntity> ListOfContent = _scRepo.GetAllContent();

        foreach (StreamingContentEntity content in ListOfContent)
        {
            DisplayContent(content);
        }

        PauseUntilKeyPress();
    }

    private void DisplayContent(StreamingContentEntity content)
    {
        System.Console.WriteLine($"Title: {content.Title}\n" +
        $"Description: {content.Description}\n" +
        $"Genre: {content.TypeOfGenre}\n" +
        $"Stars: {content.StarRating}\n" +
        $"Family Friendly {content.IsFamilyFriendly}\n" +
        $"Rating: {content.MaturityRating}\n");
    }

    private void PauseUntilKeyPress()
    {
        System.Console.WriteLine("Press any key to continue.");
        Console.ReadKey();
    }

    private void SeedContentList()
    {
        //Create some content
        StreamingContentEntity rubber = new StreamingContentEntity("Rubber", "Tire that comes to life and kills people", 5.8d, MaturityRating.R, GenreType.Horror);
        StreamingContentEntity toyStory = new StreamingContentEntity("Toy Story", "Best Childhood Movie.", 10.0d, MaturityRating.G, GenreType.Bromance);

        var starWars = new StreamingContentEntity("Star Wars", "Jar Jar saves the world!", 9.2d, MaturityRating.PG_13, GenreType.SciFi);

        //* Add to _scRepo (Repository)
        _scRepo.AddContentToDirectory(rubber);
        _scRepo.AddContentToDirectory(toyStory);
        _scRepo.AddContentToDirectory(starWars);

    }
}
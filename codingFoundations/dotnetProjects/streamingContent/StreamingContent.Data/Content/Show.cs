public class Show : StreamingContentEntity
{
    public List<Episode> episodes = new List<Episode>();
    private double showRunTime;
    private MaturityRating maturityRating;
    private GenreType typeOfGenre;

    public int SeasonCount {get;set;}
    public int EpisodeCount {get;set;}
    public double AverageTime {get;set;}

    public Show(){}

    //full constructor
    public Show(int seasonCount, int episodeCount, double averageTime, string title, string description, double starRating, MaturityRating rating, GenreType typeOfGenre)
    :base (title, description, starRating, rating, typeOfGenre)
    {
        SeasonCount = seasonCount;
        EpisodeCount = episodeCount;
        AverageTime = averageTime;
    }

    public Show(int seasonCount, int episodeCount, double showRunTime, string title, string description, MaturityRating maturityRating, GenreType typeOfGenre)
    {
        SeasonCount = seasonCount;
        EpisodeCount = episodeCount;
        this.showRunTime = showRunTime;
        Title = title;
        Description = description;
        this.maturityRating = maturityRating;
        this.typeOfGenre = typeOfGenre;
    }
}
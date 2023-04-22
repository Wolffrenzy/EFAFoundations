//* POCO -> Plain Old C# Object
//* Abstraction -> What do we perceive this content to be?

public class StreamingContentEntity
{
    //* Full Constructor -> How we can create a StreamingContentEntity
    public StreamingContentEntity(
        string title, 
        string description, 
        double starRating, 
        MaturityRating maturityRating, 
        GenreType typeOfGenre
    )
    {
        Title = title;
        Description = description;
        StarRating = starRating;
        MaturityRating = maturityRating;
        TypeOfGenre = typeOfGenre;
    }

    public StreamingContentEntity() {}

    public StreamingContentEntity(string title, string description, double starRating, GenreType typeOfGenre)
    {
        Title = title;
        Description = description;
        StarRating = starRating;
        TypeOfGenre = typeOfGenre;
    }

    //* UNIQUE IDENTIFIER (Primary Key)
    public string Title {get;set;} = string.Empty;

    public string Description { get; set; } = string.Empty;

    public double StarRating { get; set; }

    public MaturityRating MaturityRating { get; set; }

    public bool IsFamilyFriendly
    {
        get
        {
            //* we can put a 'switch' statement here
            switch(MaturityRating)
            {
                case MaturityRating.G:
                case MaturityRating.PG:
                case MaturityRating.TV_Y:
                case MaturityRating.TV_G:
                case MaturityRating.TV_PG:
                    return true;
                case MaturityRating.PG_13:
                case MaturityRating.R:
                case MaturityRating.NC_17:
                case MaturityRating.TV_14:
                case MaturityRating.TV_MA:
                default:
                    return false;
            }
        }
    }

    public GenreType TypeOfGenre { get; set; }
}


public class StreamingContentRepository
{
    //* This is the object that will hold ALL OF THE STREAMING CONTENT!
    //* This is a COLLECTION!
    //! IT represents our DATABASE (IT'S FAKE FOR NOW...)
    protected readonly List<StreamingContentEntity> _contentDirectory = new List<StreamingContentEntity>();

    //* We can use C.R.U.D on this collection!

    //? Create Method
    public bool AddContentToDirectory(StreamingContentEntity content)
    {
        //* Check the overall _contentDirectory count (how many are there)
        int startingCount = _contentDirectory.Count();

        //* Add the content to the fake database
        _contentDirectory.Add(content);

        //* Comparison to see if the startingCount is less than the _contentDirectory.Count
        bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
        return wasAdded;
    }

    //? Read -> All
    public List<StreamingContentEntity> GetAllContent()
    {
        return _contentDirectory;
    }

    //? Read -> UNIQUE IDENTIFIER (TITLE)
    //* This is considered to be a HELPER METHOD
    public StreamingContentEntity GetContent(string title)
    {
        //* Loop through the collection (fake db)
        foreach (StreamingContentEntity content in _contentDirectory)
        {
            //Logic that will compare what a user put in and what is in the db (database/_contentDirectory)
            if(content.Title.ToLower() == title.ToLower())
            {
                return content;
            }
        }
        return null;
    }

    //? Update
    public bool UpdateExistingContent(string originalTitle, StreamingContentEntity newContent)
    {
        StreamingContentEntity oldContent = GetContent(originalTitle);
        //* Check to see if 'oldContent' exists
        if(oldContent != null)
        {
            oldContent.Title = newContent.Title;
            oldContent.Description = newContent.Description;
            oldContent.StarRating = newContent.StarRating;
            oldContent.TypeOfGenre = newContent.TypeOfGenre;

            return true;
        }
        return false;
    }

    //? Delete
    public bool DeleteExistingContent(StreamingContentEntity content)
    {
        bool deleteResult = _contentDirectory.Remove(content);
        return deleteResult;
    }
    
    //? You can make other methods
    //? Not restricted to CRUD

    //* Get StreamingContent by Genre
    public List<StreamingContentEntity> GetContentByGenre(GenreType type)
    {
        //todo: start with an empty list:
        var genreList = new List<StreamingContentEntity>();

        //todo: Loop through the entire directory
        foreach (StreamingContentEntity content in _contentDirectory)
        {
            //todo: Find matching genre
            if(content.TypeOfGenre == type)
            {
                //todo: Let's add this to the list
                genreList.Add(content);
            }
        }
        //todo: return the list that was made
        return genreList;
    }

    public List<StreamingContentEntity> GetContentByMaturity(MaturityRating matRating)
    {
        //* L.I.N.Q -> Language Integrated Query
        var sContent = _contentDirectory.Where(sc => sc.MaturityRating == matRating).ToList();
        return sContent;
    }
}
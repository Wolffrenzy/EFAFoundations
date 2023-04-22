
public class StreamingRepository : StreamingContentRepository
{
    public Show GetByTitle(string title)
    {
        foreach (var show in _contentDirectory)
        {
            if(show.Title.ToLower() == title.ToLower() && show.GetType() == typeof(Show))         //&& boolean. LEft has to equal right
            {
                return (Show)show; 
            }
        }
        return default;
    }

    public Movie GetMovieByTitle(string title)
    {
        //?LINQ
        var movie = _contentDirectory.FirstOrDefault(mov => mov.Title.ToLower() == title.ToLower());
        return (Movie)movie;
    }

    public List<Show> GetAllShows()
    {
        // var allShows = new List<Show>();

        // foreach (var content in _contentDirectory)
        // {
        //     if(content is Show)
        //     {
        //         allShows.Add((Show)content);
        //     }
        // }

        // return allShows;
                                        //(Where) find a show   //.Select => transform to Show Type
        var allShows = _contentDirectory.Where(s => s is Show).Select(s => new Show()).ToList();

        return allShows;
    }

    public List<Movie> GetAllMovies()
    {
    // var allMovies = new List<Movie>();

    //     foreach (var content in _contentDirectory)
    //     {
    //         if(content is Movie)
    //         {
    //             allMovies.Add((Movie)content);
    //         }
    //     }
    
        var allMovies = _contentDirectory.Where(m=>m is Movie).Select(m=> new Movie()).ToList();

        return allMovies;
    }
}

//* Get by other parameters
//* Get by RunTime/AverageRunTime
//* Get Shows with over x episodes
//* Get Shows/Movie by Rating
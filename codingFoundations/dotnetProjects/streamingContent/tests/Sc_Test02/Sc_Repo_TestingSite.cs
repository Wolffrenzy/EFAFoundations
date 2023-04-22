namespace Sc_Test02;

public class Sc_Repo_TestingSite
{
    //Set up GLOBAL access to StreamingContentEntity and StreamingContentRepository
    private StreamingContentEntity _content; //!IF IT'S PRIVATE, START WITH A 'u'
    private StreamingContentRepository _repo;
    public Sc_Repo_TestingSite()

    //seed data..
    {
        //StreamingContentEntity[0] - line 13, first one added to the repository
        _content = new StreamingContentEntity("Rubber", "A tire that kills people", 5.8, MaturityRating.R, GenreType.Horror);
        _repo = new StreamingContentRepository();
        _repo.AddContentToDirectory(_content);

    }

    [Fact]
    public void AddContentToDirectory_ShouldGetCorrectBoolean()
    {
        //Local scope: stuff will ONLY EXIST IN HERE

        //todo: AAA Setup

        //todo Arrange
        StreamingContentEntity content = new StreamingContentEntity();
        
        //todo Action
        bool actual = _repo.AddContentToDirectory(content);
        bool expected = true;

        //todo Assertion
        Assert.Equal(expected, actual);
        System.Console.WriteLine($"expected: {expected} - actual: {actual}. ");
    }

    [Fact]
    public void GetAllContent_ShouldReturnCorrectCount_And_ShouldReturnCorrectBool()
    {
        //Arrange
        StreamingContentEntity content = new StreamingContentEntity();
        _repo.AddContentToDirectory(content);    

        //ACt
        List<StreamingContentEntity> contents = _repo.GetAllContent();
        int expectedCount = 2;
        int actualCount = contents.Count;
        string expectedTitle = "Rubber";
        string actualTitle = contents[0].Title;

        //Assertion
        Assert.Equal(expectedCount, actualCount);
        Assert.Contains(expectedTitle, actualTitle);
    }

    [Fact]
    public void GetByTitle_ShouldReturnCorrectContent()
    {
        //Arrange -> already done

        //Act
        StreamingContentEntity searchResult = _repo.GetContent("Rubber");

        //Assert
        Assert.Equal(searchResult, _content);
    }

    [Fact]
    public void UpdateExistingContent_ShouldReturnTrue()
    {
        //? Arrange
        StreamingContentEntity newContent = new StreamingContentEntity("Modified Name", "Modified Description", 1.0, MaturityRating.PG_13, GenreType.SciFi);

        //? Act
        bool updatedResult = _repo.UpdateExistingContent("Rubber", newContent);

        //? Assert
        Assert.True(updatedResult);
    }

    [Fact]
    public void DeleteExistingContent_ShouldReturnTrue()
    {
        //Arrange
        StreamingContentEntity content = _repo.GetContent("Rubber");

        //Act
        bool removeResult = _repo.DeleteExistingContent(content);

        //Assert
        Assert.True(removeResult);
    }
}
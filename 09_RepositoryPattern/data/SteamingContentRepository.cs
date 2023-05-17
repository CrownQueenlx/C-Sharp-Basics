namespace Data;
public class StreamingContentRepository
{
    // Field acts as our "Database" connection
    // readonly because we don't want our collection reference to change
    private readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();

    // Create
    // Add to our list, or CREATE a new data entry
    public bool AddContentToDirectory(StreamingContent content)
    {
        // Check the state of the current directory
        int startingCount = _contentDirectory.Count; //lists use .Count

        // Try to add the new content to the directory
        if (content.Title != null)
        {
            _contentDirectory.Add(content);
        }
        
        // Check to see that it worked and wad added
        bool countIncreased = _contentDirectory.Count > startingCount;

        // Return a true/false based on the result
        return countIncreased;
    }

    // Read
    public List<string> GetTitles()
    {
        // Declare a list to store the titles
        List<string> titles = new List<string>();

        //  Add each title to that list
        foreach (StreamingContent content in _contentDirectory)
        {
            //  Add the title property to the list unless it's null
            // if it's null, add " Untitled" to the list
            titles.Add(content.Title ?? "Untitiled");
        }
        // Return our new list
        return titles;
        // does the same thing that the above code does
        // .Select is the C# equivalent of JS .map
        // return _contentDirectory.Select(_contentDirectory => _contentDirectory.Title ?? "Untitled").ToList();
    }

    public List<StreamingContent> GetDirectory()
    {
        // Returns a reference to the readonly list\
        // return _contentDirectory;

        // Creates a new List with the same conten
        //  Returns a reference to the new lsit
        return new List<StreamingContent>(_contentDirectory);
    }

    // Update

    // Delete


}
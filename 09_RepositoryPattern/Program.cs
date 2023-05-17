﻿using Data; // Allow program.cs to access the namespace Data

StreamingContent content = new StreamingContent();
content.Title = "The SpongeBob Movie";

Console.WriteLine(content.IsFamilyFriendly);
Console.WriteLine(content.MaturityRating);

content.MaturityRating = MaturityRating.TV_Y;
Console.WriteLine(content.IsFamilyFriendly);

StreamingContentRepository repository = new StreamingContentRepository();

List<StreamingContent> listBeforeAdd = repository.GetDirectory();

bool wasAdded = repository.AddContentToDirectory(content);
Console.WriteLine(wasAdded ? "The content was added" : "The content was not added");

List<StreamingContent> listAfterAdd = repository.GetDirectory(); // <----

Console.WriteLine(listBeforeAdd.Count);
Console.WriteLine(listAfterAdd.Count);

StreamingContent toystory = new StreamingContent("Toy Story", "Bromance", "A story about toys", 10, MaturityRating.G);
var rubber = new StreamingContent("Rubber", "Action/Thriller", "It's a tire", 7.5, MaturityRating.R);
repository.AddContentToDirectory(toystory);
repository.AddContentToDirectory(rubber);

List<string> titles = repository.GetTitles();
foreach (var title in titles)
{
    Console.WriteLine(title);
}

StreamingContent? foundContent = repository.GetContentByTitle("Rubber"); // or ("ToyStory"); or ("SpongeBob");
Console.WriteLine(foundContent?.Title);
Console.WriteLine(foundContent?.Genre);
Console.WriteLine(foundContent?.Description);
Console.WriteLine(foundContent?.IsFamilyFriendly);


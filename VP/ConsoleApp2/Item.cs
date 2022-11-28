// See https://aka.ms/new-console-template for more information
class Item
{
    static int count = 0;
    public Item(string title, string description, string pubDate, string link)
    {
        Id = count++;
        Title = title;
        Description = description;
        PubDate = pubDate;
        Link = link;
    }
    int Id { get; set; }
    string Title { get; set; }
    string Description { get; set; }
    string PubDate { get; set; }
    string Link { get; set; }
}
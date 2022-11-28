public class Item
{
    static int count = 1;
    public Item(string title, string description, string pubDate, string link)
    {
        Id = count++;
        Title = title;
        Description = description;
        PubDate = pubDate;
        Link = link;
    }
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string PubDate { get; set; }
    public string Link { get; set; }
}
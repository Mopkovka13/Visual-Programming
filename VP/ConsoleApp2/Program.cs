// See https://aka.ms/new-console-template for more information
using System.Xml;


XmlDocument xDoc = new XmlDocument();
xDoc.Load("http://www.consultant.ru/rss/hotdocs.xml");
XmlElement? xRoot = xDoc.DocumentElement;
List<Item> items = new List<Item>();

XmlNodeList? nodes = xRoot?.SelectNodes("//rss/channel/item");
if(nodes is not null)
{
    foreach(XmlNode node in nodes) //Наш item
    {
        string title = "";
        string description = "";
        string pubDate = "";
        string link = "";
        foreach(XmlElement child in node.ChildNodes) //Его атрибуты
        {
            if (child.Name == "title")
                title = child.InnerText;
            if (child.Name == "description")
                description = child.InnerText;
            if (child.Name == "pubDate")
                pubDate = child.InnerText;
            if (child.Name == "link")
                link = child.InnerText;
        }
        items.Add(new Item(title, description, pubDate, link));
    }
}

using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Lab8._2
{
    public partial class Form1 : Form
    {
        private List<Item> _items = new List<Item>();
        XElement rootTag;
        public Form1()
        {
            InitializeComponent();
            readXmlFile("http://www.consultant.ru/rss/hotdocs.xml");

            foreach (var item in _items)
            {
                listBox1.Items.Add(item.Id);
            }
        }

        private void readXmlFile(string nameFile)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(nameFile);
            XmlElement xRoot = xDoc.DocumentElement;

            XmlNodeList nodes = xRoot?.SelectNodes("//rss/channel/item");
            if (nodes != null)
            {
                foreach (XmlNode node in nodes) //Наш item
                {
                    string title = "";
                    string description = "";
                    string pubDate = "";
                    string link = "";
                    foreach (XmlElement child in node.ChildNodes) //Его атрибуты
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
                    _items.Add(new Item(title, description, pubDate, link));
                }
            }
        }
        
        private void showTree()
        {
            listBox1.Items.Clear();
            rootTag = XElement.Load("http://www.consultant.ru/rss/hotdocs.xml");
            IEnumerable<XElement> tags = rootTag.Elements();
            descent(tags, 0);
        }
        private void showItems()
        {
            listBox1.Items.Clear();
            foreach (var item in _items)
            {
                listBox1.Items.Add(item.Id);
            }
        }
        void descent(IEnumerable<XElement> elems, int generation)
        {
            foreach (XElement elem in elems)
            {
                string indent = string.Concat(Enumerable.Repeat("• ", generation));
                listBox1.Items.Add(indent + elem.Name);
                //outputBox.Text += indent + elem.Name + "\n";
                IEnumerable<XElement> childTags = elem.Elements();
                if (childTags != null)
                {
                    descent(childTags, generation + 1);
                }
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if(button1.Text == "ShowTree")
            {
                showTree();
                button1.Text = "ShowItems";
            }
            else
            {
                showItems();
                button1.Text = "ShowTree";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if(button1.Text == "ShowTree")
            {
                int id = listBox1.SelectedIndex;
                Item selectedItem = _items.FirstOrDefault(x => x.Id - 1 == id);
                lbTitle.Text = "Title:\n" + selectedItem.Title;
                lbDescription.Text = "Description:\n" + selectedItem.Description;
                lbDate.Text = "Date:\n" + selectedItem.PubDate;
                lbLink.Text = "Link:\n" + selectedItem.Link;
            }
            else
            {
                lbTitle.Text = "Title";
                lbDescription.Text = "Description";
                lbDate.Text = "Date";
                lbLink.Text = "Link";
            }
            
        }
    }
}

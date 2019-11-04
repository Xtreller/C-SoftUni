using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Articles
    {
        public void Article()
        {
        }
        public void Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public void Rename(string newTitle)
        {
            Title = newTitle;
        }
        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }
        public void Edit(string newContent)
        {
            Content = newContent;
        }
        public override string ToString()
        {
            return $"{Title} -{Content}:{Author}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] articProp = Console.ReadLine().Split(',').ToArray();
            Articles article = new Articles();
            string Author = articProp[2];
            string Title = articProp[0];
            string Content = articProp[1];
            article.Article(Title, Content, Author);
            int countOfComnds = int.Parse(Console.ReadLine());
            for (int i = 0; i < countOfComnds; i++)
            {
                string[] inputCmnd = Console.ReadLine().Split(':');
                if (inputCmnd[0] == "Edit")
                {
                    string newContent = inputCmnd[1];
                    article.Edit(newContent);
                }
                if (inputCmnd[0] == "ChangeAuthor")
                {
                    string newAuthor = inputCmnd[1];
                    article.ChangeAuthor(newAuthor);
                }
                if (inputCmnd[0] == "Rename")
                {
                    string newTitle = inputCmnd[1];
                    article.Rename(newTitle);
                }


            }
            Console.WriteLine(article);

        }
    }

}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> articles = new List<Article>();
            int countOfArticles = int.Parse(Console.ReadLine());
            for (int i = 0; i < countOfArticles; i++)
            {
                string[] input = Console.ReadLine().Split(',');
                string title = input[0];
                string content = input[1];
                string author = input[2];
                Article article = new Article();
                article.Author = author;
                article.Content = content;
                article.Title = title;
                articles.Add(article);
            }
            string sortCriteria = Console.ReadLine();
            if (sortCriteria == "title")
            {
                articles = articles.OrderBy(x => x.Title).ToList();
            }
            if (sortCriteria == "content")
            {
                articles = articles.OrderBy(x => x.Content).ToList();
            }
            if (sortCriteria == "author")
            {
                articles = articles.OrderBy(x => x.Author).ToList();
            }
            foreach (Article article in articles)
            {
                Console.WriteLine($"{article.Title} -{article.Content}:{article.Author}");
            }
        }
    }

}


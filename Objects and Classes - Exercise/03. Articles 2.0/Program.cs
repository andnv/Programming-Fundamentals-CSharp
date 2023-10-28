namespace _03._Articles_2._0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            int articlesNum = int.Parse(Console.ReadLine());

            List<Article> list = new List<Article>();   

            for (int i = 0; i < articlesNum; i++)
            {
                string[] articleInfo = Console.ReadLine()
                         .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                Article article = new Article(articleInfo[0], articleInfo[1], articleInfo[2]);
                list.Add(article);
                
            }

            string orderByWhat = Console.ReadLine();

            switch (orderByWhat)
            {
                case "title":
                    list = list.OrderBy(x => x.Title).ToList();
                    break;

                case "content":
                    list = list.OrderBy(x => x.Content).ToList();
                    break;

                case "author":
                    list = list.OrderBy(x => x.Author).ToList();
                    break;
            }

            Console.WriteLine(string.Join(Environment.NewLine, list));
        }
    }

    public class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}

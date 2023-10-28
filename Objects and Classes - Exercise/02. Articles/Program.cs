namespace _02._Articles
{
    using System;
    using System.Reflection.Metadata;
    using System.Threading.Channels;

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                     .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Article article = new Article(input[0], input[1], input[2]);
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commandArgs = Console.ReadLine()
                         .Split(": ");

                string commandType = commandArgs[0];
                string commandValue = commandArgs[1];

                if (commandType == "Edit")
                {
                    article.Edit(commandValue);
                }

                if (commandType == "ChangeAuthor")
                {
                    article.ChangeAuthor(commandValue);
                }

                if (commandType == "Rename")
                {
                    article.Rename(commandValue);
                }
            }
            Console.WriteLine(article);
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

        public string Author { get; set;}

        public void Edit(string newContent)
        {
            Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            Title = newTitle;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}

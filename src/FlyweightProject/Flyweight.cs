using System.Collections.Generic;


namespace FlyweightProject {
    public class BookFlyweight {
        public string Title { get; }
        public string Author { get; }

        public BookFlyweight(string title, string author)
        {
            Title = title;
            Author = author;
        }
    }

    public class BookFlyweightFactory {
        private readonly Dictionary<string, BookFlyweight> _flyweights = new();

        public BookFlyweight GetFlyweight(string title, string author) {
            string key = $"{title}_{author}";

            if (!_flyweights.ContainsKey(key))
            {
                _flyweights[key] = new BookFlyweight(title, author);
            }

            return _flyweights[key];
        }
    }
}

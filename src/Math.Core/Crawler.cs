namespace Math.Core
{
    public class Crawler : ICrawler
    {
        private IParser _parser;
    
        public Crawler(IParser parser)
        {
            _parser = parser;
        }
    }
    
    public class Parser : IParser
    {
        public IExpose Parse(string content) => new Expose(new Uri("http://example.com"), new Title("Example"));
    }
    
    public class Expose : IExpose
    {
        public Expose(Uri uri, Title title)
        {
            Uri = uri;
            Title = title;
        }
        
        public Uri Uri { get; }
        public Title Title { get; }
    }
}
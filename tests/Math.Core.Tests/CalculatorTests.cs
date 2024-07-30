namespace Math.Core.Tests;

using FluentAssertions;

public class CalculatorTests
{
    [Fact]
    public void Add()
    {
        var result = Calculator.Add(3.0f, 5.0f);
        result.Should().Be(8.0f);
    }
}

public class CrawlerTests
{
    [Fact]
    public void InitTest()
    {
        var crawler = new Crawler(new Parser());
        crawler.Should().NotBeNull();
    }
}

public class ParserTests
{
    [Fact]
    public void InitTest()
    {
        var parser = new Parser();
        parser.Should().NotBeNull();
    }
    
    [Fact]
    public void ParseTest()
    {
        var parser = new Parser();
        var expose = parser.Parse("content");
        expose.Should().NotBeNull();
        expose.Uri.Should().NotBeNull();
        expose.Title.Should().NotBeNull();
    }
}

public class ExposeTests
{
    [Fact]
    public void InitTest()
    {
        var expose = new Expose(new Uri("http://example.com"), new Title("Example"));
        expose.Should().NotBeNull();
        expose.Uri.Should().NotBeNull();
        expose.Title.Should().NotBeNull();
    }
}

public class TitleTests
{
    [Fact]
    public void InitTest()
    {
        var title = new Title("Example");
        title.Should().NotBeNull();
        title.Value.Should().Be("Example");
    }
}
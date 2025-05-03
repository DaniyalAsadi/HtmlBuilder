using HtmlBuilder.Tags;

namespace HtmlBuilder.Tests;
public class HtmlBuilderTest
{
    [Fact]
    public void Test()
    {
        var html = HtmlBuilder.Create<Div>(div =>
        {
            div.H1("h1");
        }).ToString();




    }
}

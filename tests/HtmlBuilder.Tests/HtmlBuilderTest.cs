using HtmlBuilder.Tags;

namespace HtmlBuilder.Tests;
public class HtmlBuilderTest
{
    [Fact]
    public void Test()
    {
        var html = HtmlBuilder.Create<Div>(div =>
        {
            div.AddChild<H1>(x =>
            {
                x.AddClass("title");
                x.SetContent("Hello World");

            });
        }).ToString();

        var expected = "<div><h1 class=\"title\">Hello World</h1></div>";
        Assert.Equal(expected, html.ToString());



    }
}

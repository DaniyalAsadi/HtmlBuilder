using HtmlBuilder.Tags.StructuralTags;
using HtmlBuilder.Tags.TextContentTag;
using HtmlBuilder.Utility.Extensions.Visitors;

namespace HtmlBuilder.Tests;
public class PrettyHtmlVisitorTests
{
    [Fact]
    public void Fact()
    {

        var tag = HtmlBuilder.Div(div =>
        {
            div.Div(x => x.H1(h1 =>
                {
                    h1.SetContent("Hello - World")
                        .SetId("id")
                        .AddClass("col-md-4");

                }))
                .Div(x => x.H2(h2 =>
                {
                    h2.SetContent("GoodBye - World")
                        .SetId("id")
                        .AddClass("col-md-3");
                }));
        });
        var result = tag.ToPrettyHtml();
        var expected =
            "<div>\r\n    <div>\r\n        <h1 id=\"id\">Hello - World</h1>\r\n    </div>\r\n    <div>\r\n        <h2 id=\"id\">GoodBye - World</h2>\r\n    </div>\r\n</div>\r\n";
        Assert.Equal(expected, result);
    }
    [Fact]
    public void Fact2()
    {

        var tag = HtmlBuilder.Div(div =>
        {
            div.Div(x => x.H1(h1 =>
                {
                    h1.SetContent("Hello - World")
                        .SetId("id")
                        .AddClass("col-md-4");

                }))
                .Div(x => x.H2(h2 =>
                {
                    h2.SetContent("GoodBye - World")
                        .SetId("id")
                        .AddClass("col-md-3");
                }));
        });
        var result = tag.ToMinimalHtml();
        var expected =
            "<div><div><h1 id=\"id\">Hello - World</h1></div><div><h2 id=\"id\">GoodBye - World</h2></div></div>";
        Assert.Equal(expected, result);
    }
}

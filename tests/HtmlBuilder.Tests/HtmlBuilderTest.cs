using HtmlBuilder.Tags.StructuralTags;
using HtmlBuilder.Tags.TextContentTag;

namespace HtmlBuilder.Tests;
public class HtmlBuilderTest
{
    [Fact]
    public void Test()
    {
        var x = HtmlBuilder.Div(div =>
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


        var y = x.ToString();


    }
}

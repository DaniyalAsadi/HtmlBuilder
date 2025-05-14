using System;

namespace HtmlBuilder.Tags.StructuralTags;
public static class ArticleExtensions
{
    public static DoubleHtmlElementWithChildren Article(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Article> action)
    {
        Article tag = new Article();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
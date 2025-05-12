using System;

namespace HtmlBuilder.Tags.StructuralTags;
public static class ArticleExtensions
{
    public static Article Article(this DoubleTagWithChildren doubleTag, Action<Article> action)
    {
        Article tag = new Article();
        action(tag);
        return tag;
    }
}
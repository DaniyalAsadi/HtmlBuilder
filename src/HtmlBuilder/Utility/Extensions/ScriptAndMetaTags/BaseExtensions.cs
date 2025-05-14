using HtmlBuilder.Enums;

namespace HtmlBuilder.Tags.ScriptAndMetaTags;
public static class BaseExtensions
{
    public static Base SetHref(this Base tag, string href)
    {
        tag.SetHref(href);
        return tag;
    }

    public static Base SetTarget(this Base tag, BaseTarget target)
    {
        tag.SetTarget(target);
        return tag;
    }

    public static DoubleHtmlElementWithChildren Base(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Base> action)
    {
        Base tag = new Base();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}
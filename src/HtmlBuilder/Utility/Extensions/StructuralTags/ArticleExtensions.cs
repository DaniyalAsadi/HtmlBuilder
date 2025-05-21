using System;

namespace HtmlBuilder.Tags.StructuralTags;
/// <summary>
/// Adds an <see cref="Article"/> element as a child to the specified <see cref="DoubleHtmlElementWithChildren"/>  and
/// allows customization of the <see cref="Article"/> element through the provided action.
/// </summary>
/// <remarks>This method creates a new <see cref="Article"/> element, applies the specified configuration action
/// to it,  and then appends it as a child to the provided <see cref="DoubleHtmlElementWithChildren"/>.  Use this method
/// to construct and customize an <see cref="Article"/> element within a fluent API for building HTML
/// structures.</remarks>
public static class ArticleExtensions
{
    /// <summary>
    /// Adds an <c>&lt;article&gt;</c> element as a child to the current HTML element and allows configuration of the
    /// <c>&lt;article&gt;</c> element.
    /// </summary>
    /// <remarks>This method creates a new <c>&lt;article&gt;</c> element, applies the specified configuration
    /// action to it, and appends it as a child to the current HTML element.</remarks>
    /// <param name="doubleHtmlElement">The parent HTML element to which the <c>&lt;article&gt;</c> element will be added.</param>
    /// <param name="action">A delegate to configure the <c>&lt;article&gt;</c> element. The delegate receives an instance of the
    /// <c>Article</c> class representing the <c>&lt;article&gt;</c> element.</param>
    /// <returns>The parent HTML element, allowing for method chaining.</returns>
    public static DoubleHtmlElementWithChildren Article(this DoubleHtmlElementWithChildren doubleHtmlElement, Action<Article> action)
    {
        Article tag = new Article();
        action(tag);
        doubleHtmlElement.AddChild(tag);
        return doubleHtmlElement;
    }
}

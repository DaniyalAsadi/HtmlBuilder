namespace HtmlBuilder;

/// <summary>
/// Provides methods to create and manipulate HTML elements.
/// </summary>
public class HtmlBuilder
{
    /// <summary>
    /// Creates a new instance of the specified HTML tag type.
    /// </summary>
    /// <typeparam name="TTag">The type of the HTML tag to create. Must inherit from <see cref="DoubleTagWithChildren"/> and have a parameterless constructor.</typeparam>
    /// <param name="creator">An optional action to configure the created tag.</param>
    /// <returns>A new instance of the specified HTML tag type.</returns>
    public static TTag Create<TTag>(Action<TTag>? creator = null)
        where TTag : DoubleTagWithChildren, new()
    {
        if (creator is null)
        {
            return new TTag();
        }

        var element = new TTag();
        creator(element);
        return element;
    }
}

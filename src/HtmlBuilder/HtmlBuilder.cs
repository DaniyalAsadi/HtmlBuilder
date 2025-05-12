using HtmlBuilder.Tags.FormTags;
using HtmlBuilder.Tags.InteractiveTags;
using HtmlBuilder.Tags.MediaTags;
using HtmlBuilder.Tags.ScriptAndMetaTags;
using HtmlBuilder.Tags.StructuralTags;
using HtmlBuilder.Tags.StylingTags;
using HtmlBuilder.Tags.TableTags;
using HtmlBuilder.Tags.TextContentTag;

namespace HtmlBuilder;
/// <summary>
/// Provides methods to create and manipulate HTML elements.
/// </summary>
public class HtmlBuilder
{
    /// <summary>
    /// Creates a new instance of the specified HTML tag type.
    /// </summary>
    /// <typeparam name = "TTag">The type of the HTML tag to create. Must inherit from <see cref = "DoubleTagWithChildren"/> and have a parameterless constructor.</typeparam>
    /// <param name = "creator">An optional action to configure the created tag.</param>
    /// <returns>A new instance of the specified HTML tag type.</returns>
    private static TTag Create<TTag>(Action<TTag>? creator = null)
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

    public static Datalist Datalist(Action<Datalist>? creator = null)
    {
        return Create<Datalist>(creator);
    }

    public static Fieldset Fieldset(Action<Fieldset>? creator = null)
    {
        return Create<Fieldset>(creator);
    }

    public static Form Form(Action<Form>? creator = null)
    {
        return Create<Form>(creator);
    }

    public static Select Select(Action<Select>? creator = null)
    {
        return Create<Select>(creator);
    }

    public static Details Details(Action<Details>? creator = null)
    {
        return Create<Details>(creator);
    }

    public static Dialog Dialog(Action<Dialog>? creator = null)
    {
        return Create<Dialog>(creator);
    }

    public static Menu Menu(Action<Menu>? creator = null)
    {
        return Create<Menu>(creator);
    }

    public static Audio Audio(Action<Audio>? creator = null)
    {
        return Create<Audio>(creator);
    }

    public static Video Video(Action<Video>? creator = null)
    {
        return Create<Video>(creator);
    }

    public static Noscript Noscript(Action<Noscript>? creator = null)
    {
        return Create<Noscript>(creator);
    }

    public static Article Article(Action<Article>? creator = null)
    {
        return Create<Article>(creator);
    }

    public static Aside Aside(Action<Aside>? creator = null)
    {
        return Create<Aside>(creator);
    }

    public static Body Body(Action<Body>? creator = null)
    {
        return Create<Body>(creator);
    }

    public static Div Div(Action<Div>? creator = null)
    {
        return Create<Div>(creator);
    }

    public static Footer Footer(Action<Footer>? creator = null)
    {
        return Create<Footer>(creator);
    }

    public static Head Head(Action<Head>? creator = null)
    {
        return Create<Head>(creator);
    }

    public static Header Header(Action<Header>? creator = null)
    {
        return Create<Header>(creator);
    }

    public static Html Html(Action<Html>? creator = null)
    {
        return Create<Html>(creator);
    }

    public static Main Main(Action<Main>? creator = null)
    {
        return Create<Main>(creator);
    }

    public static Nav Nav(Action<Nav>? creator = null)
    {
        return Create<Nav>(creator);
    }

    public static Section Section(Action<Section>? creator = null)
    {
        return Create<Section>(creator);
    }

    public static Span Span(Action<Span>? creator = null)
    {
        return Create<Span>(creator);
    }

    public static Colgroup Colgroup(Action<Colgroup>? creator = null)
    {
        return Create<Colgroup>(creator);
    }

    public static Table Table(Action<Table>? creator = null)
    {
        return Create<Table>(creator);
    }

    public static Tbody Tbody(Action<Tbody>? creator = null)
    {
        return Create<Tbody>(creator);
    }

    public static Td Td(Action<Td>? creator = null)
    {
        return Create<Td>(creator);
    }

    public static Tfoot Tfoot(Action<Tfoot>? creator = null)
    {
        return Create<Tfoot>(creator);
    }

    public static Th Th(Action<Th>? creator = null)
    {
        return Create<Th>(creator);
    }

    public static Thead Thead(Action<Thead>? creator = null)
    {
        return Create<Thead>(creator);
    }

    public static Tr Tr(Action<Tr>? creator = null)
    {
        return Create<Tr>(creator);
    }

    public static Dl Dl(Action<Dl>? creator = null)
    {
        return Create<Dl>(creator);
    }

    public static Figure Figure(Action<Figure>? creator = null)
    {
        return Create<Figure>(creator);
    }

    public static Ol Ol(Action<Ol>? creator = null)
    {
        return Create<Ol>(creator);
    }

    public static Ul Ul(Action<Ul>? creator = null)
    {
        return Create<Ul>(creator);
    }
}

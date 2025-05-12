using HtmlBuilder.Tags.FormTags;
using HtmlBuilder.Tags.InteractiveTags;
using HtmlBuilder.Tags.MediaTags;
using HtmlBuilder.Tags.StructuralTags;
using HtmlBuilder.Tags.StylingTags;
using HtmlBuilder.Tags.TableTags;
using HtmlBuilder.Tags.TextContentTag;

namespace HtmlBuilder.Tests;

/// <summary>
/// Unit tests for the HtmlBuilder class.
/// </summary>
public class HtmlBuilderTests
{
    [Fact]
    public void Datalist_ShouldCreateDatalistInstance()
    {
        // Act
        var datalist = HtmlBuilder.Datalist();

        // Assert
        Assert.NotNull(datalist);
        Assert.IsType<Datalist>(datalist);
    }

    [Fact]
    public void Fieldset_ShouldCreateFieldsetInstance()
    {
        // Act
        var fieldset = HtmlBuilder.Fieldset();

        // Assert
        Assert.NotNull(fieldset);
        Assert.IsType<Fieldset>(fieldset);
    }

    [Fact]
    public void Form_ShouldCreateFormInstance()
    {
        // Act
        var form = HtmlBuilder.Form();

        // Assert
        Assert.NotNull(form);
        Assert.IsType<Form>(form);
    }

    [Fact]
    public void Select_ShouldCreateSelectInstance()
    {
        // Act
        var select = HtmlBuilder.Select();

        // Assert
        Assert.NotNull(select);
        Assert.IsType<Select>(select);
    }

    [Fact]
    public void Details_ShouldCreateDetailsInstance()
    {
        // Act
        var details = HtmlBuilder.Details();

        // Assert
        Assert.NotNull(details);
        Assert.IsType<Details>(details);
    }

    [Fact]
    public void Dialog_ShouldCreateDialogInstance()
    {
        // Act
        var dialog = HtmlBuilder.Dialog();

        // Assert
        Assert.NotNull(dialog);
        Assert.IsType<Dialog>(dialog);
    }

    [Fact]
    public void Menu_ShouldCreateMenuInstance()
    {
        // Act
        var menu = HtmlBuilder.Menu();

        // Assert
        Assert.NotNull(menu);
        Assert.IsType<Menu>(menu);
    }

    [Fact]
    public void Audio_ShouldCreateAudioInstance()
    {
        // Act
        var audio = HtmlBuilder.Audio();

        // Assert
        Assert.NotNull(audio);
        Assert.IsType<Audio>(audio);
    }

    [Fact]
    public void Video_ShouldCreateVideoInstance()
    {
        // Act
        var video = HtmlBuilder.Video();

        // Assert
        Assert.NotNull(video);
        Assert.IsType<Video>(video);
    }

    [Fact]
    public void Article_ShouldCreateArticleInstance()
    {
        // Act
        var article = HtmlBuilder.Article();

        // Assert
        Assert.NotNull(article);
        Assert.IsType<Article>(article);
    }

    [Fact]
    public void Aside_ShouldCreateAsideInstance()
    {
        // Act
        var aside = HtmlBuilder.Aside();

        // Assert
        Assert.NotNull(aside);
        Assert.IsType<Aside>(aside);
    }

    [Fact]
    public void Div_ShouldCreateDivInstance()
    {
        // Act
        var div = HtmlBuilder.Div();

        // Assert
        Assert.NotNull(div);
        Assert.IsType<Div>(div);
    }

    [Fact]
    public void Footer_ShouldCreateFooterInstance()
    {
        // Act
        var footer = HtmlBuilder.Footer();

        // Assert
        Assert.NotNull(footer);
        Assert.IsType<Footer>(footer);
    }

    [Fact]
    public void Header_ShouldCreateHeaderInstance()
    {
        // Act
        var header = HtmlBuilder.Header();

        // Assert
        Assert.NotNull(header);
        Assert.IsType<Header>(header);
    }

    [Fact]
    public void Html_ShouldCreateHtmlInstance()
    {
        // Act
        var html = HtmlBuilder.Html();

        // Assert
        Assert.NotNull(html);
        Assert.IsType<Html>(html);
    }

    [Fact]
    public void Main_ShouldCreateMainInstance()
    {
        // Act
        var main = HtmlBuilder.Main();

        // Assert
        Assert.NotNull(main);
        Assert.IsType<Main>(main);
    }

    [Fact]
    public void Nav_ShouldCreateNavInstance()
    {
        // Act
        var nav = HtmlBuilder.Nav();

        // Assert
        Assert.NotNull(nav);
        Assert.IsType<Nav>(nav);
    }

    [Fact]
    public void Section_ShouldCreateSectionInstance()
    {
        // Act
        var section = HtmlBuilder.Section();

        // Assert
        Assert.NotNull(section);
        Assert.IsType<Section>(section);
    }

    [Fact]
    public void Span_ShouldCreateSpanInstance()
    {
        // Act
        var span = HtmlBuilder.Span();

        // Assert
        Assert.NotNull(span);
        Assert.IsType<Span>(span);
    }

    [Fact]
    public void Table_ShouldCreateTableInstance()
    {
        // Act
        var table = HtmlBuilder.Table();

        // Assert
        Assert.NotNull(table);
        Assert.IsType<Table>(table);
    }

    [Fact]
    public void Tbody_ShouldCreateTbodyInstance()
    {
        // Act
        var tbody = HtmlBuilder.Tbody();

        // Assert
        Assert.NotNull(tbody);
        Assert.IsType<Tbody>(tbody);
    }

    [Fact]
    public void Td_ShouldCreateTdInstance()
    {
        // Act
        var td = HtmlBuilder.Td();

        // Assert
        Assert.NotNull(td);
        Assert.IsType<Td>(td);
    }

    [Fact]
    public void Th_ShouldCreateThInstance()
    {
        // Act
        var th = HtmlBuilder.Th();

        // Assert
        Assert.NotNull(th);
        Assert.IsType<Th>(th);
    }

    [Fact]
    public void Tr_ShouldCreateTrInstance()
    {
        // Act
        var tr = HtmlBuilder.Tr();

        // Assert
        Assert.NotNull(tr);
        Assert.IsType<Tr>(tr);
    }

    [Fact]
    public void Dl_ShouldCreateDlInstance()
    {
        // Act
        var dl = HtmlBuilder.Dl();

        // Assert
        Assert.NotNull(dl);
        Assert.IsType<Dl>(dl);
    }

    [Fact]
    public void Figure_ShouldCreateFigureInstance()
    {
        // Act
        var figure = HtmlBuilder.Figure();

        // Assert
        Assert.NotNull(figure);
        Assert.IsType<Figure>(figure);
    }

    [Fact]
    public void Ol_ShouldCreateOlInstance()
    {
        // Act
        var ol = HtmlBuilder.Ol();

        // Assert
        Assert.NotNull(ol);
        Assert.IsType<Ol>(ol);
    }

    [Fact]
    public void Ul_ShouldCreateUlInstance()
    {
        // Act
        var ul = HtmlBuilder.Ul();

        // Assert
        Assert.NotNull(ul);
        Assert.IsType<Ul>(ul);
    }
}

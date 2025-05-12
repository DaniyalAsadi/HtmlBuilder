namespace HtmlBuilder.Enums;
internal static class ButtonTypeExtensions
{
    public static string ToHtmlString(this ButtonType buttonType)
    {
        return buttonType switch
        {
            ButtonType.Button => "button",
            ButtonType.Submit => "submit",
            ButtonType.Reset => "reset",
            ButtonType.Menu => "menu",
            _ => throw new ArgumentOutOfRangeException(nameof(buttonType), buttonType, null)
        };
    }
}

namespace HtmlBuilder.Enums;

internal static class FormMethodExtensions
{
    public static string ToHtmlString(this FormMethod method)
    {
        return method switch
        {
            FormMethod.Get => "get",
            FormMethod.Post => "post",
            _ => throw new ArgumentOutOfRangeException(nameof(method), method, null)
        };
    }
}

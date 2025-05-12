namespace HtmlBuilder.Enums;

internal static class FormEncryptTypeExtensions
{
    public static string ToHtmlString(this FormEncryptType encryptType)
    {
        return encryptType switch
        {
            FormEncryptType.UrlEncoded => "application/x-www-form-urlencoded",
            FormEncryptType.Multipart => "multipart/form-data",
            FormEncryptType.PlainText => "text/plain",
            _ => throw new ArgumentOutOfRangeException(nameof(encryptType), encryptType, null)
        };
    }
}

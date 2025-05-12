namespace HtmlBuilder.Enums;

/// <summary>
/// Specifies the encoding type to use when submitting the form.
/// </summary>
public enum FormEncryptType
{
    /// <summary>
    /// 'application/x-www-form-urlencoded' is the default encoding type, used to encode form data.
    /// </summary>
    UrlEncoded,

    /// <summary>
    /// 'multipart/form-data' is used for forms that include file uploads.
    /// </summary>
    Multipart,

    /// <summary>
    /// 'text/plain' is a simple text encoding, used for debugging or sending plain data.
    /// </summary>
    PlainText
}

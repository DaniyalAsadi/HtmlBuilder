namespace HtmlBuilder.Enums;

/// <summary>
/// Defines the type of numbering used in an ordered list (&lt;ol&gt;) element.
/// </summary>
public enum OlType
{
    /// <summary>
    /// English numbers: 1, 2, 3, ... (default)
    /// </summary>
    Numeric,

    /// <summary>
    /// Uppercase Latin letters: A, B, C, ...
    /// </summary>
    UpperAlpha,

    /// <summary>
    /// Lowercase Latin letters: a, b, c, ...
    /// </summary>
    LowerAlpha,

    /// <summary>
    /// Uppercase Roman numerals: I, II, III, ...
    /// </summary>
    UpperRoman,

    /// <summary>
    /// Lowercase Roman numerals: i, ii, iii, ...
    /// </summary>
    LowerRoman
}


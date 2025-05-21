
namespace HtmlBuilder.Enums;
/// <summary>
/// Provides extension methods for the <see cref="TrackKind"/> enumeration.
/// </summary>
/// <remarks>This class includes methods to facilitate working with <see cref="TrackKind"/> values, such as
/// converting them to their corresponding HTML string representations.</remarks>
internal static class TrackKindExtensions
{
    /// <summary>
    /// Converts the specified <see cref="TrackKind"/> value to its corresponding HTML string representation.
    /// </summary>
    /// <param name="trackKind">The <see cref="TrackKind"/> value to convert.</param>
    /// <returns>A string representing the HTML equivalent of the specified <see cref="TrackKind"/> value. For example, <see
    /// cref="TrackKind.Subtitles"/> is converted to "subtitles".</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown if the <paramref name="trackKind"/> value is not a valid <see cref="TrackKind"/> enumeration value.</exception>
    public static string ToHtmlString(this TrackKind trackKind)
    {
        return trackKind switch
        {
            TrackKind.Subtitles => "subtitles",
            TrackKind.Captions => "captions",
            TrackKind.Descriptions => "descriptions",
            TrackKind.Chapters => "chapters",
            TrackKind.Metadata => "metadata",
            _ => throw new ArgumentOutOfRangeException(nameof(trackKind), trackKind, null)
        };
    }
}

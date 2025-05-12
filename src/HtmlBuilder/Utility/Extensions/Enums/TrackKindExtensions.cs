
namespace HtmlBuilder.Enums;
internal static class TrackKindExtensions
{
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

namespace HtmlBuilder.Enums;
internal static class InputTypeExtensions
{
    public static string ToHtmlString(this InputType inputType)
    {
        return inputType switch
        {
            InputType.Text => "text",
            InputType.Password => "password",
            InputType.Email => "email",
            InputType.Number => "number",
            InputType.Date => "date",
            InputType.Color => "color",
            InputType.Range => "range",
            InputType.Checkbox => "checkbox",
            InputType.Radio => "radio",
            InputType.File => "file",
            InputType.Button => "button",
            InputType.Submit => "submit",
            InputType.Reset => "reset",
            InputType.Image => "image",
            InputType.Hidden => "hidden",
            InputType.Search => "search",
            InputType.DatetimeLocal => "datetime-local",
            InputType.Month => "month",
            InputType.Time => "time",
            InputType.Url => "url",
            InputType.Tel => "tel",
            InputType.Week => "week",
            _ => throw new ArgumentOutOfRangeException(nameof(inputType), inputType, null)
        };
    }
}

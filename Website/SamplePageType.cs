using Addon;
using EPiServer.Core;
using EPiServer.DataAnnotations;

namespace Website
{
    [ContentType(GUID = "f868e34f-f20d-4a41-b8b5-94694f603110")]
    public class SamplePageType : PageData
    {
        [CustomTextBox(Style = "text-transform: uppercase;")]
        public virtual string? Alias { get; set; }

        [CustomTextBox(Style = "font-family: Consolas, \"Lucida Console\", \"Courier New\", sans-serif", Type = TextBoxType.Url)]
        public virtual string? Url { get; set; }

        [CustomTextBox(Type = TextBoxType.Password)]
        public virtual string? Password { get; set; }
        
        [CustomTextBox(
            Type = TextBoxType.Color, 
            CssClass = "custom-textbox--autowidth",
            Style = "height: 50px; width: 50px !important;")]
        public virtual string? Color { get; set; }
    }
}

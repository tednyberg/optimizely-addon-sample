using Addon;
using EPiServer.Core;
using EPiServer.DataAnnotations;

namespace Website
{
    [ContentType(GUID = "f868e34f-f20d-4a41-b8b5-94694f603110")]
    public class SamplePageType : PageData
    {
        [CustomTextBox(Width = 480)]
        public virtual string? SomeString { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace Addon
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true, Inherited = true)]
    public class CustomTextBoxAttribute : UIHintAttribute
    {
        public const string UIHintName = "CustomTextBox";

        public CustomTextBoxAttribute() : base(UIHintName)
        {
        }

        /// <summary>
        /// Gets or sets custom styling to apply to the textbox, i.e. the input DOM element, expressed as inline CSS.
        /// </summary>
        public string? Style { get; set; }

        /// <summary>
        /// Gets or sets a CSS class to add to the editor widget wrapper.
        /// </summary>
        public string? CssClass { get; set; }

        /// <summary>
        /// Gets or sets the type of textbox to display.
        /// </summary>
        public TextBoxType Type { get; set; } = TextBoxType.Text;
    }
}

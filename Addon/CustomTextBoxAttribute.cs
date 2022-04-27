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
        /// Gets or sets width of textbox in pixels.
        /// </summary>
        /// <remarks>Defaults to 240 pixels.</remarks>
        public int Width { get; set; } = 360;
    }
}

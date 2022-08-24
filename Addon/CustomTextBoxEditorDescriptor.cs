using EPiServer.Shell.ObjectEditing;
using EPiServer.Shell.ObjectEditing.EditorDescriptors;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Addon
{
    [EditorDescriptorRegistration(TargetType = typeof(string), EditorDescriptorBehavior = EditorDescriptorBehavior.OverrideDefault, UIHint = CustomTextBoxAttribute.UIHintName)]
    public class CustomTextBoxEditorDescriptor : EditorDescriptor
    {
        public override void ModifyMetadata(ExtendedMetadata metadata, IEnumerable<Attribute> attributes)
        {
            base.ModifyMetadata(metadata, attributes);

            var customTextboxAttribute = attributes.OfType<CustomTextBoxAttribute>().FirstOrDefault();

            if (customTextboxAttribute != null)
            {
                metadata.ClientEditingClass = "addon/CustomTextbox";

                metadata.EditorConfiguration.Add("cssClass", customTextboxAttribute.CssClass ?? "");

                metadata.EditorConfiguration.Add("type", customTextboxAttribute.Type.ToString().ToLower());

                metadata.EditorConfiguration.Add("style", customTextboxAttribute.Style ?? "");
            }
        }
    }
}

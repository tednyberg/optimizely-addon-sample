define([
    "dojo/_base/declare",
    "dojo/dom-class",
    "dojo/dom-style",
    "dijit/form/TextBox"
],
    function (
        declare,
        domClass,
        domStyle,
        TextBox
    ) {
        return declare([TextBox], {

            width: null, // See CustomTextBoxEditorDescriptor.cs

            postCreate: function () {
                this.inherited(arguments);

                domClass.add(this.textbox, "custom-textbox"); // See CustomAddon.css

                domStyle.set(this.domNode, "width", `${this.width}px`); // Apply width to textbox wrapper element
            }

        });
    });
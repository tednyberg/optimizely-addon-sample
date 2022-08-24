define([
    "dojo/_base/declare",
    "dojo/dom-attr",
    "dojo/dom-class",
    "dijit/form/TextBox"
],
    function (
        declare,
        domAttr,
        domClass,
        TextBox
    ) {
        return declare([TextBox], {

            /* These properties will be picked up from the EditorConfiguration in CustomTextBoxEditorDescriptor.cs
             * and will automatically be added as-is by Optimizely to the wrapper DOM element of the editor widget. */

            style: null,

            type: null,

            cssClass: null,

            postCreate: function () {
                this.inherited(arguments);

                console.log("this", this);

                if (this.cssClass) {
                    // Add CSS class to the wrapper element of the editor widget, for example to apply custom styling through /ClientResources/CustomAddon.css
                    domClass.add(this.domNode, this.cssClass);
                }

                // Apply custom inline styling directly to the textbox DOM element instead of to its wrapper element
                domAttr.set(this.textbox, "style", this.style);
                domAttr.remove(this.domNode, "style");
            }

        });
    });
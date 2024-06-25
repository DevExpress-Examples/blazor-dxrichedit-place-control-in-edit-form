<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/524045765/22.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1108948)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Blazor Rich Text Editor - How to use the component inside an EditForm

You can place various [DexExpress Blazor components](https://docs.devexpress.com/Blazor/400725/blazor-components) inside an [Edit Form](https://docs.microsoft.com/en-us/aspnet/core/blazor/forms-validation?view=aspnetcore-6.0) to process/validate user input. In this example, an edit form is bound to a data source and includes the following components:

* [Text boxes](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTextBox)  
The **Name**, **Address**, and **Phone** text boxes are bound to corresponding data fields.

* [Rich Text Editor](https://docs.devexpress.com/Blazor/DevExpress.Blazor.RichEdit.DxRichEdit)  
Displays the document whose path is specified in the **Notes** field.

* [Buttons](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxButton)  
The **Next** and **Previous** buttons allow users to navigate data records. The **Save** button saves changes to the bound data source.

![Blazor DxRichEdit bind component to a document](/images/place-rich-in-edit-form.png)

## Overview

You can place our Blazor [Rich Text Editor](https://docs.devexpress.com/Blazor/401891/rich-text-editor) component inside an [Edit Form](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.components.forms.editform?view=aspnetcore-6.0). To bind component content to a data field, use one of the following methods:

### The field contains a path to a document

Follow the steps below:

1. Assign the document's format to the [DocumentFormat](https://docs.devexpress.com/Blazor/DevExpress.Blazor.RichEdit.DxRichEdit.DocumentFormat) property.
2. To open this document in our Blazor Rich Text Editor, assign the document's content as a byte array to the [DocumentContent](https://docs.devexpress.com/Blazor/DevExpress.Blazor.RichEdit.DxRichEdit.DocumentContent) property. In this example, the component updates its content when a user clicks the **Next** or **Previous** button (when switching between data records).
3. Write the [DocumentContent](https://docs.devexpress.com/Blazor/DevExpress.Blazor.RichEdit.DxRichEdit.DocumentContent) property value back to the document to save changes.

If the Rich Text Editor does not support a given document's format, use third-party server libraries (such as the [DevExpress Office File API](https://docs.devexpress.com/OfficeFileAPI/17488/word-processing-document-api)) to convert the document from its original format to a [supported format](https://docs.devexpress.com/Blazor/403344/rich-edit/document-management#document-formats) (and vice versa).

### The field contains a document

Our Blazor Rich Text Editor allows you to bind its content directly to a field that stores the document (assuming the document is in a [supported format](https://docs.devexpress.com/Blazor/403344/rich-edit/document-management#document-formats)). To proceed with this implementation, follow the steps below:

1. Assign the document's format to the [DocumentFormat](https://docs.devexpress.com/Blazor/DevExpress.Blazor.RichEdit.DxRichEdit.DocumentFormat) property.
2. [Bind](https://docs.devexpress.com/Blazor/402330/common-concepts/two-way-data-binding) the [DocumentContent](https://docs.devexpress.com/Blazor/DevExpress.Blazor.RichEdit.DxRichEdit.DocumentContent) property to the field.

The control updates bound field values each time the [DocumentContentChanged](https://docs.devexpress.com/Blazor/DevExpress.Blazor.RichEdit.DxRichEdit.DocumentContentChanged) event occurs. Call the [SaveDocumentAsync](https://docs.devexpress.com/Blazor/DevExpress.Blazor.RichEdit.DxRichEdit.SaveDocumentAsync(System.Threading.CancellationToken)) method to raise this event on-demand.

## Files to Look At

- [Index.razor](./CS/PlaceRichEditInEditForm/Pages/Index.razor)
- [Employee.cs](./CS/PlaceRichEditInEditForm/Data/Employee.cs)
- [SampleData.cs](./CS/PlaceRichEditInEditForm/Data/SampleData.cs)

## Documentation

- [Document Management in the Rich Text Editor](https://docs.devexpress.com/Blazor/403344/rich-edit/document-management)
- [Rich Text Editor Examples](https://docs.devexpress.com/Blazor/403343/rich-edit/examples)
 
## More Examples

- [Blazor Rich Text Editor - How to export a document to a file (HTML format)](https://github.com/DevExpress-Examples/blazor-dxrichedit-export-to-html)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=blazor-dxrichedit-place-control-in-edit-form&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=blazor-dxrichedit-place-control-in-edit-form&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->

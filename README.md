<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1108948)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# Rich Edit for Blazor - How to bind the component to a document

You can place the [Rich Text Editor](https://docs.devexpress.com/Blazor/401891/rich-text-editor) component inside the [Edit Form](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.components.forms.editform?view=aspnetcore-6.0) and bind the component to a document. 

In this example, the edit form is bound to a data source and has the **Next** and **Previous** buttons that allows users to navigate through data records. The component displays the document that corresponds to the current data record and saves changes back to the document when a user clicks the **Save** button.

![Blazor DxRichEdit bind component to a document](/images/place-rich-in-edit-form.png)

## Overview

Place the [Rich Text Editor](https://docs.devexpress.com/Blazor/401891/rich-text-editor) component inside the [Edit Form](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.components.forms.editform?view=aspnetcore-6.0) to receive and validate user input. Assign a data source to the edit form's [EditContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.components.forms.editform.editcontext?view=aspnetcore-6.0#microsoft-aspnetcore-components-forms-editform-editcontext) property to bind this form to data. Depending on the data field's content, use one of the following aproaches to bind the component to a document.

### The field contains a document

The Rich Text Editor allows you to bind its content directly to a field that stores a document in a [supported format](https://docs.devexpress.com/Blazor/403344/rich-edit/document-management#document-formats). To do this, follow the steps below:

1. Assign the document's format to the [DocumentFormat](https://docs.devexpress.com/Blazor/DevExpress.Blazor.RichEdit.DxRichEdit.DocumentFormat) property.
2. [Bind](https://docs.devexpress.com/Blazor/402330/common-concepts/two-way-data-binding) the [DocumentContent](https://docs.devexpress.com/Blazor/DevExpress.Blazor.RichEdit.DxRichEdit.DocumentContent) property to the data source field.

The control updates the bound field value each time the [DocumentContentChanged](https://docs.devexpress.com/Blazor/DevExpress.Blazor.RichEdit.DxRichEdit.DocumentContentChanged) event occurs. Call the [SaveDocumentAsync](https://docs.devexpress.com/Blazor/DevExpress.Blazor.RichEdit.DxRichEdit.SaveDocumentAsync(System.Threading.CancellationToken)) method to rase this event manually.

### The field contains a path to a document file

Perform the following actions to work with this document in the Rich Text Editor:

1. Assign the document's format to the [DocumentFormat](https://docs.devexpress.com/Blazor/DevExpress.Blazor.RichEdit.DxRichEdit.DocumentFormat) property.
2. Assign the file's content as a byte array to the [DocumentContent](https://docs.devexpress.com/Blazor/DevExpress.Blazor.RichEdit.DxRichEdit.DocumentContent) property to open the document.
3. Write the [DocumentContent](https://docs.devexpress.com/Blazor/DevExpress.Blazor.RichEdit.DxRichEdit.DocumentContent) property value back to the file to save changes.

If the Rich Text Editor does not support the document's format, use third-party server libraries (for instance, [DevExpress Office File API](https://docs.devexpress.com/OfficeFileAPI/17488/word-processing-document-api)) to convert the document from its original format to a [supported format](https://docs.devexpress.com/Blazor/403344/rich-edit/document-management#document-formats) and vice versa.

## Files to Look At

- [Index.razor](./CS/PlaceRichEditInEditForm/Pages/Index.razor)

## Documentation

- [Document Management in the Rich Text Editor](https://docs.devexpress.com/Blazor/403344/rich-edit/document-management)
- [Rich Text Editor Examples](https://docs.devexpress.com/Blazor/403343/rich-edit/examples)
 
## More Examples

- [Rich Edit for Blazor - How to check whether the document is empty](https://github.com/DevExpress-Examples/blazor-dxrichedit-check-if-document-is-empty)
- [Rich Edit for Blazor - How to export a document to the HTML](https://github.com/DevExpress-Examples/blazor-dxrichedit-export-to-html)

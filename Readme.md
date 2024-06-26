<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128612167/14.2.17%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3661)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [NewFieldsForm.cs](./CS/NewFieldsForm.cs) (VB: [NewFieldsForm.vb](./VB/NewFieldsForm.vb))
<!-- default file list end -->
# Utility for creating a Mail Merge template


<p>To perform a mail merge, a merge field (or fields) is inserted into a document to create a template. This example illustrates a utility that allows you to simplify the Mail Merge template creation. You just need to specify merge field names in the corresponding dialog by invoking the "Fields > New Merge Fields" command as shown in the screenshot below. These names are used in code to create a fake datasource and assign it to the <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraRichEditRichEditMailMergeOptions_DataSourcetopic"><u>RichEditMailMergeOptions.DataSource Property</u></a>. After that, the "Mailings" Ribbon page is activated and you can use the "Insert Merge Field" command to insert an appropriate field in the document. See the "Insert Fields" section in the <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument6901"><u>How to: Perform a Mail Merge</u></a> help article to learn more.</p><p>In addition, the "Fields" Ribbon page contains commands that allow you to insert <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument9713"><u>INCLUDEPICTURE</u></a> and <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument9721"><u>DOCVARIABLE</u></a> fields and an <a href="http://documentation.devexpress.com/#CoreLibraries/clsDevExpressXtraRichEditCommandsInsertFieldCommandtopic"><u>initial field pattern</u></a> in the document. Of course, you can accomplish this manually via the CTRL+F9 key combination (see <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument9709"><u>Fields and Codes</u></a>). However, predefined commands not only save your time and increase the productivity, but also illustrate how to automate the creation of fields (see the source code of this example). Finally, you can format a document (e.g. add tables, headers) by using other Ribbon commands (see <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument5812"><u>How to: Create a Simple Word Processor with Ribbon Menu</u></a>). The resultant document can be saved to disk via the "File > Save" command and loaded in your application later as a Mail Merge template.</p><p><img src="https://raw.githubusercontent.com/DevExpress-Examples/utility-for-creating-a-mail-merge-template-e3661/13.1.4+/media/72783015-95dd-4a02-859a-06e70cdbb56e.png"></p>

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-richedit-utility-to-create-a-mail-merge-template&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-richedit-utility-to-create-a-mail-merge-template&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->

Imports Microsoft.VisualBasic
Imports System.IO
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.Commands
Imports DevExpress.XtraRichEdit.Services

Namespace RichEditMailMergeTemplateCreator
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()

			richEditControl1.Options.Fields.HighlightColor = Color.Yellow
			richEditControl1.Options.Fields.HighlightMode = FieldsHighlightMode.Always
			richEditControl1.Options.DocumentSaveOptions.CurrentFileName = Path.Combine(Application.StartupPath, "Template.rtf")

			PrepareDefaultMergeTable()
		End Sub

		Private Sub barButtonItem1_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem1.ItemClick
			Using newFieldsForm As New NewFieldsForm()
				PrepareFieldNamesByMergeTable(newFieldsForm)

				If newFieldsForm.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
					PrepareMergeTableByFieldNames(newFieldsForm)
				End If
			End Using
			ribbonControl1.SelectedPage = ribbonControl1.Pages("Mailings")
		End Sub

		Private Sub barButtonItem2_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem2.ItemClick
		richEditControl1.Document.Fields.Create(richEditControl1.Document.CaretPosition, " DOCVARIABLE dvField ")
		End Sub

		Private Sub barButtonItem3_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem3.ItemClick
		richEditControl1.Document.Fields.Create(richEditControl1.Document.CaretPosition, " INCLUDEPICTURE ""image.jpg"" ")
		End Sub

		Private Sub barButtonItem4_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem4.ItemClick
			Dim createFieldCommand As New CreateFieldCommand(richEditControl1)
			createFieldCommand.Execute()
		End Sub

		Private Sub richEditControl1_CalculateDocumentVariable(ByVal sender As Object, ByVal e As DevExpress.XtraRichEdit.CalculateDocumentVariableEventArgs) Handles richEditControl1.CalculateDocumentVariable
			e.Value = e.VariableName & "'s value"
			e.Handled = True
		End Sub

		Private Sub PrepareDefaultMergeTable()
			Dim fieldNames() As String = { "CategoryID", "CategoryName", "Description" }

			Dim dataTable As New DataTable("MergeTable")

			For Each fieldName As String In fieldNames
				dataTable.Columns.Add(fieldName)
			Next fieldName

			CreateDefaultData(dataTable)
			richEditControl1.Options.MailMerge.DataSource = dataTable
		End Sub

		Private Sub PrepareMergeTableByFieldNames(ByVal newFieldsForm As NewFieldsForm)
			Dim dataTable As New DataTable("MergeTable")

			For Each fieldName As String In newFieldsForm.FieldNames
				dataTable.Columns.Add(fieldName)
			Next fieldName

			CreateDefaultData(dataTable)
			richEditControl1.Options.MailMerge.DataSource = dataTable
		End Sub

		Private Sub PrepareFieldNamesByMergeTable(ByVal newFieldsForm As NewFieldsForm)
			Dim dataTable As DataTable = CType(richEditControl1.Options.MailMerge.DataSource, DataTable)
			Dim fieldNames(dataTable.Columns.Count - 1) As String

			For i As Integer = 0 To fieldNames.Length - 1
				fieldNames(i) = dataTable.Columns(i).ColumnName
			Next i

			newFieldsForm.FieldNames = fieldNames
		End Sub

		Private Sub CreateDefaultData(ByVal dataTable As DataTable)
			Dim dataRow As DataRow = dataTable.NewRow()

			For Each dataColumn As DataColumn In dataTable.Columns
				dataRow(dataColumn) = dataColumn.ColumnName & "'s value"
			Next dataColumn

			dataTable.Rows.Add(dataRow)
		End Sub
	End Class
End Namespace

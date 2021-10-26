using System.IO;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.Commands;
using DevExpress.XtraRichEdit.Services;

namespace RichEditMailMergeTemplateCreator {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            richEditControl1.Options.Fields.HighlightColor = Color.Yellow;
            richEditControl1.Options.Fields.HighlightMode = FieldsHighlightMode.Always;
            richEditControl1.Options.DocumentSaveOptions.CurrentFileName = Path.Combine(Application.StartupPath, "Template.rtf");

            PrepareDefaultMergeTable();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            using (NewFieldsForm newFieldsForm = new NewFieldsForm()) {
                PrepareFieldNamesByMergeTable(newFieldsForm);

                if (newFieldsForm.ShowDialog() == DialogResult.OK) {
                    PrepareMergeTableByFieldNames(newFieldsForm);
                }
            }
            ribbonControl1.SelectedPage = ribbonControl1.Pages["Mailings"];
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            richEditControl1.Document.Fields.Create(richEditControl1.Document.CaretPosition, " DOCVARIABLE dvField ");
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            richEditControl1.Document.Fields.Create(richEditControl1.Document.CaretPosition, " INCLUDEPICTURE \"image.jpg\" ");
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            CreateFieldCommand createFieldCommand = new CreateFieldCommand(richEditControl1);
            createFieldCommand.Execute();
        }

        private void richEditControl1_CalculateDocumentVariable(object sender, DevExpress.XtraRichEdit.CalculateDocumentVariableEventArgs e) {
            e.Value = e.VariableName + "'s value";
            e.Handled = true;
        }

        private void PrepareDefaultMergeTable() {
            string[] fieldNames = new string[] { "CategoryID", "CategoryName", "Description" };

            DataTable dataTable = new DataTable("MergeTable");

            foreach (string fieldName in fieldNames) {
                dataTable.Columns.Add(fieldName);
            }

            CreateDefaultData(dataTable);
            richEditControl1.Options.MailMerge.DataSource = dataTable;
        }

        private void PrepareMergeTableByFieldNames(NewFieldsForm newFieldsForm) {
            DataTable dataTable = new DataTable("MergeTable");

            foreach (string fieldName in newFieldsForm.FieldNames) {
                dataTable.Columns.Add(fieldName);
            }

            CreateDefaultData(dataTable);
            richEditControl1.Options.MailMerge.DataSource = dataTable;
        }

        private void PrepareFieldNamesByMergeTable(NewFieldsForm newFieldsForm) {
            DataTable dataTable = (DataTable)richEditControl1.Options.MailMerge.DataSource;
            string[] fieldNames = new string[dataTable.Columns.Count];
            
            for (int i = 0; i < fieldNames.Length; i++) {
                fieldNames[i] = dataTable.Columns[i].ColumnName;
            }

            newFieldsForm.FieldNames = fieldNames;
        }

        private void CreateDefaultData(DataTable dataTable) {
            DataRow dataRow = dataTable.NewRow();

            foreach (DataColumn dataColumn in dataTable.Columns) {
                dataRow[dataColumn] = dataColumn.ColumnName + "'s value";
            }

            dataTable.Rows.Add(dataRow);
        }
    }
}

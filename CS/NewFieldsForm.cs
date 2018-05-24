using System.Windows.Forms;

namespace RichEditMailMergeTemplateCreator {
    public partial class NewFieldsForm : Form {
        public NewFieldsForm() {
            InitializeComponent();
        }

        public string[] FieldNames {
            get {
                return memoEdit1.Lines;
            }
            set {
                memoEdit1.Lines = value;
            }
        }
    }
}

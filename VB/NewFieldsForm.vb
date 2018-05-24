Imports System.Windows.Forms

Namespace RichEditMailMergeTemplateCreator
    Partial Public Class NewFieldsForm
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Property FieldNames() As String()
            Get
                Return memoEdit1.Lines
            End Get
            Set(ByVal value As String())
                memoEdit1.Lines = value
            End Set
        End Property
    End Class
End Namespace

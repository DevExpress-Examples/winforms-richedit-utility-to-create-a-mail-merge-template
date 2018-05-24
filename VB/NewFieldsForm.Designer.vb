Namespace RichEditMailMergeTemplateCreator
    Partial Public Class NewFieldsForm
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.memoEdit1 = New DevExpress.XtraEditors.MemoEdit()
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.simpleButton2 = New DevExpress.XtraEditors.SimpleButton()
            CType(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' memoEdit1
            ' 
            Me.memoEdit1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.memoEdit1.Location = New System.Drawing.Point(13, 13)
            Me.memoEdit1.Name = "memoEdit1"
            Me.memoEdit1.Size = New System.Drawing.Size(423, 169)
            Me.memoEdit1.TabIndex = 0
            ' 
            ' simpleButton1
            ' 
            Me.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
            Me.simpleButton1.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.simpleButton1.Location = New System.Drawing.Point(146, 188)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New System.Drawing.Size(75, 23)
            Me.simpleButton1.TabIndex = 1
            Me.simpleButton1.Text = "OK"
            ' 
            ' simpleButton2
            ' 
            Me.simpleButton2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
            Me.simpleButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.simpleButton2.Location = New System.Drawing.Point(227, 188)
            Me.simpleButton2.Name = "simpleButton2"
            Me.simpleButton2.Size = New System.Drawing.Size(75, 23)
            Me.simpleButton2.TabIndex = 2
            Me.simpleButton2.Text = "Cancel"
            ' 
            ' NewFieldsForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(448, 223)
            Me.Controls.Add(Me.simpleButton2)
            Me.Controls.Add(Me.simpleButton1)
            Me.Controls.Add(Me.memoEdit1)
            Me.Name = "NewFieldsForm"
            Me.Text = "New Merge Fields"
            CType(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private memoEdit1 As DevExpress.XtraEditors.MemoEdit
        Private simpleButton1 As DevExpress.XtraEditors.SimpleButton
        Private simpleButton2 As DevExpress.XtraEditors.SimpleButton
    End Class
End Namespace
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ToDo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.lstBxList = New System.Windows.Forms.ListBox()
        Me.txtText = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(22, 44)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(124, 44)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnRemove.TabIndex = 1
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'lstBxList
        '
        Me.lstBxList.FormattingEnabled = True
        Me.lstBxList.Location = New System.Drawing.Point(239, 28)
        Me.lstBxList.Name = "lstBxList"
        Me.lstBxList.Size = New System.Drawing.Size(232, 160)
        Me.lstBxList.TabIndex = 2
        '
        'txtText
        '
        Me.txtText.Location = New System.Drawing.Point(22, 91)
        Me.txtText.Name = "txtText"
        Me.txtText.Size = New System.Drawing.Size(100, 20)
        Me.txtText.TabIndex = 3
        '
        'ToDo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 386)
        Me.Controls.Add(Me.txtText)
        Me.Controls.Add(Me.lstBxList)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "ToDo"
        Me.Text = "To Do"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents lstBxList As System.Windows.Forms.ListBox
    Friend WithEvents txtText As System.Windows.Forms.TextBox

End Class

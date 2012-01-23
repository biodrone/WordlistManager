<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Deduplicate = New System.Windows.Forms.Button()
        Me.FileFind = New System.Windows.Forms.OpenFileDialog()
        Me.usrInputTxt = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Deduplicate
        '
        Me.Deduplicate.Location = New System.Drawing.Point(156, 48)
        Me.Deduplicate.Name = "Deduplicate"
        Me.Deduplicate.Size = New System.Drawing.Size(78, 23)
        Me.Deduplicate.TabIndex = 0
        Me.Deduplicate.Text = "De-Duplicate"
        Me.Deduplicate.UseVisualStyleBackColor = True
        '
        'FileFind
        '
        Me.FileFind.FileName = "Wordlist"
        '
        'usrInputTxt
        '
        Me.usrInputTxt.Location = New System.Drawing.Point(50, 50)
        Me.usrInputTxt.Name = "usrInputTxt"
        Me.usrInputTxt.Size = New System.Drawing.Size(100, 20)
        Me.usrInputTxt.TabIndex = 1
        Me.usrInputTxt.Text = "File Path"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.usrInputTxt)
        Me.Controls.Add(Me.Deduplicate)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Deduplicate As System.Windows.Forms.Button
    Friend WithEvents FileFind As System.Windows.Forms.OpenFileDialog
    Friend WithEvents usrInputTxt As System.Windows.Forms.TextBox

End Class

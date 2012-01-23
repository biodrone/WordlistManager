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
        Me.cmdCopy = New System.Windows.Forms.Button()
        Me.ProgB = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'Deduplicate
        '
        Me.Deduplicate.Location = New System.Drawing.Point(156, 29)
        Me.Deduplicate.Name = "Deduplicate"
        Me.Deduplicate.Size = New System.Drawing.Size(78, 23)
        Me.Deduplicate.TabIndex = 0
        Me.Deduplicate.Text = "De-Duplicate"
        Me.Deduplicate.UseVisualStyleBackColor = True
        '
        'FileFind
        '
        Me.FileFind.DefaultExt = "txt"
        Me.FileFind.FileName = "Wordlist"
        '
        'usrInputTxt
        '
        Me.usrInputTxt.Location = New System.Drawing.Point(12, 50)
        Me.usrInputTxt.Name = "usrInputTxt"
        Me.usrInputTxt.Size = New System.Drawing.Size(138, 20)
        Me.usrInputTxt.TabIndex = 1
        '
        'cmdCopy
        '
        Me.cmdCopy.Location = New System.Drawing.Point(157, 59)
        Me.cmdCopy.Name = "cmdCopy"
        Me.cmdCopy.Size = New System.Drawing.Size(75, 23)
        Me.cmdCopy.TabIndex = 2
        Me.cmdCopy.Text = "Copy"
        Me.cmdCopy.UseVisualStyleBackColor = True
        '
        'ProgB
        '
        Me.ProgB.Location = New System.Drawing.Point(12, 104)
        Me.ProgB.Name = "ProgB"
        Me.ProgB.Size = New System.Drawing.Size(260, 23)
        Me.ProgB.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.ProgB)
        Me.Controls.Add(Me.cmdCopy)
        Me.Controls.Add(Me.usrInputTxt)
        Me.Controls.Add(Me.Deduplicate)
        Me.Name = "Form1"
        Me.Text = "Wordlist Manager V0.0.2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Deduplicate As System.Windows.Forms.Button
    Friend WithEvents FileFind As System.Windows.Forms.OpenFileDialog
    Friend WithEvents usrInputTxt As System.Windows.Forms.TextBox
    Friend WithEvents cmdCopy As System.Windows.Forms.Button
    Friend WithEvents ProgB As System.Windows.Forms.ProgressBar

End Class

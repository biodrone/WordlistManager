Imports Microsoft.VisualBasic.FileIO
Imports System.IO

Public Class Form1
    Dim Wordlist As String = "", test As String, wrdPath As String = ""
    Private Sub SetUp(sender As System.Object, e As System.EventArgs) Handles Deduplicate.Click
        'FileLoc(Wordlist)
        FileFind.CheckFileExists = True
        FileFind.InitialDirectory = "%USERPROFILE%"

        If usrInputTxt.Text.Contains("\") Then
            If usrInputTxt.Text.Length > 1 Then
                Wordlist = usrInputTxt.Text
            Else
                MsgBox("Please Enter A File Valid Path")
                Exit Sub
            End If
        Else
            MsgBox("Please Enter A File Valid Path")
            Exit Sub
        End If

        'wrdPath = 

        remove()

    End Sub

    Public Function FileLoc(ByRef Location)

    End Function

    Public Sub remove()
        Dim sr As New StreamReader(Wordlist)
        Dim newFile As String = Wordlist.Substring(0, Wordlist.LastIndexOf(".")) + "_NoDups"
        File.CreateText(newFile)


    End Sub
End Class

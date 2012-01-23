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

        wrdPath = Wordlist.Substring(0, Wordlist.LastIndexOf("\"))

        remove(wrdPath)

    End Sub

    Public Function FileLoc(ByRef Location)

    End Function

    Public Sub remove(ByVal wrdPath As String)
        Dim sr As New StreamReader(Wordlist)



    End Sub
End Class

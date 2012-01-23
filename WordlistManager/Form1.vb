Imports Microsoft.VisualBasic.FileIO
Imports System.IO

Public Class Form1
    Dim Wordlist As String = "", test As String, wrdPath As String = "", newFile As String = ""
    Dim DeDup As Boolean = False
    Private Sub Copy(sender As System.Object, e As System.EventArgs) Handles cmdCopy.Click
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

        newFile = Wordlist.Substring(0, Wordlist.LastIndexOf(".")) + "_NoDups.txt"
        If DeDup = True Then
            Copy(newFile, True)
        Else
            Copy(newFile, False)
        End If


    End Sub

    Public Function FileLoc(ByRef Location)

    End Function

    Public Sub copy(ByVal newFile As String, ByVal DeDup As Boolean)
        Dim sr As New StreamReader(Wordlist)

        While sr.EndOfStream = False
            My.Computer.FileSystem.WriteAllText(newFile, sr.ReadLine + vbCrLf, True)
        End While

        MsgBox("done!")
    End Sub

    Private Sub Deduplicate_Click(sender As System.Object, e As System.EventArgs) Handles Deduplicate.Click
        DeDup = True
        Copy(sender, e)
    End Sub
End Class

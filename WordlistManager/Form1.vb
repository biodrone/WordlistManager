Imports Microsoft.VisualBasic.FileIO
Imports System.IO

Public Class Form1
    Dim Wordlist As String = "", test As String, wrdPath As String = "", newFile As String = ""
    Dim DeDup As Boolean = False, arr1(0 To 1) As String
    Dim arrj As Integer = 0

    Private Sub Copy(sender As System.Object, e As System.EventArgs) Handles cmdCopy.Click
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
            wrdmanage(True)
        Else
            wrdmanage(False)
        End If

        Dim endOfarr As Integer = arr1.Length - 1
        ProgB.Minimum = 0
        ProgB.Maximum = endOfarr
        ProgB.Step = 1
        For arri = 0 To endOfarr
            If arr1(arri) <> "" Then
                My.Computer.FileSystem.WriteAllText(newFile, arr1(arri) + vbCrLf, True)
            End If
            ProgB.PerformStep()
        Next
        MsgBox("Action Complete")
        ProgB.Value = 0
        DeDup = False
    End Sub

    Public Function FileLoc(ByRef Location)
        FileFind.CheckPathExists = True
        FileFind.CheckFileExists = True
        FileFind.InitialDirectory = "%USERPROFILE%"

    End Function

    Public Sub wrdmanage(ByVal DeDup As Boolean)
        Dim sr As New StreamReader(Wordlist)
        Dim Dup As New StreamReader(Wordlist)
        Dim arrFill As New StreamReader(Wordlist)
        Dim comWord As String = "", copWord As String = ""
        Dim arri As Integer = 0, endOfarr As Integer = 0

        If DeDup = True Then
            FillArray(endOfarr, Wordlist)
            Dim arr2(0 To 1) As String, arrk As Integer = 0
            For arri = 0 To endOfarr
                For Me.arrj = 0 To endOfarr
                    If arrj = arri Then
                        If arrj <> endOfarr Then
                            arrj = arrj + 1
                        End If
                    End If
                    If arr1(arri) = arr1(arrj) Then
                        arr1(arrj) = ""
                    End If
                Next
            Next
        Else
            FillArray(endOfarr, Wordlist)
            Exit Sub
        End If
    End Sub

    Public Function FillArray(ByRef ender As Integer, ByVal filePath As String)
        Dim reader As New StreamReader(filePath)
        While reader.EndOfStream = False
            reader.ReadLine()
            ender = ender + 1
        End While

        reader.Close()
        reader = New StreamReader(Wordlist)

        ender = ender - 1
        ReDim arr1(0 To ender)
        For arri = 0 To ender
            arr1(arri) = reader.ReadLine
        Next

        Return ender
    End Function

    Private Sub Deduplicate_Click(sender As System.Object, e As System.EventArgs) Handles Deduplicate.Click
        DeDup = True
        Copy(sender, e)
    End Sub
End Class

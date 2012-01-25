Imports Microsoft.VisualBasic.FileIO
Imports System.IO

Public Class Form1
    Dim Wordlist As String = "", wrdPath As String = "", newFile As String = ""
    Dim DeDup As Boolean = False, arr1(0 To 1) As String
    Dim arrj As Integer = 0

    Private Sub Alphabetize(sender As System.Object, e As System.EventArgs) Handles cmdAlpha.Click

    End Sub

    Public Sub CheckFile()
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
    End Sub

    Private Sub Copy(sender As System.Object, e As System.EventArgs) Handles cmdCopy.Click
        CheckFile()


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
    Private Sub Alpha(sender As System.Object, e As System.EventArgs) Handles cmdAlpha.Click
        CheckFile()
    End Sub

    Public Sub wrdmanage(ByVal DeDup As Boolean)
        Dim sr As New StreamReader(Wordlist)
        Dim Dup As New StreamReader(Wordlist)
        Dim arrFill As New StreamReader(Wordlist)
        Dim comWord As String = "", copWord As String = ""
        Dim arri As Integer = 0, endOfarr As Integer = 0

        ArrayProg.Value = 0

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
                ArrayProg.PerformStep()
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
        ArrayProg.Minimum = 0
        ArrayProg.Maximum = ender
        ArrayProg.Step = 1
        ender = ender - 1
        ReDim arr1(0 To ender)
        For arri = 0 To ender
            arr1(arri) = reader.ReadLine
            ArrayProg.PerformStep()
        Next

        Return ender
    End Function

    Private Sub Deduplicate_Click(sender As System.Object, e As System.EventArgs) Handles Deduplicate.Click
        DeDup = True
        Copy(sender, e)
    End Sub
End Class

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
            wrdmanage(newFile, True)
        Else
            wrdmanage(newFile, False)
        End If

    End Sub

    Public Function FileLoc(ByRef Location)
        FileFind.CheckPathExists = True
        FileFind.CheckFileExists = True
        FileFind.InitialDirectory = "%USERPROFILE%"

    End Function

    Public Sub wrdmanage(ByVal newFile As String, ByVal DeDup As Boolean)
        Dim sr As New StreamReader(Wordlist)
        Dim Dup As New StreamReader(Wordlist)
        Dim arrFill As New StreamReader(Wordlist)
        Dim comWord As String = "", copWord As String = ""
        Dim arri As Integer = 0, endOfarr As Integer = 0

        If DeDup = True Then
            FillArray(endOfarr, Wordlist)

            Dim arr2(0 To 1) As String, arrk As Integer = 0
            
            For arri = 0 To endOfarr
                'arr2(arrk) = arr1(arri)
                For Me.arrj = 0 To endOfarr
                    If arrj = arri Then
                        arrj = arrj + 1
                    ElseIf arrj = endOfarr Then

                    End If
                    If arr1(arri) = arr1(arrj) Then
                        'arrk = arrk + 1
                        'arr2(arrk) = arr1(arrj)
                        'ReDim Preserve arr2(0 To arrk + 1)
                        arr1(arrj) = ""
                    End If

                Next

            Next

            'For arri = 0 To endOfarr
            '    arr2(arrk) = arr1(arri)
            '    For arrj = 1 To endOfarr
            '        'For arrk = 1 To endOfarr
            '        If arr1(arri) <> arr1(arrj) Then
            '            arrk = arrk + 1
            '            arr2(arrk) = arr1(arrj)
            '            ReDim Preserve arr2(arrk + 1)
            '        Else
            '            Console.WriteLine("Duplicate: " + arr1(arrj))
            '        End If
            '        'Next
            '    Next
            '    arrk = 0
            'Next



        Else

            '    While Dup.EndOfStream = False
            '        comWord = Dup.ReadLine
            '        While sr.EndOfStream = False
            '            copWord = sr.ReadLine
            '            If comWord <> copWord Then
            '                'My.Computer.FileSystem.WriteAllText(newFile, copWord + vbCrLf, True)
            '            End If
            '        End While
            '        sr.Close()
            '        sr = New StreamReader(Wordlist)
            '    End While
            '    While sr.EndOfStream = False
            '        My.Computer.FileSystem.WriteAllText(newFile, sr.ReadLine + vbCrLf, True)
            '    End While
        End If
        MsgBox("done!")
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

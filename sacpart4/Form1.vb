Public Class Form1
    Dim sr As New System.IO.StreamReader("u:\kolal17337\My Documents\My Pictures\markdata.csv")

    Dim strNames(6)
    Dim strEnglish(6)
    Dim strMaths(6)
    Dim strPE(6)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        Dim x As Integer = 0

        Do Until sr.EndOfStream = True
            lblRead.Text = sr.ReadLine & vbNewLine
            Dim marksarray As String() = Split(lblRead.Text, Delimiter:=",")
            strNames(x) = marksarray(0)
            strEnglish(x) = marksarray(1)
            strMaths(x) = marksarray(2)
            strPE(x) = marksarray(3)
            x = x + 1
            MsgBox("Reading the file...")
        Loop

        Array.Sort(strEnglish)
        Array.Reverse(strEnglish)
        Array.Sort(strMaths)
        Array.Reverse(strMaths)
        Array.Sort(strPE)
        Array.Reverse(strPE)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnReward.Click
        Dim strReward = InputBox("What subject would you like to award marks for?")
        If strReward = "Maths" Then
            MsgBox(strMaths(1))
        ElseIf strReward = "English" Then
            MsgBox(strEnglish(1))
        ElseIf strReward = "PE" Then
            MsgBox(strPE(1))
        Else
            MsgBox("That is not a viable input")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnExitProgram.Click
        End
    End Sub
End Class

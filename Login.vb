Public Class Login
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        UidTb.Clear()
        PassTb.Clear()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If UidTb.Text = "" Or PassTb.Text = "" Then
            MsgBox("Enter the Username & Password")
        ElseIf UidTb.Text = "User" And PassTb.Text = "Password" Then
            Dim Main = New MainForm
            Main.Show()
            Me.Hide()
        Else
            MsgBox("Wrong UserName or Password")
        End If
    End Sub
End Class
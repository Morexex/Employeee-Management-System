Imports System.Data.SqlClient
Public Class Details
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ynana\OneDrive\المستندات\EmployeeVbDb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub FetchEmployeeData()
        If EmpIdTb.Text = "" Then
            MsgBox("Enter The Employee Id")
        Else
            Con.Open()
            Dim Query = "select* from EmployeeTb1 where EmpId=" & EmpIdTb.Text & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(Query, Con)
            Dim dt As DataTable
            dt = New DataTable
            Dim sda As SqlDataAdapter
            sda = New SqlDataAdapter(cmd)
            sda.Fill(dt)
            For Each dr As DataRow In dt.Rows
                EmpNamelbl.Text = dr(1).ToString()
                EmpAddlbl.Text = dr(2).ToString()
                EmpPoslbl.Text = dr(3).ToString()
                EmpPhone.Text = dr(4).ToString()
                EmpDOBlbl.Text = dr(5).ToString()
                EmpEdulbl.Text = dr(6).ToString()
                EmpGender.Text = dr(7).ToString()
                EmpNamelbl.Visible = True
                EmpAddlbl.Visible = True
                EmpPoslbl.Visible = True
                EmpPhone.Visible = True
                EmpDOBlbl.Visible = True
                EmpEdulbl.Visible = True
                EmpGender.Visible = True
            Next
            Con.Close()
        End If

    End Sub
    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles EmpNamelbl.Click

    End Sub

    Private Sub Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FetchEmployeeData()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Dim Main = New MainForm
        Main.Show()
    End Sub

    Private Sub Label11_Click_1(sender As Object, e As EventArgs) Handles Label11.Click
        Application.Exit()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("Employee Management System", New Font("Century Gothic", 25), Brushes.DarkGreen, 180, 40)
        e.Graphics.DrawString("***Employee SUmmary***", New Font("Arial", 20), Brushes.Black, 330, 100)
        e.Graphics.DrawString("Name:  " + EmpNamelbl.Text, New Font("Century Gothic", 20), Brushes.Black, 330, 100)
        e.Graphics.DrawString("Education:  " + EmpEdulbl.Text, New Font("Century Gothic", 20), Brushes.Black, 330, 100)
        e.Graphics.DrawString("Address" + EmpAddlbl.Text, New Font("Century Gothic", 20), Brushes.Black, 330, 100)
        e.Graphics.DrawString("Gender:  " + EmpGender.Text, New Font("Century Gothic", 20), Brushes.Black, 330, 100)
        e.Graphics.DrawString("DOB:  " + EmpDOBlbl.Text, New Font("Century Gothic", 20), Brushes.Black, 330, 100)

        e.Graphics.DrawString("==================EMP 1.0 MoreTech=================", New Font("Century Gothic", 15), Brushes.DarkGreen, 150, 500)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PrintPreviewDialog1.Show()
    End Sub
End Class
Imports System.Data.SqlClient
Public Class Salary
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
                EmpNameLbl.Text = dr(1).ToString()
                EmpPosLbl.Text = dr(3).ToString()
                EmpNameLbl.Visible = True
                EmpPosLbl.Visible = True

            Next
            Con.Close()
        End If

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Dim Main = New MainForm
        Main.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FetchEmployeeData()
    End Sub
    Dim DailyPay
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If EmpPosLbl.Text = "" Then
            MsgBox("Select and Employee")
        ElseIf WorkedTb.Text = "" Or Convert.ToInt32(WorkedTb.Text) > 28 Then
            MsgBox("Ener a valid Number of Days")
        Else
            If EmpPosLbl.Text = "Manager" Then
                DailyPay = 1200
            ElseIf EmpPosLbl.Text = "Accountant" Then
                DailyPay = 1200
            ElseIf EmpPosLbl.Text = "Security" Then
                DailyPay = 600
            ElseIf EmpPosLbl.Text = "IT" Then
                DailyPay = 850
            Else
                DailyPay = 500
            End If
            Dim total = DailyPay * Convert.ToInt32(WorkedTb.Text)
            SalaryTb.Text = "Employee Id:    " + EmpIdTb.Text + vbCrLf + "Employee Name:     " + EmpNameLbl.Text + vbCrLf + "Employee Position:    " + EmpPosLbl.Text + vbCrLf + "Days Worked:    " + WorkedTb.Text + vbCrLf + "Daily Salary Rs:   " + Convert.ToString(DailyPay) + vbCrLf + "Total Amount Rs:" + Convert.ToString(total)

        End If
    End Sub

    Private Sub Salary_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("Employee Management System", New Font("Century Gothic", 25), Brushes.DarkGreen, 180, 40)
        e.Graphics.DrawString("***PAYSLIP***", New Font("Arial", 20), Brushes.Black, 330, 100)
        e.Graphics.DrawString(SalaryTb.Text, New Font("Century Gothic", 20), Brushes.Black, 150, 190)
        e.Graphics.DrawString("==================Thank You For Your Service=================", New Font("Century Gothic", 15), Brushes.DarkGreen, 150, 500)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PrintPreviewDialog1.Show()
    End Sub
End Class
Imports System.Data.SqlClient
Public Class Employee
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ynana\OneDrive\المستندات\EmployeeVbDb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If EmpNameTb.Text = "" Or EmpPhoneTb.Text = "" Or EmpAdd.Text = "" Or PosCb.SelectedItem = "" Or EmpDOB.Text = "" Or EmpEdCb.SelectedItem = "" Or GendCb.SelectedItem = "" Then
            MsgBox("Missing INfomation")
        Else
            Try
                Con.Open()
                Dim Query As String
                Query = "insert into EmployeeTb1 values('" & EmpNameTb.Text & "', '" & EmpAdd.Text & "', '" & PosCb.SelectedItem.ToString() & "', '" & EmpDOB.Value & "', '" & EmpPhoneTb.Text & "', '" & EmpEdCb.SelectedItem.ToString() & "', '" & GendCb.SelectedItem.ToString() & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(Query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Employee Updated Succesfully")
                Con.Close()
                Populate()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub Populate()
        Con.Open()
        Dim sql = "select* from EmployeeTb1"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        EmployeeDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Dim key = 0
    Private Sub Clear()
        EmpNameTb.Clear()
        PosCb.Text = ""
        GendCb.Text = ""
        EmpAdd.Text = ""
        key = 0
        EmpEdCb.Text = ""
        EmpPhoneTb.Text = ""

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If key = 0 Then
            MsgBox("Select The Employer to Deleate")
        Else
            Try
                Con.Open()
                Dim Query As String
                Query = "Delete from EmployeeTb1 where EmpId = " & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(Query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Employee Deleated Successfuly")
                Con.Close()
                Populate()
                Clear()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub EmployeeDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles EmployeeDGV.CellMouseClick
        Dim row As DataGridViewRow = EmployeeDGV.Rows(e.RowIndex)
        key = Convert.ToInt32(row.Cells(0).Value.ToString())
        EmpNameTb.Text = row.Cells(1).Value.ToString()
        EmpAdd.Text = row.Cells(2).Value.ToString()
        PosCb.SelectedItem = row.Cells(3).Value.ToString()
        EmpDOB.Text = row.Cells(4).Value.ToString()
        EmpPhoneTb.Text = row.Cells(5).Value.ToString()
        EmpEdCb.SelectedItem = row.Cells(6).Value.ToString()
        GendCb.SelectedItem = row.Cells(7).Value.ToString()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If EmpNameTb.Text = "" Or EmpPhoneTb.Text = "" Or EmpAdd.Text = "" Then
            MsgBox("Missing INfomation")
        Else
            Try
                Con.Open()
                Dim Query As String
                Query = "Update EmployeeTB1 set EmpName = '" & EmpNameTb.Text & "', '" & EmpAdd.Text & "', '" & PosCb.SelectedItem.ToString() & "', '" & EmpDOB.Value & "', '" & EmpPhoneTb.Text & "', '" & EmpEdCb.SelectedItem.ToString() & "', '" & GendCb.SelectedItem.ToString() & "' where EmpId = " & key & ""
                Dim cmd As New SqlCommand(Query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Emplolyee Updataed")
                Con.Close()
                Populate()
                Clear()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Application.Exit()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Dim Main = New MainForm
        Main.Show()
    End Sub
End Class
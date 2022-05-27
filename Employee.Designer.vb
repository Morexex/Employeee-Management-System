<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.EmployeeDGV = New System.Windows.Forms.DataGridView()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.EmpEdCb = New System.Windows.Forms.ComboBox()
        Me.PosCb = New System.Windows.Forms.ComboBox()
        Me.GendCb = New System.Windows.Forms.ComboBox()
        Me.EmpDOB = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.EmpPhoneTb = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EmpAdd = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EmpNameTb = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.EmployeeDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.EmployeeDGV)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.EmpEdCb)
        Me.Panel1.Controls.Add(Me.PosCb)
        Me.Panel1.Controls.Add(Me.GendCb)
        Me.Panel1.Controls.Add(Me.EmpDOB)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.EmpPhoneTb)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.EmpAdd)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.EmpNameTb)
        Me.Panel1.Location = New System.Drawing.Point(0, 122)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1312, 569)
        Me.Panel1.TabIndex = 0
        '
        'EmployeeDGV
        '
        Me.EmployeeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmployeeDGV.GridColor = System.Drawing.SystemColors.MenuHighlight
        Me.EmployeeDGV.Location = New System.Drawing.Point(654, 3)
        Me.EmployeeDGV.Name = "EmployeeDGV"
        Me.EmployeeDGV.RowTemplate.Height = 28
        Me.EmployeeDGV.Size = New System.Drawing.Size(645, 565)
        Me.EmployeeDGV.TabIndex = 27
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Green
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button4.Location = New System.Drawing.Point(292, 525)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(98, 32)
        Me.Button4.TabIndex = 26
        Me.Button4.Text = "Home"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Green
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(291, 471)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(98, 32)
        Me.Button3.TabIndex = 25
        Me.Button3.Text = "Edit"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Green
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(549, 471)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(98, 32)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(24, 472)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 32)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'EmpEdCb
        '
        Me.EmpEdCb.FormattingEnabled = True
        Me.EmpEdCb.Items.AddRange(New Object() {"Diploma", "Under Graduate", "Post Graduate"})
        Me.EmpEdCb.Location = New System.Drawing.Point(384, 315)
        Me.EmpEdCb.Name = "EmpEdCb"
        Me.EmpEdCb.Size = New System.Drawing.Size(260, 28)
        Me.EmpEdCb.TabIndex = 22
        '
        'PosCb
        '
        Me.PosCb.FormattingEnabled = True
        Me.PosCb.Items.AddRange(New Object() {"Manager", "Security", "Cleaner", "Accountant", "IT"})
        Me.PosCb.Location = New System.Drawing.Point(384, 214)
        Me.PosCb.Name = "PosCb"
        Me.PosCb.Size = New System.Drawing.Size(260, 28)
        Me.PosCb.TabIndex = 21
        '
        'GendCb
        '
        Me.GendCb.FormattingEnabled = True
        Me.GendCb.Items.AddRange(New Object() {"Male", "Female"})
        Me.GendCb.Location = New System.Drawing.Point(20, 214)
        Me.GendCb.Name = "GendCb"
        Me.GendCb.Size = New System.Drawing.Size(264, 28)
        Me.GendCb.TabIndex = 20
        '
        'EmpDOB
        '
        Me.EmpDOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.EmpDOB.Location = New System.Drawing.Point(240, 403)
        Me.EmpDOB.Name = "EmpDOB"
        Me.EmpDOB.Size = New System.Drawing.Size(200, 26)
        Me.EmpDOB.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label8.Location = New System.Drawing.Point(260, 371)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(146, 29)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Employee DOB"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label7.Location = New System.Drawing.Point(388, 269)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(191, 29)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Employee Education"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label6.Location = New System.Drawing.Point(20, 269)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(161, 29)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Employee Phone"
        '
        'EmpPhoneTb
        '
        Me.EmpPhoneTb.Location = New System.Drawing.Point(20, 315)
        Me.EmpPhoneTb.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.EmpPhoneTb.Name = "EmpPhoneTb"
        Me.EmpPhoneTb.Size = New System.Drawing.Size(264, 26)
        Me.EmpPhoneTb.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label5.Location = New System.Drawing.Point(384, 171)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(173, 29)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Employee Position"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label4.Location = New System.Drawing.Point(14, 171)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(170, 29)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Employee Gender"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label2.Location = New System.Drawing.Point(384, 65)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 29)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Employee Address"
        '
        'EmpAdd
        '
        Me.EmpAdd.Location = New System.Drawing.Point(384, 109)
        Me.EmpAdd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.EmpAdd.Name = "EmpAdd"
        Me.EmpAdd.Size = New System.Drawing.Size(260, 26)
        Me.EmpAdd.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label1.Location = New System.Drawing.Point(14, 65)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 29)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Employee Name"
        '
        'EmpNameTb
        '
        Me.EmpNameTb.Location = New System.Drawing.Point(14, 109)
        Me.EmpNameTb.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.EmpNameTb.Name = "EmpNameTb"
        Me.EmpNameTb.Size = New System.Drawing.Size(270, 26)
        Me.EmpNameTb.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bodoni MT", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(136, 75)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(234, 34)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Manage Employee"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Bodoni MT", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(1107, 694)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(133, 34)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "MoreTech"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Bodoni MT", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(1214, 14)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 34)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "X"
        '
        'Employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(1258, 740)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Employee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.EmployeeDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents EmpNameTb As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents EmpAdd As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents EmpPhoneTb As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents EmpEdCb As ComboBox
    Friend WithEvents PosCb As ComboBox
    Friend WithEvents GendCb As ComboBox
    Friend WithEvents EmpDOB As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents EmployeeDGV As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class

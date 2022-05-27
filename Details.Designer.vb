<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Details
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Details))
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.EmpEdulbl = New System.Windows.Forms.Label()
        Me.EmpPoslbl = New System.Windows.Forms.Label()
        Me.EmpAddlbl = New System.Windows.Forms.Label()
        Me.EmpDOBlbl = New System.Windows.Forms.Label()
        Me.EmpPhone = New System.Windows.Forms.Label()
        Me.EmpGender = New System.Windows.Forms.Label()
        Me.EmpNamelbl = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.EmpIdTb = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Bodoni MT", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(1094, 657)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(133, 34)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "MoreTech"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bodoni MT", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(13, 34)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(226, 34)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Employee Details"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Green
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(688, 472)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(98, 32)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Home"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(416, 472)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 32)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label8.Location = New System.Drawing.Point(392, 332)
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
        Me.Label7.Location = New System.Drawing.Point(710, 238)
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
        Me.Label6.Location = New System.Drawing.Point(24, 238)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(161, 29)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Employee Phone"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label5.Location = New System.Drawing.Point(710, 171)
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
        Me.Label4.Location = New System.Drawing.Point(24, 171)
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
        Me.Label2.Location = New System.Drawing.Point(710, 111)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 29)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Employee Address"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label1.Location = New System.Drawing.Point(24, 92)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 29)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Employee Name"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.EmpEdulbl)
        Me.Panel1.Controls.Add(Me.EmpPoslbl)
        Me.Panel1.Controls.Add(Me.EmpAddlbl)
        Me.Panel1.Controls.Add(Me.EmpDOBlbl)
        Me.Panel1.Controls.Add(Me.EmpPhone)
        Me.Panel1.Controls.Add(Me.EmpGender)
        Me.Panel1.Controls.Add(Me.EmpNamelbl)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.EmpIdTb)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.ForeColor = System.Drawing.Color.Red
        Me.Panel1.Location = New System.Drawing.Point(2, 82)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1312, 569)
        Me.Panel1.TabIndex = 28
        '
        'EmpEdulbl
        '
        Me.EmpEdulbl.AutoSize = True
        Me.EmpEdulbl.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpEdulbl.ForeColor = System.Drawing.Color.Red
        Me.EmpEdulbl.Location = New System.Drawing.Point(921, 238)
        Me.EmpEdulbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EmpEdulbl.Name = "EmpEdulbl"
        Me.EmpEdulbl.Size = New System.Drawing.Size(191, 29)
        Me.EmpEdulbl.TabIndex = 34
        Me.EmpEdulbl.Text = "Employee Education"
        Me.EmpEdulbl.Visible = False
        '
        'EmpPoslbl
        '
        Me.EmpPoslbl.AutoSize = True
        Me.EmpPoslbl.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpPoslbl.ForeColor = System.Drawing.Color.Red
        Me.EmpPoslbl.Location = New System.Drawing.Point(921, 171)
        Me.EmpPoslbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EmpPoslbl.Name = "EmpPoslbl"
        Me.EmpPoslbl.Size = New System.Drawing.Size(173, 29)
        Me.EmpPoslbl.TabIndex = 33
        Me.EmpPoslbl.Text = "Employee Position"
        Me.EmpPoslbl.Visible = False
        '
        'EmpAddlbl
        '
        Me.EmpAddlbl.AutoSize = True
        Me.EmpAddlbl.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpAddlbl.ForeColor = System.Drawing.Color.Red
        Me.EmpAddlbl.Location = New System.Drawing.Point(920, 111)
        Me.EmpAddlbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EmpAddlbl.Name = "EmpAddlbl"
        Me.EmpAddlbl.Size = New System.Drawing.Size(177, 29)
        Me.EmpAddlbl.TabIndex = 32
        Me.EmpAddlbl.Text = "Employee Address"
        Me.EmpAddlbl.Visible = False
        '
        'EmpDOBlbl
        '
        Me.EmpDOBlbl.AutoSize = True
        Me.EmpDOBlbl.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpDOBlbl.ForeColor = System.Drawing.Color.Red
        Me.EmpDOBlbl.Location = New System.Drawing.Point(620, 332)
        Me.EmpDOBlbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EmpDOBlbl.Name = "EmpDOBlbl"
        Me.EmpDOBlbl.Size = New System.Drawing.Size(146, 29)
        Me.EmpDOBlbl.TabIndex = 31
        Me.EmpDOBlbl.Text = "Employee DOB"
        Me.EmpDOBlbl.Visible = False
        '
        'EmpPhone
        '
        Me.EmpPhone.AutoSize = True
        Me.EmpPhone.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpPhone.ForeColor = System.Drawing.Color.Red
        Me.EmpPhone.Location = New System.Drawing.Point(250, 238)
        Me.EmpPhone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EmpPhone.Name = "EmpPhone"
        Me.EmpPhone.Size = New System.Drawing.Size(161, 29)
        Me.EmpPhone.TabIndex = 30
        Me.EmpPhone.Text = "Employee Phone"
        Me.EmpPhone.Visible = False
        '
        'EmpGender
        '
        Me.EmpGender.AutoSize = True
        Me.EmpGender.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpGender.ForeColor = System.Drawing.Color.Red
        Me.EmpGender.Location = New System.Drawing.Point(250, 171)
        Me.EmpGender.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EmpGender.Name = "EmpGender"
        Me.EmpGender.Size = New System.Drawing.Size(170, 29)
        Me.EmpGender.TabIndex = 29
        Me.EmpGender.Text = "Employee Gender"
        Me.EmpGender.Visible = False
        '
        'EmpNamelbl
        '
        Me.EmpNamelbl.AutoSize = True
        Me.EmpNamelbl.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpNamelbl.ForeColor = System.Drawing.Color.Red
        Me.EmpNamelbl.Location = New System.Drawing.Point(250, 92)
        Me.EmpNamelbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EmpNamelbl.Name = "EmpNamelbl"
        Me.EmpNamelbl.Size = New System.Drawing.Size(156, 29)
        Me.EmpNamelbl.TabIndex = 28
        Me.EmpNamelbl.Text = "Employee Name"
        Me.EmpNamelbl.Visible = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Green
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(860, 25)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(126, 32)
        Me.Button3.TabIndex = 27
        Me.Button3.Text = "Fetch Data"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'EmpIdTb
        '
        Me.EmpIdTb.Location = New System.Drawing.Point(489, 28)
        Me.EmpIdTb.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.EmpIdTb.Name = "EmpIdTb"
        Me.EmpIdTb.Size = New System.Drawing.Size(332, 26)
        Me.EmpIdTb.TabIndex = 26
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label10.Location = New System.Drawing.Point(346, 25)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(122, 29)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Employee ID"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Bodoni MT", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(1189, 9)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 34)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "X"
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(1233, 694)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Details"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Details"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents EmpEdulbl As Label
    Friend WithEvents EmpPoslbl As Label
    Friend WithEvents EmpAddlbl As Label
    Friend WithEvents EmpDOBlbl As Label
    Friend WithEvents EmpPhone As Label
    Friend WithEvents EmpGender As Label
    Friend WithEvents EmpNamelbl As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents EmpIdTb As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class

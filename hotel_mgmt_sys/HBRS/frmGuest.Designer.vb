<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGuest
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.bttnCancel = New System.Windows.Forms.Button()
        Me.bttnSave = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lvGuest = New System.Windows.Forms.ListView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(10, 13)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(679, 381)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.bttnCancel)
        Me.TabPage1.Controls.Add(Me.bttnSave)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.txtEmail)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.cboGender)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.txtNumber)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txtAddress)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txtMName)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtLName)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtFName)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(671, 355)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "New Guest"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'bttnCancel
        '
        Me.bttnCancel.Location = New System.Drawing.Point(544, 301)
        Me.bttnCancel.Name = "bttnCancel"
        Me.bttnCancel.Size = New System.Drawing.Size(100, 31)
        Me.bttnCancel.TabIndex = 59
        Me.bttnCancel.Text = "&Cancel"
        Me.bttnCancel.UseVisualStyleBackColor = True
        '
        'bttnSave
        '
        Me.bttnSave.Location = New System.Drawing.Point(438, 301)
        Me.bttnSave.Name = "bttnSave"
        Me.bttnSave.Size = New System.Drawing.Size(100, 31)
        Me.bttnSave.TabIndex = 58
        Me.bttnSave.Text = "&Save"
        Me.bttnSave.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(20, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(167, 24)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "New Guest Form"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(157, 250)
        Me.txtEmail.Multiline = True
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(210, 25)
        Me.txtEmail.TabIndex = 55
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(40, 256)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 16)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Email Address"
        '
        'cboGender
        '
        Me.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cboGender.Location = New System.Drawing.Point(157, 223)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(147, 21)
        Me.cboGender.TabIndex = 54
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(40, 224)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 16)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Gender"
        '
        'txtNumber
        '
        Me.txtNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumber.Location = New System.Drawing.Point(157, 190)
        Me.txtNumber.Multiline = True
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(210, 25)
        Me.txtNumber.TabIndex = 50
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(40, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 16)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Contact Number"
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(157, 159)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(210, 25)
        Me.txtAddress.TabIndex = 48
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(40, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 16)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Address"
        '
        'txtMName
        '
        Me.txtMName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMName.Location = New System.Drawing.Point(157, 128)
        Me.txtMName.Multiline = True
        Me.txtMName.Name = "txtMName"
        Me.txtMName.Size = New System.Drawing.Size(210, 25)
        Me.txtMName.TabIndex = 46
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 16)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Middle Name"
        '
        'txtLName
        '
        Me.txtLName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLName.Location = New System.Drawing.Point(157, 97)
        Me.txtLName.Multiline = True
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(210, 25)
        Me.txtLName.TabIndex = 44
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 16)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Last Name"
        '
        'txtFName
        '
        Me.txtFName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFName.Location = New System.Drawing.Point(157, 66)
        Me.txtFName.Multiline = True
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(210, 25)
        Me.txtFName.TabIndex = 42
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 16)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "First Name"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lvGuest)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(671, 355)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Guest List"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lvGuest
        '
        Me.lvGuest.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lvGuest.FullRowSelect = True
        Me.lvGuest.GridLines = True
        Me.lvGuest.Location = New System.Drawing.Point(24, 61)
        Me.lvGuest.Name = "lvGuest"
        Me.lvGuest.Size = New System.Drawing.Size(623, 241)
        Me.lvGuest.TabIndex = 59
        Me.lvGuest.UseCompatibleStateImageBehavior = False
        Me.lvGuest.View = System.Windows.Forms.View.Details
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(20, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 24)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "Guest List"
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "First Name"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 150
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Middle Name"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 150
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Last Name"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 150
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Address"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 150
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Contact Number"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 100
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Status"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 80
        '
        'frmGuest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 408)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmGuest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guest"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txtLName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboGender As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lvGuest As System.Windows.Forms.ListView
    Friend WithEvents bttnCancel As System.Windows.Forms.Button
    Friend WithEvents bttnSave As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
End Class

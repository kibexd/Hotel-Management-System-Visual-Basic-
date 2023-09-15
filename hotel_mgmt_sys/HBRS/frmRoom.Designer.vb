<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRoom
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRoom))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.bttnCancel = New System.Windows.Forms.Button()
        Me.bttnSave = New System.Windows.Forms.Button()
        Me.txtNoOfbeds = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRoomRate = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRoomType = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lvRoom = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(21, 18)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(481, 314)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.bttnCancel)
        Me.TabPage1.Controls.Add(Me.bttnSave)
        Me.TabPage1.Controls.Add(Me.txtNoOfbeds)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txtRoomRate)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtRoomType)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtID)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(473, 288)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "New Room"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'bttnCancel
        '
        Me.bttnCancel.Location = New System.Drawing.Point(353, 238)
        Me.bttnCancel.Name = "bttnCancel"
        Me.bttnCancel.Size = New System.Drawing.Size(100, 31)
        Me.bttnCancel.TabIndex = 69
        Me.bttnCancel.Text = "&Cancel"
        Me.bttnCancel.UseVisualStyleBackColor = True
        '
        'bttnSave
        '
        Me.bttnSave.Location = New System.Drawing.Point(247, 238)
        Me.bttnSave.Name = "bttnSave"
        Me.bttnSave.Size = New System.Drawing.Size(100, 31)
        Me.bttnSave.TabIndex = 68
        Me.bttnSave.Text = "&Save"
        Me.bttnSave.UseVisualStyleBackColor = True
        '
        'txtNoOfbeds
        '
        Me.txtNoOfbeds.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoOfbeds.Location = New System.Drawing.Point(170, 183)
        Me.txtNoOfbeds.Multiline = True
        Me.txtNoOfbeds.Name = "txtNoOfbeds"
        Me.txtNoOfbeds.Size = New System.Drawing.Size(74, 25)
        Me.txtNoOfbeds.TabIndex = 66
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 16)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Number of Beds"
        '
        'txtRoomRate
        '
        Me.txtRoomRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoomRate.Location = New System.Drawing.Point(170, 141)
        Me.txtRoomRate.Multiline = True
        Me.txtRoomRate.Name = "txtRoomRate"
        Me.txtRoomRate.Size = New System.Drawing.Size(74, 25)
        Me.txtRoomRate.TabIndex = 64
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 16)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Room Rate"
        '
        'txtRoomType
        '
        Me.txtRoomType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoomType.Location = New System.Drawing.Point(170, 100)
        Me.txtRoomType.Multiline = True
        Me.txtRoomType.Name = "txtRoomType"
        Me.txtRoomType.Size = New System.Drawing.Size(170, 25)
        Me.txtRoomType.TabIndex = 62
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Room Type"
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(170, 60)
        Me.txtID.Multiline = True
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(74, 25)
        Me.txtID.TabIndex = 60
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Room Number"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(19, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 24)
        Me.Label9.TabIndex = 59
        Me.Label9.Text = "New Room"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lvRoom)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(473, 288)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Room List"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lvRoom
        '
        Me.lvRoom.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvRoom.FullRowSelect = True
        Me.lvRoom.GridLines = True
        Me.lvRoom.Location = New System.Drawing.Point(23, 55)
        Me.lvRoom.Name = "lvRoom"
        Me.lvRoom.Size = New System.Drawing.Size(429, 212)
        Me.lvRoom.TabIndex = 61
        Me.lvRoom.UseCompatibleStateImageBehavior = False
        Me.lvRoom.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "ID"
        Me.ColumnHeader5.Width = 30
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Room Number"
        Me.ColumnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Room Type"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 130
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Room Rate"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 80
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "No Of Beds"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 100
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 24)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Room List"
        '
        'frmRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 344)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRoom"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Room"
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
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtRoomType As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNoOfbeds As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtRoomRate As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lvRoom As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents bttnCancel As System.Windows.Forms.Button
    Friend WithEvents bttnSave As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
End Class

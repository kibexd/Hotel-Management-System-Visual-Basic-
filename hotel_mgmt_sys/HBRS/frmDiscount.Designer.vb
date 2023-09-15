<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDiscount
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
        Me.lvlDiscount = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bttnSave = New System.Windows.Forms.Button()
        Me.bttnCancel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lvlDiscount
        '
        Me.lvlDiscount.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvlDiscount.FullRowSelect = True
        Me.lvlDiscount.GridLines = True
        Me.lvlDiscount.Location = New System.Drawing.Point(305, 59)
        Me.lvlDiscount.Name = "lvlDiscount"
        Me.lvlDiscount.Size = New System.Drawing.Size(201, 159)
        Me.lvlDiscount.TabIndex = 0
        Me.lvlDiscount.UseCompatibleStateImageBehavior = False
        Me.lvlDiscount.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 30
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Type"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Rate"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtType
        '
        Me.txtType.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtType.Location = New System.Drawing.Point(138, 85)
        Me.txtType.Multiline = True
        Me.txtType.Name = "txtType"
        Me.txtType.ReadOnly = True
        Me.txtType.Size = New System.Drawing.Size(146, 25)
        Me.txtType.TabIndex = 76
        Me.txtType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 16)
        Me.Label4.TabIndex = 77
        Me.Label4.Text = "Discount Type"
        '
        'txtRate
        '
        Me.txtRate.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRate.Location = New System.Drawing.Point(138, 116)
        Me.txtRate.Multiline = True
        Me.txtRate.Name = "txtRate"
        Me.txtRate.ReadOnly = True
        Me.txtRate.Size = New System.Drawing.Size(66, 25)
        Me.txtRate.TabIndex = 78
        Me.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 16)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Discount Rate (%)"
        '
        'bttnSave
        '
        Me.bttnSave.Location = New System.Drawing.Point(108, 174)
        Me.bttnSave.Name = "bttnSave"
        Me.bttnSave.Size = New System.Drawing.Size(85, 29)
        Me.bttnSave.TabIndex = 80
        Me.bttnSave.Text = "&Save"
        Me.bttnSave.UseVisualStyleBackColor = True
        '
        'bttnCancel
        '
        Me.bttnCancel.Location = New System.Drawing.Point(199, 174)
        Me.bttnCancel.Name = "bttnCancel"
        Me.bttnCancel.Size = New System.Drawing.Size(85, 29)
        Me.bttnCancel.TabIndex = 81
        Me.bttnCancel.Text = "&Cancel"
        Me.bttnCancel.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 24)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Discounts"
        '
        'frmDiscount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaGreen
        Me.ClientSize = New System.Drawing.Size(580, 344)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.bttnCancel)
        Me.Controls.Add(Me.bttnSave)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lvlDiscount)
        Me.Name = "frmDiscount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lvlDiscount As System.Windows.Forms.ListView
    Friend WithEvents txtType As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents bttnSave As System.Windows.Forms.Button
    Friend WithEvents bttnCancel As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class

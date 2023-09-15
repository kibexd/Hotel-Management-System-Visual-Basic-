<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheckOutList
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
        Me.dtOut = New System.Windows.Forms.DateTimePicker()
        Me.dtIn = New System.Windows.Forms.DateTimePicker()
        Me.lvlcheckin = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'dtOut
        '
        Me.dtOut.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtOut.Location = New System.Drawing.Point(123, 479)
        Me.dtOut.Name = "dtOut"
        Me.dtOut.Size = New System.Drawing.Size(104, 20)
        Me.dtOut.TabIndex = 45
        '
        'dtIn
        '
        Me.dtIn.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtIn.Location = New System.Drawing.Point(23, 479)
        Me.dtIn.Name = "dtIn"
        Me.dtIn.Size = New System.Drawing.Size(94, 20)
        Me.dtIn.TabIndex = 44
        '
        'lvlcheckin
        '
        Me.lvlcheckin.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11})
        Me.lvlcheckin.FullRowSelect = True
        Me.lvlcheckin.GridLines = True
        Me.lvlcheckin.Location = New System.Drawing.Point(12, 21)
        Me.lvlcheckin.Name = "lvlcheckin"
        Me.lvlcheckin.Size = New System.Drawing.Size(801, 349)
        Me.lvlcheckin.TabIndex = 46
        Me.lvlcheckin.UseCompatibleStateImageBehavior = False
        Me.lvlcheckin.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "TransID"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Guest Name"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 200
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Room #"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Checkin Date"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Checkout Date"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 100
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "No. of Days"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 80
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Children"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Adults"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Advance Payment"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader9.Width = 120
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Discount"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader10.Width = 80
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Total"
        Me.ColumnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader11.Width = 80
        '
        'frmCheckOutList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(828, 387)
        Me.Controls.Add(Me.lvlcheckin)
        Me.Controls.Add(Me.dtOut)
        Me.Controls.Add(Me.dtIn)
        Me.Name = "frmCheckOutList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Checked Out List"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtOut As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtIn As System.Windows.Forms.DateTimePicker
    Friend WithEvents lvlcheckin As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
End Class

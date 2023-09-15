<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheckout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCheckout))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bttnSearchGuest = New System.Windows.Forms.Button()
        Me.txtGuestName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTransID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRoomNumber = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRoomType = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRoomRate = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.txtCheckin = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCheckout = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDays = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtChildren = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtAdult = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDiscountType = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtAdvance = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtCash = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtChange = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.bttnCheckout = New System.Windows.Forms.Button()
        Me.lblGuestID = New System.Windows.Forms.Label()
        Me.lblTransID = New System.Windows.Forms.Label()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dtIn = New System.Windows.Forms.DateTimePicker()
        Me.dtOut = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(11, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 24)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Check Out Guest"
        '
        'bttnSearchGuest
        '
        Me.bttnSearchGuest.Location = New System.Drawing.Point(362, 93)
        Me.bttnSearchGuest.Name = "bttnSearchGuest"
        Me.bttnSearchGuest.Size = New System.Drawing.Size(30, 26)
        Me.bttnSearchGuest.TabIndex = 71
        Me.bttnSearchGuest.Text = "..."
        Me.bttnSearchGuest.UseVisualStyleBackColor = True
        '
        'txtGuestName
        '
        Me.txtGuestName.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtGuestName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuestName.Location = New System.Drawing.Point(146, 94)
        Me.txtGuestName.Multiline = True
        Me.txtGuestName.Name = "txtGuestName"
        Me.txtGuestName.ReadOnly = True
        Me.txtGuestName.Size = New System.Drawing.Size(210, 25)
        Me.txtGuestName.TabIndex = 67
        Me.txtGuestName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 16)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Guest Name"
        '
        'txtTransID
        '
        Me.txtTransID.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtTransID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTransID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransID.ForeColor = System.Drawing.Color.DarkRed
        Me.txtTransID.Location = New System.Drawing.Point(146, 63)
        Me.txtTransID.Multiline = True
        Me.txtTransID.Name = "txtTransID"
        Me.txtTransID.ReadOnly = True
        Me.txtTransID.Size = New System.Drawing.Size(115, 25)
        Me.txtTransID.TabIndex = 69
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 16)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Transaction ID"
        '
        'txtRoomNumber
        '
        Me.txtRoomNumber.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtRoomNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoomNumber.Location = New System.Drawing.Point(146, 125)
        Me.txtRoomNumber.Multiline = True
        Me.txtRoomNumber.Name = "txtRoomNumber"
        Me.txtRoomNumber.ReadOnly = True
        Me.txtRoomNumber.Size = New System.Drawing.Size(85, 25)
        Me.txtRoomNumber.TabIndex = 72
        Me.txtRoomNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "Room Number"
        '
        'txtRoomType
        '
        Me.txtRoomType.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtRoomType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoomType.Location = New System.Drawing.Point(146, 156)
        Me.txtRoomType.Multiline = True
        Me.txtRoomType.Name = "txtRoomType"
        Me.txtRoomType.ReadOnly = True
        Me.txtRoomType.Size = New System.Drawing.Size(115, 25)
        Me.txtRoomType.TabIndex = 76
        Me.txtRoomType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "Room Type"
        '
        'txtRoomRate
        '
        Me.txtRoomRate.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtRoomRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoomRate.Location = New System.Drawing.Point(146, 187)
        Me.txtRoomRate.Multiline = True
        Me.txtRoomRate.Name = "txtRoomRate"
        Me.txtRoomRate.ReadOnly = True
        Me.txtRoomRate.Size = New System.Drawing.Size(85, 25)
        Me.txtRoomRate.TabIndex = 78
        Me.txtRoomRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 16)
        Me.Label6.TabIndex = 79
        Me.Label6.Text = "Room Rate"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(735, 444)
        Me.ShapeContainer1.TabIndex = 80
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.MenuText
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 13
        Me.LineShape1.X2 = 717
        Me.LineShape1.Y1 = 42
        Me.LineShape1.Y2 = 42
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.DarkGray
        Me.RectangleShape1.Location = New System.Drawing.Point(18, 328)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(697, 96)
        '
        'txtCheckin
        '
        Me.txtCheckin.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtCheckin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheckin.Location = New System.Drawing.Point(146, 218)
        Me.txtCheckin.Multiline = True
        Me.txtCheckin.Name = "txtCheckin"
        Me.txtCheckin.ReadOnly = True
        Me.txtCheckin.Size = New System.Drawing.Size(115, 25)
        Me.txtCheckin.TabIndex = 81
        Me.txtCheckin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 223)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 16)
        Me.Label7.TabIndex = 82
        Me.Label7.Text = "Checkin Date"
        '
        'txtCheckout
        '
        Me.txtCheckout.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtCheckout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheckout.Location = New System.Drawing.Point(146, 249)
        Me.txtCheckout.Multiline = True
        Me.txtCheckout.Name = "txtCheckout"
        Me.txtCheckout.ReadOnly = True
        Me.txtCheckout.Size = New System.Drawing.Size(115, 25)
        Me.txtCheckout.TabIndex = 83
        Me.txtCheckout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(20, 254)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 16)
        Me.Label8.TabIndex = 84
        Me.Label8.Text = "Checkout Date"
        '
        'txtDays
        '
        Me.txtDays.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDays.Location = New System.Drawing.Point(146, 280)
        Me.txtDays.Multiline = True
        Me.txtDays.Name = "txtDays"
        Me.txtDays.ReadOnly = True
        Me.txtDays.Size = New System.Drawing.Size(58, 25)
        Me.txtDays.TabIndex = 85
        Me.txtDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(20, 285)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 16)
        Me.Label9.TabIndex = 86
        Me.Label9.Text = "No. Of Days"
        '
        'txtChildren
        '
        Me.txtChildren.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtChildren.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChildren.Location = New System.Drawing.Point(587, 89)
        Me.txtChildren.Multiline = True
        Me.txtChildren.Name = "txtChildren"
        Me.txtChildren.ReadOnly = True
        Me.txtChildren.Size = New System.Drawing.Size(54, 25)
        Me.txtChildren.TabIndex = 87
        Me.txtChildren.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(456, 94)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 16)
        Me.Label10.TabIndex = 88
        Me.Label10.Text = "No. Of Children"
        '
        'txtAdult
        '
        Me.txtAdult.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtAdult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdult.Location = New System.Drawing.Point(587, 120)
        Me.txtAdult.Multiline = True
        Me.txtAdult.Name = "txtAdult"
        Me.txtAdult.ReadOnly = True
        Me.txtAdult.Size = New System.Drawing.Size(54, 25)
        Me.txtAdult.TabIndex = 89
        Me.txtAdult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(456, 125)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 16)
        Me.Label11.TabIndex = 90
        Me.Label11.Text = "No. Of Adults"
        '
        'txtDiscountType
        '
        Me.txtDiscountType.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtDiscountType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscountType.Location = New System.Drawing.Point(587, 151)
        Me.txtDiscountType.Multiline = True
        Me.txtDiscountType.Name = "txtDiscountType"
        Me.txtDiscountType.ReadOnly = True
        Me.txtDiscountType.Size = New System.Drawing.Size(124, 25)
        Me.txtDiscountType.TabIndex = 91
        Me.txtDiscountType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(456, 156)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(95, 16)
        Me.Label12.TabIndex = 92
        Me.Label12.Text = "Discount Type"
        '
        'txtAdvance
        '
        Me.txtAdvance.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtAdvance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdvance.Location = New System.Drawing.Point(587, 213)
        Me.txtAdvance.Multiline = True
        Me.txtAdvance.Name = "txtAdvance"
        Me.txtAdvance.ReadOnly = True
        Me.txtAdvance.Size = New System.Drawing.Size(85, 25)
        Me.txtAdvance.TabIndex = 93
        Me.txtAdvance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(456, 218)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(118, 16)
        Me.Label13.TabIndex = 94
        Me.Label13.Text = "Advance Payment"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(587, 244)
        Me.txtTotal.Multiline = True
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(85, 25)
        Me.txtTotal.TabIndex = 95
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(456, 249)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(92, 16)
        Me.Label14.TabIndex = 96
        Me.Label14.Text = "Total Balance"
        '
        'txtCash
        '
        Me.txtCash.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCash.ForeColor = System.Drawing.Color.Red
        Me.txtCash.Location = New System.Drawing.Point(123, 358)
        Me.txtCash.Multiline = True
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(143, 38)
        Me.txtCash.TabIndex = 97
        Me.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(35, 365)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(89, 29)
        Me.Label15.TabIndex = 98
        Me.Label15.Text = "CASH:"
        '
        'txtChange
        '
        Me.txtChange.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChange.ForeColor = System.Drawing.Color.Red
        Me.txtChange.Location = New System.Drawing.Point(393, 358)
        Me.txtChange.Multiline = True
        Me.txtChange.Name = "txtChange"
        Me.txtChange.ReadOnly = True
        Me.txtChange.Size = New System.Drawing.Size(143, 38)
        Me.txtChange.TabIndex = 99
        Me.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(267, 365)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(127, 29)
        Me.Label16.TabIndex = 100
        Me.Label16.Text = "CHANGE:"
        '
        'bttnCheckout
        '
        Me.bttnCheckout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnCheckout.Location = New System.Drawing.Point(571, 352)
        Me.bttnCheckout.Name = "bttnCheckout"
        Me.bttnCheckout.Size = New System.Drawing.Size(128, 50)
        Me.bttnCheckout.TabIndex = 101
        Me.bttnCheckout.Text = "&CHECKOUT"
        Me.bttnCheckout.UseVisualStyleBackColor = True
        '
        'lblGuestID
        '
        Me.lblGuestID.AutoSize = True
        Me.lblGuestID.Location = New System.Drawing.Point(14, 497)
        Me.lblGuestID.Name = "lblGuestID"
        Me.lblGuestID.Size = New System.Drawing.Size(46, 13)
        Me.lblGuestID.TabIndex = 102
        Me.lblGuestID.Text = "GuestID"
        '
        'lblTransID
        '
        Me.lblTransID.AutoSize = True
        Me.lblTransID.Location = New System.Drawing.Point(15, 517)
        Me.lblTransID.Name = "lblTransID"
        Me.lblTransID.Size = New System.Drawing.Size(41, 13)
        Me.lblTransID.TabIndex = 103
        Me.lblTransID.Text = "transID"
        '
        'txtSubTotal
        '
        Me.txtSubTotal.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotal.Location = New System.Drawing.Point(587, 182)
        Me.txtSubTotal.Multiline = True
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(85, 25)
        Me.txtSubTotal.TabIndex = 104
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(456, 187)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(66, 16)
        Me.Label17.TabIndex = 105
        Me.Label17.Text = "Sub Total"
        '
        'dtIn
        '
        Me.dtIn.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtIn.Location = New System.Drawing.Point(101, 497)
        Me.dtIn.Name = "dtIn"
        Me.dtIn.Size = New System.Drawing.Size(93, 20)
        Me.dtIn.TabIndex = 106
        '
        'dtOut
        '
        Me.dtOut.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtOut.Location = New System.Drawing.Point(200, 497)
        Me.dtOut.Name = "dtOut"
        Me.dtOut.Size = New System.Drawing.Size(102, 20)
        Me.dtOut.TabIndex = 107
        '
        'frmCheckout
        '
        Me.AcceptButton = Me.bttnCheckout
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(735, 444)
        Me.Controls.Add(Me.txtGuestName)
        Me.Controls.Add(Me.dtOut)
        Me.Controls.Add(Me.dtIn)
        Me.Controls.Add(Me.txtSubTotal)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.lblTransID)
        Me.Controls.Add(Me.lblGuestID)
        Me.Controls.Add(Me.bttnCheckout)
        Me.Controls.Add(Me.txtChange)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtCash)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtAdvance)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtDiscountType)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtAdult)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtChildren)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtDays)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCheckout)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtCheckin)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtRoomRate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtRoomType)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtRoomNumber)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.bttnSearchGuest)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTransID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCheckout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Checkout Guest"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bttnSearchGuest As System.Windows.Forms.Button
    Friend WithEvents txtGuestName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTransID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtRoomNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtRoomType As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtRoomRate As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents txtCheckin As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCheckout As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtDays As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtChildren As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtAdult As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtDiscountType As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtAdvance As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtCash As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtChange As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents bttnCheckout As System.Windows.Forms.Button
    Friend WithEvents lblGuestID As System.Windows.Forms.Label
    Friend WithEvents lblTransID As System.Windows.Forms.Label
    Friend WithEvents txtSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents dtIn As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtOut As System.Windows.Forms.DateTimePicker
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
End Class

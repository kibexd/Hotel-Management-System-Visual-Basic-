<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheckin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCheckin))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lblAdvancePayment = New System.Windows.Forms.Label()
        Me.bttnAddChildren = New System.Windows.Forms.Button()
        Me.bttnAddAdult = New System.Windows.Forms.Button()
        Me.bttnSubChildren = New System.Windows.Forms.Button()
        Me.bttnSubAdult = New System.Windows.Forms.Button()
        Me.txtAdults = New System.Windows.Forms.TextBox()
        Me.txtChildren = New System.Windows.Forms.TextBox()
        Me.bttnSearchRoom = New System.Windows.Forms.Button()
        Me.bttnSearchGuest = New System.Windows.Forms.Button()
        Me.bttnCancel = New System.Windows.Forms.Button()
        Me.bttnCheckIn = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtAdvance = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cboDiscount = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDaysNumber = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCheckInDate = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtCheckOutDate = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtRoomRate = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRoomType = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRoomNumber = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtGuestName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTransID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dtOut = New System.Windows.Forms.DateTimePicker()
        Me.dtIn = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
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
        Me.lblNoOfbeds = New System.Windows.Forms.Label()
        Me.lblGuestID = New System.Windows.Forms.Label()
        Me.lblDiscountID = New System.Windows.Forms.Label()
        Me.lblDiscountRate = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(10, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(746, 398)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TabPage1.Controls.Add(Me.lblAdvancePayment)
        Me.TabPage1.Controls.Add(Me.bttnAddChildren)
        Me.TabPage1.Controls.Add(Me.bttnAddAdult)
        Me.TabPage1.Controls.Add(Me.bttnSubChildren)
        Me.TabPage1.Controls.Add(Me.bttnSubAdult)
        Me.TabPage1.Controls.Add(Me.txtAdults)
        Me.TabPage1.Controls.Add(Me.txtChildren)
        Me.TabPage1.Controls.Add(Me.bttnSearchRoom)
        Me.TabPage1.Controls.Add(Me.bttnSearchGuest)
        Me.TabPage1.Controls.Add(Me.bttnCancel)
        Me.TabPage1.Controls.Add(Me.bttnCheckIn)
        Me.TabPage1.Controls.Add(Me.txtTotal)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.txtAdvance)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.cboDiscount)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.txtSubTotal)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.txtDaysNumber)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.txtCheckInDate)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.dtCheckOutDate)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.txtRoomRate)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.txtRoomType)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txtRoomNumber)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txtGuestName)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txtTransID)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.ShapeContainer1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(738, 372)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Check In Form"
        '
        'lblAdvancePayment
        '
        Me.lblAdvancePayment.AutoSize = True
        Me.lblAdvancePayment.ForeColor = System.Drawing.Color.Red
        Me.lblAdvancePayment.Location = New System.Drawing.Point(486, 246)
        Me.lblAdvancePayment.Name = "lblAdvancePayment"
        Me.lblAdvancePayment.Size = New System.Drawing.Size(0, 13)
        Me.lblAdvancePayment.TabIndex = 74
        Me.lblAdvancePayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bttnAddChildren
        '
        Me.bttnAddChildren.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnAddChildren.Location = New System.Drawing.Point(664, 118)
        Me.bttnAddChildren.Name = "bttnAddChildren"
        Me.bttnAddChildren.Size = New System.Drawing.Size(23, 25)
        Me.bttnAddChildren.TabIndex = 73
        Me.bttnAddChildren.Text = ">"
        Me.bttnAddChildren.UseVisualStyleBackColor = True
        '
        'bttnAddAdult
        '
        Me.bttnAddAdult.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnAddAdult.Location = New System.Drawing.Point(664, 88)
        Me.bttnAddAdult.Name = "bttnAddAdult"
        Me.bttnAddAdult.Size = New System.Drawing.Size(23, 25)
        Me.bttnAddAdult.TabIndex = 72
        Me.bttnAddAdult.Text = ">"
        Me.bttnAddAdult.UseVisualStyleBackColor = True
        '
        'bttnSubChildren
        '
        Me.bttnSubChildren.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnSubChildren.Location = New System.Drawing.Point(641, 117)
        Me.bttnSubChildren.Name = "bttnSubChildren"
        Me.bttnSubChildren.Size = New System.Drawing.Size(23, 25)
        Me.bttnSubChildren.TabIndex = 71
        Me.bttnSubChildren.Text = "<"
        Me.bttnSubChildren.UseVisualStyleBackColor = True
        '
        'bttnSubAdult
        '
        Me.bttnSubAdult.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnSubAdult.Location = New System.Drawing.Point(641, 87)
        Me.bttnSubAdult.Name = "bttnSubAdult"
        Me.bttnSubAdult.Size = New System.Drawing.Size(23, 25)
        Me.bttnSubAdult.TabIndex = 70
        Me.bttnSubAdult.Text = "<"
        Me.bttnSubAdult.UseVisualStyleBackColor = True
        '
        'txtAdults
        '
        Me.txtAdults.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtAdults.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdults.Location = New System.Drawing.Point(581, 88)
        Me.txtAdults.Multiline = True
        Me.txtAdults.Name = "txtAdults"
        Me.txtAdults.ReadOnly = True
        Me.txtAdults.Size = New System.Drawing.Size(51, 25)
        Me.txtAdults.TabIndex = 69
        Me.txtAdults.Text = "0"
        Me.txtAdults.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtChildren
        '
        Me.txtChildren.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtChildren.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChildren.Location = New System.Drawing.Point(581, 119)
        Me.txtChildren.Multiline = True
        Me.txtChildren.Name = "txtChildren"
        Me.txtChildren.ReadOnly = True
        Me.txtChildren.Size = New System.Drawing.Size(51, 25)
        Me.txtChildren.TabIndex = 68
        Me.txtChildren.Text = "0"
        Me.txtChildren.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'bttnSearchRoom
        '
        Me.bttnSearchRoom.Location = New System.Drawing.Point(280, 123)
        Me.bttnSearchRoom.Name = "bttnSearchRoom"
        Me.bttnSearchRoom.Size = New System.Drawing.Size(30, 26)
        Me.bttnSearchRoom.TabIndex = 67
        Me.bttnSearchRoom.Text = "..."
        Me.bttnSearchRoom.UseVisualStyleBackColor = True
        '
        'bttnSearchGuest
        '
        Me.bttnSearchGuest.Location = New System.Drawing.Point(375, 91)
        Me.bttnSearchGuest.Name = "bttnSearchGuest"
        Me.bttnSearchGuest.Size = New System.Drawing.Size(30, 26)
        Me.bttnSearchGuest.TabIndex = 66
        Me.bttnSearchGuest.Text = "..."
        Me.bttnSearchGuest.UseVisualStyleBackColor = True
        '
        'bttnCancel
        '
        Me.bttnCancel.Location = New System.Drawing.Point(589, 311)
        Me.bttnCancel.Name = "bttnCancel"
        Me.bttnCancel.Size = New System.Drawing.Size(113, 35)
        Me.bttnCancel.TabIndex = 65
        Me.bttnCancel.Text = "C&ancel"
        Me.bttnCancel.UseVisualStyleBackColor = True
        '
        'bttnCheckIn
        '
        Me.bttnCheckIn.Location = New System.Drawing.Point(469, 311)
        Me.bttnCheckIn.Name = "bttnCheckIn"
        Me.bttnCheckIn.Size = New System.Drawing.Size(113, 35)
        Me.bttnCheckIn.TabIndex = 64
        Me.bttnCheckIn.Text = "&Check In"
        Me.bttnCheckIn.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(582, 269)
        Me.txtTotal.Multiline = True
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(120, 25)
        Me.txtTotal.TabIndex = 53
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(449, 272)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(92, 16)
        Me.Label15.TabIndex = 63
        Me.Label15.Text = "Total Balance"
        '
        'txtAdvance
        '
        Me.txtAdvance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdvance.Location = New System.Drawing.Point(582, 214)
        Me.txtAdvance.Multiline = True
        Me.txtAdvance.Name = "txtAdvance"
        Me.txtAdvance.Size = New System.Drawing.Size(120, 25)
        Me.txtAdvance.TabIndex = 52
        Me.txtAdvance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(449, 217)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(118, 16)
        Me.Label14.TabIndex = 62
        Me.Label14.Text = "Advance Payment"
        '
        'cboDiscount
        '
        Me.cboDiscount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDiscount.FormattingEnabled = True
        Me.cboDiscount.Location = New System.Drawing.Point(582, 154)
        Me.cboDiscount.Name = "cboDiscount"
        Me.cboDiscount.Size = New System.Drawing.Size(119, 21)
        Me.cboDiscount.TabIndex = 51
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(449, 155)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(95, 16)
        Me.Label13.TabIndex = 61
        Me.Label13.Text = "Discount Type"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(449, 121)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 16)
        Me.Label12.TabIndex = 60
        Me.Label12.Text = "No. Of Children"
        '
        'txtSubTotal
        '
        Me.txtSubTotal.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotal.Location = New System.Drawing.Point(582, 182)
        Me.txtSubTotal.Multiline = True
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(120, 25)
        Me.txtSubTotal.TabIndex = 49
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(449, 185)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 16)
        Me.Label11.TabIndex = 59
        Me.Label11.Text = "Sub Total"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(449, 91)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 16)
        Me.Label10.TabIndex = 58
        Me.Label10.Text = "No. Of Adults"
        '
        'txtDaysNumber
        '
        Me.txtDaysNumber.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtDaysNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDaysNumber.Location = New System.Drawing.Point(159, 274)
        Me.txtDaysNumber.Multiline = True
        Me.txtDaysNumber.Name = "txtDaysNumber"
        Me.txtDaysNumber.ReadOnly = True
        Me.txtDaysNumber.Size = New System.Drawing.Size(115, 25)
        Me.txtDaysNumber.TabIndex = 44
        Me.txtDaysNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(38, 278)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 16)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "No. Of Days"
        '
        'txtCheckInDate
        '
        Me.txtCheckInDate.BackColor = System.Drawing.Color.White
        Me.txtCheckInDate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCheckInDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheckInDate.Location = New System.Drawing.Point(159, 215)
        Me.txtCheckInDate.Multiline = True
        Me.txtCheckInDate.Name = "txtCheckInDate"
        Me.txtCheckInDate.ReadOnly = True
        Me.txtCheckInDate.Size = New System.Drawing.Size(115, 25)
        Me.txtCheckInDate.TabIndex = 56
        Me.txtCheckInDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(38, 219)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 16)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "Check In Date"
        '
        'dtCheckOutDate
        '
        Me.dtCheckOutDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtCheckOutDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtCheckOutDate.Location = New System.Drawing.Point(159, 246)
        Me.dtCheckOutDate.Name = "dtCheckOutDate"
        Me.dtCheckOutDate.Size = New System.Drawing.Size(115, 22)
        Me.dtCheckOutDate.TabIndex = 43
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(38, 248)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 16)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Check Out Date"
        '
        'txtRoomRate
        '
        Me.txtRoomRate.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtRoomRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoomRate.Location = New System.Drawing.Point(159, 185)
        Me.txtRoomRate.Multiline = True
        Me.txtRoomRate.Name = "txtRoomRate"
        Me.txtRoomRate.ReadOnly = True
        Me.txtRoomRate.Size = New System.Drawing.Size(115, 25)
        Me.txtRoomRate.TabIndex = 42
        Me.txtRoomRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(38, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 16)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Room Rate"
        '
        'txtRoomType
        '
        Me.txtRoomType.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtRoomType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoomType.Location = New System.Drawing.Point(159, 154)
        Me.txtRoomType.Multiline = True
        Me.txtRoomType.Name = "txtRoomType"
        Me.txtRoomType.ReadOnly = True
        Me.txtRoomType.Size = New System.Drawing.Size(210, 25)
        Me.txtRoomType.TabIndex = 40
        Me.txtRoomType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(38, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Room Type"
        '
        'txtRoomNumber
        '
        Me.txtRoomNumber.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtRoomNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoomNumber.Location = New System.Drawing.Point(159, 123)
        Me.txtRoomNumber.Multiline = True
        Me.txtRoomNumber.Name = "txtRoomNumber"
        Me.txtRoomNumber.ReadOnly = True
        Me.txtRoomNumber.Size = New System.Drawing.Size(115, 25)
        Me.txtRoomNumber.TabIndex = 38
        Me.txtRoomNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Room Number"
        '
        'txtGuestName
        '
        Me.txtGuestName.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtGuestName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuestName.Location = New System.Drawing.Point(159, 92)
        Me.txtGuestName.Multiline = True
        Me.txtGuestName.Name = "txtGuestName"
        Me.txtGuestName.ReadOnly = True
        Me.txtGuestName.Size = New System.Drawing.Size(210, 25)
        Me.txtGuestName.TabIndex = 35
        Me.txtGuestName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 16)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Guest Name"
        '
        'txtTransID
        '
        Me.txtTransID.BackColor = System.Drawing.Color.White
        Me.txtTransID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTransID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransID.ForeColor = System.Drawing.Color.DarkRed
        Me.txtTransID.Location = New System.Drawing.Point(159, 61)
        Me.txtTransID.Multiline = True
        Me.txtTransID.Name = "txtTransID"
        Me.txtTransID.ReadOnly = True
        Me.txtTransID.Size = New System.Drawing.Size(115, 25)
        Me.txtTransID.TabIndex = 39
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 16)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Transaction ID"
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 24)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Check In Form"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 3)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(732, 366)
        Me.ShapeContainer1.TabIndex = 75
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.MenuText
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 11
        Me.LineShape1.X2 = 715
        Me.LineShape1.Y1 = 46
        Me.LineShape1.Y2 = 46
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dtOut)
        Me.TabPage2.Controls.Add(Me.dtIn)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.lvlcheckin)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(738, 372)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Check In List"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dtOut
        '
        Me.dtOut.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtOut.Location = New System.Drawing.Point(115, 334)
        Me.dtOut.Name = "dtOut"
        Me.dtOut.Size = New System.Drawing.Size(104, 20)
        Me.dtOut.TabIndex = 39
        Me.dtOut.Visible = False
        '
        'dtIn
        '
        Me.dtIn.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtIn.Location = New System.Drawing.Point(15, 334)
        Me.dtIn.Name = "dtIn"
        Me.dtIn.Size = New System.Drawing.Size(94, 20)
        Me.dtIn.TabIndex = 38
        Me.dtIn.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoEllipsis = True
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(10, 24)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(129, 24)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "Check In List"
        '
        'lvlcheckin
        '
        Me.lvlcheckin.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11})
        Me.lvlcheckin.FullRowSelect = True
        Me.lvlcheckin.GridLines = True
        Me.lvlcheckin.Location = New System.Drawing.Point(12, 51)
        Me.lvlcheckin.Name = "lvlcheckin"
        Me.lvlcheckin.Size = New System.Drawing.Size(712, 270)
        Me.lvlcheckin.TabIndex = 0
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
        'lblNoOfbeds
        '
        Me.lblNoOfbeds.AutoSize = True
        Me.lblNoOfbeds.Location = New System.Drawing.Point(7, 468)
        Me.lblNoOfbeds.Name = "lblNoOfbeds"
        Me.lblNoOfbeds.Size = New System.Drawing.Size(87, 13)
        Me.lblNoOfbeds.TabIndex = 1
        Me.lblNoOfbeds.Text = "NoOfbeds"
        Me.lblNoOfbeds.Visible = False
        '
        'lblGuestID
        '
        Me.lblGuestID.AutoSize = True
        Me.lblGuestID.Location = New System.Drawing.Point(7, 446)
        Me.lblGuestID.Name = "lblGuestID"
        Me.lblGuestID.Size = New System.Drawing.Size(46, 13)
        Me.lblGuestID.TabIndex = 2
        Me.lblGuestID.Text = "GuestID"
        Me.lblGuestID.Visible = False
        '
        'lblDiscountID
        '
        Me.lblDiscountID.AutoSize = True
        Me.lblDiscountID.Location = New System.Drawing.Point(7, 492)
        Me.lblDiscountID.Name = "lblDiscountID"
        Me.lblDiscountID.Size = New System.Drawing.Size(60, 13)
        Me.lblDiscountID.TabIndex = 3
        Me.lblDiscountID.Text = "DiscountID"
        Me.lblDiscountID.Visible = False
        '
        'lblDiscountRate
        '
        Me.lblDiscountRate.AutoSize = True
        Me.lblDiscountRate.Location = New System.Drawing.Point(146, 446)
        Me.lblDiscountRate.Name = "lblDiscountRate"
        Me.lblDiscountRate.Size = New System.Drawing.Size(72, 13)
        Me.lblDiscountRate.TabIndex = 4
        Me.lblDiscountRate.Text = "DiscountRate"
        Me.lblDiscountRate.Visible = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(153, 469)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(31, 13)
        Me.lblTotal.TabIndex = 5
        Me.lblTotal.Text = "Total"
        Me.lblTotal.Visible = False
        '
        'frmCheckin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 525)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblDiscountRate)
        Me.Controls.Add(Me.lblDiscountID)
        Me.Controls.Add(Me.lblGuestID)
        Me.Controls.Add(Me.lblNoOfbeds)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCheckin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents bttnSearchRoom As System.Windows.Forms.Button
    Friend WithEvents bttnSearchGuest As System.Windows.Forms.Button
    Friend WithEvents bttnCancel As System.Windows.Forms.Button
    Friend WithEvents bttnCheckIn As System.Windows.Forms.Button
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtAdvance As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cboDiscount As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtDaysNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCheckInDate As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtCheckOutDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtRoomRate As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtRoomType As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtRoomNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtGuestName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTransID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lvlcheckin As System.Windows.Forms.ListView
    Friend WithEvents lblNoOfbeds As System.Windows.Forms.Label
    Friend WithEvents lblGuestID As System.Windows.Forms.Label
    Friend WithEvents txtAdults As System.Windows.Forms.TextBox
    Friend WithEvents txtChildren As System.Windows.Forms.TextBox
    Friend WithEvents bttnSubChildren As System.Windows.Forms.Button
    Friend WithEvents bttnSubAdult As System.Windows.Forms.Button
    Friend WithEvents bttnAddChildren As System.Windows.Forms.Button
    Friend WithEvents bttnAddAdult As System.Windows.Forms.Button
    Friend WithEvents lblDiscountID As System.Windows.Forms.Label
    Friend WithEvents lblDiscountRate As System.Windows.Forms.Label
    Friend WithEvents lblAdvancePayment As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
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
    Friend WithEvents dtOut As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtIn As System.Windows.Forms.DateTimePicker
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
End Class

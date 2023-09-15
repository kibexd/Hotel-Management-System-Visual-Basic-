Imports System.Data.OleDb
Public Class frmCheckin
    Dim guestID, roomID, trans_ID As Integer

    Private Sub frmCheckin_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim a As String = MsgBox("Cancel Transaction?", vbQuestion + vbYesNo, "Cancel")
        If a = vbNo Then
            e.Cancel = True
        Else
            clear_text()
        End If
    End Sub
    Private Sub frmCheckin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clear_text()
        Dim time As DateTime = DateTime.Now
        Dim format As String = "MM/d/yyyy"
        txtCheckInDate.Text = time.ToString(format)
        dtCheckOutDate.Text = Now.AddDays(1D)
        transID()
        pop_discount()
        display_checkin()
    End Sub

    Public Sub transID()
        con.Open()
        Dim dt As New DataTable("tblTransaction")
        rs = New OleDbDataAdapter("SELECT * FROM tblTransaction ORDER BY TransID DESC", con)
        rs.Fill(dt)

        If dt.Rows.Count = 0 Then
            txtTransID.Text = "TransID - 0001"
        Else
            Dim value As Integer = Val(dt.Rows(0).Item("TransID"))
            value = value + 1
            txtTransID.Text = "TransID - " & value.ToString("0000")
            trans_ID = value
        End If
        rs.Dispose()
        con.Close()
    End Sub

    Private Sub bttnCheckIn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnCheckIn.Click
        Dim children As Integer = Val(txtChildren.Text)
        Dim adult As Integer = Val(txtAdults.Text)
        Dim advance As Integer = Val(txtAdvance.Text)
        Dim discount As Integer = Val(lblDiscountID.Text)
        Dim reserve As String = "0"
        Dim remarks As String = "Checkin"
        Dim stat As String = "Active"

        If lblGuestID.Text = "GuestID" Or lblGuestID.Text = Nothing Or txtRoomNumber.Text = Nothing Or Val(children + adult) = Nothing Or advance = Nothing Or discount = Nothing Then
            MsgBox("Please Fill All Fields", vbInformation, "Note")
        Else
            If Val(Val(txtSubTotal.Text) * 0.5) > Val(txtAdvance.Text) Then
                MsgBox("Ops")
                Exit Sub
            End If
            Dim a As String = MsgBox("Confirm Checkin Transaction?", vbQuestion + vbYesNo, "Check In")
            If a = vbYes Then
                con.Open()
                Dim checkin As New OleDbCommand("INSERT INTO tblTransaction(GuestID,RoomNum,CheckInDate,CheckOutDate,NoOfChild,NoOfAdult,AdvancePayment,DiscountID,Remarks,Status) values ('" &
                                                lblGuestID.Text & "','" &
                                                txtRoomNumber.Text & "','" &
                                                txtCheckInDate.Text & "','" &
                                                dtCheckOutDate.Text & "','" &
                                                txtChildren.Text & "','" &
                                                txtAdults.Text & "','" &
                                                txtAdvance.Text & "','" &
                                                lblDiscountID.Text & "','" &
                                                remarks & "','" &
                                                stat & "')", con)
                checkin.ExecuteNonQuery()

                Dim update_guest As New OleDbCommand("UPDATE tblGuest SET Remarks = 'Checkin' WHERE ID = " & lblGuestID.Text & "", con)
                update_guest.ExecuteNonQuery()

                Dim update_room As New OleDbCommand("UPDATE tblRoom SET Status = 'Occupied' WHERE RoomNumber = " & txtRoomNumber.Text & "", con)
                update_room.ExecuteNonQuery()

                If Val(txtSubTotal.Text) < Val(txtAdvance.Text) Or Val(txtSubTotal.Text) = Val(txtAdvance.Text) Then
                    MsgBox("Guest Successfully Checkin! " & "Change: Kshs " & Val(Val(txtAdvance.Text) - Val(txtSubTotal.Text)).ToString("00.00"), vbInformation, "Check In")
                    Dim change As String = MsgBox("Return change to customer?", vbQuestion + vbYesNo, "Change")
                    If change = vbYes Then
                        Dim update_trans As New OleDbCommand("UPDATE tblTransaction SET AdvancePayment = " & Val(txtSubTotal.Text) & " WHERE TransID = " & trans_ID & "", con)
                        update_trans.ExecuteNonQuery()
                    End If
                Else
                    MsgBox("Guest Successfully Checkin!", vbInformation, "Check In")
                End If

                clear_text()
                con.Close()
                transID()
                display_checkin()
            End If
        End If
    End Sub

    Private Sub bttnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnCancel.Click
        clear_text()
    End Sub

    Private Sub dtCheckOutDate_ValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtCheckOutDate.ValueChanged
        Dim T As TimeSpan = dtCheckOutDate.Value - Now
        If T.Days < 1 Then
            dtCheckOutDate.Text = Now.AddDays(1D)
            txtDaysNumber.Text = "1"
        Else
            txtDaysNumber.Text = T.Days + 1
        End If
        lblTotal.Text = Val(txtRoomRate.Text) * Val(txtDaysNumber.Text)
        txtSubTotal.Text = Val(txtRoomRate.Text) * Val(txtDaysNumber.Text)
    End Sub

    Private Sub bttnSearchGuest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnSearchGuest.Click
        frmSelectGuest.ShowDialog()
    End Sub

    Private Sub bttnSearchRoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnSearchRoom.Click
        frmSelectRoom.ShowDialog()
    End Sub

    Private Sub txtRoomRate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRoomRate.TextChanged
        lblTotal.Text = Val(txtRoomRate.Text) * Val(txtDaysNumber.Text)
        txtSubTotal.Text = (Val(txtRoomRate.Text) * Val(txtDaysNumber.Text)).ToString("00.00")
    End Sub

    Private Sub bttnAddAdult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnAddAdult.Click
        Dim tao As Integer
        tao = Val(txtAdults.Text) + Val(txtChildren.Text)
        If tao = Val(lblNoOfbeds.Text) Then

        Else
            txtAdults.Text = Val(txtAdults.Text) + 1
        End If
    End Sub

    Private Sub bttnAddChildren_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnAddChildren.Click
        Dim tao As Integer
        tao = Val(txtAdults.Text) + Val(txtChildren.Text)
        If tao = Val(lblNoOfbeds.Text) Then

        Else
            txtChildren.Text = Val(txtChildren.Text) + 1
        End If
    End Sub

    Private Sub bttnSubAdult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnSubAdult.Click
        If Val(txtAdults.Text) = 0 Then
            txtAdults.Text = Val(txtAdults.Text)
        Else
            txtAdults.Text = Val(txtAdults.Text) - 1
        End If
    End Sub

    Private Sub bttnSubChildren_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnSubChildren.Click
        If Val(txtChildren.Text) = 0 Then
            txtChildren.Text = Val(txtChildren.Text)
        Else
            txtChildren.Text = Val(txtChildren.Text) - 1
        End If
    End Sub

    Private Sub pop_discount()
        con.Open()
        Dim dt As New DataTable
        rs = New OleDbDataAdapter("SELECT * FROM tblDiscount", con)
        rs.Fill(dt)

        cboDiscount.Items.Clear()
        Dim i As Integer
        For i = 0 To dt.Rows.Count - 1
            cboDiscount.Items.Add(dt.Rows(i).Item("DiscountType"))
        Next
        rs.Dispose()
        con.Close()
    End Sub

    Private Sub cboDiscount_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDiscount.TextChanged
        con.Open()
        Dim dt As New DataTable
        rs = New OleDbDataAdapter("SELECT * FROM tblDiscount WHERE DiscountType = '" & cboDiscount.Text & "'", con)
        rs.Fill(dt)

        lblDiscountID.Text = dt.Rows(0).Item("ID")
        lblDiscountRate.Text = dt.Rows(0).Item("DiscountRate")

        'lblTotal.Text = Val(txtSubTotal.Text) - (Val(txtSubTotal.Text) * Val(lblDiscountRate.Text))
        txtSubTotal.Text = (Val(lblTotal.Text) - (Val(lblTotal.Text) * Val(lblDiscountRate.Text))).ToString("00.00")
        lblAdvancePayment.Text = "Advance payment must be atleast Kshs " & (Val(txtSubTotal.Text) * 0.5).ToString("00.00")
        rs.Dispose()
        con.Close()
    End Sub

    Private Sub txtAdvance_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAdvance.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
    AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            'cancel keys
            e.Handled = True
        End If
    End Sub

    Private Sub txtAdvance_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAdvance.TextChanged
        If Val(txtSubTotal.Text) < Val(txtAdvance.Text) Or Val(txtSubTotal.Text) = Val(txtAdvance.Text) Then
            txtTotal.Text = "0.00"
        Else
            txtTotal.Text = (Val(txtSubTotal.Text) - Val(txtAdvance.Text)).ToString("00.00")
        End If
    End Sub

    Private Sub clear_text()
        txtGuestName.Clear()
        txtRoomNumber.Clear()
        txtRoomType.Clear()
        txtRoomRate.Clear()
        txtChildren.Text = "0"
        txtAdults.Text = "0"
        cboDiscount.Refresh()
        txtAdvance.Clear()
        txtSubTotal.Clear()
        txtTotal.Clear()
        lblDiscountID.Text = ""
        lblDiscountRate.Text = ""
        lblGuestID.Text = ""
        lblAdvancePayment.Text = ""
        lblNoOfbeds.Text = "0"

        Dim time As DateTime = DateTime.Now
        Dim format As String = "MM/d/yyyy"
        txtCheckInDate.Text = time.ToString(format)
        dtCheckOutDate.Text = Now.AddDays(1D)
    End Sub

    Private Sub display_checkin()
        con.Open()
        Dim Dt As New DataTable("tblGuest")
        Dim rs As OleDbDataAdapter

        rs = New OleDbDataAdapter("Select * from tblTransaction, tblGuest, tblDiscount, tblRoom WHERE tblTransaction.GuestID = tblGuest.ID AND tblTransaction.DiscountID = tblDiscount.ID AND tblTransaction.RoomNum = tblRoom.RoomNumber AND tblTransaction.Remarks = 'Checkin' AND tblTransaction.Status = 'Active'", con)

        rs.Fill(Dt)
        Dim indx As Integer
        lvlcheckin.Items.Clear()
        For indx = 0 To Dt.Rows.Count - 1
            Dim lv As New ListViewItem
            Dim getdate As TimeSpan
            Dim days, subtotal, total, rate As Integer
            Dim discount As Double

            Dim value As Integer = Val(Dt.Rows(indx).Item("TransID"))

            lv.Text = "TransID - " & value.ToString("0000")
            lv.SubItems.Add(Dt.Rows(indx).Item("GuestFName") & " " & Dt.Rows(indx).Item("GuestLName"))
            lv.SubItems.Add(Dt.Rows(indx).Item("RoomNum"))

            rate = Dt.Rows(indx).Item("RoomRate")

            lv.SubItems.Add(Dt.Rows(indx).Item("CheckInDate"))
            lv.SubItems.Add(Dt.Rows(indx).Item("CheckOutDate"))

            dtIn.Value = Dt.Rows(indx).Item("CheckOutDate")
            dtOut.Value = Dt.Rows(indx).Item("CheckInDate")

            getdate = dtIn.Value - dtOut.Value
            days = getdate.Days

            lv.SubItems.Add(days)
            lv.SubItems.Add(Dt.Rows(indx).Item("NoOfChild"))
            lv.SubItems.Add(Dt.Rows(indx).Item("NoOfAdult"))
            lv.SubItems.Add(Dt.Rows(indx).Item("AdvancePayment").ToString("00.00"))
            lv.SubItems.Add(Dt.Rows(indx).Item("DiscountType"))

            discount = Val(Dt.Rows(indx).Item("DiscountRate"))

            subtotal = (days * rate) - ((days * rate) * discount)
            total = (Val(subtotal) - Val(Dt.Rows(indx).Item("AdvancePayment"))).ToString("00.00")

            If Val(subtotal) > Val(Dt.Rows(indx).Item("AdvancePayment")) Then
                lv.SubItems.Add(Val(total))
            Else
                lv.SubItems.Add("0")
            End If

            lvlcheckin.Items.Add(lv)
        Next
        rs.Dispose()
        con.Close()
    End Sub

    Private Sub cboDiscount_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDiscount.SelectedIndexChanged

    End Sub
End Class
Imports System.Data.OleDb
Public Class frmReserve
    Dim trans_id As String
    Dim id, guest_id, room_num As Integer

    Private Sub dtCheckOutDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtCheckOutDate.ValueChanged
        Dim T As TimeSpan = dtCheckOutDate.Value - dtCheckInDate.Value
        If T.Days < 1 Then
            dtCheckOutDate.Text = dtCheckInDate.Value.Date.AddDays(1D)
            txtDaysNumber.Text = "1"
        Else
            txtDaysNumber.Text = T.Days
        End If
        lblTotal.Text = Val(txtRoomRate.Text) * Val(txtDaysNumber.Text)
        txtSubTotal.Text = Val(txtRoomRate.Text) * Val(txtDaysNumber.Text)
        lblDateNow.Text = Now.Date
    End Sub

    Private Sub bttnSearchGuest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnSearchGuest.Click
        frmSelectGuest.ShowDialog()
    End Sub

    Private Sub bttnSearchRoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnSearchRoom.Click
        frmSelectRoom.ShowDialog()
    End Sub

    Private Sub bttnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmReserve_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim a As String = MsgBox("Cancel Transaction?", vbQuestion + vbYesNo, "Cancel")
        If a = vbNo Then
            e.Cancel = True
        Else
            clear_text()
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
        dtCheckInDate.Text = time.ToString(format)
        dtCheckOutDate.Text = Now.AddDays(1D)
    End Sub

    Private Sub frmReserve_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        clear_text()
        Dim time As DateTime = DateTime.Now
        Dim format As String = "MM/d/yyyy"
        dtCheckInDate.Text = time.ToString(format)
        dtCheckOutDate.Text = dtCheckInDate.Value.Date.AddDays(1D)
        lblDateNow.Text = Now.Date
        transID()
        pop_discount()
        display_reserve()
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
        End If
        rs.Dispose()
        con.Close()

    End Sub

    Private Sub pop_discount()

        Dim dt As New DataTable
        rs = New OleDbDataAdapter("SELECT * FROM tblDiscount", con)
        rs.Fill(dt)

        cboDiscount.Items.Clear()
        Dim i As Integer
        For i = 0 To dt.Rows.Count - 1
            cboDiscount.Items.Add(dt.Rows(i).Item("DiscountType"))
        Next
        rs.Dispose()

    End Sub

    Private Sub display_reserve()

        Dim Dt As New DataTable("tblGuest")
        Dim rs As OleDbDataAdapter

        rs = New OleDbDataAdapter("Select * from tblTransaction, tblGuest, tblDiscount, tblRoom WHERE tblTransaction.GuestID = tblGuest.ID AND tblTransaction.DiscountID = tblDiscount.ID AND tblTransaction.RoomNum = tblRoom.RoomNumber AND tblTransaction.Remarks = 'Reserve'", con)

        rs.Fill(Dt)
        Dim indx As Integer
        lvlreserve.Items.Clear()
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
            lv.SubItems.Add(Dt.Rows(indx).Item("AdvancePayment"))
            lv.SubItems.Add(Dt.Rows(indx).Item("DiscountType"))

            discount = Val(Dt.Rows(indx).Item("DiscountRate"))

            subtotal = (days * rate) - ((days * rate) * discount)

            total = Val(subtotal) - Val(Dt.Rows(indx).Item("AdvancePayment"))

            lv.SubItems.Add(Val(total))
            lvlreserve.Items.Add(lv)
        Next
        rs.Dispose()

    End Sub

    Private Sub bttnReserve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnReserve.Click
        Dim children As Integer = Val(txtChildren.Text)
        Dim adult As Integer = Val(txtAdults.Text)
        Dim advance As Integer = Val(txtAdvance.Text)
        Dim discount As Integer = Val(lblDiscountID.Text)
        Dim reserve As String = "0"
        Dim remarks As String = "Reserve"
        Dim stat As String = "Active"

        If lblGuestID.Text = "GuestID" Or lblGuestID.Text = Nothing Or txtRoomNumber.Text = Nothing Or Val(children + adult) = Nothing Or advance = Nothing Or discount = Nothing Then
            MsgBox("Please Fill All Fields", vbInformation, "Note")
        Else
            Dim a As String = MsgBox("Confirm Reservation Transaction?", vbQuestion + vbYesNo, "Reservation")
            If a = vbYes Then
                con.Open()
                Dim checkin As New OleDbCommand("INSERT INTO tblTransaction(GuestID,RoomNum,CheckInDate,CheckOutDate,ReservationDate,NoOfChild,NoOfAdult,AdvancePayment,DiscountID,Remarks,Status) values ('" &
                                                lblGuestID.Text & "','" &
                                                txtRoomNumber.Text & "','" &
                                                dtCheckInDate.Text & "','" &
                                                dtCheckOutDate.Text & "','" &
                                                lblDateNow.Text & "','" &
                                                txtChildren.Text & "','" &
                                                txtAdults.Text & "','" &
                                                txtAdvance.Text & "','" &
                                                lblDiscountID.Text & "','" &
                                                remarks & "','" &
                                                stat & "')", con)
                checkin.ExecuteNonQuery()

                Dim update_guest As New OleDbCommand("UPDATE tblGuest SET Remarks = 'Reserve' WHERE ID = " & lblGuestID.Text & "", con)
                update_guest.ExecuteNonQuery()

                Dim update_room As New OleDbCommand("UPDATE tblRoom SET Status = 'Reserve' WHERE RoomNumber = " & txtRoomNumber.Text & "", con)
                update_room.ExecuteNonQuery()

                MsgBox("Guest Successfully Reserved!", vbInformation, "Reservation")
                clear_text()
                con.Close()
                transID()
                display_reserve()
            End If
        End If
    End Sub

    Private Sub dtCheckInDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtCheckInDate.ValueChanged
        Dim t As Date = dtCheckInDate.Value
        If t.Date < Now.Date Then
            dtCheckInDate.Value = Now.Date
        Else
            dtCheckOutDate.Value = dtCheckInDate.Value.Date.AddDays(1D)
        End If
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

    Private Sub cboDiscount_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDiscount.TextChanged
        con.Open()
        Dim dt As New DataTable
        rs = New OleDbDataAdapter("SELECT * FROM tblDiscount WHERE DiscountType = '" & cboDiscount.Text & "'", con)
        rs.Fill(dt)

        lblDiscountID.Text = dt.Rows(0).Item("ID")
        lblDiscountRate.Text = dt.Rows(0).Item("DiscountRate")

        'lblTotal.Text = Val(txtSubTotal.Text) - (Val(txtSubTotal.Text) * Val(lblDiscountRate.Text))
        txtSubTotal.Text = Val(lblTotal.Text) - (Val(lblTotal.Text) * Val(lblDiscountRate.Text))
        lblAdvancePayment.Text = "Advance payment must be atleast Kshs " & (Val(txtSubTotal.Text) * 0.5)
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
        txtTotal.Text = Val(lblTotal.Text) - Val(txtAdvance.Text)
    End Sub

    Private Sub txtRoomRate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRoomRate.TextChanged
        lblTotal.Text = Val(txtRoomRate.Text) * Val(txtDaysNumber.Text)
        txtSubTotal.Text = Val(txtRoomRate.Text) * Val(txtDaysNumber.Text)
    End Sub

    Private Sub lvlreserve_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvlreserve.Click
        trans_id = lvlreserve.SelectedItems(0).Text
        con.Open()
        Dim dt As New DataTable("tblTransaction")
        rs = New OleDbDataAdapter("SELECT * FROM tblTransaction", con)
        rs.Fill(dt)
        Dim indx As Integer
        For indx = 0 To dt.Rows.Count - 1
            If trans_id = "TransID - " & Val(dt.Rows(indx).Item("TransID")).ToString("0000") Then
                guest_id = dt.Rows(0).Item("GuestID")
                room_num = dt.Rows(0).Item("RoomNum")
                id = dt.Rows(indx).Item("TransID")
                Exit For
            End If
        Next
        rs.Dispose()
        con.Close()
    End Sub

    Private Sub bttnCheckin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnCheckin.Click
        Dim check_in As String = MsgBox("Checkin Guest?", vbQuestion + vbYesNo, "Checkin")
        If check_in = vbYes Then
            con.Open()
            Dim update_trans As New OleDbCommand("UPDATE tblTransaction SET Remarks = 'Checkin' WHERE TransID = " & id & "", con)
            update_trans.ExecuteNonQuery()

            Dim update_guest As New OleDbCommand("UPDATE tblGuest SET Remarks = 'Checkin' WHERE ID = " & guest_id & "", con)
            update_guest.ExecuteNonQuery()

            Dim update_room As New OleDbCommand("UPDATE tblRoom SET Status = 'Occupied' WHERE RoomNumber = " & room_num & "", con)
            update_room.ExecuteNonQuery()
            con.Close()
            display_reserve()
            MsgBox("Guest Checkedin!", vbInformation, "Checkin")
        End If
    End Sub

    Private Sub bttnCancelReserve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnCancelReserve.Click
        Dim check_in As String = MsgBox("Cancel Reservation?", vbQuestion + vbYesNo, "Cancel")
        If check_in = vbYes Then
            con.Open()

            Dim update_trans As New OleDbCommand("UPDATE tblTransaction SET Remarks = 'Cancelled' WHERE TransID = " & id & "", con)
            update_trans.ExecuteNonQuery()

            Dim update_guest As New OleDbCommand("UPDATE tblGuest SET Remarks = 'Available' WHERE ID = " & guest_id & "", con)
            update_guest.ExecuteNonQuery()

            Dim update_room As New OleDbCommand("UPDATE tblRoom SET Status = 'Available' WHERE RoomNumber = " & room_num & "", con)
            update_room.ExecuteNonQuery()

            con.Close()
            display_reserve()
            MsgBox("Reservation Cancelled!", vbInformation, "Cancel")
        End If
    End Sub

    Private Sub lvlreserve_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvlreserve.SelectedIndexChanged

    End Sub
End Class
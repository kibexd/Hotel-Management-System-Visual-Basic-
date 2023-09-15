Imports System.Data.OleDb
Public Class frmCheckout

    Private Sub bttnSearchGuest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnSearchGuest.Click
        frmCheckinList.ShowDialog()
    End Sub

    Private Sub txtRoomNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRoomNumber.TextChanged
        If txtRoomNumber.Text = Nothing Then
        Else
            con.Open()
            Dim dt As New DataTable("tblRoom")
            rs = New OleDbDataAdapter("SELECT * FROM tblRoom WHERE RoomNumber = " & txtRoomNumber.Text & "", con)
            rs.Fill(dt)
            txtRoomType.Text = dt.Rows(0).Item("RoomType")
            txtRoomRate.Text = Val(dt.Rows(0).Item("RoomRate")).ToString("N")
            rs.Dispose()
            con.Close()
        End If

    End Sub

    Private Sub txtCash_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCash.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
    AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            'cancel keys
            e.Handled = True
        End If
    End Sub

    Private Sub txtCash_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCash.TextChanged
        If Val(txtCash.Text) < Val(txtTotal.Text) Then
            txtChange.Text = "0.00"
        Else
            txtChange.Text = (Val(txtCash.Text) - Val(txtTotal.Text)).ToString("N")
        End If
    End Sub

    Private Sub bttnCheckout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnCheckout.Click
        If txtTransID.Text = Nothing Then
            MsgBox("Please select transaction to checkout!", vbExclamation, "Note")
        Else
            If Val(txtCash.Text) < Val(txtTotal.Text) Then
                MsgBox("Insufficient cash!", vbExclamation, "Note")
            Else
                Dim out As String = MsgBox("Confirm Checkout", vbQuestion + vbYesNo, "Checkout")
                If out = vbYes Then
                    con.Open()
                    Dim update_trans As New OleDbCommand("UPDATE tblTransaction SET Remarks = 'Checkout' WHERE TransID = " & lblTransID.Text & "", con)
                    update_trans.ExecuteNonQuery()

                    Dim update_guest As New OleDbCommand("UPDATE tblGuest SET Remarks = 'Available' WHERE ID = " & lblGuestID.Text & "", con)
                    update_guest.ExecuteNonQuery()

                    Dim update_room As New OleDbCommand("UPDATE tblRoom SET Status = 'Available' WHERE RoomNumber = " & txtRoomNumber.Text & "", con)
                    update_room.ExecuteNonQuery()

                    MsgBox("Guest Checked out!", vbInformation, "Checkout")
                    con.Close()
                    clear_text()
                End If
            End If
        End If
    End Sub

    Public Sub clear_text()
        txtTransID.Clear()
        txtGuestName.Clear()
        txtRoomNumber.Clear()
        txtRoomRate.Clear()
        txtRoomType.Clear()
        txtCheckin.Clear()
        txtCheckout.Clear()
        txtChildren.Clear()
        txtAdult.Clear()
        txtAdvance.Clear()
        txtDiscountType.Clear()
        txtTotal.Clear()
        txtSubTotal.Clear()
        txtDays.Clear()
        txtCash.Clear()
        txtChange.Clear()
    End Sub

    Private Sub lblTransID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblTransID.TextChanged

    End Sub

    Private Sub frmCheckout_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        clear_text()
    End Sub

    Private Sub frmCheckout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtRoomNumber.Clear()
        dtOut.Value = Date.Now
    End Sub

    Private Sub txtAdvance_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAdvance.TextChanged

    End Sub

    Private Sub txtTotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotal.TextChanged

    End Sub


    Private Sub txtDiscountType_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDiscountType.TextChanged

    End Sub

    Private Sub Label16_Click(sender As System.Object, e As System.EventArgs) Handles Label16.Click

    End Sub
End Class
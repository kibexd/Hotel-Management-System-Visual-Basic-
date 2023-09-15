Imports System.Data.OleDb
Public Class frmCheckinList

    Private Sub frmCheckinList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open()
        Dim Dt As New DataTable("tblTransaction")
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
            lv.SubItems.Add(Dt.Rows(indx).Item("AdvancePayment"))
            lv.SubItems.Add(Dt.Rows(indx).Item("DiscountType"))

            discount = Val(Dt.Rows(indx).Item("DiscountRate"))

            subtotal = (days * rate) - ((days * rate) * discount)
            total = Val(subtotal) - Val(Dt.Rows(indx).Item("AdvancePayment"))

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

    Private Sub lvlcheckin_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvlcheckin.DoubleClick

        dtIn.Value = lvlcheckin.SelectedItems(0).SubItems(3).Text
        dtOut.Value = Now.Date

        con.Open()
        Dim dt As New DataTable("tblTransaction")
        rs = New OleDbDataAdapter("Select * from tblTransaction, tblRoom, tblDiscount WHERE tblTransaction.RoomNum = tblRoom.RoomNumber AND tblTransaction.DiscountID = tblDiscount.ID", con)
        rs.Fill(dt)
        Dim indx As Integer
        For indx = 0 To dt.Rows.Count - 1
            Dim value As Double = Val(dt.Rows(indx).Item("TransID"))

            If lvlcheckin.SelectedItems(0).Text = "TransID - " & value.ToString("0000") Then
                frmCheckout.txtTransID.Text = "TransID - " & value.ToString("0000")
                frmCheckout.lblTransID.Text = dt.Rows(indx).Item("TransID")
                frmCheckout.lblGuestID.Text = dt.Rows(indx).Item("GuestID")

                Dim time As DateTime = DateTime.Now
                Dim format As String = "MM/d/yyyy"
                Dim getdate As TimeSpan

                If dtIn.Value = dtOut.Value Then
                    frmCheckout.txtCheckout.Text = Now.Date.AddDays(1D)
                    frmCheckout.txtDays.Text = "1"
                    Dim subtotal As Double = Val(frmCheckout.txtDays.Text) * Val(dt.Rows(indx).Item("RoomRate"))
                    subtotal = Val(subtotal) - Val((dt.Rows(indx).Item("DiscountRate")) * Val(subtotal))

                    If Val(subtotal) > Val(dt.Rows(indx).Item("AdvancePayment")) Then
                        Dim total As Double = Val(subtotal) - (dt.Rows(indx).Item("AdvancePayment"))

                        frmCheckout.txtSubTotal.Text = Val(subtotal).ToString("N")
                        frmCheckout.txtTotal.Text = Val(total).ToString("N")
                        frmCheckout.txtCash.Text = Val(total).ToString("N")
                        frmCheckout.txtChange.Text = "0.00"
                    Else
                        Dim total As Double = (dt.Rows(indx).Item("AdvancePayment")) - Val(subtotal)
                        Dim change As Double = Val(total) - (dt.Rows(indx).Item("AdvancePayment"))

                        frmCheckout.txtSubTotal.Text = Val(subtotal).ToString("N")
                        frmCheckout.txtTotal.Text = "0.00"
                        frmCheckout.txtCash.Text = "0.00"
                        frmCheckout.txtChange.Text = Val(total).ToString("N")
                    End If

                Else
                    frmCheckout.txtCheckout.Text = Now.Date

                    getdate = (dtOut.Value) - (dtIn.Value)
                    frmCheckout.txtDays.Text = getdate.Days

                    Dim subtotal As Double = Val(getdate.Days) * Val(dt.Rows(indx).Item("RoomRate"))
                    subtotal = Val(subtotal) - Val((dt.Rows(indx).Item("DiscountRate")) * Val(subtotal))

                    If Val(subtotal) > Val(dt.Rows(indx).Item("AdvancePayment")) Then
                        Dim total As Double = Val(subtotal) - (dt.Rows(indx).Item("AdvancePayment"))

                        frmCheckout.txtSubTotal.Text = Val(subtotal).ToString("N")
                        frmCheckout.txtTotal.Text = Val(total).ToString("N")
                        frmCheckout.txtCash.Text = Val(total).ToString("N")
                        frmCheckout.txtChange.Text = "0.00"
                    Else
                        Dim total As Double = (dt.Rows(indx).Item("AdvancePayment")) - Val(subtotal)
                        Dim change As Double = Val(total) - (dt.Rows(indx).Item("AdvancePayment"))

                        frmCheckout.txtSubTotal.Text = Val(subtotal).ToString("N")
                        frmCheckout.txtTotal.Text = "0.00"
                        frmCheckout.txtCash.Text = "0.00"
                        frmCheckout.txtChange.Text = Val(total).ToString("N")
                    End If
                End If

                Exit For

            End If
        Next


        rs.Dispose()
        con.Close()

        'frmCheckout.txtTransID.Text = lvlcheckin.SelectedItems(0).Text
        frmCheckout.txtGuestName.Text = lvlcheckin.SelectedItems(0).SubItems(1).Text
        frmCheckout.txtRoomNumber.Text = lvlcheckin.SelectedItems(0).SubItems(2).Text
        frmCheckout.txtCheckin.Text = lvlcheckin.SelectedItems(0).SubItems(3).Text
        'frmCheckout.txtCheckout.Text = lvlcheckin.SelectedItems(0).SubItems(4).Text
        'frmCheckout.txtDays.Text = lvlcheckin.SelectedItems(0).SubItems(5).Text
        frmCheckout.txtChildren.Text = lvlcheckin.SelectedItems(0).SubItems(6).Text
        frmCheckout.txtAdult.Text = lvlcheckin.SelectedItems(0).SubItems(7).Text
        frmCheckout.txtAdvance.Text = Val(lvlcheckin.SelectedItems(0).SubItems(8).Text).ToString("N")
        frmCheckout.txtDiscountType.Text = lvlcheckin.SelectedItems(0).SubItems(9).Text

        Me.Close()
    End Sub
End Class
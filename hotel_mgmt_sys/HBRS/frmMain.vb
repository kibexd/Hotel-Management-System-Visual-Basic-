Public Class frmMain

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim exit_app As String = MsgBox("Exit application?", vbQuestion + vbYesNo, "Exit")
        If exit_app = vbNo Then
            e.Cancel = True
        Else
            End
        End If
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub toolbarCheckIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolbarCheckIn.Click
        frmCheckin.ShowDialog()
    End Sub

    Private Sub ToolStripButton13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton13.Click
        Dim exit_app As String = MsgBox("Exit application?", vbQuestion + vbYesNo, "Exit")
        If exit_app = vbYes Then
            End
        End If
    End Sub

    Private Sub ToolStripButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton12.Click
        Dim out_app As String = MsgBox("Logout from application?", vbQuestion + vbYesNo, "Logout")
        If out_app = vbYes Then
            con.Close()
            Me.Hide()
            frmLogin.Show()
        End If
    End Sub

    Private Sub ToolStripButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton10.Click
        frmGuest.ShowDialog()
    End Sub

    Private Sub toolbarRoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolbarRoom.Click
        frmRoom.ShowDialog()
    End Sub

    Private Sub toolbarReserve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolbarReserve.Click
        frmReserve.ShowDialog()
    End Sub

    Private Sub NewCheckInToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewCheckInToolStripMenuItem.Click
        frmCheckin.ShowDialog()
    End Sub

    Private Sub NewReservationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewReservationToolStripMenuItem.Click
        frmReserve.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim out_app As String = MsgBox("Logout from application?", vbQuestion + vbYesNo, "Logout")
        If out_app = vbYes Then
            Me.Hide()
            frmLogin.Show()
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub toolbarCheckOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolbarCheckOut.Click
        frmCheckout.ShowDialog()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsToolStripMenuItem.Click

    End Sub

    Private Sub FileToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileToolStripMenuItem1.Click

    End Sub

    Private Sub CheckedInListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckedInListToolStripMenuItem.Click
        frmCheckinListMonitor.ShowDialog()
    End Sub

    Private Sub RoomStatusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomStatusToolStripMenuItem.Click
        frmRoomListMonitor.ShowDialog()
    End Sub

    Private Sub ReservedListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReservedListToolStripMenuItem.Click
        frmReserveListMonitor.ShowDialog()
    End Sub

    Private Sub CheckedOutListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckedOutListToolStripMenuItem.Click
        frmCheckOutList.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim datenow As Date = Now
        status.Items(2).Text = "Date and Time : " & datenow.ToString("MMMM dd, yyyy") & " " & TimeOfDay
    End Sub

    Private Sub DiscountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiscountToolStripMenuItem.Click
        frmDiscount.ShowDialog()
    End Sub

    Private Sub RoomToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomToolStripMenuItem.Click
        frmRoom.ShowDialog()
        frmRoom.TabPage2.Select()
    End Sub

    Private Sub GuestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuestToolStripMenuItem.Click
        frmGuest.ShowDialog()
    End Sub

    Private Sub ToolStripLabel2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripLabel2.Click

    End Sub
End Class

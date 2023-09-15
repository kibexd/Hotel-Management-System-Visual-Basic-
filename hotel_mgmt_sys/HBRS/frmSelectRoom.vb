Imports System.Data.OleDb
Public Class frmSelectRoom

    Private Sub frmSelectRoom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        display_room()
    End Sub
    Private Sub display_room()
        con.Open()
        Dim Dt As New DataTable("tblRoom")
        Dim rs As OleDbDataAdapter

        rs = New OleDbDataAdapter("Select * from tblRoom WHERE Status = 'Available'", con)

        rs.Fill(Dt)
        Dim indx As Integer
        lvRoom.Items.Clear()
        For indx = 0 To Dt.Rows.Count - 1
            Dim lv As New ListViewItem
            lv.Text = Dt.Rows(indx).Item("RoomNumber")
            lv.SubItems.Add(Dt.Rows(indx).Item("RoomType"))
            lv.SubItems.Add(Dt.Rows(indx).Item("RoomRate"))
            lv.SubItems.Add(Dt.Rows(indx).Item("NoofBeds"))
            lvRoom.Items.Add(lv)
        Next
        rs.Dispose()
        con.Close()
    End Sub

    Private Sub lvRoom_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvRoom.DoubleClick
        frmCheckin.txtRoomNumber.Text = lvRoom.SelectedItems(0).Text
        frmCheckin.txtRoomType.Text = lvRoom.SelectedItems(0).SubItems(1).Text
        frmCheckin.txtRoomRate.Text = lvRoom.SelectedItems(0).SubItems(2).Text
        frmCheckin.lblNoOfbeds.Text = lvRoom.SelectedItems(0).SubItems(3).Text

        frmReserve.txtRoomNumber.Text = lvRoom.SelectedItems(0).Text
        frmReserve.txtRoomType.Text = lvRoom.SelectedItems(0).SubItems(1).Text
        frmReserve.txtRoomRate.Text = lvRoom.SelectedItems(0).SubItems(2).Text
        frmReserve.lblNoOfbeds.Text = lvRoom.SelectedItems(0).SubItems(3).Text

        Me.Close()
    End Sub

    Private Sub lvRoom_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvRoom.SelectedIndexChanged

    End Sub
End Class
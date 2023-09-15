Imports System.Data.OleDb
Public Class frmRoom
    Dim id As Integer
    Private Sub frmRoom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TabControl1.SelectTab(0)
        display_room()
    End Sub
    Private Sub display_room()
        con.Open()
        Dim Dt As New DataTable("tblRoom")
        Dim rs As OleDbDataAdapter

        rs = New OleDbDataAdapter("Select * from tblRoom", con)

        rs.Fill(Dt)
        Dim indx As Integer
        lvRoom.Items.Clear()
        For indx = 0 To Dt.Rows.Count - 1
            Dim lv As New ListViewItem
            lv.Text = Dt.Rows(indx).Item("ID")
            lv.SubItems.Add(Dt.Rows(indx).Item("RoomNumber"))
            lv.SubItems.Add(Dt.Rows(indx).Item("RoomType"))
            lv.SubItems.Add(Dt.Rows(indx).Item("RoomRate"))
            lv.SubItems.Add(Dt.Rows(indx).Item("NoofBeds"))
            lvRoom.Items.Add(lv)
        Next
        rs.Dispose()
        con.Close()
    End Sub

    Private Sub bttnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnCancel.Click
        txtID.Clear()
        txtRoomType.Clear()
        txtRoomRate.Clear()
        txtNoOfbeds.Clear()
        bttnSave.Text = "&Save"
    End Sub

    Private Sub bttnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnSave.Click
        con.Open()
        Dim num As String = Trim(txtID.Text)
        Dim type As String = Trim(txtRoomType.Text)
        Dim rate As String = Trim(txtRoomRate.Text)
        Dim beds As String = Trim(txtNoOfbeds.Text)
        Dim stat As String = "Available"
        If type = Nothing Or rate = Nothing Or beds = Nothing Then
            MsgBox("Please Fill All Fields", vbInformation, "Note")
        Else
            If bttnSave.Text = "&Save" Then
                Dim sql = "SELECT * FROM tblRoom WHERE RoomNumber = " & SafeSqlLiteral(num, 2) & ""

                Dim cmd = New OleDbCommand(sql, con)
                Dim dr As OleDbDataReader = cmd.ExecuteReader

                Try
                    If dr.Read = False Then
                        Dim add_room As New OleDbCommand("INSERT INTO tblRoom(RoomNumber,RoomType,RoomRate,NoOfbeds,Status) values ('" &
                                                 SafeSqlLiteral(num, 2) & "','" &
                                                 SafeSqlLiteral(type, 2) & "','" &
                                                 SafeSqlLiteral(rate, 2) & "','" &
                                                 SafeSqlLiteral(beds, 2) & "','" &
                                                 stat & "')", con)
                        add_room.ExecuteNonQuery()
                        add_room.Dispose()
                        MsgBox("Room Added!", vbInformation, "Note")
                        txtID.Clear()
                        txtRoomType.Clear()
                        txtRoomRate.Clear()
                        txtNoOfbeds.Clear()
                    Else
                        MsgBox("Room Number Existed!", vbExclamation, "Note")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                Dim update_room As New OleDbCommand("UPDATE tblRoom SET RoomNumber= '" & SafeSqlLiteral(num, 2) & "',RoomType = '" & SafeSqlLiteral(type, 2) & "',RoomRate = '" & SafeSqlLiteral(rate, 2) & "',NoOfbeds = '" & SafeSqlLiteral(beds, 2) & "' WHERE ID = " & id & "", con)
                update_room.ExecuteNonQuery()
                update_room.Dispose()
                MsgBox("Room Saved!", vbInformation, "Note")
                bttnSave.Text = "&Save"
                txtID.Clear()
                txtRoomType.Clear()
                txtRoomRate.Clear()
                txtNoOfbeds.Clear()
            End If
        End If
        con.Close()
        display_room()
    End Sub

    Private Sub lvRoom_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvRoom.DoubleClick
        Dim a As String = MsgBox("Update selected Item?", vbQuestion + vbYesNo, "Update Room")
        If a = vbYes Then
            id = lvRoom.SelectedItems(0).Text
            txtID.Text = lvRoom.SelectedItems(0).SubItems(1).Text
            txtRoomType.Text = lvRoom.SelectedItems(0).SubItems(2).Text
            txtRoomRate.Text = lvRoom.SelectedItems(0).SubItems(3).Text
            txtNoOfbeds.Text = lvRoom.SelectedItems(0).SubItems(4).Text

            TabControl1.SelectTab(0)
            bttnSave.Text = "&Update"
        End If
    End Sub

    Private Sub lvRoom_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvRoom.SelectedIndexChanged

    End Sub

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs) Handles Label4.Click

    End Sub
End Class
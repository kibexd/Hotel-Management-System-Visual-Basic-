Imports System.Data.OleDb
Public Class frmDiscount
    Dim update_discount As Boolean = False
    Dim id As Integer
    Private Sub bttnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnCancel.Click
        clear_txt()
        update_discount = False
    End Sub

    Private Sub frmDiscount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        display_discount()
        clear_txt()
    End Sub

    Private Sub display_discount()
        con.Open()
        Dim dt As New DataTable("tblDiscount")
        rs = New OleDbDataAdapter("SELECT * FROM tblDiscount", con)
        rs.Fill(dt)

        lvlDiscount.Items.Clear()

        Dim indx As Integer
        For indx = 0 To dt.Rows.Count - 1
            Dim lv As New ListViewItem
            lv.Text = dt.Rows(indx).Item("ID")
            lv.SubItems.Add(dt.Rows(indx).Item("DiscountType"))
            lv.SubItems.Add(dt.Rows(indx).Item("DiscountRate"))
            lvlDiscount.Items.Add(lv)
        Next
        rs.Dispose()
        con.Close()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRate.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            'cancel keys
            e.Handled = True
        End If
    End Sub

    Private Sub bttnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnSave.Click
        If Trim(txtType.Text) = Nothing Or Trim(txtRate.Text) Then
            MsgBox("Fill All Fields!", vbInformation, "Note")
            Exit Sub
        End If
        Dim a As String = MsgBox("Save Discount Info?", vbQuestion + vbYesNo, "Save")
        If a = vbYes Then
            If update_discount = False Then
                con.Open()
                Dim save As New OleDbCommand("INSERT INTO tblDiscount(DiscountType,DiscountRate,Status) values ('" & Trim(txtType.Text) & "','" & Trim(txtRate.Text) & "','Active')", con)
                save.ExecuteNonQuery()
                con.Close()
            Else
                con.Open()
                Dim update As New OleDbCommand("UPDATE tblDiscount SET DiscountType = '" & Trim(txtType.Text) & "',DiscountRate = '" & Val(Trim(txtRate.Text)) / 100 & "' WHERE ID = '" & id & "'", con)
                update.ExecuteNonQuery()
                con.Close()
            End If
            MsgBox("Data saved successfully!", vbInformation, "Discount")
            display_discount()
            clear_txt()
        End If

    End Sub

    Private Sub clear_txt()
        txtType.Clear()
        txtRate.Clear()
        update_discount = False
    End Sub

    Private Sub lvlDiscount_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvlDiscount.DoubleClick
        Dim a As String = MsgBox("Update selected Item?", vbQuestion + vbYesNo, "Update Discount")
        If a = vbYes Then
            id = lvlDiscount.SelectedItems(0).Text
            txtType.Text = lvlDiscount.SelectedItems(0).SubItems(1).Text
            txtRate.Text = Val(lvlDiscount.SelectedItems(0).SubItems(2).Text) * 100
            update_discount = True
            bttnSave.Text = "&Update"
        End If
    End Sub
End Class
Imports System.Data.OleDb
Public Class frmLogin
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        If Trim(UsernameTextBox.Text) = "" Or Trim(PasswordTextBox.Text) = "" Then
            MsgBox("Please Enter Both Fields!", vbInformation, "Note")
        Else
            con.Open()
            Dim sql = "SELECT * FROM tblUser WHERE username = '" & SafeSqlLiteral(UsernameTextBox.Text, 2) & "' AND password = '" & SafeSqlLiteral(PasswordTextBox.Text, 2) & "'"

            Dim cmd = New OleDbCommand(sql, con)
            Dim dr As OleDbDataReader = cmd.ExecuteReader

            Try
                If dr.Read = False Then
                    MsgBox("Login Failed!", vbCritical, "Note")
                Else
                    MsgBox("Login Successful!", vbInformation, "Note")
                    frmMain.status.Items(0).Text = "Login as : " & Trim(UsernameTextBox.Text)
                    Dim datenow As Date = Now
                    frmMain.status.Items(2).Text = "Date and Time : " & datenow.ToString("MMMM dd, yyyy") & " " & TimeOfDay
                    con.Close()
                    Me.Hide()
                    frmMain.ShowDialog()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try

            con.Close()
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
        End
    End Sub
End Class

Imports System.Data
Imports System.Data.OleDb


Public Class LoginForm1


    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        con.Close()

        If UsernameTextBox.Text = "" Then
            MessageBox.Show("Please Enter your User Id to login", "Bicycle Shop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            UsernameTextBox.Focus()
        ElseIf PasswordTextBox.Text = "" Then
            MessageBox.Show("Please Enter your Password to login", "Bicycle Shop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PasswordTextBox.Focus()
        Else
            con.Open()
            cmd = New OleDbCommand("Select 8 from Login Where UserName='" + UsernameTextBox.Text + "' and Password='" + PasswordTextBox.Text + "'", con)
            da = New OleDbDataAdapter(cmd)
            ds = New Data.DataSet
            da.Fill(ds)
            Dim i As Integer
            i = ds.Tables(0).Rows.Count
            If i = 0 Then
                MsgBox("Login fail Enter valid id and password", MsgBoxStyle.Critical)

            Else

                con.Close()

                My.Forms.MDIParent1.Show()


                Me.Hide()


            End If
            con.Close()

        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    'Private Sub UsernameTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles UsernameTextBox.KeyPress

    '    If (e.KeyChar >= "a" AndAlso e.KeyChar <= "z") OrElse (e.KeyChar >= "A" AndAlso e.KeyChar <= "Z") Then

    '        e.Handled = True
    '    End If

    '    If Not Char.IsLetter(e.KeyChar) Then

    '        e.Handled = True
    '        MsgBox("Hello")
    '    End If

    'End Sub
End Class

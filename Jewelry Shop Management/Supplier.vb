Imports System.Data
Imports System.Data.OleDb
Public Class Supplier


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If name_txt.Text = "" Then name_txt.Focus() : Exit Sub
        If prod_txt.Text = "" Then prod_txt.Focus() : Exit Sub
        If TextBox1.Text = "" Then TextBox1.Focus() : Exit Sub
        If mobile_txt.Text = "" Then mobile_txt.Focus() : Exit Sub
        If email_txt.Text = "" Then email_txt.Focus() : Exit Sub
        If add_txt.Text = "" Then add_txt.Focus() : Exit Sub

        Try
            con.Close()

            con.Open()
            cmd = New OleDbCommand("Insert into supplier(supname,prosup,modsup,mobile,email,address) values('" + name_txt.Text + "','" + prod_txt.Text + "','" + TextBox1.Text + "','" + mobile_txt.Text + "','" + email_txt.Text + "','" + add_txt.Text + "')", con)
            Dim i As Integer = cmd.ExecuteNonQuery()
            If (i > 0) Then
                con.Close()

                MsgBox("Record Saved Successfully", MsgBoxStyle.Information, MsgBoxStyle.OkOnly)
                SearchId()

                clr()


            Else

                MsgBox("Record Not Saved", MsgBoxStyle.Critical, MsgBoxStyle.OkOnly)
            End If

        Catch ex As Exception

            MsgBox("Error", ex.Message)
        Finally
            con.Close()

        End Try

        con.Close()

    End Sub

    Public Sub clr()
        name_txt.Clear()
        prod_txt.Clear()
        TextBox1.Clear()
        mobile_txt.Clear()
        email_txt.Clear()
        add_txt.Clear()


    End Sub

    Public Sub SearchId()

        con.Open()
        cmd = New OleDbCommand("Select MAX(sup_id)from supplier", con)

        Dim dr As OleDbDataReader
        Try

            dr = cmd.ExecuteReader()
            While dr.Read
                Dim Cus_id As String = dr.GetValue(0)
                MessageBox.Show("Supplier registration done" & vbCrLf & "Your id =" & Cus_id & "")

            End While
        Catch ex As Exception
            MsgBox("Error", ex.Message)
        Finally
            con.Close()

        End Try
    End Sub

End Class

Imports System.Data.OleDb


Public Class EditSupplier

    Private Sub EditSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        con.Close()

        CustId()
    End Sub

    Public Sub CustId()
        ComboBox1.Items.Clear()
        ds.Clear()
        con.Close()

        con.Open()
        cmd = New OleDbCommand("Select * from supplier", con)
        da.SelectCommand = cmd
        da.Fill(ds, "supplier")
        Dim a As Integer = ds.Tables("supplier").Rows.Count - 1
        For i As Integer = 0 To a
            ComboBox1().Items.Add(ds.Tables("supplier").Rows(i)(0).ToString())


        Next

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        con.Close()

        con.Open()

        cmd = New OleDbCommand("select * from supplier where sup_id ='" & ComboBox1.Text & "'", con)

        If IsNumeric(ComboBox1.Text) Then
            cmd.CommandText = "select * from supplier where sup_id =@sid"
            cmd.Prepare()
            cmd.Parameters.AddWithValue("@sid", ComboBox1.Text)
            Dim dr As OleDbDataReader = cmd.ExecuteReader()
            Try
                If dr.Read() Then
                    name_txt.Text = dr.GetValue(1)
                    prod_txt.Text = dr.GetValue(2)
                    mobile_txt.Text = dr.GetValue(4)
                    email_txt.Text = dr.GetValue(5)
                    add_txt.Text = dr.GetValue(6)
                    dr.Close()

                End If

            Catch ex As Exception
                MsgBox("", ex.Message)
                dr.Close()
            Finally
                dr.Close()

            End Try

        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If name_txt.Text = "" Or prod_txt.Text = "" Or mobile_txt.Text = "" Or email_txt.Text = "" Or add_txt.Text = "" Then
            MsgBox("Please Fill All Detail's")
            Exit Sub
        End If
        Try
            con.Close()
            con.Open()
            str = " UPDATE supplier set supname=@name,prosup=@pro,mobile=@mob,email=@em,address=@add where sup_id=@cid"
            cmd = New OleDbCommand(str, con)
            cmd.Parameters.AddWithValue("@name", name_txt.Text)
            cmd.Parameters.AddWithValue("@pro", prod_txt.Text)
            cmd.Parameters.AddWithValue("@mob", mobile_txt.Text)
            cmd.Parameters.AddWithValue("@em", email_txt.Text)
            cmd.Parameters.AddWithValue("@add", add_txt.Text)
            cmd.Parameters.AddWithValue("@cid", ComboBox1.Text)
            cmd.ExecuteNonQuery()
            MsgBox("Record updated Successfully", MsgBoxStyle.Information, MsgBoxStyle.OkOnly)

        Catch ex As Exception

            MsgBox("error", ex.Message)
        Finally
            con.Close()

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If name_txt.Text = "" Or prod_txt.Text = "" Or mobile_txt.Text = "" Or email_txt.Text = "" Or add_txt.Text = "" Then
            MsgBox("Please Fill All Detail's")
            Exit Sub
        End If

        Dim msg As Integer = MsgBox("Do you want to delete Supplier :- '" & name_txt.Text & "' ?", MsgBoxStyle.YesNoCancel, "Delete Supplier Record")

        If msg = DialogResult.Yes Then
            Try
                con.Close()
                con.Open()
                str = "Delete from supplier where sup_id=@ID"
                cmd = New OleDbCommand(str, con)
                cmd.Parameters.AddWithValue("@ID", ComboBox1.Text)
                cmd.ExecuteNonQuery()
                MsgBox("Supplier Recor Deleted ", MsgBoxStyle.Information, MsgBoxStyle.OkOnly)

                clr()

                Dim ctr As Integer
                ComboBox1.Items.Clear()
                ds.Clear()
                str = "Select * from supplier"
                cmd = New OleDbCommand(str, con)
                da.SelectCommand = cmd

                da.Fill(ds, "supplier")
                ctr = ds.Tables("supplier").Rows.Count - 1
                For i = 0 To ctr
                    ComboBox1.Items.Add(ds.Tables("Supplier").Rows(i)(0).ToString)

                Next
            Catch ex As Exception

                MsgBox("Record Not Deleted", ex.Message)
            Finally
                con.Close()

            End Try
        End If
    End Sub
    Public Sub clr()
        name_txt.Clear()
        mobile_txt.Clear()
        add_txt.Clear()
        email_txt.Clear()
        prod_txt.Clear()
        ComboBox1.Items.Clear()


    End Sub

End Class
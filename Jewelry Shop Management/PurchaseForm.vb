Imports System.Data.OleDb
Public Class PurchaseForm


    Public dr As OleDbDataReader
    Dim Lastno As Integer

    Private Sub PurchaseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getSuppData()
        PurchaseIdAuto()

        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd-MM-yyyy"


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con.Close()
        If txt_pid.Text = "" Or com_man.Text = "" Or com_supp.Text = "" Or com_model.Text = "" Or txt_pRate.Text = "" Or txt_sRate.Text = "" Or txt_quantity.Text = "" Then

            MsgBox("Please Fill All Details")
        Else
            Try
                con.Open()
                cmd = New OleDbCommand("Insert into purchase (Purchase_id , Supplier_name, Model_Name, pro_name ,weight , Sale_Rate  ,Quantity , Purchase_Date ) values('" + txt_pid.Text + "','" + com_supp.Text & "','" + com_man.Text & "','" + com_model.Text & "','" & txt_pRate.Text & "','" & txt_sRate.Text & "','" & txt_quantity.Text & "','" & DateTimePicker1.Text & "')", con)
                Dim i As Integer = cmd.ExecuteNonQuery()
                If (i > 0) Then
                    MsgBox("Record Saved Successfully", MsgBoxStyle.Information, MsgBoxStyle.OkOnly)
                    getData()
                    Dim result As Integer = MessageBox.Show("Do you want add More Product", "Added", MessageBoxButtons.YesNo)
                    If result = DialogResult.Yes Then

                        ds.Clear()
                        str = "Select * from purchase"
                        cmd = New OleDb.OleDbCommand(str, con)
                        da.SelectCommand = cmd
                        da.Fill(ds, "purchase")





                        Lastno = ds.Tables("purchase").Rows.Count + 1


                        If Lastno >= 0 Then
                            txt_pid.Text = "PUR_" & Lastno

                        Else
                            txt_pid.Text = "PUR_" & 0



                        End If
                    Else
                        '  Me.Hide()

                    End If
                End If


            Catch ex As Exception
                MsgBox("Error", ex.Message)
            Finally
                con.Close()


            End Try

        End If

    End Sub

    Public Sub getSuppData()
        con.Close()

        con.Open()
        com_supp.Items.Clear()
        Dim cmd As New OleDbCommand()

        cmd.CommandText = "Select * from supplier"
        cmd.Connection = con
        dr = cmd.ExecuteReader

        While dr.Read
            com_supp.Items.Add(dr.GetString(1))
            'com_model.Items.Add(dr.GetString(2))

        End While
        dr.Close()




    End Sub
    Public Sub getSuppModelData()
        con.Close()

        con.Open()
        com_man.Items.Clear()
        Dim cmd As New OleDbCommand()

        cmd.CommandText = "Select * from supplier where supname='" & com_supp.SelectedItem & "'"
        cmd.Connection = con
        dr = cmd.ExecuteReader

        While dr.Read
            'com_supp.Items.Add(dr.GetString(1))
            com_man.Items.Add(dr.GetString(2))
            com_model.Items.Add(dr.GetString(3))

        End While
        'getWarrantyData()
        dr.Close()




    End Sub

    Public Sub getWarrantyData()
        con.Close()

        con.Open()
        'com_man.Items.Clear()
        com_model.Items.Clear()

        Dim cmd As New OleDbCommand()

        cmd.CommandText = "Select * from supplier where prosup='" & com_man.SelectedItem & "'"
        cmd.Connection = con
        dr = cmd.ExecuteReader

        While dr.Read
            'com_supp.Items.Add(dr.GetString(1))
            '  com_man.Items.Add(dr.GetString(2))
            com_model.Items.Add(dr.GetString(3))

        End While
        dr.Close()




    End Sub

    Private Sub com_supp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles com_supp.SelectedIndexChanged
        getSuppModelData()

    End Sub

    Public Sub PurchaseIdAuto()

        con.Close()
        con.Open()
        str = "Select * from purchase"
        cmd = New OleDb.OleDbCommand(str, con)
        da.SelectCommand = cmd
        da.Fill(ds, "purchase")


        'for product id


        Lastno = ds.Tables("purchase").Rows.Count + 1


        If Lastno >= 0 Then
            txt_pid.Text = "PUR_" & Lastno
        Else
            txt_pid.Text = "PUR_" & 0
            'man_txt.Focus()


        End If

    End Sub

    Public Sub getData()
        con.Close()

        con.Open()
        Using cmd As New OleDbCommand()

            cmd.CommandText = "Select * from purchase where Purchase_Date='" & DateTimePicker1.Text & "'"
            cmd.Connection = con
            Dim dt As New DataTable()

            Using da As New OleDbDataAdapter(cmd)

                da.Fill(dt)

                DataGridView1.DataSource = dt


            End Using


        End Using

    End Sub
    Public Sub getDataAll()
        con.Close()

        con.Open()
        Using cmd As New OleDbCommand()

            cmd.CommandText = "Select * from purchase "
            cmd.Connection = con
            Dim dt As New DataTable()

            Using da As New OleDbDataAdapter(cmd)

                da.Fill(dt)

                DataGridView1.DataSource = dt


            End Using


        End Using

    End Sub

    Private Sub com_man_SelectedIndexChanged(sender As Object, e As EventArgs) Handles com_man.SelectedIndexChanged
        getWarrantyData()


    End Sub

    
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        getDataAll()
    End Sub
End Class
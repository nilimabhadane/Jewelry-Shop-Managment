Imports System.Data.OleDb
Public Class saleForm


    Public dr As OleDbDataReader
    Dim Lastno As Integer
    Dim c As Integer


    Private Sub PurchaseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getSuppData()
        PurchaseIdAuto()

        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd-MM-yyyy"


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con.Close()
        If txt_pid.Text = "" Or com_model.Text = "" Or cust_name.Text = "" Or com_war.Text = "" Or cust_mobile.Text = "" Or price.Text = "" Or txt_quantity.Text = "" Then

            MsgBox("Please Fill All Details")
        Else
            Try
                con.Open()
                Dim a As Integer = txt_wieght.Text()
                Dim b As Integer = price.Text()

                txt_total.Text = a * b

                cmd = New OleDbCommand("Insert into Sales (invoice_id , Customer_Name, Moblie, Model_Name ,pro_name , Price  ,Quantity ,weight,total, Date_Sale ) values('" + txt_pid.Text + "','" + cust_name.Text & "','" + cust_mobile.Text & "','" + com_model.Text & "','" & com_war.Text & "','" & price.Text & "','" & txt_quantity.Text & "','" & txt_wieght.Text & "','" & txt_total.Text & "','" & DateTimePicker1.Text & "')", con)
                Dim i As Integer = cmd.ExecuteNonQuery()
                updateQuan()
                
                If (i > 0) Then
                    MsgBox("Record Saved Successfully", MsgBoxStyle.Information, MsgBoxStyle.OkOnly)
                    getData()
                    Dim result As Integer = MessageBox.Show("Do you want add More Product", "Added", MessageBoxButtons.YesNo)
                    If result = DialogResult.Yes Then

                        ' ds.Clear()
                        str = "Select * from Sales"
                        cmd = New OleDb.OleDbCommand(str, con)
                        da.SelectCommand = cmd
                        da.Fill(ds, "Sales")





                        Lastno = ds.Tables("Sales").Rows.Count + 1


                        If Lastno >= 0 Then
                            txt_pid.Text = "BILL_" & Lastno

                        Else
                            txt_pid.Text = "BILL_" & 0



                        End If
                    Else
                        ' Me.Hide()

                    End If
                End If


            Catch ex As Exception
                MsgBox("Error", ex.Message)
            Finally
                con.Close()


            End Try

        End If

    End Sub
    Public Sub updateQuan()
        con.Close()

        con.Open()
        'com_supp.Items.Clear()
        '  com_warranty.Items.Clear()


        Dim cmd As New OleDbCommand()

        cmd.CommandText = "Select * from purchase where Model_Name='" & com_model.Text & "' AND pro_name ='" & com_war.Text & "' "
        cmd.Connection = con
        dr = cmd.ExecuteReader

        While dr.Read
            ' com_warranty.Items.Add(dr.GetString(5))
            ' txt_price.Text = (dr.GetString(5))
            c = (dr.GetString(6))

            ' txt_avail.Text = (dr.GetString(6))

        End While

        Dim f As Integer = c - txt_quantity.Text
        dr.Close()
        con.Close()
        con.Open()
        cmd = New OleDbCommand("Update [purchase] Set [Quantity]='" & f & "' where Model_Name='" & com_model.Text & "' AND pro_name ='" & com_war.Text & "' ", con)

        Try
            cmd.ExecuteNonQuery()
            MsgBox("Quantity Update Successfully..")


        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            cmd.Dispose()

            con.Close()

        End Try




    End Sub

    Public Sub getSuppData()
        con.Close()

        con.Open()
        ' com_supp.Items.Clear()
        Dim cmd As New OleDbCommand()

        cmd.CommandText = "Select * from purchase"
        cmd.Connection = con
        dr = cmd.ExecuteReader

        While dr.Read
            com_model.Items.Add(dr.GetString(2))
            'com_model.Items.Add(dr.GetString(2))

        End While
        dr.Close()




    End Sub
    'Public Sub getSuppModelData()
    '    con.Close()

    '    con.Open()
    '    com_man.Items.Clear()
    '    Dim cmd As New OleDbCommand()

    '    cmd.CommandText = "Select * from supplier where supname='" & com_supp.SelectedItem & "'"
    '    cmd.Connection = con
    '    dr = cmd.ExecuteReader

    '    While dr.Read
    '        'com_supp.Items.Add(dr.GetString(1))
    '        com_man.Items.Add(dr.GetString(2))
    '        com_model.Items.Add(dr.GetString(3))

    '    End While
    '    'getWarrantyData()
    '    dr.Close()




    'End Sub

    Public Sub getWarrantyData()
        con.Close()

        con.Open()
        'com_man.Items.Clear()
        com_war.Items.Clear()

        Dim cmd As New OleDbCommand()

        cmd.CommandText = "Select * from supplier where prosup='" & com_model.SelectedItem & "'"
        cmd.Connection = con
        dr = cmd.ExecuteReader

        While dr.Read
            'com_supp.Items.Add(dr.GetString(1))
            '  com_man.Items.Add(dr.GetString(2))
            com_war.Items.Add(dr.GetString(3))

        End While
        dr.Close()




    End Sub

    Private Sub com_supp_SelectedIndexChanged(sender As Object, e As EventArgs)
        '   getSuppModelData()

    End Sub

    Public Sub PurchaseIdAuto()

        con.Close()
        con.Open()
        str = "Select * from Sales"
        cmd = New OleDb.OleDbCommand(str, con)
        da.SelectCommand = cmd
        da.Fill(ds, "Sales")


        'for product id


        Lastno = ds.Tables("Sales").Rows.Count + 1


        If Lastno >= 0 Then
            txt_pid.Text = "BILL_" & Lastno
        Else
            txt_pid.Text = "BILL" & 0
            'man_txt.Focus()


        End If

    End Sub

    Public Sub getData()
        con.Close()

        con.Open()
        Using cmd As New OleDbCommand()

            cmd.CommandText = "Select * from Sales where Moblie='" & cust_mobile.Text & "'"
            cmd.Connection = con
            Dim dt As New DataTable()

            Using da As New OleDbDataAdapter(cmd)

                da.Fill(dt)

                DataGridView1.DataSource = dt


            End Using


        End Using

    End Sub

    Private Sub com_man_SelectedIndexChanged(sender As Object, e As EventArgs) Handles com_model.SelectedIndexChanged
        getWarrantyData()


    End Sub

    Public Sub getPriceData()
        con.Close()

        con.Open()
        'com_man.Items.Clear()
        ' com_model.Items.Clear()

        Dim cmd As New OleDbCommand()

        cmd.CommandText = "Select * from purchase where Model_Name='" & com_model.SelectedItem & "' and pro_name='" & com_war.SelectedItem & "'"
        cmd.Connection = con
        dr = cmd.ExecuteReader

        While dr.Read
            'com_supp.Items.Add(dr.GetString(1))
            '  com_man.Items.Add(dr.GetString(2))
            'com_model.Items.Add(dr.GetString(3))
            price.Text = (dr.GetString(4))



        End While
        dr.Close()




    End Sub

    Public Sub getPrice()
        con.Close()

        con.Open()
        'com_supp.Items.Clear()
        '  com_warranty.Items.Clear()


        Dim cmd As New OleDbCommand()

        cmd.CommandText = "Select * from purchase where pro_name='" & com_war.Text & "'"
        cmd.Connection = con
        dr = cmd.ExecuteReader

        While dr.Read
            ' com_warranty.Items.Add(dr.GetString(5))
            price.Text = (dr.GetString(4))
            '   txt_avail.Text = (dr.GetString(6))


        End While
        dr.Close()




    End Sub

    Private Sub com_model_SelectedIndexChanged(sender As Object, e As EventArgs) Handles com_war.SelectedIndexChanged
        ' getPriceData()
        '' getPrice()
    End Sub

  
End Class
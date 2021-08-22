<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class saleForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cust_mobile = New System.Windows.Forms.TextBox()
        Me.cust_name = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_quantity = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.price = New System.Windows.Forms.TextBox()
        Me.com_war = New System.Windows.Forms.ComboBox()
        Me.com_model = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_pid = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_wieght = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label28)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(931, 71)
        Me.Panel1.TabIndex = 0
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label28.Font = New System.Drawing.Font("Bodoni MT Condensed", 26.25!, System.Drawing.FontStyle.Bold)
        Me.Label28.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label28.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label28.Location = New System.Drawing.Point(289, 15)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(180, 41)
        Me.Label28.TabIndex = 2
        Me.Label28.Text = " Product Sale "
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.txt_wieght)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.txt_total)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.cust_mobile)
        Me.Panel2.Controls.Add(Me.cust_name)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.DateTimePicker1)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txt_quantity)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.price)
        Me.Panel2.Controls.Add(Me.com_war)
        Me.Panel2.Controls.Add(Me.com_model)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txt_pid)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.ForeColor = System.Drawing.Color.LightGray
        Me.Panel2.Location = New System.Drawing.Point(0, 71)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(931, 571)
        Me.Panel2.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label9.Font = New System.Drawing.Font("Bodoni MT Condensed", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.SystemColors.Control
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(686, 148)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 22)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Total Price"
        '
        'txt_total
        '
        Me.txt_total.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txt_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_total.Font = New System.Drawing.Font("Bodoni MT Condensed", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txt_total.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_total.Location = New System.Drawing.Point(685, 173)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(155, 30)
        Me.txt_total.TabIndex = 36
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label5.Font = New System.Drawing.Font("Bodoni MT Condensed", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(241, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 22)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Customer Mobile"
        '
        'cust_mobile
        '
        Me.cust_mobile.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cust_mobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cust_mobile.Font = New System.Drawing.Font("Bodoni MT Condensed", 14.25!, System.Drawing.FontStyle.Bold)
        Me.cust_mobile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cust_mobile.Location = New System.Drawing.Point(240, 49)
        Me.cust_mobile.Name = "cust_mobile"
        Me.cust_mobile.Size = New System.Drawing.Size(155, 30)
        Me.cust_mobile.TabIndex = 34
        '
        'cust_name
        '
        Me.cust_name.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cust_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cust_name.Font = New System.Drawing.Font("Bodoni MT Condensed", 14.25!, System.Drawing.FontStyle.Bold)
        Me.cust_name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cust_name.Location = New System.Drawing.Point(32, 116)
        Me.cust_name.Name = "cust_name"
        Me.cust_name.Size = New System.Drawing.Size(155, 30)
        Me.cust_name.TabIndex = 32
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Bodoni MT Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(188, 506)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 32)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label8.Font = New System.Drawing.Font("Bodoni MT Condensed", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.SystemColors.Control
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(680, 82)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 22)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Date"
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Azure
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.Location = New System.Drawing.Point(32, 209)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(887, 270)
        Me.DataGridView1.TabIndex = 29
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Bodoni MT Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(681, 107)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(156, 30)
        Me.DateTimePicker1.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label7.Font = New System.Drawing.Font("Bodoni MT Condensed", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(680, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 22)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Qantity"
        '
        'txt_quantity
        '
        Me.txt_quantity.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txt_quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_quantity.Font = New System.Drawing.Font("Bodoni MT Condensed", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txt_quantity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_quantity.Location = New System.Drawing.Point(679, 49)
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.Size = New System.Drawing.Size(161, 30)
        Me.txt_quantity.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label6.Font = New System.Drawing.Font("Bodoni MT Condensed", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(481, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 22)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Rate"
        '
        'price
        '
        Me.price.BackColor = System.Drawing.SystemColors.ControlLight
        Me.price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.price.Font = New System.Drawing.Font("Bodoni MT Condensed", 14.25!, System.Drawing.FontStyle.Bold)
        Me.price.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.price.Location = New System.Drawing.Point(480, 116)
        Me.price.Name = "price"
        Me.price.Size = New System.Drawing.Size(155, 30)
        Me.price.TabIndex = 25
        '
        'com_war
        '
        Me.com_war.BackColor = System.Drawing.SystemColors.ControlLight
        Me.com_war.Font = New System.Drawing.Font("Bodoni MT Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.com_war.FormattingEnabled = True
        Me.com_war.Location = New System.Drawing.Point(480, 49)
        Me.com_war.Name = "com_war"
        Me.com_war.Size = New System.Drawing.Size(155, 30)
        Me.com_war.TabIndex = 21
        '
        'com_model
        '
        Me.com_model.BackColor = System.Drawing.SystemColors.ControlLight
        Me.com_model.Font = New System.Drawing.Font("Bodoni MT Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.com_model.FormattingEnabled = True
        Me.com_model.Location = New System.Drawing.Point(240, 117)
        Me.com_model.Name = "com_model"
        Me.com_model.Size = New System.Drawing.Size(155, 30)
        Me.com_model.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label3.Font = New System.Drawing.Font("Bodoni MT Condensed", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(481, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 22)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Porduct Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label4.Font = New System.Drawing.Font("Bodoni MT Condensed", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(241, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 22)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Product Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label2.Font = New System.Drawing.Font("Bodoni MT Condensed", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(33, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 22)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Customer Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Bodoni MT Condensed", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(33, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 22)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Bill Number"
        '
        'txt_pid
        '
        Me.txt_pid.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txt_pid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_pid.Font = New System.Drawing.Font("Bodoni MT Condensed", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txt_pid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_pid.Location = New System.Drawing.Point(32, 49)
        Me.txt_pid.Name = "txt_pid"
        Me.txt_pid.Size = New System.Drawing.Size(155, 30)
        Me.txt_pid.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label10.Font = New System.Drawing.Font("Bodoni MT Condensed", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.SystemColors.Control
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(481, 149)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 22)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Weight in gram"
        '
        'txt_wieght
        '
        Me.txt_wieght.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txt_wieght.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_wieght.Font = New System.Drawing.Font("Bodoni MT Condensed", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txt_wieght.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_wieght.Location = New System.Drawing.Point(480, 174)
        Me.txt_wieght.Name = "txt_wieght"
        Me.txt_wieght.Size = New System.Drawing.Size(155, 30)
        Me.txt_wieght.TabIndex = 38
        '
        'saleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(931, 642)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "saleForm"
        Me.Text = "Form4"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_pid As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents com_war As System.Windows.Forms.ComboBox
    Friend WithEvents com_model As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents price As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_quantity As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cust_name As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cust_mobile As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_total As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_wieght As System.Windows.Forms.TextBox
End Class

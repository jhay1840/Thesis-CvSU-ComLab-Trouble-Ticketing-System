Imports MySql.Data.MySqlClient
Public Class frm_userAddtkt

    Dim conn As New MySqlConnection
    Dim sda As New MySqlDataAdapter
    Dim reader As MySqlDataReader
    Dim cmd As New MySqlCommand
    Dim dbdataset As New DataTable
    Dim bsource As New BindingSource
    Dim query As String
    Dim user As String
    Dim cl As Integer

    Private Sub btn_mytkt_Click(sender As Object, e As EventArgs) Handles btn_mytkt.Click
        frm_user.Show()
        Me.Hide()
    End Sub

    Private Sub btn_minimize_Click(sender As Object, e As EventArgs) Handles btn_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Dim result = MessageBox.Show(" Are you sure you want to exit?", "Prompt", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub create()
        conn.ConnectionString = Form6.server

        query = "INSERT INTO `systemdb`.`tickets` (`subject`, `priority`, `message`,username,date,status,due_date,category,cl_num,pc_num,user_act) VALUES ('" & txt_subject.selectedValue & "', 'Not Set','" & RichTextBox1.Text & "','" & user & "',current_timestamp(),'unread','Not Set','" & txt_cat.selectedValue & "','" & txt_cl.selectedValue & "','PC" & txt_pc.Text & "','" & RichTextBox2.Text & "');"

        Try
            conn.Open()
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            sda.SelectCommand = cmd
            conn.Close()
            txt_pc.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
    Private Sub getTime()
        conn.ConnectionString = Form6.server
        Dim query As String
        query = "select firstname from systemdb.accounts where username = '" & frm_login.user & "'"
        Try
            conn.Open()
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            sda.SelectCommand = cmd
            While reader.Read
                user = reader.GetString("firstname")
            End While

            conn.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub


    Private Sub frm_userAddtkt_Load(sender As Object, e As EventArgs) Handles Me.Load
        getTime()
        getTime2()
    End Sub


    Private Sub getTime2()
        conn.ConnectionString = Form6.server
        Dim query As String
        query = "select firstname from systemdb.accounts where username = '" & frm_login.user & "'"
        Try
            conn.Open()
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            sda.SelectCommand = cmd
            While reader.Read
                user = reader.GetString("firstname")
            End While

            conn.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_greet.Text = Date.Now.ToString(" hh:mm:ss tt")
        Label8.Text = Date.Now.Date
        Dim tmpTime As Date
        tmpTime = Now()


        If tmpTime.Hour > 18 Then
            lbl_greet.Text = "Good Evening User" & vbNewLine + "@" + user & vbNewLine& + lbl_greet.Text
        ElseIf tmpTime.Hour > 12 Then
            lbl_greet.Text = "Good Afternoon User" & vbNewLine + "@" + user & vbNewLine& + lbl_greet.Text
        Else
            lbl_greet.Text = "Good Morning User" & vbNewLine + "@" + user & vbNewLine& + lbl_greet.Text
        End If
    End Sub

    Private Sub frm_userAddtkt_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        getTime2()
        getcl()
        txt_cat.selectedIndex = 0
    End Sub




    Private Sub btn_confirm_Click_1(sender As Object, e As EventArgs) Handles btn_confirm.Click
        If RichTextBox1.Text = "" Or txt_pc.Text = "" Then
            MessageBox.Show("Please Complete all fields")
        Else
            Dim result = MessageBox.Show(" Added Successfully", "Prompt", MessageBoxButtons.OK)
            If result = DialogResult.OK Then
                create()
                txt_subject.Text = ""

                RichTextBox1.Clear()
                RichTextBox2.Clear()
            End If
        End If
    End Sub



    Private Sub txt_pc_TextChanged(sender As Object, e As EventArgs) Handles txt_pc.TextChanged

    End Sub

    Private Sub txt_pc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_pc.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
        If txt_pc.Text.Length >= 2 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub getdata()
        txt_subject.Clear()

        conn.ConnectionString = Form6.server
        Dim query As String
        query = "select subject from systemdb.subject where category = '" & txt_cat.selectedValue & "'"
        Try
            conn.Open()
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            sda.SelectCommand = cmd
            While reader.Read
                txt_subject.AddItem(reader.GetString("subject"))
            End While

            conn.Close()
            txt_subject.selectedIndex = 0

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub txt_cat_onItemSelected(sender As Object, e As EventArgs) Handles txt_cat.onItemSelected
        getdata()

    End Sub
    Private Sub getcl()
        txt_cl.Clear()
        conn.ConnectionString = Form6.server
        Dim query As String
        query = "select clab from systemdb.computers"
        Try
            conn.Open()
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            sda.SelectCommand = cmd
            While reader.Read
                cl = reader.GetInt64("clab")
            End While

            conn.Close()
            Dim counter As Integer
            counter = 1
            Do While counter <= cl
                txt_cl.AddItem("CL" & counter & "")
                counter = counter + 1
            Loop
            txt_cl.selectedIndex = 0
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub btn_dash_Click(sender As Object, e As EventArgs) Handles btn_dash.Click
        frm_userdash.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Dim result = MessageBox.Show(" Are you sure you want to logout?", "Prompt", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            frm_login.Show()
            Me.Hide()
        End If
    End Sub
End Class
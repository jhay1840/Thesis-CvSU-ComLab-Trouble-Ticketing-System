
Imports MySql.Data.MySqlClient
Public Class frm_user

    Dim conn As New MySqlConnection
    Dim sda As New MySqlDataAdapter
    Dim reader As MySqlDataReader
    Dim cmd As New MySqlCommand
    Dim dbdataset As New DataTable
    Dim bsource As New BindingSource
    Dim query As String
    Dim user As String
    Dim id As Integer


    Private Sub btn_addtkt_Click(sender As Object, e As EventArgs) Handles btn_addtkt.Click
        frm_userAddtkt.Show()
        Me.Hide()
    End Sub

    Private Sub btn_minimize_Click(sender As Object, e As EventArgs) Handles btn_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Public Sub refresh_dgv()
        Dim sda As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource
        conn.ConnectionString = Form6.server

        query = "SELECT tktid as 'Ticket ID', subject, priority , status,category,cl_num,DATE_FORMAT(date,'%Y-%m-%d %H:%I'), due_date FROM systemdb.tickets where username='" & user & "' order by date desc"
        Try
            conn.Open()

            cmd = New MySqlCommand(query, conn)
            sda.SelectCommand = cmd
            sda.Fill(dbdataset)
            bsource.DataSource = dbdataset
            tkt_dgv.DataSource = bsource
            sda.Update(dbdataset)
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
    Private Sub frm_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getTime()
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Dim result = MessageBox.Show(" Are you sure you want to exit?", "Prompt", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub frm_user_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        getTime()
        refresh_dgv()
        Panel4.Height = 0
        Panel6.Height = 0
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
            MessageBox.Show(" Error Server not running")
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



    Private Sub BunifuMaterialTextbox1_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox1.OnValueChanged
        If BunifuMaterialTextbox1.Text <> "" Then

            search()

        Else
            refresh_dgv()
        End If
    End Sub
    Private Sub search()
        Dim sda As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource
        conn.ConnectionString = Form6.server

        query = "SELECT tktid as 'Ticket ID', subject, priority , status,category,cl_num,DATE_FORMAT(date,'%Y-%m-%d %H:%I'), due_date FROM systemdb.tickets where (subject like '" & BunifuMaterialTextbox1.Text & "%' and username='" & user & "') or (DATE_FORMAT(date,'%Y-%m-%d %H:%I') like '" & BunifuMaterialTextbox1.Text & "%' and username='" & user & "') or (category like '" & BunifuMaterialTextbox1.Text & "%' and username='" & user & "') or (cl_num like '" & BunifuMaterialTextbox1.Text & "%' and username='" & user & "') or (due_date like '" & BunifuMaterialTextbox1.Text & "%' and username='" & user & "') or (priority like '" & BunifuMaterialTextbox1.Text & "%' and username='" & user & "') or (status like '" & BunifuMaterialTextbox1.Text & "%' and username='" & user & "') or (tktid like '" & BunifuMaterialTextbox1.Text & "%' and username='" & user & "') order by date desc "
        Try
            conn.Open()

            cmd = New MySqlCommand(query, conn)
            sda.SelectCommand = cmd
            sda.Fill(dbdataset)
            bsource.DataSource = dbdataset
            tkt_dgv.DataSource = bsource
            sda.Update(dbdataset)
            conn.Close()

        Catch ex As Exception

        Finally
            conn.Dispose()
        End Try
    End Sub



    Private Sub btn_dash_Click(sender As Object, e As EventArgs) Handles btn_dash.Click
        frm_userdash.Show()
        Me.Hide()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btn_closes_Click(sender As Object, e As EventArgs) Handles btn_closes.Click
        Panel4.Hide()
        Panel6.Hide()

    End Sub

    Private Sub tkt_dgv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles tkt_dgv.CellDoubleClick
        id = tkt_dgv.Rows(e.RowIndex).Cells(0).Value
        If tkt_dgv.Rows(e.RowIndex).Cells(3).Value = "Completed" Then
            loaddata()
            loaddata2()
            Panel6.Hide()
            Panel4.Hide()
            Panel4.Height = 395
            BunifuTransition1.ShowSync(Panel4)

        Else
            loaddata()
            Panel6.Hide()
            Panel4.Hide()

            Panel6.Height = 395
            BunifuTransition1.ShowSync(Panel6)
        End If

    End Sub

    Private Sub tkt_dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tkt_dgv.CellClick

    End Sub
    Public Sub loaddata2()
        Dim sda As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource
        conn.ConnectionString = Form6.server
        Dim tid, trans, det, datef, query, closed As String
        query = " select * from systemdb.transaction where tktid='" & id & "'"
        Try
            conn.Open()
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            sda.SelectCommand = cmd
            While reader.Read
                tid = reader.GetInt64("tranid")
                trans = reader.GetString("transaction")
                det = reader.GetString("details")
                datef = reader.GetString("date_finished")
                Closed = reader.GetString("closedby")
            End While
            Label13.Text = "Ticket ID:   " & id & ""
            Label15.Text = "Transaction ID:   " + tid
            Label14.Text = "Action Taken:   " + trans
            RichTextBox1.Text = det
            Label5.Text = "Date Finished:   " + datef
            Label17.Text = "Closed by:   " + Closed



            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
    Public Sub loaddata()
        Dim sda As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource
        conn.ConnectionString = Form6.server
        Dim cat, cl, pc, subj, dc, prio, stat, mess, query, dd, ua As String
        query = " select * from systemdb.tickets where tktid='" & id & "'"
        Try
            conn.Open()
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            sda.SelectCommand = cmd
            While reader.Read
                subj = reader.GetString("subject")
                cat = reader.GetString("category")
                pc = reader.GetString("pc_num")
                cl = reader.GetString("cl_num")
                dc = reader.GetString("date")
                prio = reader.GetString("priority")
                stat = reader.GetString("status")
                mess = reader.GetString("message")
                dd = reader.GetString("due_date")
                ua = reader.GetString("user_act")

            End While
            Label16.Text = "Category:   " & cat & "    " & subj & "    " & cl & "    " & pc & ""
            lbl_cat.Text = "Category:   " & cat & "    " & subj & "    " & cl & "    " & pc & ""
            lbl_date.Text = "Date Created: " & dc & ""
            lbl_prio.Text = "Priority: " & prio & ""
            lbl_status.Text = "Status: " & stat & ""
            lbl_ticket.Text = "Ticket ID: " & id & ""
            lbl_duedate.Text = "Due Date : " & dd & ""
            RichTextBox2.Text = mess
            RichTextBox3.Text = ua



            conn.Close()
        Catch ex As Exception
        MessageBox.Show(ex.Message)
        Finally
        conn.Dispose()
        End Try
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Dim result = MessageBox.Show(" Are you sure you want to quit", "Prompt", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            frm_login.Show()
            Me.Hide()
        End If
    End Sub

  

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Panel4.Hide()
        Panel6.Hide()
    End Sub
End Class
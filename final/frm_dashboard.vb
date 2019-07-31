Imports MySql.Data.MySqlClient
Public Class frm_dashboard
    Dim conn As New MySqlConnection
    Dim sda As New MySqlDataAdapter
    Dim reader As MySqlDataReader
    Dim cmd As New MySqlCommand
    Dim dbdataset As New DataTable
    Dim bsource As New BindingSource
    Dim user As String
    Dim alltkts As Integer
    Dim newtkts As Integer
    Dim duetkts As Integer
    Dim odtkts As Integer

    Private Sub btn_minimize_Click(sender As Object, e As EventArgs) Handles btn_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub btn_maximize_Click(sender As Object, e As EventArgs) Handles btn_maximize.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
            Me.CenterToScreen()
            lbl_alltix.Location = New Point(233, 40)
            Label2.Location = New Point(208, 95)
            lbl_newtix.Location = New Point(233, 40)
            Label3.Location = New Point(184, 95)
            lbl_duetoday.Location = New Point(233, 40)
            Label4.Location = New Point(138, 97)
            lbl_overduetix.Location = New Point(233, 40)
            Label5.Location = New Point(150, 97)
        Else
            Me.WindowState = FormWindowState.Maximized
            mxmz()
        End If
    End Sub
    Private Sub mxmz()
        lbl_alltix.Location = New Point(225, 45)
        Label2.Location = New Point(210, 115)
        lbl_newtix.Location = New Point(245, 50)
        Label3.Location = New Point(210, 115)
        lbl_duetoday.Location = New Point(250, 55)
        Label4.Location = New Point(185, 125)
        lbl_overduetix.Location = New Point(240, 55)
        Label5.Location = New Point(190, 125)

    End Sub



    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Dim result = MessageBox.Show(" Are you sure you want to quit", "Prompt", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Application.Exit()

        End If
    End Sub

    Private Sub btn_tickets_Click(sender As Object, e As EventArgs) Handles btn_tickets.Click
        Timer2.Enabled = False
        frm_tickets.Show()
        Me.Hide()
    End Sub


    Private Sub btn_accounts_Click(sender As Object, e As EventArgs) Handles btn_accounts.Click
        Timer2.Enabled = False
        frm_acc.Show()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_greet.Text = Date.Now.ToString(" hh:mm:ss tt")
        Label8.Text = Date.Now.Date
        Dim tmpTime As Date
        tmpTime = Now()


        If tmpTime.Hour > 18 Then
            lbl_greet.Text = "Good Evening Admin" & vbNewLine + "@" + user & vbNewLine& + lbl_greet.Text
        ElseIf tmpTime.Hour > 11 Then
            lbl_greet.Text = "Good Afternoon Admin" & vbNewLine + "@" + user & vbNewLine& + lbl_greet.Text
        Else
            lbl_greet.Text = "Good Morning Admin" & vbNewLine + "@" + user & vbNewLine& + lbl_greet.Text
        End If
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

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub frm_dashboard_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged


        Timer2.Enabled = True
    End Sub

    Private Sub LoadAll()
        conn.ConnectionString = Form6.server

        Dim query = "SELECT count(tktID) FROM systemdb.tickets where status=""completed"";"
        Try
            conn.Open()

            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            sda.SelectCommand = cmd
            While reader.Read
                alltkts = reader.GetInt64("count(tktID)")

            End While
            lbl_alltix.Text = alltkts

            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
    Private Sub LoadNew()
        conn.ConnectionString = Form6.server

        Dim query = "SELECT count(tktID) FROM systemdb.tickets where (date(date)=curdate() or status='unread') and status!='completed'"
        Try
            conn.Open()

            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            sda.SelectCommand = cmd
            While reader.Read
                newtkts = reader.GetInt64("count(tktID)")

            End While
            lbl_newtix.Text = newtkts

            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub LoadDue()
        conn.ConnectionString = Form6.server

        Dim query = "SELECT count(tktID) FROM systemdb.tickets where due_date=curdate() and status!='completed'"
        Try
            conn.Open()

            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            sda.SelectCommand = cmd
            While reader.Read
                duetkts = reader.GetInt64("count(tktID)")

            End While
            lbl_duetoday.Text = duetkts

            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub frm_dashboard_Load(sender As Object, e As EventArgs) Handles Me.Load

        DoubleBuffered = True
        getTime()
        LoadAll()
        LoadNew()
        LoadDue()
        LoadOver()
        mxmz()

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        LoadAll()
        LoadNew()
        LoadDue()
        LoadOver()

    End Sub
    Private Sub LoadOver()
        conn.ConnectionString = Form6.server

        Dim query = "SELECT count(tktID) FROM systemdb.tickets where status='pending' or due_date='Not Set'"
        Try
            conn.Open()

            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            sda.SelectCommand = cmd
            While reader.Read
                odtkts = reader.GetInt64("count(tktID)")

            End While
            lbl_overduetix.Text = odtkts

            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub





    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click, BunifuCards4.Click
        frm_tickets.Show()
        frm_tickets.duet()

        Me.Hide()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub frm_dashboard_TextChanged(sender As Object, e As EventArgs) Handles Me.TextChanged

    End Sub

    Private Sub BunifuImageButton4_Click(sender As Object, e As EventArgs) Handles BunifuImageButton4.Click, BunifuCards1.Click
        frm_tickets.Show()
        frm_tickets.newt()
        Me.Hide()
    End Sub

    Private Sub BunifuCards2_Paint(sender As Object, e As PaintEventArgs) Handles BunifuCards2.Paint

    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click, BunifuCards2.Click
        frm_tickets.Show()
        frm_tickets.cmplt()
        Me.Hide()
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click, BunifuCards3.Click
        frm_tickets.Show()
        frm_tickets.pend()
        Me.Hide()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub btn_reports_Click(sender As Object, e As EventArgs) Handles btn_reports.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        frm_admin.Show()
        Me.Hide()
    End Sub

    Private Sub frm_dashboard_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        getTime()
        LoadDue()
        If lbl_duetoday.Text = 0 Then
            NotifyIcon1.BalloonTipText = "no tickets Due today"
        Else
            NotifyIcon1.BalloonTipText = "" & lbl_duetoday.Text & "  Tickets Due today"
        End If
        NotifyIcon1.BalloonTipTitle = "Hi " & user & ""

        NotifyIcon1.Visible = True
        NotifyIcon1.ShowBalloonTip(5000)
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Dim result = MessageBox.Show(" Are you sure you want to logout?", "Prompt", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            frm_login.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub BunifuCards1_Paint(sender As Object, e As PaintEventArgs) Handles BunifuCards1.Paint

    End Sub
End Class
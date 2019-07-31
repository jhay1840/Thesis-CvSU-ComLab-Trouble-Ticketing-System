Imports MySql.Data.MySqlClient


Public Class frm_tickets
    Dim conn As New MySqlConnection

    Dim reader As MySqlDataReader
    Dim cmd As New MySqlCommand
    Public tktid As String
    Dim lvl As Int16
    Dim query, user, pass As String
    Dim alltkts, counter As Integer
    Private Sub btn_minimize_Click(sender As Object, e As EventArgs) Handles btn_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_maximize_Click(sender As Object, e As EventArgs) Handles btn_maximize.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
            Me.CenterToScreen()
        Else
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Dim result = MessageBox.Show(" Are you sure you want to quit", "Prompt", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btn_dashboard_Click(sender As Object, e As EventArgs) Handles btn_dashboard.Click
        tkt_dgv.Enabled = True
        frm_dashboard.Show()
        Form2.Hide()
        Me.Hide()
    End Sub
    Private Sub btn_accounts_Click(sender As Object, e As EventArgs) Handles btn_accounts.Click
        tkt_dgv.Enabled = True
        Form2.Hide()
        frm_acc.Show()
        Me.Hide()
    End Sub





    Public Sub refresh_dgv()
        Dim sda As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource
        conn.ConnectionString = Form6.server

        query = "SELECT tktid as 'Ticket ID',username, subject, priority , status,category,cl_num,DATE_FORMAT(date,'%Y-%m-%d %H:%I'), due_date FROM systemdb.tickets order by date desc"
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











    Private Sub btn_all_Click(sender As Object, e As EventArgs) Handles btn_all.Click
        btn_all.Normalcolor = Color.LimeGreen
        btn_duetoday.Normalcolor = Color.Transparent
        btn_new.Normalcolor = Color.Transparent
        btn_solved.Normalcolor = Color.Transparent
        refresh_dgv()
    End Sub



    Private Sub LoadAll()
        conn.ConnectionString = Form6.server
        Dim sda As New MySqlDataAdapter
        Dim query = "SELECT count(tktID) FROM systemdb.tickets;"
        Try
            conn.Open()

            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            sda.SelectCommand = cmd
            While reader.Read
                alltkts = reader.GetInt64("count(tktID)")

            End While


            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LoadAll()
        If alltkts <> counter Then
            refresh_dgv()
            counter = alltkts
        End If

    End Sub
    Public Sub duet()
        Dim sda As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource
        conn.ConnectionString = Form6.server

        query = "SELECT tktid as 'Ticket ID',username, subject, priority , status,category,cl_num,DATE_FORMAT(date,'%Y-%m-%d %H:%I'), due_date FROM systemdb.tickets where due_date=curdate() order by date desc "
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
    Public Sub newt()
        Dim sda As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource
        conn.ConnectionString = Form6.server

        query = "SELECT tktid as 'Ticket ID',username, subject, priority , status,category,cl_num,DATE_FORMAT(date,'%Y-%m-%d %H:%I'), due_date FROM systemdb.tickets where (date(date)=curdate() or status='unread') and status!='completed' order by date desc "
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
    Public Sub pend()
        Dim sda As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource
        conn.ConnectionString = Form6.server

        query = "SELECT tktid as 'Ticket ID',username, subject, priority , status,category,cl_num,DATE_FORMAT(date,'%Y-%m-%d %H:%I'), due_date FROM systemdb.tickets where (status='pending' or due_date='Not Set') and status!='completed' order by date desc "
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
    Private Sub btn_duetoday_Click(sender As Object, e As EventArgs) Handles btn_duetoday.Click
        duet()
        btn_all.Normalcolor = Color.Transparent
        btn_duetoday.Normalcolor = Color.LimeGreen
        btn_new.Normalcolor = Color.Transparent
        btn_solved.Normalcolor = Color.Transparent
    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        newt()
        btn_all.Normalcolor = Color.Transparent
        btn_duetoday.Normalcolor = Color.Transparent
        btn_new.Normalcolor = Color.LimeGreen
        btn_solved.Normalcolor = Color.Transparent
    End Sub

    Private Sub btn_solved_Click(sender As Object, e As EventArgs) Handles btn_solved.Click
        pend()
        btn_all.Normalcolor = Color.Transparent
        btn_duetoday.Normalcolor = Color.Transparent
        btn_new.Normalcolor = Color.Transparent
        btn_solved.Normalcolor = Color.LimeGreen
    End Sub



    Private Sub btn_reports_Click(sender As Object, e As EventArgs) Handles btn_reports.Click
        tkt_dgv.Enabled = True
        Form2.Hide()
        Form3.Show()
        Me.Hide()
    End Sub





    Private Sub frm_tickets_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadAll()
        counter = alltkts
        refresh_dgv()
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

        query = "SELECT tktid as 'Ticket ID',username, subject, priority , status,category,cl_num,DATE_FORMAT(date,'%Y-%m-%d %H:%I'), due_date FROM systemdb.tickets where subject like '" & BunifuMaterialTextbox1.Text & "%' or DATE_FORMAT(date,'%Y-%m-%d %H:%I') like '" & BunifuMaterialTextbox1.Text & "%' or category like '" & BunifuMaterialTextbox1.Text & "%' or cl_num like '" & BunifuMaterialTextbox1.Text & "%' or username like '" & BunifuMaterialTextbox1.Text & "%' or due_date like '" & BunifuMaterialTextbox1.Text & "%' or priority like '" & BunifuMaterialTextbox1.Text & "%' or status like '" & BunifuMaterialTextbox1.Text & "%'  or tktid like '" & BunifuMaterialTextbox1.Text & "%' order by date desc "
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

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        tkt_dgv.Enabled = True
        Form2.Hide()
        frm_admin.Show()
        Me.Hide()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub



    Private Sub tkt_dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tkt_dgv.CellClick
        tktid = tkt_dgv.Rows(e.RowIndex).Cells(0).Value
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Dim result = MessageBox.Show(" Are you sure you want to logout?", "Prompt", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Form2.Hide()
            frm_login.Show()
            Me.Hide()
        End If
    End Sub



    Private Sub tkt_dgv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles tkt_dgv.CellDoubleClick
        Try
            Form2.Show()
            tkt_dgv.Enabled = False
        Catch

        End Try
    End Sub

    Public Sub cmplt()
        Dim sda As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource
        conn.ConnectionString = Form6.server

        query = "SELECT tktid as 'Ticket ID',username, subject, priority , status,category,cl_num,DATE_FORMAT(date,'%Y-%m-%d %H:%I'), due_date FROM systemdb.tickets where status='completed' order by date desc "
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

    Private Sub frm_tickets_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        DoubleBuffered = True
    End Sub
End Class
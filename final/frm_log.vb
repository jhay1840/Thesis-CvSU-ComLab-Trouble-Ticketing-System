
Imports MySql.Data.MySqlClient



Public Class frm_log

    Dim conn As New MySqlConnection

    Dim reader As MySqlDataReader
    Dim cmd As New MySqlCommand
    Dim counter, cmp, perc, pend As Integer
    Dim query As String
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
        frm_dashboard.Show()
        Me.Hide()
    End Sub
    Private Sub btn_tickets_Click(sender As Object, e As EventArgs) Handles btn_tickets.Click

        frm_tickets.Show()
        Me.Hide()
    End Sub

    Private Sub btn_accounts_Click(sender As Object, e As EventArgs) Handles btn_accounts.Click
        frm_acc.Show()
        Me.Hide()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized

        refresh_dgv()


    End Sub
    Public Sub refresh_dgv()
        Dim sda As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource
        conn.ConnectionString = Form6.server

        query = "SELECT tranid as TranID, tktid as 'Ticket ID',subject as Subject, transaction as Transaction,date_finished as 'Date Finished',closedby as 'Closed By' from transaction  order by date_finished desc"
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


    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        frm_admin.Show()
        Me.Hide()
    End Sub

    Private Sub tkt_dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tkt_dgv.CellContentClick

    End Sub

    Private Sub btn_ann_Click(sender As Object, e As EventArgs) Handles btn_ann.Click
        Form4.Show()
        Me.Hide()
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

        query = "SELECT tranid as TranID, tktid as 'Ticket ID',subject as Subject, transaction as Transaction,date_finished as 'Date Finished',closedby as 'Closed By' FROM systemdb.transaction where subject like '" & BunifuMaterialTextbox1.Text & "%' or DATE_FORMAT(date_finished,'%Y-%m-%d %H:%I') like '" & BunifuMaterialTextbox1.Text & "%' or tktid like '" & BunifuMaterialTextbox1.Text & "%' or transaction like '" & BunifuMaterialTextbox1.Text & "%' or tranid like '" & BunifuMaterialTextbox1.Text & "%' or closedby like '" & BunifuMaterialTextbox1.Text & "%' order by date_finished desc "
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

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        Dim result = MessageBox.Show(" Are you sure you want to logout?", "Prompt", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            frm_login.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btn_mont_Click(sender As Object, e As EventArgs) Handles btn_mont.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub frm_log_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        refresh_dgv()
    End Sub
End Class
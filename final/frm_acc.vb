Imports MySql.Data.MySqlClient



Public Class frm_acc

    Dim conn As New MySqlConnection

    Dim reader As MySqlDataReader
    Dim cmd As New MySqlCommand

    Dim query As String
    Public un, fn, ln, email As String


    Private Sub btn_minimize_Click(sender As Object, e As EventArgs) Handles btn_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_maximize_Click(sender As Object, e As EventArgs) Handles btn_maximize.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
            tkt_dgv.Width = 692
            Me.CenterToScreen()

        Else
            Me.WindowState = FormWindowState.Maximized
            tkt_dgv.Width = 892
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

    Public Sub refresh_dgv()
        Dim sda As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource
        conn.ConnectionString = Form6.server

        query = "SELECT  user_id,username as username,  firstname as 'First Name',lastname,mobilenum  FROM accounts where not(user_lvl='1')"
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




    Private Sub frm_acc_Load(sender As Object, e As EventArgs) Handles Me.Load

        refresh_dgv()
        tkt_dgv.Width = 892
    End Sub

    Private Sub btn_create_Click(sender As Object, e As EventArgs) Handles btn_create.Click
        Form1.Panel2.Hide()
        Form1.Panel3.Hide()

        Form1.Show()
        Me.Opacity = 50
        Me.Hide()
    End Sub


    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If un = "" Then
            MessageBox.Show("Please Select an account first", "prompt", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Form1.Panel2.Hide()
            Form1.Panel3.Show()
            Form1.sec()
            Form1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btn_all_Click(sender As Object, e As EventArgs) Handles btn_all.Click
        refresh_dgv()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btn_reports_Click(sender As Object, e As EventArgs) Handles btn_reports.Click
        Form3.Show()
        Me.Hide()
    End Sub



    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Me.Hide()
        frm_login.Show()
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        frm_admin.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        frm_myadmin.Show()
        Me.Hide()
    End Sub

    Private Sub tkt_dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tkt_dgv.CellContentClick

    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        Dim result = MessageBox.Show(" Are you sure you want to logout?", "Prompt", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            frm_login.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub btn_rem_Click(sender As Object, e As EventArgs) Handles btn_rem.Click
        If un = "" Then
            MessageBox.Show("Please Select an account first", "prompt", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Form1.Panel2.Show()
            Form1.Panel2.Dock = DockStyle.Fill

            Form1.Panel3.Hide()
            Form1.Show()
            Me.Hide()
        End If

    End Sub



    Private Sub tkt_dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tkt_dgv.CellClick
        un = tkt_dgv.Rows(e.RowIndex).Cells(1).Value

        fn = tkt_dgv.Rows(e.RowIndex).Cells(2).Value
        ln = tkt_dgv.Rows(e.RowIndex).Cells(3).Value
        email = tkt_dgv.Rows(e.RowIndex).Cells(4).Value
    End Sub
End Class
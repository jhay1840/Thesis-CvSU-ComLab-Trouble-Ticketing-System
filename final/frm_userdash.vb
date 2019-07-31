Imports MySql.Data.MySqlClient
Public Class frm_userdash
    Dim conn As New MySqlConnection
    Dim sda As New MySqlDataAdapter
    Dim reader As MySqlDataReader
    Dim cmd As New MySqlCommand
    Dim dbdataset As New DataTable
    Dim bsource As New BindingSource
    Dim query As String
    Dim user As String
    Dim newt As Integer
    Private Sub btn_mytkt_Click(sender As Object, e As EventArgs) Handles btn_mytkt.Click
        frm_user.Show()
        Me.Hide()
    End Sub

    Private Sub btn_addtkt_Click(sender As Object, e As EventArgs) Handles btn_addtkt.Click
        frm_userAddtkt.Show()
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

    Private Sub frm_userdash_Load(sender As Object, e As EventArgs) Handles Me.Load
        getTime()
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

    Private Sub frm_userdash_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged

        Panel4.Width = 0
        getTime()
        Loadcmp()
        Loadunread()
        Loadinp()
        Loadpend()
        Loadnew()
        refresh_dgv()
        If newt = 0 Then
            lbl_newt.Text = "No New Tickets Completed"
        End If
    End Sub
    Private Sub Loadcmp()
        conn.ConnectionString = Form6.server

        Dim query = "SELECT count(tktID) FROM systemdb.tickets where status=""completed"" and username='" & frm_login.first & "';"
        Try
            conn.Open()
            Dim cmp As Integer
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            sda.SelectCommand = cmd
            While reader.Read
                cmp = reader.GetInt64("count(tktID)")

            End While
            lbl_cmp.Text = cmp

            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
    Private Sub Loadunread()
        conn.ConnectionString = Form6.server

        Dim query = "SELECT count(tktID) FROM systemdb.tickets where status=""unread"" and username='" & frm_login.first & "';"
        Try
            conn.Open()
            Dim unr As Integer
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            sda.SelectCommand = cmd
            While reader.Read
                unr = reader.GetInt64("count(tktID)")

            End While
            lbl_unread.Text = unr

            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
    Private Sub Loadinp()
        conn.ConnectionString = Form6.server

        Dim query = "SELECT count(tktID) FROM systemdb.tickets where status=""In Progress"" and username='" & frm_login.first & "';"
        Try
            conn.Open()
            Dim inp As Integer
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            sda.SelectCommand = cmd
            While reader.Read
                inp = reader.GetInt64("count(tktID)")

            End While
            lbl_inp.Text = inp

            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
    Private Sub Loadpend()
        conn.ConnectionString = Form6.server

        Dim query = "SELECT count(tktID) FROM systemdb.tickets where status=""Pending"" and username='" & frm_login.first & "';"
        Try
            conn.Open()
            Dim pend As Integer
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            sda.SelectCommand = cmd
            While reader.Read
                pend = reader.GetInt64("count(tktID)")

            End While
            lbl_pend.Text = pend

            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub Loadnew()
        conn.ConnectionString = Form6.server

        Dim query = "SELECT count(tktID) FROM systemdb.tickets where new='1' and username='" & frm_login.first & "';"
        Try
            conn.Open()

            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            sda.SelectCommand = cmd
            While reader.Read
                newt = reader.GetInt64("count(tktID)")

            End While
            lbl_newt.Text = "" & newt & " New tickets Completed"

            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Public Sub refresh_dgv()
        Dim sda As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource
        conn.ConnectionString = Form6.server

        query = "select tktid as 'Ticket ID',category as Category, subject as Subject, cl_num as 'ComLab No.'  FROM systemdb.tickets where new=1 and username='" & frm_login.first & "'  order by date desc"
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

    Private Sub BunifuImageButton5_Click(sender As Object, e As EventArgs) Handles BunifuImageButton5.Click
        If newt = 0 Then
            lbl_newt.Text = "No New Tickets Completed"
        Else
            Panel4.Hide()
            Panel4.Width = 691
            BunifuTransition1.ShowSync(Panel4)
        End If

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        updatenew()
        refresh_dgv()
        Loadnew()
        Panel4.Hide()
        Panel4.Width = 0
        BunifuTransition1.ShowSync(Panel4)
        lbl_newt.Text = "No New Tickets Completed"
    End Sub
    Private Sub updatenew()
        conn.ConnectionString = Form6.server
        Dim QUERY As String
        Dim sda As New MySqlDataAdapter
        QUERY = "Update `systemdb`.`tickets` Set `new`='0' WHERE `new`='1' and username='" & frm_login.first & "' ;

"


        Try
            conn.Open()
            cmd = New MySqlCommand(QUERY, conn)
            reader = cmd.ExecuteReader
            sda.SelectCommand = cmd
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try



    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        frm_pass.Show()
        Me.Hide()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Dim result = MessageBox.Show(" Are you sure you want to logout?", "Prompt", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            frm_login.Show()
            Me.Hide()
        End If
    End Sub
End Class
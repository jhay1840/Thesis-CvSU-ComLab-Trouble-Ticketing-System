Imports MySql.Data.MySqlClient


Public Class Form2
    Dim conn As New MySqlConnection

    Dim reader As MySqlDataReader
    Dim cmd As New MySqlCommand
    Dim stat, subject As String



    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Panel1.Hide()
        frm_tickets.tkt_dgv.Enabled = True
        Me.Close()
        frm_tickets.refresh_dgv()

    End Sub
    Public Sub loaddata()
        Dim sda As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource
        conn.ConnectionString = Form6.server
        Dim query, subj, user, dates, prio, due, det, cl, pc, cat, ua As String
        query = " select *, DATE_FORMAT(date,'%Y-%m-%d %H:%I') from systemdb.tickets where tktid='" & frm_tickets.tktid & "'"
        Try
            conn.Open()
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            sda.SelectCommand = cmd
            While reader.Read
                subject = reader.GetString("subject")
                subj = reader.GetString("subject")
                user = reader.GetString("username")
                dates = reader.GetString("DATE_FORMAT(date,'%Y-%m-%d %H:%I')")
                prio = reader.GetString("priority")
                due = reader.GetString("due_date")
                det = reader.GetString("message")
                stat = reader.GetString("status")
                cl = reader.GetString("cl_num")
                pc = reader.GetString("pc_num")
                cat = reader.GetString("category")
                ua = reader.GetString("user_act")
            End While
            lbl_subj.Text = "Subject:   " + subj + "  " & cat & ""
            lbl_user.Text = "From:   " + user + "  " & cl & "  " & pc & ""
            lbl_Date.Text = "Date:   " + dates
            lbl_prio.Text = "Priority   " + prio
            lbl_due.Text = "Due Date:   " + due
            txt_details.Text = det
            lbl_tktid.Text = "Ticket ID   " + frm_tickets.tktid
            RichTextBox2.Text = ua
            If lbl_due.Text <> "Due Date:   Not Set" Then
                btn_set.ButtonText = "Edit Due Date"
            Else
                btn_set.ButtonText = "Set Due Date"
            End If

            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub Form2_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        BunifuDatepicker1.Value = Now
        date_fin.Value = Now

        loaddata2()
        TextBox2.Text = Format(date_fin.Value, "yyyy-MM-dd")
        Panel2.Hide()
        txt_details1.Clear()
        txt_at1.selectedIndex = 0
        Me.Height = 463
        Me.CenterToScreen()
        BunifuDragControl1.TargetControl = Me
        Panel1.Hide()
        loaddata()
        If stat = "unread" Then
            updateStats()

        End If
        If stat = "Completed" Then
            btn_cmp.Hide()
            btn_set.Hide()
            btn_change.Hide()
            Me.Height = 732
            Me.CenterToScreen()
        End If
    End Sub

    Private Sub updateStats()
        conn.ConnectionString = Form6.server
        Dim QUERY As String
        Dim sda As New MySqlDataAdapter
        QUERY = "Update tickets Set `status`=""Pending"" WHERE `tktid`='" & frm_tickets.tktid & "'"

        Try
            conn.Open()
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            sda.SelectCommand = cmd
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub btn_set_Click(sender As Object, e As EventArgs) Handles btn_set.Click
        Panel1.Show()
    End Sub




    Private Sub BunifuDatepicker1_onValueChanged(sender As Object, e As EventArgs) Handles BunifuDatepicker1.onValueChanged
        TextBox1.Text = Format(BunifuDatepicker1.Value, "yyyy-MM-dd")


    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Panel1.Hide()
    End Sub

    Private Sub btn_setnow_Click(sender As Object, e As EventArgs) Handles btn_setnow.Click
        If BunifuDatepicker1.Value < Today Then
            MessageBox.Show("You are not allowed to select older day than today!")

            Exit Sub
        End If
        conn.ConnectionString = Form6.server
        Dim QUERY As String
        Dim sda As New MySqlDataAdapter
        QUERY = "Update `systemdb`.`tickets` Set `due_date`='" & TextBox1.Text & "'WHERE `tktid`='" & frm_tickets.tktid & "';
Update `systemdb`.`tickets` Set `status`='In progress' WHERE `tktid`='" & frm_tickets.tktid & "';
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
        loaddata()
        Panel1.Hide()
    End Sub



    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btn_cmp_Click(sender As Object, e As EventArgs) Handles btn_cmp.Click
        Panel2.Show()

    End Sub
    Private Sub mark_cmp()
        conn.ConnectionString = Form6.server
        Dim QUERY As String
        Dim sda As New MySqlDataAdapter
        QUERY = "Update `systemdb`.`tickets` Set `status`='Completed',new='1' WHERE `tktid`='" & frm_tickets.tktid & "';
INSERT INTO `systemdb`.`transaction` (`tktid`, `transaction`, `details`, `date_finished`,subject,closedby) VALUES ('" & frm_tickets.tktid & "', '" & txt_at1.selectedValue & "', '" & txt_details1.Text & "', '" & TextBox2.Text & "','" & subject & "','" & frm_login.first & "');"


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
        loaddata()
        frm_tickets.tkt_dgv.Enabled = True
        frm_tickets.refresh_dgv()
        Me.Close()

    End Sub





    Private Sub update_prio()
        conn.ConnectionString = Form6.server
        Dim QUERY As String
        Dim sda As New MySqlDataAdapter
        QUERY = "Update `systemdb`.`tickets` Set `priority`='" & txtbox_pri.selectedValue & "' WHERE `tktid`='" & frm_tickets.tktid & "';

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
        loaddata()


    End Sub

    Private Sub btn_markSave_Click(sender As Object, e As EventArgs) Handles btn_markSave.Click
        If lbl_due.Text = "Due Date:   Not Set" Then
            MessageBox.Show("Please set the due date first")
            Panel2.Hide()
        Else
            If txt_details1.Text = "" Then
                MessageBox.Show("Please Complete all fields")
            Else
                mark_cmp()
                MessageBox.Show("Saved")
                Panel2.Hide()
                loaddata()
            End If
        End If



    End Sub

    Private Sub date_fin_onValueChanged(sender As Object, e As EventArgs) Handles date_fin.onValueChanged
        TextBox2.Text = Format(date_fin.Value, "yyyy-MM-dd")
    End Sub


    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_change_Click(sender As Object, e As EventArgs) Handles btn_change.Click

        If btn_change.ButtonText = "Save" Then
            txtbox_pri.Hide()
            btn_change.ButtonText = "Change"
            update_prio()
        Else
            txtbox_pri.selectedIndex = 0
            txtbox_pri.Show()
            btn_change.ButtonText = "Save"

        End If
    End Sub

    Public Sub loaddata2()
        Dim sda As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource
        conn.ConnectionString = Form6.server
        Dim tid, trans, det, datef, query, closed As String
        query = " select * from systemdb.transaction where tktid='" & frm_tickets.tktid & "'"
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
                closed = reader.GetString("closedby")
            End While
            Label3.Text = "Transaction ID:   " + tid
            Label4.Text = "Action Taken:   " + trans
            RichTextBox1.Text = det
            Label7.Text = "Date Finished:   " + datef
            Label8.Text = "Closed by:   " + closed



            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
End Class
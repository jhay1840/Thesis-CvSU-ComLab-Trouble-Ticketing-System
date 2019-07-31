

Imports MySql.Data.MySqlClient



Public Class frm_admin

    Dim conn As New MySqlConnection
    Dim sda As New MySqlDataAdapter
    Dim reader As MySqlDataReader
    Dim cmd As New MySqlCommand
    Dim counter As Integer
    Dim query As String
    Dim tktid As String

    Private Sub btn_dashboard_Click(sender As Object, e As EventArgs) Handles btn_dashboard.Click
        frm_dashboard.Show()
        Me.Hide()

    End Sub

    Private Sub btn_tickets_Click(sender As Object, e As EventArgs) Handles btn_tickets.Click
        frm_tickets.Show()
        Me.Hide()
    End Sub

    Private Sub btn_reports_Click(sender As Object, e As EventArgs) Handles btn_reports.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub btn_accounts_Click(sender As Object, e As EventArgs) Handles btn_accounts.Click
        frm_acc.Show()
        Me.Hide()
    End Sub

    Private Sub btn_minimize_Click(sender As Object, e As EventArgs) Handles btn_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_maximize_Click(sender As Object, e As EventArgs) Handles btn_maximize.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
            tkt_dgv.Height = 224
            Panel7.Height = 226
            Me.CenterToScreen()
            tkt_dgv.Width = 677
        Else
            Me.WindowState = FormWindowState.Maximized
            tkt_dgv.Height = 370
            tkt_dgv.Width = 940
            Panel7.Height = 350

        End If
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Dim result = MessageBox.Show(" Are you sure you want to quit", "Prompt", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub frm_admin_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.WindowState = FormWindowState.Maximized
        Panel6.Width = 0
    End Sub
    Public Sub cl_count()
        Dim sda As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource
        conn.ConnectionString = Form6.server

        query = "SELECT clab FROM systemdb.computers "
        Try
            conn.Open()
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            sda.SelectCommand = cmd
            While reader.Read
                counter = reader.GetInt64("clab")

            End While
            lbl_clab.Text = counter
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub frm_admin_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        txtbox_cat.selectedIndex = 0
        txt_addcat.selectedIndex = 0
        Me.WindowState = FormWindowState.Maximized
        Panel6.Width = 0
        tkt_dgv.Height = 370
        tkt_dgv.Width = 940
        cl_count()

    End Sub
    Public Sub refresh_dgv()
        Dim sda As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource
        conn.ConnectionString = Form6.server

        query = "SELECT subject as Subject from systemdb.subject where category='" & txtbox_cat.selectedValue & "' "
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

    Private Sub txtbox_cat_onItemSelected(sender As Object, e As EventArgs) Handles txtbox_cat.onItemSelected
        refresh_dgv()
    End Sub

    Private Sub BunifuMaterialTextbox1_OnValueChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If Me.WindowState = FormWindowState.Normal Then
            Panel7.Height = 226
        Else
            Panel7.Height = 350
        End If
        Panel7.Dock = DockStyle.Bottom

        Panel6.Visible = False
        Panel6.Width = 330
        tkt_dgv.Hide()
        BunifuTransition1.ShowSync(Panel6)
        BunifuTransition2.ShowSync(tkt_dgv)
        Panel6.BackColor = Color.White
        txt_cl.Enabled = True
        btn_save.Show()


    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        Panel7.Dock = DockStyle.Top
        Panel7.Height = 226
        Panel6.Visible = False
        Panel6.Width = 330
        tkt_dgv.Hide()
        BunifuTransition1.ShowSync(Panel6)
        BunifuTransition2.ShowSync(tkt_dgv)
        btn_save2.Show()
        txt_addsub.Enabled = True
        txt_addcat.Enabled = True
        Panel6.BackColor = Color.White

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If txt_cl.Text = "" Or txt_cl.Text = "0" Then
            MessageBox.Show("Please Input Data")
            cl_count()
            btn_save.Hide()
            txt_cl.Enabled = False
            txt_cl.Text = ""

            If btn_save2.Visible = True Then
            Else
                Panel6.Visible = False
                Panel6.Width = 0

                BunifuTransition1.ShowSync(Panel6)


            End If
        Else
            MessageBox.Show("Adding Successful")

            editData()
            cl_count()
            btn_save.Hide()
            txt_cl.Enabled = False
            txt_cl.Text = ""
            If btn_save2.Visible = True Then
            Else
                Panel6.Visible = False
                Panel6.Width = 0

                BunifuTransition1.ShowSync(Panel6)


            End If
        End If

    End Sub
    Private Sub editData()
        conn.ConnectionString = Form6.server


        query = "Update `systemdb`.`computers` Set `clab`='" & txt_cl.Text & "'WHERE `idcomputers`='1'"

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
    Private Sub addsub()
        conn.ConnectionString = Form6.server


        query = "INSERT INTO `systemdb`.`subject` (`category`, `subject`) VALUES ('" & txt_addcat.selectedValue & "', '" & txt_addsub.Text & "');
"
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

    Private Sub btn_save2_Click(sender As Object, e As EventArgs) Handles btn_save2.Click
        If txt_addsub.Text = "" Then
            MessageBox.Show("Please Input Data")
            btn_save2.Hide()
            txt_addcat.Enabled = False
            txt_addsub.Text = ""
            txt_addsub.Enabled = False
            If btn_save.Visible = True Then
            Else
                Panel6.Visible = False
                Panel6.Width = 0

                BunifuTransition1.ShowSync(Panel6)

            End If
        Else
            MessageBox.Show("Adding Successful")

            addsub()
            refresh_dgv()
            btn_save2.Hide()
            txt_addcat.Enabled = False
            txt_addsub.Text = ""
            txt_addsub.Enabled = False
            If btn_save.Visible = True Then
            Else
                Panel6.Visible = False
                Panel6.Width = 0

                BunifuTransition1.ShowSync(Panel6)

            End If
        End If
    End Sub



    Private Sub txt_cl_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cl.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
        If txt_cl.Text.Length >= 2 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt_cl_OnValueChanged(sender As Object, e As EventArgs) Handles txt_cl.OnValueChanged

    End Sub

    Private Sub tkt_dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tkt_dgv.CellContentClick
        tktid = tkt_dgv.Rows(e.RowIndex).Cells(0).Value
    End Sub

    Private Sub tkt_dgv_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles tkt_dgv.CellContentDoubleClick
        tktid = tkt_dgv.Rows(e.RowIndex).Cells(0).Value
        Dim result = MessageBox.Show(" Do you want to delete this item?", "Prompt", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            deletedItem()
            refresh_dgv()
        End If
    End Sub
    Private Sub deletedItem()
        conn.ConnectionString = Form6.server


        query = "DELETE FROM `systemdb`.`subject` WHERE `subject`.`Subject` = '" & tktid & "'
"
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

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Dim result = MessageBox.Show(" Are you sure you want to logout?", "Prompt", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            frm_login.Show()
            Me.Hide()
        End If
    End Sub
End Class
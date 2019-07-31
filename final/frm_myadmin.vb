Imports MySql.Data.MySqlClient

Public Class frm_myadmin
    Dim conn As New MySqlConnection
    Dim sda As New MySqlDataAdapter
    Dim reader As MySqlDataReader
    Dim cmd As New MySqlCommand
    Dim query As String
    Dim user, first, last, email As String


    Private Sub frm_pass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetMaximumLength(curr_pass, 15)
        SetMaximumLength(edit_user, 10)
        SetMaximumLength(new_pass, 15)
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        frm_acc.Show()
        Me.Hide()
    End Sub
    Private Sub loaddata()
        conn.ConnectionString = Form6.server
        Dim count As Integer

        query = "select * from accounts where username like '" & frm_login.user & "'"
        Try
            conn.Open()
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            sda.SelectCommand = cmd

            While reader.Read
                user = reader.GetString("username")
                first = reader.GetString("firstname")
                last = reader.GetString("lastname")
                email = reader.GetString("mobilenum")
            End While
            lbl_user.Text = "Username:  " & user & ""
            lbl_first.Text = "Firstname:  " & first & ""
            lbl_email.Text = "Email:  " & email & ""
            lbl_last.Text = "Lastname:  " & last & ""
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub frm_pass_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Panel3.Hide()
        Panel2.Hide()
        curr_pass.Text = ""
        new_pass.Text = ""
        loaddata()
        Label11.Hide()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Panel2.Show()
        Panel2.Dock = DockStyle.Fill
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        check_pass()
    End Sub
    Private Sub check_pass()
        conn.ConnectionString = Form6.server
        Dim count As Integer

        query = "select count(username) from accounts where binary password=sha1('" & curr_pass.Text & "') and binary username='" & frm_login.user & "'"
        Try
            conn.Open()
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            sda.SelectCommand = cmd
            While reader.Read
                count = reader.GetInt64("count(username)")
            End While
            If count = 1 Then
                query = "Update `systemdb`.`accounts` Set password=sha1('" & new_pass.Text & "') where username='" & frm_login.user & "'"
                reader.Close()
                cmd = New MySqlCommand(query, conn)
                reader = cmd.ExecuteReader
                sda.SelectCommand = cmd
                MessageBox.Show("New Password was set", "Prompt")
                new_pass.Text = ""
                curr_pass.Text = ""
            Else
                MessageBox.Show("Wrong Password", "Prompt")
            End If
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub curr_pass_OnValueChanged(sender As Object, e As EventArgs) Handles curr_pass.OnValueChanged
        curr_pass.isPassword = True

    End Sub

    Private Sub new_pass_OnValueChanged(sender As Object, e As EventArgs) Handles new_pass.OnValueChanged
        new_pass.isPassword = True
    End Sub

    Private Sub btn_edit2_Click(sender As Object, e As EventArgs) Handles btn_edit2.Click
        Panel3.Show()
        edit_user.Text = user
        edit_first.Text = first
        edit_last.Text = last
        edit_email.Text = email
    End Sub

    Private Sub edit_user_OnValueChanged(sender As Object, e As EventArgs) Handles edit_user.OnValueChanged

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub BunifuThinButton21_Click_1(sender As Object, e As EventArgs) Handles btn_editsave.Click
        If edit_user.Text = user Then
            If edit_email.Text = "" Or edit_first.Text = "" Or edit_last.Text = "" Or edit_user.Text = "" Or Label11.Visible = True Then
                MessageBox.Show("Please check all the fields", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                conn.ConnectionString = Form6.server
                query = "Update `systemdb`.`accounts` Set username='" & edit_user.Text & "', firstname='" & edit_first.Text & "',mobilenum='" & edit_email.Text & "',lastname='" & edit_last.Text & "' where username='" & frm_login.user & "'"
                Try
                    conn.Open()
                    cmd = New MySqlCommand(query, conn)
                    reader = cmd.ExecuteReader
                    sda.SelectCommand = cmd
                    MessageBox.Show("Saved", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Panel3.Hide()
                    edit_email.Text = ""
                    edit_first.Text = ""
                    edit_last.Text = ""
                    edit_user.Text = ""
                    conn.Close()
                    frm_login.Show()
                    Me.Hide()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    conn.Dispose()
                End Try
            End If
        Else
            check_user()
            If edit_email.Text = "" Or edit_first.Text = "" Or edit_last.Text = "" Or edit_user.Text = "" Or Label11.Visible = True Then
                MessageBox.Show("Please check all the fields", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                conn.ConnectionString = Form6.server
                query = "Update `systemdb`.`accounts` Set username='" & edit_user.Text & "', firstname='" & edit_first.Text & "',mobilenum='" & edit_email.Text & "',lastname='" & edit_last.Text & "' where username='" & frm_login.user & "'"
                Try
                    conn.Open()
                    cmd = New MySqlCommand(query, conn)
                    reader = cmd.ExecuteReader
                    sda.SelectCommand = cmd
                    MessageBox.Show("Saved", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Panel3.Hide()
                    edit_email.Text = ""
                    edit_first.Text = ""
                    edit_last.Text = ""
                    edit_user.Text = ""
                    conn.Close()
                    frm_login.Show()
                    Me.Hide()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    conn.Dispose()
                End Try
            End If
        End If



    End Sub
    Private Sub check_user()
        conn.ConnectionString = Form6.server
        Dim count As Integer

        query = "select count(username) from accounts where username like '" & edit_user.Text & "'"
        Try
            conn.Open()
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            sda.SelectCommand = cmd
            While reader.Read
                count = reader.GetString("count(username)")
            End While

            If count = 1 Then

                Label11.Show()


            Else


                Label11.Hide()

            End If





            conn.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
    Private Sub SetMaximumLength(ByVal metroTextbox As Bunifu.Framework.UI.BunifuMaterialTextbox, ByVal maximumLength As Integer)
        For Each ctl As Control In metroTextbox.Controls

            If ctl.[GetType]() = GetType(TextBox) Then
                Dim txt = CType(ctl, TextBox)
                txt.MaxLength = maximumLength
            End If
        Next
    End Sub
End Class
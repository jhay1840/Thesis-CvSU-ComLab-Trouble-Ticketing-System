Imports MySql.Data.MySqlClient

Public Class frm_pass
    Dim conn As New MySqlConnection
    Dim sda As New MySqlDataAdapter
    Dim reader As MySqlDataReader
    Dim cmd As New MySqlCommand
    Dim query As String

    Private Sub frm_pass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetMaximumLength(new_pass, 15)
        SetMaximumLength(curr_pass, 15)
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        frm_userdash.Show()
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
            Dim user, first, last, email
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
        Panel2.Hide()
        curr_pass.Text = ""
        new_pass.Text = ""
        loaddata()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Panel2.Show()

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
    Private Sub SetMaximumLength(ByVal metroTextbox As Bunifu.Framework.UI.BunifuMaterialTextbox, ByVal maximumLength As Integer)
        For Each ctl As Control In metroTextbox.Controls

            If ctl.[GetType]() = GetType(TextBox) Then
                Dim txt = CType(ctl, TextBox)
                txt.MaxLength = maximumLength
            End If
        Next
    End Sub
End Class
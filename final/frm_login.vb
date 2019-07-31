Imports MySql.Data.MySqlClient


Imports System.Net.Mail
Public Class frm_login
    Dim conn As New MySqlConnection
    Dim sda As New MySqlDataAdapter
    Dim reader As MySqlDataReader
    Dim cmd As New MySqlCommand
    Dim lvl As Int16
    Dim counter As Integer
    Public query, user, pass, first, email, code, userid As String


    Private Sub txt_pass_OnValueChanged(sender As Object, e As EventArgs) Handles txt_pass.OnValueChanged
        txt_pass.isPassword = True
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click


        login()

    End Sub
    Private Sub login()


        Dim lvl As Int16
        query = "select * from systemdb.accounts where  username='" & txt_user.Text & "'and binary password=sha1('" & txt_pass.Text & "')"
        Try
            conn.ConnectionString = Form6.server
            conn.Open()
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            sda.SelectCommand = cmd
            While reader.Read
                user = reader.GetString("username")
                pass = reader.GetString("password")
                lvl = reader.GetInt16("user_lvl")
                first = reader.GetString("firstname")
            End While

            If lvl = 1 Then

                frm_dashboard.Show()
                Me.Hide()
            ElseIf lvl = 2 Then

                frm_userdash.Show()
                Me.Hide()
            Else
                MessageBox.Show("Username or Password is incorrect", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)


            End If





            conn.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
    Private Sub btn_forgot_MouseHover(sender As Object, e As EventArgs) Handles btn_forgot.MouseHover
        btn_forgot.ForeColor = Color.PaleGreen
    End Sub

    Private Sub btn_forgot_MouseLeave(sender As Object, e As EventArgs) Handles btn_forgot.MouseLeave
        btn_forgot.ForeColor = SystemColors.AppWorkspace
    End Sub


    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Dim result = MessageBox.Show(" Are you sure you want to quit", "Prompt", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub txt_user_OnValueChanged(sender As Object, e As EventArgs) Handles txt_user.OnValueChanged

    End Sub

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MessageBox.Show(My.Resources.db_connection)
        Dim notif As New NotifyIcon

        notif.Visible = True

        notif.ShowBalloonTip(5000, "My title", "My text", ToolTipIcon.Info)
        SetMaximumLength(for_user, 10)
        SetMaximumLength(txt_newpass, 15)
        SetMaximumLength(txt_pass, 15)
        SetMaximumLength(txt_user, 10)
        SetMaximumLength(txt_verify, 4)
    End Sub

    Private Sub BunifuCustomLabel1_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel1.Click

    End Sub

    Private Sub txt_pass_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_pass.KeyDown
        If e.KeyCode = Keys.Enter Then
            login()
        End If
    End Sub

    Private Sub txt_user_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_user.KeyDown
        If e.KeyCode = Keys.Enter Then
            login()
        End If
    End Sub

    Private Sub btn_forgot_Click(sender As Object, e As EventArgs) Handles btn_forgot.Click
        Panel2.Hide()
        Panel2.Width = 403

        BunifuTransition1.ShowSync(Panel2)
        Panel3.Hide()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Panel3.Hide()
        Panel2.Width = 0
        for_ans.Text = ""
        for_user.Text = ""
        drop_sec.selectedIndex = 0
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click



        If for_ans.Text = "" Or for_user.Text = "" Then
                MessageBox.Show("Please Complete All Fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                check_sec()
            End If


    End Sub

    Private Sub frm_login_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        frm_login.ActiveForm.Opacity = 95
    End Sub

    Private Sub for_user_OnValueChanged(sender As Object, e As EventArgs) Handles for_user.OnValueChanged

    End Sub

    Private Sub frm_login_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Panel2.Width = 0
        counter = 0
        txt_pass.Text = ""
        txt_user.Text = ""
        for_ans.Text = ""
        for_user.Text = ""
        drop_sec.selectedIndex = 0
        code = "0"
        Panel3.Hide()
        btn_reset.Hide()
        txt_newpass.Enabled = False
    End Sub




    Private Sub sendmailcounter()
        Try
            Dim Mail As New MailMessage
            Dim SMTP As New SmtpClient("smtp.gmail.com")

            Mail.Subject = "Security Update"
            Mail.From = New MailAddress("cvsu.ticketingsystem@gmail.com")
            SMTP.Credentials = New System.Net.NetworkCredential("cvsu.ticketingsystem@gmail.com", "k@bsunumb@w@n") '<-- Password Here
            Mail.To.Add(email) 'I used ByVal here for address
            Mail.Body = "An unauthorized attempt to access your account

Date: " & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") & "

If this was you, please disregard this email. If this wasn't you, please secure your account  as someone else may be accessing it.
 
Thanks, The CvSU Ticketing System Team"

            SMTP.EnableSsl = True
            SMTP.Port = "587"
            SMTP.Send(Mail)

        Catch ex As Exception

        End Try
    End Sub
    Private Sub check_user()
        conn.ConnectionString = Form6.server
        Dim count As Integer

        query = "select count(username) from accounts where username like '" & for_user.Text & "'"
        Try
            conn.Open()
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            sda.SelectCommand = cmd
            While reader.Read
                count = reader.GetString("count(username)")
            End While

            If count = 1 Then
                btn_edit.Show()
                Label11.Hide()
            Else
                btn_edit.Hide()
                Label11.Show()
            End If
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub



    Private Sub for_user_Leave(sender As Object, e As EventArgs) Handles for_user.Leave

        check_user()
        If Label11.Visible = False Then
            getemail()
        End If

    End Sub

    Private Sub txt_verify_OnValueChanged(sender As Object, e As EventArgs) Handles txt_verify.OnValueChanged

    End Sub

    Private Sub for_user_KeyPress(sender As Object, e As KeyPressEventArgs) Handles for_user.KeyPress
        btn_edit.Hide()
    End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        conn.ConnectionString = Form6.server

        query = "Update `systemdb`.`accounts` Set password=sha1('" & txt_newpass.Text & "') where username='" & userid & "'"
        Try
            conn.Open()
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            sda.SelectCommand = cmd
            MessageBox.Show("Password has been reset", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information)
            conn.Close()
            Panel3.Hide()
            txt_verify.Text = ""
            txt_newpass.Text = ""
            btn_reset.Hide()
            txt_newpass.Enabled = False
            code = 0
            Panel2.Width = 0
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        forgotmail()
    End Sub

    Private Sub btn_proceed_Click(sender As Object, e As EventArgs) Handles btn_proceed.Click
        If txt_verify.Text = code Then
            btn_reset.Show()
            txt_newpass.Enabled = True
            btn_proceed.Hide()
        Else
            MessageBox.Show("Wrong Verification code", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub txt_newpass_OnValueChanged(sender As Object, e As EventArgs) Handles txt_newpass.OnValueChanged
        txt_newpass.isPassword = True
    End Sub
    Private Sub SetMaximumLength(ByVal metroTextbox As Bunifu.Framework.UI.BunifuMaterialTextbox, ByVal maximumLength As Integer)
        For Each ctl As Control In metroTextbox.Controls

            If ctl.[GetType]() = GetType(TextBox) Then
                Dim txt = CType(ctl, TextBox)
                txt.MaxLength = maximumLength
            End If
        Next
    End Sub
    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub check_sec()
        conn.ConnectionString = Form6.server
        Dim count As Integer

        query = "select count(username),mobilenum from accounts where username ='" & for_user.Text & "' and  sec_ques ='" & drop_sec.selectedIndex & "' and sec_ans ='" & for_ans.Text & "' "
        Try
            conn.Open()
            Dim RandGen As New Random
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            sda.SelectCommand = cmd
            While reader.Read
                count = reader.GetString("count(username)")
            End While

            If count = 1 Then
                counter = 0

                forgotmail()



                Panel3.Show()
                btn_proceed.Show()
            Else
                counter += 1
                MessageBox.Show("Wrong Answers", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If counter = 3 Then
                    sendmailcounter()
                    counter = 0
                End If
            End If

            conn.Close()
        Catch ex As Exception

        Finally
            conn.Dispose()
        End Try
    End Sub
    Private Sub getemail()
        conn.ConnectionString = Form6.server


        query = "select mobilenum,username from accounts where username ='" & for_user.Text & "'"
        Try
            conn.Open()
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            sda.SelectCommand = cmd
            While reader.Read
                email = reader.GetString("mobilenum")
                userid = reader.GetString("username")
            End While
        Catch ex As Exception

        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub forgotmail()
        Try
            Dim Mail As New MailMessage
            Dim randgen As New Random
            Dim SMTP As New SmtpClient("smtp.gmail.com")
            code = randgen.Next(1000, 9999).ToString
            Mail.Subject = "Security Update"
            Mail.From = New MailAddress("cvsu.ticketingsystem@gmail.com")
            SMTP.Credentials = New System.Net.NetworkCredential("cvsu.ticketingsystem@gmail.com", "k@bsunumb@w@n") '<-- Password Here
            Mail.To.Add(email) 'I used ByVal here for address
            Mail.Body = "Verification code for resetting pasword

Date: " & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") & "
Verification code: " & code & "

If this wasn't you, please disregard this email. If this was you, please secure your account  as someone else may be accessing it.
 
Thanks, The CvSU Ticketing System Team"

            SMTP.EnableSsl = True
            SMTP.Port = "587"
            SMTP.Send(Mail)
            MessageBox.Show("An email was sent to your account", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Panel2.Width = 0
        End Try
    End Sub



    Private Sub txt_verify_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_verify.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
        If txt_verify.Text.Length >= 4 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Label4_MouseMove(sender As Object, e As MouseEventArgs) Handles Label4.MouseMove
        Label4.ForeColor = Color.Black
    End Sub

    Private Sub Label4_MouseLeave(sender As Object, e As EventArgs) Handles Label4.MouseLeave
        Label4.ForeColor = Color.White
    End Sub
End Class
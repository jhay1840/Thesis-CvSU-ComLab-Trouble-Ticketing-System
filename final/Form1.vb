Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Public Class Form1

    Dim conn As New MySqlConnection
        Dim sda As New MySqlDataAdapter
        Dim reader As MySqlDataReader
        Dim cmd As New MySqlCommand
    Dim lvl As Integer
    Dim query, user, pass, secq, seca As String

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        user_edit.Text = ""
        txt_user.Text = ""
        frm_acc.Show()
        Me.Hide()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub txt_user_OnValueChanged(sender As Object, e As EventArgs) Handles txt_user.OnValueChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.Dock = DockStyle.Fill
        SetMaximumLength(txt_user, 10)
        SetMaximumLength(user_edit, 10)
        SetMaximumLength(txt_password, 15)
        SetMaximumLength(pass_admin, 15)
    End Sub


    Private Sub check_user()
        conn.ConnectionString = Form6.server
        Dim count As Integer

        query = "select count(username) from accounts where username like '" & txt_user.Text & "'"
        Try
            conn.Open()
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            sda.SelectCommand = cmd
            While reader.Read
                count = reader.GetString("count(username)")
            End While

            If count = 1 Then

                Label6.Show()
                btn_create.Hide()

            Else
                btn_create.Show()
                Label6.Hide()


            End If





            conn.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
    Private Sub check_pass()
        conn.ConnectionString = Form6.server
        Dim count As Integer

        query = "select count(username) from accounts where binary password=sha1('" & pass_admin.Text & "') and binary username='" & frm_login.user & "'"
        Try
            conn.Open()
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            sda.SelectCommand = cmd
            While reader.Read
                count = reader.GetInt64("count(username)")
            End While
            If count = 1 Then
                reader.Close()
                delete()
                MessageBox.Show("Deleted Succesfully")
                pass_admin.Text = ""
                frm_acc.refresh_dgv()
                Me.Hide()
                frm_acc.Show()
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

    Private Sub btn_create_Click(sender As Object, e As EventArgs) Handles btn_create.Click


        If txt_user.Text = "" Or txt_password.Text = "" Or txt_last.Text = "" Or txt_first.Text = "" Or txt_email.Text = "" Then 'may kulang pa tong number
            MessageBox.Show("Please Complete All Fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            If validateEmail(txt_email.Text) = False Then
                MessageBox.Show("PleaseInput Valid Email", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            create()
            MessageBox.Show("Adding Account Succcesful", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_user.Text = ""
            txt_password.Text = ""
            txt_last.Text = ""
            txt_first.Text = ""
            txt_email.Text = ""
            txt_cat.selectedIndex = 0
            txt_secret.Text = ""
            frm_acc.refresh_dgv()
        End If

    End Sub

    Private Sub txt_user_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_user.KeyPress
        btn_create.Hide()
    End Sub

    Private Sub txt_password_OnValueChanged(sender As Object, e As EventArgs) Handles txt_password.OnValueChanged
        txt_password.isPassword = True
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub pass_admin_OnValueChanged(sender As Object, e As EventArgs) Handles pass_admin.OnValueChanged
        pass_admin.isPassword = True
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        check_pass()
        frm_acc.Enabled = True
    End Sub

    Private Sub txt_user_Leave(sender As Object, e As EventArgs) Handles txt_user.Leave

        check_user()
    End Sub
    Private Sub create()
        conn.ConnectionString = Form6.server


        query = "INSERT INTO `systemdb`.`accounts` (`username`, `password`, `user_lvl`, `lastname`, `firstname`,mobilenum,sec_ques,sec_ans) VALUES ('" & txt_user.Text & "', sha1('" & txt_password.Text & "'), '" & lvl & "', '" & txt_last.Text & "', '" & txt_first.Text & "', '" & txt_email.Text & "','" & txt_cat.selectedIndex & "','" & txt_secret.Text & "');
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



    Private Sub delete()
        query = "DELETE FROM `systemdb`.`accounts` WHERE `username`='" & frm_acc.un & "';
"
        Try
            cmd = New MySqlCommand(query, conn)
            sda.SelectCommand = cmd
            reader = cmd.ExecuteReader
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub Form1_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        lvl = 2
        Label17.Text = "Create User Account"
        BunifuiOSSwitch1.Value = False
        txt_cat.selectedIndex = 0
        Label8.Text = "Are you sure you want to delete " & frm_acc.un & " ?"
        user_edit.Text = frm_acc.un
        fn_edit.Text = frm_acc.fn
        ln_edit.Text = frm_acc.ln
        email_edit.Text = frm_acc.email
        secret_edit.Text = seca
        btn_edit.Show()

        Label11.Hide()
    End Sub

    Private Sub user_edit_Leave(sender As Object, e As EventArgs) Handles user_edit.Leave
        check_user1()
        If user_edit.Text = frm_acc.un Then
            btn_edit.Show()
            Label11.Hide()
        End If

    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If user_edit.Text = "" Or ln_edit.Text = "" Or fn_edit.Text = "" Or email_edit.Text = "" Or secret_edit.Text = "" Then 'may kulang pa tong number
            MessageBox.Show("Please Complete All Fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If validateEmail(email_edit.Text) = False Then
                MessageBox.Show("PleaseInput Valid Email", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            check_user()
            editData()
            MessageBox.Show("Edit Data Succesfull", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information)
            user_edit.Text = ""
            ln_edit.Text = ""
            fn_edit.Text = ""

            frm_acc.refresh_dgv()
            Me.Close()
            frm_acc.Show()
        End If



    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub user_edit_OnValueChanged(sender As Object, e As EventArgs) Handles user_edit.OnValueChanged

    End Sub

    Private Sub check_user1()
        conn.ConnectionString = Form6.server
        Dim count As Integer

        query = "select count(username) from accounts where username like '" & user_edit.Text & "'"
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

                btn_edit.Hide()
            Else


                Label11.Hide()
                btn_edit.Show()
            End If





            conn.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub BunifuiOSSwitch1_OnValueChange(sender As Object, e As EventArgs) Handles BunifuiOSSwitch1.OnValueChange
        If BunifuiOSSwitch1.Value = True Then
            Label17.Text = "Create Admin Account"
            lvl = 1
        Else
            Label17.Text = "Create User Account"
            lvl = 2
        End If
    End Sub

    Private Sub BunifuMaterialTextbox1_OnValueChanged(sender As Object, e As EventArgs) Handles txt_email.OnValueChanged

    End Sub

    Private Sub editData()
        conn.ConnectionString = Form6.server

        query = "Update `systemdb`.`accounts` Set `username`='" & user_edit.Text & "', `lastname`='" & ln_edit.Text & "', `firstname`='" & fn_edit.Text & "',mobilenum='" & email_edit.Text & "',sec_ques='" & cat_edit.selectedIndex & "',sec_ans='" & secret_edit.Text & "' WHERE `username`='" & frm_acc.un & "'"

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

    Private Sub user_edit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles user_edit.KeyPress
        btn_edit.Hide()
    End Sub
    Public Sub sec()
        conn.ConnectionString = Form6.server

        query = "select * from accounts where username like '" & frm_acc.un & "'"
        Try
            conn.Open()
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            sda.SelectCommand = cmd
            While reader.Read
                secq = reader.GetInt64("sec_ques")
                seca = reader.GetString("sec_ans")
            End While
            conn.Close()
            '  0          Favorite Pet's name?
            '  1          Favorite Movie?
            '  2          Father 's Middle Name?
            '  3         Favorite Teacher's Name?
            '  4          Favorite Sport's Team?
            '  5          High School Name?

            cat_edit.selectedIndex = secq

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
    Function validateEmail(emailAddress) As Boolean

        Dim email As New Regex("([\w-+]+(?:\.[\w-+]+)*@(?:[\w-]+\.)+[a-zA-Z]{2,7})")
        If email.IsMatch(emailAddress) Then
            Return True
        Else
            Return False
        End If
    End Function


    Private Sub SetMaximumLength(ByVal metroTextbox As Bunifu.Framework.UI.BunifuMaterialTextbox, ByVal maximumLength As Integer)
        For Each ctl As Control In metroTextbox.Controls

            If ctl.[GetType]() = GetType(TextBox) Then
                Dim txt = CType(ctl, TextBox)
                txt.MaxLength = maximumLength
            End If
        Next
    End Sub
End Class
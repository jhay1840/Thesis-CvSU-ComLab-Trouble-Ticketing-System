Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel


Public Class Form3

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
            tkt_dgv.Height = 224
            Me.CenterToScreen()

        Else
            Me.WindowState = FormWindowState.Maximized
            tkt_dgv.Height = 322

        End If
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Dim result = MessageBox.Show(" Are you sure you want to quit", "Prompt", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            System.Windows.Forms.Application.Exit()

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
        tkt_dgv.Height = 322
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "MMMM yyyy"
        TextBox1.Text = Format(DateTimePicker1.Value, "yyyy-MM")
        refresh_dgv()
        countall()
        countcmp()

        Loadpend()

        If counter = 0 Then
            BunifuCircleProgressbar1.Value = 0
            Label4.Text = "Total tasks this month:"
            Label5.Text = "Total tasks completed:"
            Label6.Text = "Pending Tickets this month: "
        Else
            perc = 100 / (counter / cmp)
            BunifuCircleProgressbar1.Value = perc
            Label4.Text = "Total tasks this month: " & counter & ""
            Label5.Text = "Total tasks completed: " & cmp & ""
            Label6.Text = "Pending Tickets this month: " & pend & ""

        End If

    End Sub
    Public Sub refresh_dgv()
        Dim sda As New MySqlDataAdapter
        Dim dbdataset As New Data.DataTable
        Dim bsource As New BindingSource
        conn.ConnectionString = Form6.server

        query = "SELECT tktid as 'Ticket ID',username as Username, subject as Subject, priority as Priority, status as Status,category as Category,cl_num as 'ComLab No.',DATE_FORMAT(date,'%Y-%m-%d %H:%I') as 'Date Added', due_date as 'Due Date' FROM systemdb.tickets where date like '%" & TextBox1.Text & "%'  order by date desc"
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
    Public Sub countall()
        Dim sda As New MySqlDataAdapter
        Dim dbdataset As New Data.DataTable
        Dim bsource As New BindingSource
        conn.ConnectionString = Form6.server

        query = "SELECT count(tktid) FROM systemdb.tickets where date like '%" & TextBox1.Text & "%'  order by date desc"
        Try
            conn.Open()
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            sda.SelectCommand = cmd
            While reader.Read
                counter = reader.GetInt64("count(tktID)")

            End While


            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        frm_admin.Show()
        Me.Hide()
    End Sub

    Private Sub btn_ann_Click(sender As Object, e As EventArgs) Handles btn_ann.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub btn_mont_Click(sender As Object, e As EventArgs) Handles btn_mont.Click

    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        frm_log.Show()
        Me.Hide()
    End Sub



    Public Sub countcmp()
        Dim sda As New MySqlDataAdapter
        Dim dbdataset As New Data.DataTable
        Dim bsource As New BindingSource
        conn.ConnectionString = Form6.server

        query = "SELECT count(tktid) FROM systemdb.tickets where date like '%" & TextBox1.Text & "%' and status='completed' order by date desc"
        Try
            conn.Open()
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            sda.SelectCommand = cmd
            While reader.Read
                cmp = reader.GetInt64("count(tktID)")

            End While


            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

        TextBox1.Text = Format(DateTimePicker1.Value, "yyyy-MM")
        refresh_dgv()
        countall()
        countcmp()
        Loadpend()

        If counter = 0 Then
            BunifuCircleProgressbar1.Value = 0
            Label4.Text = "Total tasks this month:"
            Label5.Text = "Total tasks completed:"
            Label6.Text = "Pending Tickets this month: "
        Else
            perc = 100 / (counter / cmp)
            BunifuCircleProgressbar1.Value = perc
            Label4.Text = "Total tasks this month: " & counter & ""
            Label5.Text = "Total tasks completed: " & cmp & ""
            Label6.Text = "Pending Tickets this month: " & pend & ""
        End If

    End Sub

    Private Sub Loadpend()

        Dim sda As New MySqlDataAdapter
        Dim dbdataset As New Data.DataTable
        Dim bsource As New BindingSource
        conn.ConnectionString = Form6.server


        Dim query = "SELECT count(tktID) FROM systemdb.tickets where date like '%" & TextBox1.Text & "%' and status='pending' "

        Try
            conn.Open()

            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            sda.SelectCommand = cmd
            While reader.Read
                pend = reader.GetInt64("count(tktID)")

            End While


            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        Dim result = MessageBox.Show(" Are you sure you want to logout?", "Prompt", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            frm_login.Show()
            Me.Hide()

        End If
    End Sub

    Private Sub btn_export_Click(sender As Object, e As EventArgs) Handles btn_export.Click

        Me.Cursor = Cursors.WaitCursor
        Dim xls As New Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim resourcesFolder = IO.Path.GetFullPath(System.Windows.Forms.Application.StartupPath & "\Resources\")
        Dim i As Integer
        Dim j As Integer
        Dim fn = "Monthly Report " & Now.Day & "-" & Now.Month & "-" & Now.Year & ".xlsx"

        xlWorkBook = xls.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")


        For i = 0 To tkt_dgv.RowCount - 1
            For j = 0 To tkt_dgv.ColumnCount - 1
                For k As Integer = 1 To tkt_dgv.Columns.Count
                    xlWorkSheet.Cells(1, k) = tkt_dgv.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 2, j + 1) = tkt_dgv(j, i).Value.ToString()
                Next
            Next
        Next
        Try
            SaveFileDialog1.Filter = "Excel Files (*.xlsx)|*.xlsx"
            SaveFileDialog1.FileName = "Monthly Report " & Now.Day & "-" & Now.Month & "-" & Now.Year & ".xlsx"
            If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                xlWorkBook.SaveAs(SaveFileDialog1.FileName)
            End If
            xlWorkBook.Saved = True
            xlWorkBook.Close()
            xls.Quit()
            GC.Collect()
            GC.WaitForPendingFinalizers()
        Catch ex As Exception

        Finally
            conn.Dispose()
        End Try
        Me.Cursor = Cursors.Arrow

        GC.Collect()
        GC.WaitForPendingFinalizers()

    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub



    Private Sub Form3_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        DateTimePicker1.Value = Now
    End Sub
End Class




